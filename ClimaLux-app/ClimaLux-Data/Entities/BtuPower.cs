using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaLux_Data.Entities
{
    public class BtuPower
    {
        public int Id { get; set; }

        [Required]
        public string Power { get; set; }

        public ICollection<Climatic> Climatics { get; set; } = new HashSet<Climatic>();
    }
}
