using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace EksamensProjektOOP
{
    class FileReader
    {
        public void ReadFile()
        {

            //columncount = -1, da det fortæller om programmet fejler eller ej
            //foreach splitter filen op i string array columnValues
            //if sætter cloumnCount til længden af columnValues
            //for loop tæller columnValues in i row, row addes til userfiles, så den ikke bliver overrided
            List<List<String>> userFile = new List<List<string>>();
            int columnCount = -1;
            char delimiter = ',';
            foreach (string line in File.ReadLines(@"C:\Users\lkbc3\Desktop\users.csv"))
            {
                string[] columnValues = line.Split(delimiter);
                List<string> row = new List<string>();
                if (columnCount == -1)
                {
                    columnCount = columnValues.Length;
                }

                for (int i = 0; i < columnValues.Length; i++)
                {
                    row.Add(columnValues[i]);
                }

                userFile.Add(row);
            }
            //mulitdimensional array x-akse er rækkerne, y-akse er columncount(id, navn osv.)
            //[,] fortæller mængden af dimensioner
            string[,] output = new string[userFile.Count, columnCount];

            for (int i = 0; i < userFile.Count; i++)
            {
                for (int j = 0; j < userFile[i].Count; j++)
                {
                    output[i, j] = userFile[i][j];
                    //Console.WriteLine(output[i,j]);
                }
            }
        }
    }
}
