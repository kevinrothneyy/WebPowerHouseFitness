using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPowerHouseFitness.Models
{
    public class Usuarios
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Rut { get; set; }
        public string Correo { get; set; }
        public int Fono { get; set; }
        public Boolean Estado { get; set; }
        public string Perfil { get; set; }
    }
}
