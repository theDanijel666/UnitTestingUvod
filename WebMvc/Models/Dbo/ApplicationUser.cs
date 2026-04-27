using Shared.Models.Base;

namespace WebMvc.Models.Dbo
{
    public class ApplicationUser:ApplicationUserBase
    {
        public int Id { get; set; }

        public static List<ApplicationUser> GetApplicationUsers(int? number = 15)
        {
            List<ApplicationUser> ApplicationUsers = new List<ApplicationUser>();

            for(int i = 0; i < number; i++)
            {
                ApplicationUsers.Add(new ApplicationUser
                {
                    Id = i + 1,
                    Email=$"user{i}@domain.com",
                    FirstName=$"FirstName{i}",
                    LastName=$"LastName{i}",
                    PhoneNumber=$"098/123-45{i}"
                });
            }

            return ApplicationUsers;
        }
    }
}
