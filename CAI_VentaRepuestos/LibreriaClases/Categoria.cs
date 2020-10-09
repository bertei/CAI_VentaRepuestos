using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaConsola;

namespace LibreriaClases
{
    public class Categoria
    {
        private int _codigoCat;
        private string _nombreCat;

        //properties
        public int Codigo
        {
            get { return _codigoCat; }
            set { _codigoCat = value; }
        }
        public string Nombre
        {
            get { return _nombreCat; }
            set { _nombreCat = value; }
        }

        //constructor
        public Categoria (string nombreCategoria, int codigoCategoria)
        {
            this._nombreCat = nombreCategoria;
            this._codigoCat = codigoCategoria;
        }

        public override string ToString()
        {
            return string.Format("Codigo cat: {0} - Nombre cat: {1}.", Codigo, Nombre);
        }


    }
}
