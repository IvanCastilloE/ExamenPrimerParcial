using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Platillo
    {
        public string Id { get; set; }
        string Nombre { get; set; }
        string Descripcion { get; set; }
        public List<Ingrediente> ingredientes = new List<Ingrediente>();
        double _precio;
        public double precio
        {
            get
            {
                return _precio;
            }
            set
            {
                if (value < 50)
                {
                    _precio = 50;
                }
                else
                {
                    _precio = precio;
                }

            }
        }
