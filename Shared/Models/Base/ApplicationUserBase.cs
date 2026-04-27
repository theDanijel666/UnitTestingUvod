using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models.Base
{
    public abstract class ApplicationUserBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

    }
}
