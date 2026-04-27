using AutoMapper;
using Shared.Models.Binding;
using Shared.Models.ViewModel;
using WebMvc.Models.Dbo;

namespace WebMvc.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<VehicleUpdateBinding, Vehicle>();
            CreateMap<VehicleBinding, Vehicle>();
            CreateMap<Vehicle, VehicleViewModel>();

            CreateMap<ApplicationUserUpdateBinding,ApplicationUser>();
            CreateMap<ApplicationUserBinding, ApplicationUser>();
            CreateMap<ApplicationUser,ApplicationUserViewModel>();
        }
    }
}
