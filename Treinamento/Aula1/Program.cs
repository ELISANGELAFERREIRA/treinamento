using System;
using Aula1.Model;

namespace Aula1
{
    class Program
    {

        public static void Print(object o)
        {
            Console.WriteLine(o.ToString());
        }


        public static void Show(Local local)
        {
            Console.WriteLine("{0} - {1}", local.Code, local.Size);
            local.Harvest();

        }

        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello World!");
             Console.ReadKey();*/
            int i = 10;
            bool b = true;
            string s = "Felipe";

            Print(i);
            Print(b);
            Print(s);


            Sector sectorA = new Sector("S1", 100);

            Farm farm1 = new Farm();
            farm1.Code = "F1";

            Block block1 = new Block();
            block1.Code = "B1";
            block1.Size = 50;


            Field field1 = new Field();
            field1.Code = "FI1";
            field1.Size = 10;
            field1.Culture = "Suggar Cane";

            
            Show(sectorA);
            Show(farm1);
            Show(block1);
            Show(field1);

            Console.ReadKey();
        
        }

   




    }
}
