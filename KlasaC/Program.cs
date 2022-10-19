using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KlasaC A=new KlasaC();
            int[] broj = new int[5];
            Console.WriteLine("Upisi 5 brojeva.");
            for (int i = 0; i < broj.Length; i++)
            {
                broj[i]=Convert.ToInt32(Console.ReadLine());
                
            }
            Console.WriteLine("Zbroj je "+A.Zbroj(broj));
            Console.WriteLine("Prosjek je :"+A.Prosjek(broj));
            Console.ReadKey();
        }
    }
    class KlasaC
    {
        int[] broj = new int[4];
        int zbroj;
        double prosjek;

        public int Zbroj(int[] broj)
        {
            int zbr = 0;
            for (int i = 0; i < broj.Length; i++)
            {
                zbroj+=broj[i];
               
            }
            return this.zbroj;
        }

        public double Prosjek(int[] broj)
        {
            int zbroj=Zbroj(broj);
            double prosjek = (double)zbroj / broj.Length;
            return prosjek;
        }
        
    }
}
