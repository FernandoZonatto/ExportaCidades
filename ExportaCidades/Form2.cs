using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ExportaCidades
{
    
    public partial class Form2 : Form
    {
        Form1 instanciaDoForm1;
        public Form2(string anexo)
        {
            InitializeComponent();
            textBox2.Text =  anexo;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string desti = textBox1.Text;
            ArrayList aAnexosEmail;

            string[] arr = textBox2.Text.Split(';');
            //cria um novo arraylist
            aAnexosEmail = new ArrayList();
            //percorre o array de string e inclui os anexos
            for (int i = 0; i < arr.Length; i++)
            {
                if (!String.IsNullOrEmpty(arr[i].ToString().Trim()))
                {
                    aAnexosEmail.Add(arr[i].ToString().Trim());
                }
            }


            string resultado = EnviaEmail.EnviaEmail.EnviaMensagem(desti,
                   "Sistema", "Planilha de cidades", "Segue planilha de cidades brasilheiras",
                   aAnexosEmail);
            MessageBox.Show(resultado, "Email enviado com sucesso");



        }
    }
}
