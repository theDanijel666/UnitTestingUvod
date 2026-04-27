using Shared.Models.Binding;
using Shared.Models.ViewModel;
using WebMvc.Models.Dbo;

namespace WebMvc.Service.Interface
{
    public interface IVehicleService
    {
        /// <summary>
        /// Retrieves a list of all vehicles available in the system.
        /// </summary>
        /// <returns>A list of <see cref="VehicleViewModel"/> objects representing all vehicles. The list is empty if no vehicles
        /// are found.</returns>
        List<VehicleViewModel> GetAllVehicles();
        /// <summary>
        /// Adds a new vehicle using the specified data model and returns a view model representing the created vehicle.
        /// </summary>
        /// <param name="model">The data model containing the details of the vehicle to add. Cannot be null.</param>
        /// <returns>A view model representing the newly added vehicle.</returns>
        VehicleViewModel AddVehicle(VehicleBinding model);
        /// <summary>
        /// Updates the details of an existing vehicle using the specified update model.
        /// </summary>
        /// <param name="model">An object containing the updated values for the vehicle. Must include all required fields for a valid
        /// update.</param>
        /// <returns>A VehicleViewModel representing the updated vehicle details.</returns>
        VehicleViewModel UpdateVehicle(VehicleUpdateBinding model);
        /// <summary>
        /// Retrieves the vehicle with the specified identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the vehicle to retrieve.</param>
        /// <returns>A VehicleViewModel representing the vehicle with the specified identifier, or null if no such vehicle
        /// exists.</returns>
        VehicleViewModel GetVehicle(int id);
        /// <summary>
        /// Deletes the vehicle with the specified identifier and returns the deleted vehicle's details.
        /// </summary>
        /// <param name="id">The unique identifier of the vehicle to delete. Must correspond to an existing vehicle.</param>
        /// <returns>A VehicleViewModel representing the deleted vehicle. Returns null if no vehicle with the specified
        /// identifier exists.</returns>
        VehicleViewModel DeleteVehicle(int id);
    }
}
