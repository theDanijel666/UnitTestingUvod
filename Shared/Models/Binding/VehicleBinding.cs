using System;
using System.Collections.Generic;
using System.Text;
using Shared.Models.Base;

namespace Shared.Models.Binding
{
    public class VehicleBinding:VehicleBase
    {
    }

    public class VehicleUpdateBinding : VehicleBase
    {
        public int Id {  get; set; }
    }
}
