using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using NuGet.ContentModel;
using System;
using System.Collections.Generic;
using System.Text;
using WebMvc.Models.Dbo;

namespace WebMvc.UnitTest
{
    public class VehicleServiceUnitTests:WebMvcSetup
    {
        [Fact]
        public async Task GetAllVehicles_ReturnsListOfViewModel()
        {
            var result = vehicleService.GetAllVehicles();

            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal(15, result.Count);
        }

        [Fact]
        public async Task Getvehicle_By_Id_ReturnsViewModel()
        {
            var vehicles = vehicleService.GetAllVehicles();
            var result = vehicleService.GetVehicle(vehicles[0].Id);
            Assert.NotNull(result);
            Assert.Equal(vehicles[0].Id, result.Id);
            Assert.Equal(vehicles[0].Make, result.Make);
            Assert.Equal(vehicles[0].Model, result.Model);
        }

        [Fact]
        public async Task GetVehicle_By_Id_ReturnsNullForNonExistingVehicle()
        {
            var result=vehicleService.GetVehicle(100000);
            Assert.Null(result);
        }

        [Fact]
        public async Task AddVehicle_ReturnsAddedViewModel()
        {
            //var gp = DateTime.Now.Ticks % 10000;
            //var ma = "Make" + DateTime.Now.Ticks.ToString();
            //var mo = "Model" + DateTime.Now.Ticks.ToString();
            var newVehicle = vehicleService.AddVehicle(new Shared.Models.Binding.VehicleBinding
            {
                GodinaProizvodnje = 2007,
                Make = "Honda",
                Model = "Accord"
            });

            Assert.NotNull(newVehicle);
            Assert.True(newVehicle.Id > 0);
            Assert.Equal("Honda",newVehicle.Make);
            Assert.Equal("Accord", newVehicle.Model);
        }

        [Fact]
        public async Task Updatevehicle_ReturnsUpdatedViewModel()
        {
            var res = vehicleService.UpdateVehicle(new Shared.Models.Binding.VehicleUpdateBinding
            {
                Id=1,
                GodinaProizvodnje=2009,
                Make="Peugeot",
                Model="107"
            });

            Assert.NotNull(res);
            Assert.Equal(1, res.Id);
            Assert.Equal(2009, res.GodinaProizvodnje);
            Assert.Equal("Peugeot", res.Make);
            Assert.Equal("107", res.Model);

            var indb = vehicleService.GetVehicle(res.Id);
            Assert.NotNull(indb);
            Assert.Equal(1, indb.Id);
            Assert.Equal(2009, indb.GodinaProizvodnje);
            Assert.Equal("Peugeot", indb.Make);
            Assert.Equal("107", indb.Model);
        }

        [Fact]
        public async Task UpdateVehicle_ReturnsNullForUpdatingNonExistingVehicle()
        {
            var res = vehicleService.UpdateVehicle(new Shared.Models.Binding.VehicleUpdateBinding
            {
                Id = 100000,
                GodinaProizvodnje = 2009,
                Make = "Peugeot",
                Model = "107"
            });

            Assert.Null(res);
        }

        [Fact]
        public async Task DeleteVehicle_ReturnsDeletedViewModel()
        {
            var vehicle = vehicleService.GetAllVehicles();
            var res = vehicleService.DeleteVehicle(vehicle[0].Id);
            Assert.NotNull(res);
            Assert.Equal(vehicle[0].Id, res.Id);

            vehicle=vehicleService.GetAllVehicles();
            Assert.NotEqual(vehicle[0].Id, res.Id);
            Assert.Equal(14, vehicle.Count);
        }

        [Fact]
        public async Task DeleteVehicle_ReturnsNullWhenDeletingnonExistingVehicle()
        {
            var res = vehicleService.DeleteVehicle(100000);
            Assert.Null(res);

            var vehicle = vehicleService.GetAllVehicles();
            Assert.Equal(15, vehicle.Count);
        }

    }
}
