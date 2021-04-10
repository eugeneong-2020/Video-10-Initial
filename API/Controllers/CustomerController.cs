using System.Threading.Tasks;
using API.DTO;
using AutoMapper;
using Data;
using Data.Entity;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class CustomerController : BaseApiController
    {
        private readonly CustomerRepository customerRepository;
        private readonly IMapper _mapper;
        public CustomerController(DataContext dataContext, IMapper mapper)
        {
            _mapper = mapper;
            customerRepository = new CustomerRepository(dataContext);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CustomerDTO customerDTO)
        {
            Customer customer = new Customer();
            _mapper.Map(customerDTO, customer);

            await customerRepository.AddAsync(customer);

            return Ok(customer.Id);
        }

    }
}