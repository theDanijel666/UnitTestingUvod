using Shared.Models.Base;

namespace WebMvc.Models.Dbo
{
    public class Vehicle:VehicleBase
    {
        public int Id { get; set; }

        public static List<Vehicle> GetVehicles(int? number = 15)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            
            for(int i = 0; i < number; i++)
            {
                vehicles.Add(new Vehicle
                {
                    Id = i + 1,
                    GodinaProizvodnje = 2000 + i,
                    Make = "Marka " + (i + 1),
                    Model = "Model " + i
                });
            }

            return vehicles;
        }
    }
}
