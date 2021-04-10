using System.Threading.Tasks;
using API.DTO;
using AutoMapper;
using Data;
using Data.Entity;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class MembershipController : BaseApiController
    {
        private readonly MembershipRepository membershipRepository;
        private readonly IMapper _mapper;
        public MembershipController(DataContext dataContext, IMapper mapper)
        {
            _mapper = mapper;
            membershipRepository = new MembershipRepository(dataContext);
        }

        [HttpPost]
        public async Task<IActionResult> Create(MembershipDTO membershipDTO)
        {
            Membership membership = new Membership();
            _mapper.Map(membershipDTO, membership);

            await membershipRepository.AddAsync(membership);

            return Ok();

        }
    }
}