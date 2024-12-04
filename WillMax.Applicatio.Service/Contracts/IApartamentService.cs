using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WillMax.Applicatio.Service.DTos;

namespace WillMax.Applicatio.Service.Contracts
{
    public interface IApartamentService
    {
        Task<IEnumerable<ApartmentResponseDto>> GetAll();
        Task<ApartmentResponseDto> GetById(Guid id);
        Task<ApartmentResponseDto> Create(ApartmentResponseDto apartment);
        Task<ApartmentResponseDto> Update(ApartmentResponseDto apartment);
        Task<ApartmentResponseDto> Delete(ApartmentDeleteRequestDto apartment);
        Task<ApartmentResponseDto> Dto(Guid id);


    }
}
