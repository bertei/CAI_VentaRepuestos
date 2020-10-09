using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClases;
using LibreriaConsola;

namespace CAI_VentaRepuestos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc;
            VentaRepuesto vr1 = new VentaRepuesto("AutoVentas", "asd 123");

            Console.WriteLine("ABM de Repuestos");
            Console.WriteLine("Ingrese '1' para Agregar un Repuesto.");
            Console.WriteLine("Ingrese '2' para Modificar datos de un Repuesto existente.");
            Console.WriteLine("Ingrese '3' para Agregar stock a un repuesto existente.");
            Console.WriteLine("Ingrese '3' para Quitar stock a un repuesto existente.");
            Console.WriteLine("Ingrese '5' para Eliminar un repuesto existente.");
            Console.WriteLine("Ingrese '6' para mostrar lista repuestos existentes.");
            do
            {
                opc = ConsoleHelper.ValidarInt("Ingrese una de las opciones: ");
                switch (opc)
                {
                    case 1:
                        {
                            AgregarRepuesto(vr1);
                            break;
                        }
                    case 2:
                        {
                            ModificarPrecioRep(vr1);
                            break;
                        }
                    case 3:
                        {
                            AgregarStock(vr1);
                            break;
                        }
                    case 4:
                        {
                            QuitarStock(vr1);
                            break;
                        }
                    case 5:
                        {
                            EliminarRepuesto(vr1);
                            break;
                        }
                    case 6:
                        {
                            vr1.ListaRepuestos();
                            break;
                        }
                }
            } while (opc<=6);

           
                

           
        }

        public static void AgregarRepuesto(VentaRepuesto vr)
        {
            int codRep = ConsoleHelper.ValidarInt("Ingrese el codigo del repuesto: ");
            string nombRep = ConsoleHelper.ValidarStr("Ingrese el nombre del repuesto: ");
            double precRep = ConsoleHelper.ValidarDouble("Ingrese el precio del repuesto: ");
            int stockRep = ConsoleHelper.ValidarInt("Ingrese el stock del repuesto: ");

            Console.WriteLine("Categorias disponibles: ");
            CategoriaHelper.MostrarListaCat();
            int codCategoria = ConsoleHelper.ValidarInt("Ingrese el codigo de la categoria a la que pertenece el repuesto: ");

            try
            {
                Repuesto r1 = new Repuesto(codRep, nombRep, precRep, stockRep, codCategoria);
                vr.AgregarRepuesto(r1);
                Console.WriteLine("Repuesto agregado con exito." + Environment.NewLine + r1.ToString());
            }
            catch(RepuestoExistenteException ree)
            {
                Console.WriteLine(ree.Message);
            }
            catch (CategoriaInexistenteException cie)
            {
                Console.WriteLine(cie.Message);
            }
        }

        public static void ModificarPrecioRep(VentaRepuesto vr)
        {
            //Repuesto repOld = null;

            int codRepAModif = ConsoleHelper.ValidarInt("Ingrese el codigo del repuesto que desea modificar: ");
            double precioNuevo = ConsoleHelper.ValidarDouble("Ingrese el precio nuevo: ");
            try
            {
                vr.ModificarPrecio(codRepAModif, precioNuevo);
            }
            catch(RepuestoIneExistenteException rie)
            {
                Console.WriteLine(rie.Message);
            }
        }

        public static void AgregarStock(VentaRepuesto vr)
        {
            int codRepAModif = ConsoleHelper.ValidarInt("Ingrese el codigo del repuesto que desea modificar: ");
            int stockNuevo = ConsoleHelper.ValidarInt("Ingrese la cantidad de stock que desea agregar: ");
            try
            {
                vr.AgregarStock(codRepAModif, stockNuevo);
            }
            catch(RepuestoIneExistenteException rie)
            {
                Console.WriteLine(rie.Message);
            }
        }

        public static void QuitarStock(VentaRepuesto vr)
        {
            int codRepAModif = ConsoleHelper.ValidarInt("Ingrese el codigo del repuesto que desea modificar: ");
            int stockNuevo = ConsoleHelper.ValidarInt("Ingrese la cantidad de stock que desea quitar: ");
            try
            {
                vr.AgregarStock(codRepAModif, stockNuevo);
            }
            catch (RepuestoIneExistenteException rie)
            {
                Console.WriteLine(rie.Message);
            }
        }

        public static void EliminarRepuesto(VentaRepuesto vr)
        {
            int codRepARemover = ConsoleHelper.ValidarInt("Ingrese el codigo del repuesto que desea eliminar: ");
            try
            {
                vr.QuitarRepuesto(codRepARemover);
            }
            catch (RepuestoIneExistenteException rie)
            {
                Console.WriteLine(rie.Message);
            }
        }



    }
}
