using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaConsola;


namespace LibreriaClases
{
    public class Repuesto
    {
        private int _codigo;
        private int _stock;
        private double _precio;
        private string _nombre;
        private Categoria _categoria;

        //properties
        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        public int Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
        public double Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public Categoria CategoriaRep
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

        //constructor
        public Repuesto (int codigoRep, string nombreRep, double precioRep, int stockRep, int codigoCat)
        {
            this._codigo = codigoRep;
            this._nombre = nombreRep;
            this._precio = precioRep;
            this._stock = stockRep;
            this._categoria = CategoriaHelper.GetCategoriaPorCodigo(codigoCat);
        }

        //metodos
        public override string ToString()
        {
            return string.Format("Codigo del repuesto: {0} - Nombre: {1} - Precio: {2} - Stock: {3} - Categoria: {4}.", Codigo, Nombre, Precio, Stock, CategoriaRep);
        }

        public override bool Equals(object obj) //EL OBJECT OBJ ES CON EL CUAL SE COMPARA
        {
            if(obj == null) //si el objeto recibio es nullo, tira falso
            {
                return false;
            }
            if(!(obj is Repuesto)) //si el obj no es repuesto, tira false
            {
                return false;
            }
            Repuesto repuestoExterno = (Repuesto)obj;

            //forma 2 mas facil
            return (this._codigo == repuestoExterno._codigo);//si son iguales da true y si son diferentes, false

            //FORMA 1
            //if(this._codigo == repuestoExterno.Codigo)
            //{
            //    return true; //son iguales
            //}
            //else
            //{
            //    return false; //no son iguales
            //}
        }


    }
}
