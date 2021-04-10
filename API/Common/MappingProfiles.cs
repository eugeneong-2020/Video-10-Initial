using API.DTO;
using AutoMapper;
using Data.Entity;

namespace API.Common
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<CustomerDTO, Customer>();

            CreateMap<MembershipDTO, Membership>();
        }

    }
}