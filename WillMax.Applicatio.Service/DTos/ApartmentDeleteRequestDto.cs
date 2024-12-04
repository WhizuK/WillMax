using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillMax.Applicatio.Service.DTos
{
    public class ApartmentDeleteRequestDto
    {
        public ApartmentDeleteRequestDto(Guid Id) 
        {
            this.Id = Id;
        }
        public Guid Id { get; set; }
    }
}
