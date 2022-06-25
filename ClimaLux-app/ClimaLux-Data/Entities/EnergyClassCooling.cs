using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaLux_Data.Entities
{
    public class EnergyClassCooling : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CoolClass { get; set; }

        public ICollection<Climatic> Climatics { get; set; } = new HashSet<Climatic>();
       
    }
}
