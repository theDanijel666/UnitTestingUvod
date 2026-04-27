using System;
using System.Collections.Generic;
using System.Text;
using Shared.Models.Base;

namespace Shared.Models.Binding
{
    public class ApplicationUserBinding : ApplicationUserBase
    {
    }

    public class ApplicationUserUpdateBinding : ApplicationUserBase
    {
        public int Id { get; set; }
    }
}
