

using Postres.Core.Dominio;

namespace Postres.Core.CasosDeUso
{
    public interface IRepositorioDeMenu
    {
        void AgregarUnPostre(Postre postre);
        Postre[] ObtenerListaDePostres();
        Postre ObtenerUnPostrePorId(string Id);
        Postre[] ObtenerUnPostrePorNombre(string nombre);

        void AgregarUnIngrediente(string Id, Pollos ingrediente);
        void EliminarUnIngrediente(string Id_Postre, string Id_Ingrediente);    
        bool DarDeAltaUnPostre(string Id);
        bool DarDeBajaUnPostre(string Id);
    }
}
