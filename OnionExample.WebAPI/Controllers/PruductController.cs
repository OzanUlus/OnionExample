using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionExample.Application.Interfaces.Repositories;
using OnionExample.Application.Interfaces.Services;
using OnionExample.Domain.Entities;

namespace OnionExample.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PruductController : Controller
    {
        private readonly IProductRepository _repository;
        private readonly IEmailService _emailService;

        public PruductController(IProductRepository repository, IEmailService emailService)
        {
            _repository = repository;
            _emailService = emailService;
        }
        [HttpGet]
        public async Task<IActionResult> Get() 
        {
          List<Product> products = await _repository.GetAsync();
            return Ok(products);
        
        }
        [HttpGet("SendMail")]
        public IActionResult SendMail() 
        {
            bool result = _emailService.SendMail("ozan@ozan.com", "denedik bakalım birşeyler.");
            return Ok(result);
        
        }
            
    }
}
