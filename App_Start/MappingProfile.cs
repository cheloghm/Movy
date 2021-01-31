using AutoMapper;
using Movy.Dtos;
using Movy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movy.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}