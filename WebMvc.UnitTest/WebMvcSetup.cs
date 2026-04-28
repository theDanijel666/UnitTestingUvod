using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using WebMvc.Service.Implementation;
using WebMvc.Mapping;
using Microsoft.Extensions.Logging.Abstractions;

namespace WebMvc.UnitTest
{
    public abstract class WebMvcSetup
    {
        private IMapper mapper;
        protected VehicleService vehicleService;

        protected WebMvcSetup()
        {
            var mappingConfig = new MapperConfiguration(mc=>
            {
                mc.AddProfile(new MappingProfile());
            },new NullLoggerFactory());
            mapper = mappingConfig.CreateMapper();
            vehicleService = new VehicleService(mapper);
        }
    }
}
