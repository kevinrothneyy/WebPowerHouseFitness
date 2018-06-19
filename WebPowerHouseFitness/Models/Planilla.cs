using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPowerHouseFitness.Models
{
    public class Planilla
    {
        public int ID { get; set; }
        public string PT { get; set; }
        public DateTime Hora { get; set; }
        public int Valoracion { get; set; }
        public int asistencia { get; set; }

    }
}
