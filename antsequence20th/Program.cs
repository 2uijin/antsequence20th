using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace antsequence20th
{
    class Program
    {

        static void Main(string[] args)
        {

            string sq = "1";
            int i = 1;
            while (i <= 20)
            {
                Console.WriteLine(i+"번  :"+sq);
                char num = sq[0];
                int cnt = 0;
                string temp = " ";

                for (int n = 0; n<sq.Length; n++) {
                    if (num == sq[n])
                        cnt++;
                    else {
                        temp += "" + num + cnt;
                        cnt = 0;
                        num = sq[n];
                        cnt++;
                    }
                    if (n + 1 == sq.Length)
                        temp += "" + num + cnt;
                }

                    sq = temp;
                    i++;

            }
        }
    }
}
