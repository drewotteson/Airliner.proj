﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Airline
{
    class FileWriter
    {
 
            int score;
            public FileWriter()
            {

            }
            public void WriteInfoToFile()
            {
                score += 1;
                System.IO.StreamWriter file = new System.IO.StreamWriter("score.txt", true);
                file.WriteLine(score);
                file.Close();
            }
        }
    }

    //methods to create the file, write to the file, open the file, etc.






//methods to create the file, write to the file, open the file, etc.