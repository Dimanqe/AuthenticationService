using AuthenticationService.DAL;
using AuthenticationService.PLL;
using AutoMapper;

namespace AuthenticationService.BLL
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserViewModel>()
                .ConstructUsing(v => new UserViewModel(v));

        }
    }
}
