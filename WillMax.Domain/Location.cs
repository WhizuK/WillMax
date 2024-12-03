using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillMax.Domain
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Apartament> Apartaments { get; set; }
    }
}
