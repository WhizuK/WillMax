using Microsoft.AspNetCore.Mvc;
using WillMax.Applicatio.Service.Contracts;
using WillMax.Applicatio.Service.DTos;
using WillMax.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WillMax.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentController : ControllerBase
    {
        private readonly IApartamentService _apartamentService;
        private readonly ILogger _logger;

        public ApartmentController(IApartamentService apartamentService)
        {
            _apartamentService = apartamentService;
           
        }


        // GET: api/<ApartmentController>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _apartamentService.GetAll());
        }

        // GET api/<ApartmentController>/5
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _apartamentService.GetById(id));
        }

        // POST api/<ApartmentController>
        [HttpPost]
        public async Task<IActionResult> Create(ApartmentRequestDto apartament)
        {
            return Ok(await _apartamentService.Create(apartament));
        }

        // PUT api/<ApartmentController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(ApartmentRequestDto apartment)
        {
            return Ok(await _apartamentService.Update(apartment));
        }

        // DELETE api/<ApartmentController>/5
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return Ok(await _apartamentService.Delete(id));
        }
    }
}
