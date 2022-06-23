using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaLux_Data.Entities
{
    public class EnergyClassHeating
    {
        public int Id { get; set; }

        [Required]
        public string HeatClass { get; set; }

        public ICollection<Climatic> Climatics { get; set; } = new HashSet<Climatic>();
    }
}
