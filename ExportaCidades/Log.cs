using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExportaCidades
{
    internal class Log
    {
        public static void RegitraLog(string log)
        {



            StreamWriter x;


            string CaminhoNome =  "log-" + DateTime.Today.ToString("dd-MM-yyyy") + ".txt";

            if (File.Exists(CaminhoNome))
            {

                x = File.AppendText(CaminhoNome);

                x.WriteLine(log);

                x.Close();

            }
            else
            {
                x = File.CreateText(CaminhoNome);

                x.WriteLine(log);

                x.Close();
            }
        }
    }
}
