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
        Task<ApartmentResponseDto> Create(ApartmentRequestDto apartmentDto);
        Task<ApartmentResponseDto> Update(ApartmentRequestDto apartmentDto);
        Task<ApartmentResponseDto> Delete(ApartmentDeleteRequestDto apartmentDto);
        Task<ApartmentResponseDto> Delete(Guid id);


    }
}
