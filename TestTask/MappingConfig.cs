using System;
using AutoMapper;
using TestTask.Models;
using TestTask.Models.DTO;

namespace TestTask
{
	public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Device, DeviceDTO>();
            CreateMap<DeviceDTO, Device>();            
        }
    }
}

