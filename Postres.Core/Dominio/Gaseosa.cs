
using System.Collections.Generic;

namespace Postres.Core.Dominio
{
    public class Postre
    {
        public string Id { get; set; }  
        public string Nombre { get; set; }
        public LinkedList<Pollos> Ingredientes { get; set; } = new LinkedList<Pollos>();  
        public bool EstaEnAlta { get; set; } = true;  
    }
}
