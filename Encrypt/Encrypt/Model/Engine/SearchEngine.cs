using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Encrypt.Model.Engine
{
    class SearchEngine
    {
        public SearchEngine(string[] args)
        {
            string directoryPath = @"C:\MyDirectory"; // replace with your directory path
            string fileExtension = ".txt"; // replace with your file extension

            string[] files = Directory.GetFiles(directoryPath, "*" + fileExtension, SearchOption.AllDirectories);

            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}
