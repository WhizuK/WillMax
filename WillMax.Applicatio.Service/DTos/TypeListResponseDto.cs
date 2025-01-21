using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WillMax.Domain;

namespace WillMax.Applicatio.Service.DTos
{
    public class TypeListResponseDto
    {
        public TypeListResponseDto() { }
        public TypeListResponseDto(TypeListing type)
        {
            if (type == null)
            {
                Id = 0;
            }
            else
            {
                Id = type.Id;
                Name = type.Name;
            }
        }
        public int? Id { get; set; }
        public string? Name { get; set; }

    }
}

