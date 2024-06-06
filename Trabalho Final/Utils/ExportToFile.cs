using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho_Final.Utils
{
    public class ExportToFile
    {
        private const string dir = @"C:\Users\joaov\OneDrive\Documentos\Programação 2024\Exercicios\Arquivos";
        public static bool SaveToDelimitedTxt(string fileName, string fileContent)
        {
            string filePath = $@"{dir}\{fileName}";

            try
            {
                if(!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                using(StreamWriter sw = File.CreateText(filePath))
                {
                    sw.Write(fileContent);
                }
            }
            catch
            {
                return false;
            }
            
            return true;
        }
    }
}