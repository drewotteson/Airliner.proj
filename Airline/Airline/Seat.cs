using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Airline
{
    public class Seat
    {
        public List<string> mainList = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        public List<string> subList = new List<string> { "A", "B", "C", "D" };

        public Seat()
        {

        }
        public void AllSeats()
        {
            for (int x=0; x < mainList.Count; x++)
            {
                for (int y=0; y < subList.Count; y++)
                {
                    Console.WriteLine(mainList[x] + subList[y]);
                }
                
            }
        }
    }
}
