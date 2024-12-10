
using WillMax.Applicatio.Service.Contracts;
using WillMax.Applicatio.Service.DTos;
using WillMax.Domain;

namespace WillMax.Applicatio.Service.Service
{
    public class ApartmentService : IApartamentService
    {
        private readonly IApartamentRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public ApartmentService(IUnitOfWork unitOfWork, IApartamentRepository repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public async Task<ApartmentResponseDto> Create(ApartmentRequestDto apartmentDto)
        {
            Apartament apartament = apartmentDto.ToEntity();
            apartament.Id = new Guid();

            if(apartament.Price == 0)
            {
                throw new Exception("Defina um Preço diferente de 0 !!!!");
            }

            var entity = await _repository.Create(apartament);
            await _unitOfWork.Commit();

            return new ApartmentResponseDto(apartament);
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
            List<ApartmentResponseDto> allApatments = new List<ApartmentResponseDto>();
            List<Apartament> apartments = (List<Apartament>)await _repository.GetAll();
            foreach (var apartment in apartments)
            {
                allApatments.Add(new ApartmentResponseDto(apartment));
            }
            return allApatments;
        }

        public async Task<ApartmentResponseDto> GetById(Guid id)
        {
            Apartament apartament = await _repository.GetById(id);
            return new ApartmentResponseDto(apartament);
        }

        public async Task<ApartmentResponseDto> Update(ApartmentRequestDto apartmentDto)
        {
            Apartament apartament = new Apartament();
            var entity = _repository.Update(apartament);
            await _unitOfWork.Commit();
            return new ApartmentResponseDto(entity);
        }
    }
}
