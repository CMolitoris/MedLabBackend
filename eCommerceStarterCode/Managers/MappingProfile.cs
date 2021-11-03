using AutoMapper;
using eCommerceStarterCode.DataTransferObjects;
using eCommerceStarterCode.Models;
using Profile = AutoMapper.Profile;

namespace eCommerceStarterCode.Managers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserForRegistrationDto, User>();
        }
    }
}
