using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models.Base
{
    public abstract class VehicleBase
    {
        public string Make {  get; set; }
        public string Model { get; set; }
        public int GodinaProizvodnje { get; set; }
    }
}
