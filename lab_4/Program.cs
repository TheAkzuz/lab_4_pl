using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        struct Vedomost : IComparable
        {
            public string x;
            public int y;
            public double z;
            public Vedomost(string x, int y, double z)
            {
                this.x = x; this.y = y; this.z = z;
            }
            public override string ToString()
            {
                return ("ФИО пассажира:" + x + " Количество вещей:" + Convert.ToString(y) + " Общий вес вещей:" + Convert.ToString(z));
            }
            public int CompareTo(object obj)
            {
                Vedomost b = (Vedomost)obj;
                if (this.y == b.y)
                {
                    return 0;
                }

                else if (this.y > b.y)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
        static void Main(string[] args)
        {
            StreamReader fileIn = new StreamReader("input.txt");
            StreamWriter fileOut = new StreamWriter("newText.txt");
            string line;

            Vedomost[] KV = new Vedomost[4];
            int k = 0;
            while ((line = fileIn.ReadLine()) != null) //пока поток не пуст  
            {
               // Array.Sort(KV);
                string[] subs = line.Split(' ');
                KV[k].x = subs[0];
                KV[k].y = Convert.ToInt32(subs[1]);
                KV[k].z = Convert.ToDouble(subs[2]);
                //Console.WriteLine(subs[0] + "!" + subs[1] + "!" + subs[2] + "!");
                
                k++;
                
            }
            fileIn.Close();
              Array.Sort(KV); 

            string line1;
            for (int i = 0; i < k; i++)
            { //Console.WriteLine(KV[i].x + "!" +  Convert.ToString(KV[i].y) + "!" +  Convert.ToString(KV[i].z) + "!");
                
                   line1 = KV[i].ToString();
                Console.WriteLine(KV[i]);
                fileOut.WriteLine(line1);
                

            }

            fileOut.Close();
            Console.Read();
        }
    }
}
