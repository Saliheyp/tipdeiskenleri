using System;

namespace tipdeiskn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // implicit conversion (bilinçsiz Dönüşüm)
            byte a = 5;
            sbyte b = 30;
            short c = 10;
            
            int d = a+b+c;

            Console.WriteLine("d:"+d);

            long h = d;
            Console.WriteLine("h:"+h);

            float i = h;
            Console.WriteLine("i:"+i);

            string name = "salih";
            char f ='k';
            object g =name+f+i;

            Console.WriteLine("g:"+g);
            
            // Explicit conversion (bilinçli Dönüşüm)

            Console.WriteLine("*********** Explicit conversion*************");
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:"+y);
            int z =100;
            byte t = (byte)z;
            Console.WriteLine("t:"+t);

            float w=10.3f;
            byte v =(byte)w;
            Console.WriteLine("v:"+v);

            // ToString Methodu
            Console.WriteLine("ToString Methodu");
            int xx =6;
            string yy=xx.ToString();
            Console.WriteLine(yy);
            string zz =12.5f.ToString();
            Console.WriteLine(zz);

            //System.Convert 
            Console.WriteLine("System.Convert");
            string s1 ="10",s2 = "20";
            int sayi1, sayi2, Toplam;
            
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            Toplam = sayi1+sayi2;
            Console.WriteLine(Toplam);

            //Parse 
            Console.WriteLine ("**********Parse*********");
            ParseMethod();

        }
        public static void ParseMethod()
        {
            string metin1 ="10", metin2="10.25";
            int rakam1;
            double double1;
            rakam1=Int32.Parse(metin1);
            Console.WriteLine (rakam1);

            double1=double.Parse(metin2);
            Console.WriteLine ("rakam1="+rakam1);
            Console.WriteLine ("duble1="+double1);



        }
    }
}