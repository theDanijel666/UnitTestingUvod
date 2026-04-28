using AutoMapper;
using Shared.Models.Binding;
using Shared.Models.ViewModel;
using WebMvc.Models.Dbo;
using WebMvc.Service.Interface;

namespace WebMvc.Service.Implementation
{
    public class ApplicationUserService : IApplicationUserService
    {
        private readonly List<ApplicationUser> _applicationUsers;
        private readonly IMapper _mapper;

        public ApplicationUserService(IMapper mapper)
        {
            _mapper = mapper;
            if (_applicationUsers == null)
            {
                _applicationUsers = ApplicationUser.GetApplicationUsers();
            }
        }


        public List<ApplicationUserViewModel> GetAllApplicationUsers()
        {
            return _applicationUsers.Select(u => _mapper.Map<ApplicationUserViewModel>(u)).ToList();
        }

        public ApplicationUserViewModel GetApplicationUser(int id)
        {
            var user=_applicationUsers.FirstOrDefault(u=> u.Id == id);
            return _mapper.Map<ApplicationUserViewModel>(user);
        }

        public ApplicationUserViewModel AddApplicationUser(ApplicationUserBinding model)
        {
            var maxId=_applicationUsers.Max(u=> u.Id);
            var dbo = _mapper.Map<ApplicationUser>(model);
            dbo.Id = maxId + 1;
            _applicationUsers.Add(dbo);
            return _mapper.Map<ApplicationUserViewModel>(dbo);
        }
        
        public ApplicationUserViewModel UpdateApplicationUSer(ApplicationUserUpdateBinding model)
        {
            var dbo=_applicationUsers.FirstOrDefault(u=>u.Id==model.Id);
            dbo = _mapper.Map(model, dbo);
            return _mapper.Map<ApplicationUserViewModel>(dbo);
        }

        public ApplicationUserViewModel DeleteApplicationUser(int id)
        {
            var user = _applicationUsers.FirstOrDefault(u => u.Id == id);
            _applicationUsers.Remove(user);
            return _mapper.Map<ApplicationUserViewModel>(user);
        }        
    }
}
