using Shared.Models.Binding;
using Shared.Models.ViewModel;

namespace WebMvc.Service.Interface
{
    public interface IAppplicationUserService
    {
        ApplicationUserViewModel AddApplicationUser(ApplicationUserBinding model);
        ApplicationUserViewModel DeleteApplicationUser(int id);
        List<ApplicationUserViewModel> GetAllApplicationUsers();
        ApplicationUserViewModel GetApplicationUser(int id);
        ApplicationUserViewModel UpdateApplicationUSer(ApplicationUserUpdateBinding model);
    }
}
