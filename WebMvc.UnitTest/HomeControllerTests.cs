using Microsoft.AspNetCore.Mvc;
using Shared.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using WebMvc.Controllers;

namespace WebMvc.UnitTest
{
    public class HomeControllerTests : WebMvcSetup
    {
        [Fact]
        public async Task HomeController_ReturnsViewWithData()
        {
            var controller = new HomeController(null, vehicleService);

            var res = controller.Index();

            var viewResult = Assert.IsType<ViewResult>(res);
            Assert.True(viewResult.ViewName == null || viewResult.ViewName=="Index");
            var model=Assert.IsAssignableFrom<List<VehicleViewModel>>(viewResult.ViewData.Model);
            Assert.Equal(16,model.Count);
        }
    }
}
