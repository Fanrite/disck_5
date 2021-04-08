using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disck_5
{
    
    class Program
    {
        public static int DesYun (int x, int y)
        {
            if (x == 0 && y == 0) return 0;
            else return 1;
        }

        public static int Neg (int x)
        {
            if (x == 0) return 1;
            else if (x == 1) return 0;
            else return x;
        }

        public static int ImpL (int x, int y)
        {
            if (x == 0 && y == 1) return 0;
            else return 1;
        }

        public static int ImpR(int x, int y)
        {
            if (x == 1 && y == 0) return 0;
            else return 1;
        }

        public static int Inver (int x, int y)
        {
            if (x == y) return 1;
            else return 0;
        }

        public static int ArrowP (int x, int y)
        {
            if (x == 0 && y == 0) return 1;
            else return 0;
        }

        public static int ShtrShef (int x, int y)
        {
            if (x == 1 && y == 1) return 0;
            else return 1;
        }

        static void Main(string[] args)
        {
            //1
            string output = "";

            int[] f = new int[4];
            int[] x = { 0, 1, 1, 0 };
            int[] y = { 0, 1, 0, 1 };
            int[] z,t;

            for (int i = 0; i < 4; i++)
                f[i] = ImpL(Neg(x[i]), DesYun(x[i], y[i]));
            
            for (int i = 0; i < 4; i++)
                output += $"|X={x[i]}|Y={y[i]}|F={f[i]}|\n";
            Console.WriteLine("//----1-----//");
            Console.WriteLine(output);          
            //2
            output = "";
            f = new int[8];
            x = new int[8] { 1, 0, 0, 0, 1, 1, 0, 1};
            y = new int[8] { 0, 1, 0, 0, 1, 1, 1, 0};
            z = new int[8] { 0, 0, 1, 0, 1, 0, 1, 1};

            for (int i = 0; i < 8; i++)
                f[i] = Inver(x[i], (ArrowP(z[i], ImpR(y[i], x[i]))));
            

            for (int i = 0; i < 8; i++)
                output += $"|X={x[i]}|Y={y[i]}|Z={z[i]}|G={f[i]}|\n";

            Console.WriteLine("//------2-------//");
            Console.WriteLine(output);
            //3
            output = "";
            f = new int[14];
            t = new int[14] { 0, 0, 0, 1, 0, 1, 0, 0, 1, 1, 0, 1, 1, 1 };
            x = new int[14] { 1, 0, 0, 0, 0, 1, 1, 0, 0, 1, 1, 0, 1, 1 };
            y = new int[14] { 0, 1, 0, 0, 0, 1, 1, 1, 0, 0, 1, 1, 0, 1 };
            z = new int[14] { 0, 0, 1, 0, 0, 1, 0, 1, 1, 0, 1, 1, 1, 0 };

            for (int i = 0; i < 14; i++)
                f[i] = Inver((ImpR(t[i], ShtrShef(x[i], y[i]))), (DesYun(y[i], z[i])));
            
            for (int i = 0; i < 14; i++)
                output += $"|X={x[i]}|Y={y[i]}|Z={z[i]}|T={t[i]}|H={f[i]}|\n";

            Console.WriteLine("//--------3---------//");
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
