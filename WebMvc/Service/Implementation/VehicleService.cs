using AutoMapper;
using Shared.Models.Binding;
using Shared.Models.ViewModel;
using WebMvc.Models.Dbo;
using WebMvc.Service.Interface;

namespace WebMvc.Service.Implementation
{
    public class VehicleService : IVehicleService
    {
        private readonly List<Vehicle> _vehicles;
        private readonly IMapper _mapper;

        public VehicleService(IMapper mapper)
        {
            _mapper= mapper;
            if (_vehicles == null)
            {
                _vehicles = Vehicle.GetVehicles();
            }
        }
        
        public List<VehicleViewModel> GetAllVehicles()
        {
            return _vehicles.Select(y => _mapper.Map<VehicleViewModel>(y)).ToList();
        }

        public VehicleViewModel GetVehicle(int id)
        {
            var vehicle = _vehicles.FirstOrDefault(v => v.Id == id);
            return _mapper.Map<VehicleViewModel>(vehicle);
        }

        public VehicleViewModel AddVehicle(VehicleBinding model)
        {
            var maxId = _vehicles.Max(v => v.Id);
            var dbo = _mapper.Map<Vehicle>(model);
            dbo.Id = maxId + 1;
            _vehicles.Add(dbo);
            return _mapper.Map<VehicleViewModel>(dbo);
        }

        public VehicleViewModel UpdateVehicle(VehicleUpdateBinding model)
        {
            var dbo = _vehicles.FirstOrDefault(v => v.Id == model.Id);
            dbo = _mapper.Map(model, dbo);
            return _mapper.Map<VehicleViewModel>(dbo);
        }

        public VehicleViewModel DeleteVehicle(int id)
        {
            var vehicle = _vehicles.FirstOrDefault(v => v.Id == id);
            _vehicles.Remove(vehicle);
            return _mapper.Map<VehicleViewModel>(vehicle);
        }
    }
}
