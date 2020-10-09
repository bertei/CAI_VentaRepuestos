using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    public static class CategoriaHelper
    {
        private static List<Categoria> _listaCategorias; //creo variable de tipo lista(de objeto categoria)

        static CategoriaHelper()
        {
            _listaCategorias = new List<Categoria>(); //creo variable de lista categoria

            Categoria c1 = new Categoria("Motor", 1);
            Categoria c2 = new Categoria("Accesorios", 2);
            Categoria c3 = new Categoria("Ruedas", 3);

            _listaCategorias.Add(c1); //agrego categorias a la lista
            _listaCategorias.Add(c2);
            _listaCategorias.Add(c3);

        }

        public static List<Categoria> GetCategorias() //metodo que me devuelve la lista de categorias
        {
            return _listaCategorias;
        }

        public static void MostrarListaCat()
        {
            foreach(Categoria c in _listaCategorias)
            {
                Console.WriteLine("Nombre categoria: {0} - Codigo categoria: {1}.", c.Nombre, c.Codigo);
            }
        }
        
        public static Categoria GetCategoriaPorCodigo(int codigo)
        {
            Categoria cat = null;
            foreach (Categoria c in _listaCategorias)
            {
                if (c.Codigo == codigo) //si se iguala el codigo q ingres epor parametro con algun codigo de las categorias listadas, me devuelve esa categorai
                {
                    cat = c; //la variable categoria se iguala con la categoria encontrada por codigo
                }
            }
            if (cat == null) //excepcion en caso de que cat sea null
            {
                //throw new Exception("No se encontro ninguna categoria por ese codigo."); 
                throw new CategoriaInexistenteException("Categoria inexistente"); //lanzo nueva clase de excpecion y paso por parmetro el mensaje de error
            }
            return cat; //retorno el objeto
        }
    }
}
