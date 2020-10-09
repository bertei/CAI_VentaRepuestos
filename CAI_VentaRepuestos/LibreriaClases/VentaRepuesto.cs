using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaConsola;

namespace LibreriaClases
{
    public class VentaRepuesto
    {
        public List<Repuesto> _listaRepuestos = new List<Repuesto>();
        public string _nombreComercio;
        public string _direccion;

        //properties
        public string NombreComercio
        {
            get { return _nombreComercio; }
            set { _nombreComercio = value; }
        }
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        //constructor
        public VentaRepuesto (string nombreCom, string direccionCom)
        {
            this._nombreComercio = nombreCom;
            this._direccion = direccionCom;
        }

        //metodos
        public void AgregarRepuesto(Repuesto r1)
        {
            foreach(Repuesto r in _listaRepuestos)
            {
                if(r.Equals(r1)) //si meto un codigo de repuesto que ya existe tira esto
                {
                    throw new RepuestoExistenteException("Repuesto existente.");
                }
            }
            if(r1.CategoriaRep == null)
            {
                throw new CategoriaInexistenteException("Error. Se introdujo un codigo de categoria que no existe en la base de datos.");
            }

            this._listaRepuestos.Add(r1);
        }

        //public void RepuestoRepetidoPorCodigo(int codigo)
        //{
        //    foreach(Repuesto r in _listaRepuestos)
        //    {
        //        if(r.Codigo == codigo)
        //        {
        //            throw new CodigoRepuestoRepException("Repuesto repetido.");
        //        }
        //    }
        //}

        public void QuitarRepuesto(int codigoRepARemover)
        {
            Repuesto repARemover;
            repARemover = BuscarRepuestoPorCodigo(codigoRepARemover);

            if(BuscarRepuestoPorCodigo(codigoRepARemover) == null)
            {
                throw new RepuestoIneExistenteException("Repuesto inexistente.");
            }
            else
            {
                if(repARemover.Codigo == codigoRepARemover)
                {
                    this._listaRepuestos.Remove(repARemover);
                    Console.WriteLine("Repuesto eliminado.");
                }
                
            }
           
        }

        public Repuesto BuscarRepuestoPorCodigo(int codigoRep)
        {
            return this._listaRepuestos.Find(rep => rep.Codigo == codigoRep); //busca en la lista de rep, el repuesto ingresado por codigo int y devuelve objeto rep encontrado x ese codigo
        }

        public void ModificarPrecio(int codigoRep, double precioNew)
        {
            Repuesto repuest;
            repuest = BuscarRepuestoPorCodigo(codigoRep);
            if(BuscarRepuestoPorCodigo(codigoRep) == null)
            {
                throw new RepuestoIneExistenteException("Repuesto inexistente.");
            }
            else
            {
                if(repuest.Codigo == codigoRep)
                {
                    if(precioNew < 0)
                    {
                        throw new Exception("No puede ingresar un precio negativo.");
                    }
                    else
                    {
                        repuest.Precio =  precioNew;
                        Console.WriteLine("Precio modificado.");
                    }
                    
                }
            }
        }

        public void AgregarStock(int codigoRep, int stockNew)
        {
            Repuesto repuest;
            repuest = BuscarRepuestoPorCodigo(codigoRep);
            if (BuscarRepuestoPorCodigo(codigoRep) == null)
            {
                throw new RepuestoIneExistenteException("Repuesto inexistente.");
            }
            else
            {
                if (repuest.Codigo == codigoRep)
                {
                    repuest.Stock += stockNew; 
                }
            }
        }
        public void QuitarStock(int codigoRep, int stockNew)
        {
            Repuesto repuest;
            repuest = BuscarRepuestoPorCodigo(codigoRep);
            if (BuscarRepuestoPorCodigo(codigoRep) == null)
            {
                throw new RepuestoIneExistenteException("Repuesto inexistente.");
            }
            else
            {
                if (repuest.Codigo == codigoRep)
                {
                    repuest.Stock -= stockNew;
                }
            }
        }
        
        public void ListaRepuestos()
        {
            if(_listaRepuestos.Count == 0)
            {
                Console.WriteLine("Lista vacia.");
            }
            foreach(Repuesto r in _listaRepuestos)
            {
                Console.WriteLine(r.ToString());
            }
        }
        
    }
}
