using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPowerHouseFitness.Models
{
    public class Anuncio
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public int Duracion { get; set; }
        public Boolean Validacion { get; set; }


    }
}
