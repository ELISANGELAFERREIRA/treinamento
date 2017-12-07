using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1.Model
{
    class Local
    {
        public string Code { get; set; }

        public int Size { get; set; }

        public Local()
           // : this("L1", 100)
        {
        }

        public Local(string code, int size)
        {
            Code = code;
            Size = size;
        }

        public virtual void Harvest() //colher
        {

        }

    }

    class Sector: Local
    {
        //public string Code { get; set; }
       // public int Size { get; set; }

        public Farm[] Farms { get; set; }

        public Sector(String code, int size)
            : base(code, size)
        {
            //Code = code;
            //Size = size;
        }

        public override void Harvest()
        {

            Console.WriteLine("Harvest Sector {0}", Code);
        } 

    }


    class Farm : Local
    {
        public Block[] Blocks { get; set; }

        public override void Harvest()
        {

            Console.WriteLine("Harvest Farm {0}", Code);
        }
    }



    class Block : Local
    {
        public Field[] Fields { get; set; }

        public override void Harvest()
        {

            Console.WriteLine("Harvest Block {0}", Code);
        }
    }


    class Field : Local
    {
        private string _culture;

        public string Culture
        {
            get
            {
                return _culture;
            }

            set
            {
                _culture = value;
            }
        } 

        public void Plant(string culture)
        {
            Culture = culture;
        }

        public override void Harvest()
        {

            Console.WriteLine("Harvest Field {0}", Code);
        }
    }
}
