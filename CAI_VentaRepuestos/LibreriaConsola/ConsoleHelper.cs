using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaConsola
{
    public class ConsoleHelper
    {

        public static int ValidarInt(string msg)
        {
            int salidainput;
            //string strinput;
            bool flag = false;
            do
            {
                Console.WriteLine(msg);
                //strinput = Console.ReadLine().ToLower();
                if (!int.TryParse(Console.ReadLine().ToLower(), out salidainput))
                {
                    Console.WriteLine("Debe ingresar un dato numerico entero.");
                }
                else if (salidainput < 0)
                {
                    Console.WriteLine("Debe ingresar un dato numero entero mayor a cero.");
                }
                else
                {
                    flag = true;
                }

            } while (flag == false);
            return salidainput;
        }
        public static double ValidarDouble(string msg)
        {
            double salidainput;
            //string strinput;
            bool flag = false;
            do
            {
                Console.WriteLine(msg);
                //strinput = Console.ReadLine().ToLower();
                if (!double.TryParse(Console.ReadLine().ToLower(), out salidainput))
                {
                    Console.WriteLine("Debe ingresar un dato numerico entero.");
                }
                else if (salidainput < 0)
                {
                    Console.WriteLine("Debe ingresar un dato numero entero mayor a cero.");
                }
                else
                {
                    flag = true;
                }

            } while (flag == false);
            return salidainput;
        }

        public static string ValidarStr(string msg)
        {
            string userinput;
            do
            {
                Console.WriteLine(msg);
                userinput = Console.ReadLine().ToLower();
                if(string.IsNullOrEmpty(userinput))
                {
                    Console.WriteLine("Error, texto vacio. Debe ingresar un dato.");
                }
            } while (string.IsNullOrEmpty(userinput));
            return userinput;
        }

        public static DateTime ValidarFecha(string msg)
        {
            bool flagfecha = false;
            DateTime fecha;

            do
            {
                Console.WriteLine(msg);
                if(DateTime.TryParse(Console.ReadLine(), out fecha) == true)
                {
                    flagfecha = true;
                }
                else
                {
                    Console.WriteLine("Debe ingresar una fecha correcta. En forma (anio-dia-mes).");
                }
            } while (flagfecha == false);
            return fecha;

        }




    }
}
