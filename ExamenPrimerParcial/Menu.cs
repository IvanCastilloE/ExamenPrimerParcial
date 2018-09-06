using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Menu
    {
        public string Nombre { get; set; }
        public string Id { get; set; }
        public int Horainicio { get; set; }
        public int Horafin { get; set; }
        public List<Platillo> platillos = new List<Platillo>();
        public Menu()
        {
            Nombre = "Nuevo nombre";
        }

    }
}
