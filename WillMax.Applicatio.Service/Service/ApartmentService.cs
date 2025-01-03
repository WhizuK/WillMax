﻿
using AutoMapper;
using WillMax.Applicatio.Service.Contracts;
using WillMax.Applicatio.Service.DTos;
using WillMax.Domain;

namespace WillMax.Applicatio.Service.Service
{
    public class ApartmentService : IApartamentService
    {
        private readonly IApartamentRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ApartmentService(IUnitOfWork unitOfWork, IApartamentRepository repository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _mapper = mapper;

        }

        public async Task<ApartmentResponseDto> Create(ApartmentRequestDto apartmentDto)
        {
            Apartament apartment = _mapper.Map<Apartament>(apartmentDto);
            apartment.Id = Guid.NewGuid();

            if(apartment.Price == 0)
            {
                throw new Exception("Defina um Preço diferente de 0 !!!!");
            }

            var entity =  _repository.Create(apartment);
            await _unitOfWork.Commit();

            return new ApartmentResponseDto(apartment);
        }

        public async Task<ApartmentResponseDto> Delete(ApartmentDeleteRequestDto apartmentDto)
        {
            Apartament apartment = new Apartament();
            apartment.Id = apartmentDto.Id;

            var entity = _repository.Delete(apartment);
            await _unitOfWork.Commit();
            return new ApartmentResponseDto(entity);
        }

        public async Task<ApartmentResponseDto> Delete(Guid id)
        {
            var entity = await _repository.DeleteById(id);
            await _unitOfWork.Commit(); 
            return new ApartmentResponseDto(entity);
        }

        public async Task<IEnumerable<ApartmentResponseDto>> GetAll()
        {
            var apartments = await _repository.GetAll();
            return apartments.Select(a => new ApartmentResponseDto(a));
        }

        public async Task<ApartmentResponseDto> GetById(Guid id)
        {
            Apartament apartament = await _repository.GetById(id);
            return new ApartmentResponseDto(apartament);
        }

        public async Task<ApartmentResponseDto> Update(ApartmentRequestDto apartmentDto)
        {
            var apartament = _mapper.Map<Apartament>(apartmentDto);

            var updatedEntity = _repository.Update(apartament);
            await _unitOfWork.Commit();
            return new ApartmentResponseDto(updatedEntity);
        }
    }
}
