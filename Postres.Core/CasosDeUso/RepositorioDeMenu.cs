using Postres.Core.Dominio;
using System;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Postres.Core.CasosDeUso
{
    public class RepositorioDeMenu : IRepositorioDeMenu
    {

        private readonly  ArregloDeObjetos<Postre> _Comidas;

        public RepositorioDeMenu(ArregloDeObjetos<Postre> postres)
        {
          _Comidas = postres;
        }


        void OrdenarLista()
        {
            _Comidas.setDatos(_Comidas.OrderBy(p => p.Nombre).ToArray());
        }
        public void AgregarUnPostre(Postre postre)
        {
            _Comidas.Agregar(postre);
            OrdenarLista();
          


        }
        public void AgregarUnIngrediente(string Id, Pollos ingrediente)
        {
            var Postre = ObtenerUnaComidaPorId(Id);
            if(Postre != null)
            {
                Postre.Ingredientes.AddLast(ingrediente);
            }
        }


        public Postre ObtenerUnaComidaPorId(string Id)
        {
            return _Comidas.First(p => p.Id.Equals(Id));  
        }

        public bool DarDeAltaUnPostre(string Id)
        {
            return ObtenerUnaComidaPorId(Id).EstaEnAlta = true;
        }

        public bool DarDeBajaUnPostre(string Id)
        {
            return ObtenerUnaComidaPorId(Id).EstaEnAlta = false;
        }

        public void EliminarUnIngrediente(string Id_Postre, string Id_Ingrediente)
        {
            var Postre = ObtenerUnaComidaPorId(Id_Postre);
            if (Postre != null)
            {
                var ingrediente = Postre.Ingredientes.First(i => i.Id.Equals(Id_Ingrediente));
                Postre.Ingredientes.Remove(ingrediente);
            }
        }

        public Postre[] ObtenerListaDePostres()
        {
            if (!_Comidas.EstaVacia())
            {
                return _Comidas.ToArray();
            }
            else return null;
        }

        public Postre[] ObtenerUnPostrePorNombre(string nombre)
        {
            if (!_Comidas.EstaVacia())
            {
                return _Comidas.Where(p => p.Nombre.Equals(nombre)).ToArray();
            }else return null;
                
        }

        public Postre ObtenerUnPostrePorId(string Id)
        {
            throw new NotImplementedException();
        }
    }
}
