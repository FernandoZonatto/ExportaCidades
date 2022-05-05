
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;


namespace ExportaCidades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var log = new Log();
            Log.RegitraLog("O programa foi inciado - " + DateTime.Now);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.progressBar1.Maximum = 100;

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {

            Log.RegitraLog("Clique no Bot�o: " + btnGerar.Text + " " + DateTime.Now);

            btnExportar.Enabled = true;
            progressBar1.Value = 0;
            listView1.Items.Clear();
            if (rdTodos.Checked == true)
            {
                Log.RegitraLog("Op��o selecionada para gera��o: " + rdTodos.Text + " " + DateTime.Now);

                var estado = Estado.BuscarEstados();

                foreach (Estado est in estado)
                {
                    var municipios = Municipios.BuscarMunicipio(est.sigla);

                    foreach (Municipios m in municipios)
                    {
                        ListViewItem item = new ListViewItem(new[] { m.microrregiao.mesorregiao.UF.sigla, m.RegiaoImediata.nome, m.nome, m.microrregiao.mesorregiao.nome, m.nome + "/" + m.microrregiao.mesorregiao.UF.sigla });
                        listView1.Items.Add(item);
                        if (this.progressBar1.Value >= 100)
                        {
                        }
                        else
                        {
                            this.progressBar1.Value += 4;
                            label2.Text = "Gerando Visualiza��o...";
                        }
                    }
                }
                this.progressBar1.Value = progressBar1.Maximum;
                label2.Text = "Visualiza��o Completa";
                MessageBox.Show("Visualiza��o gerada com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Log.RegitraLog("Visualiza��o gerada com sucesso! " + DateTime.Now);
            }
            else
            {

                if (checkedListBox1.CheckedItems.Count > 0)
                {
                    Log.RegitraLog("Op��o selecionada para gera��o: " + rbSelecionado.Text + " " + DateTime.Now);

                    for (var i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                    {


                        var selecionado = checkedListBox1.CheckedItems[i];


                        var municipios = Municipios.BuscarMunicipio(selecionado.ToString());

                        Log.RegitraLog("Gerado as cidades do estado: " + selecionado + " - " + DateTime.Now);


                        foreach (Municipios m in municipios)
                        {
                            ListViewItem item = new ListViewItem(new[] { m.microrregiao.mesorregiao.UF.sigla, m.RegiaoImediata.nome, m.nome, m.microrregiao.mesorregiao.nome, m.nome + "/" + m.microrregiao.mesorregiao.UF.sigla });
                            listView1.Items.Add(item);

                            if (this.progressBar1.Value >= 100)
                            {
                            }
                            else
                            {
                                this.progressBar1.Value += 4;
                                label2.Text = "Gerando Visualiza��o...";
                            }

                        }


                    }
                    label2.Text = "Visualiza��o Completa";
                    this.progressBar1.Value = progressBar1.Maximum;
                    MessageBox.Show("Visualiza��o gerada com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Log.RegitraLog("Visualiza��o gerada com sucesso! " + DateTime.Now);

                }
                else
                {
                    MessageBox.Show("Necessario selecionar pelo menos 1 estado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Log.RegitraLog("Necessario selecionar pelo menos 1 estado! " + DateTime.Now);
                }
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Log.RegitraLog("Op��o selecionada: " + rbSelecionado.Text + " " + DateTime.Now);

            checkedListBox1.Visible = true;
            checkedListBox1.Enabled = true;


            var estado = Estado.BuscarEstados();

            foreach (Estado est in estado)
            {
                CheckedListBox estados = new CheckedListBox();
                string[] item = new[] { est.sigla };
                checkedListBox1.Items.Add(est.sigla);

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Log.RegitraLog("Op��o selecionada: " + rdTodos.Text + " " + DateTime.Now);
            checkedListBox1.Enabled = false;
            checkedListBox1.Items.Clear();
            checkedListBox1.Visible = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Log.RegitraLog("Clique no bot�o : " + btnExportar.Text + " " + DateTime.Now);

            if (listView1.Items.Count > 0)
            {
                label2.Text = "Gerando arquivo...";
                using (SaveFileDialog sfd = new SaveFileDialog()
                {
                    Filter = "Excel |* .xls",
                    InitialDirectory = @"c:\",
                    FileName = "CidadeBrasileiras_" + DateTime.Now.ToString("dd-MM-yyyy") + ".xls",
                    ValidateNames = true
                })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Log.RegitraLog("Local selecionado para salvar o arquivo: " + sfd.FileName);
                        Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                        Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                        Worksheet ws = (Worksheet)app.ActiveSheet;
                        app.Visible = false;
                        ws.Cells[1, 1] = "UF";
                        ws.Cells[1, 2] = "Nome Regi�o";
                        ws.Cells[1, 3] = "Cidade";
                        ws.Cells[1, 4] = "Messoregi�o";
                        ws.Cells[1, 5] = "Cidade/UF";
                        int i = 2;
                        foreach (ListViewItem item in listView1.Items)
                        {
                            ws.Cells[i, 1] = item.SubItems[0].Text;
                            ws.Cells[i, 2] = item.SubItems[1].Text;
                            ws.Cells[i, 3] = item.SubItems[2].Text;
                            ws.Cells[i, 4] = item.SubItems[3].Text;
                            ws.Cells[i, 5] = item.SubItems[4].Text;
                            i++;
                        }
                        wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange,
     XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                        app.Quit();
                        Log.RegitraLog("Dados exportados com sucesso " + DateTime.Now);
                        MessageBox.Show("Seus dados foram exportados para o Excel com sucesso ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        label2.Text = "Arquivo gerado";
                    }
                    else {
                        Log.RegitraLog("Exporta��o Cancelada " + DateTime.Now);
                        MessageBox.Show("Exporta��o Cancelada ", "Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                   /* if (emailResposta == DialogResult.Yes)
                    {
                        Log.RegitraLog("Resposta email: Sim, enviar por e-mail " + DateTime.Now);
                        //var anexo = sfd.FileName;
                       // Form2 email = new Form2(anexo);
                        //email.ShowDialog();
                    }
                    else 
                    {
                        Log.RegitraLog("Resposta email:N�o, n�o enviar por e-mail " + DateTime.Now);

                    }*/
                }
            }
            else
            {
                MessageBox.Show("Necessario primeiro gerar a visualiza��o", "Necessario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Log.RegitraLog("Necessario primeiro gerar a visualiza��o " + DateTime.Now);
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Log.RegitraLog("Sistema encerrado " + DateTime.Now);
            Log.RegitraLog(" ");


        }
    }

}
