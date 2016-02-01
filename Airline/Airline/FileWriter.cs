using System;
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
        public void getScore()
        {
            score += 1;
            System.IO.StreamWriter file = new System.IO.StreamWriter("score.txt", true);
            file.WriteLine(score);
            file.Close();
        }
    }
}

