using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siraSizde2
{
    public abstract class Yayin

    {

        public string Baslik { get; set; }
        public string Yazar { get; set; }
        public ushort BasimYili { get; set; }


        public abstract void Oku();
        
    }




    public class Kitap : Yayin

    {

        public int SayfaSayisi { get; set; }


        public override void Oku()

        {
            Console.WriteLine("kitap okuma işlemi gerçekleştirildi");
        }

    }




    public class Dergi : Yayin

    {

        public int sayıNo { get; set; }

        public string BolumAdi { get; set; }


        public override void Oku()
        {
            Console.WriteLine("Dergi okuma işlemi gerçekleştirildi");
        }

    }




    public class Ansiklopedi : Yayin

    {

        public int ciltNo { get; set; }


        public override void Oku()
        {
            Console.WriteLine("Ansiklopedi okuma işlemi gerçekleştirildi");
        }

    }




    class Program

    {

        static void Main(string[] args)
        {
            Ansiklopedi ansiklopedi = new Ansiklopedi();
            ansiklopedi.Oku();
            Console.WriteLine("===============================");
            Kitap kitap = new Kitap();
            kitap.Oku();
            Console.WriteLine("===============================");
            Dergi dergi = new Dergi();
            dergi.Oku();
            Console.WriteLine("===============================");
        }

    }
}
