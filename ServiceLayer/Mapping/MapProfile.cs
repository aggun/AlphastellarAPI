using AutoMapper;
using CoreLayer.DTOs;
using CoreLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
                CreateMap<Boat, BoatDto>().ReverseMap();
                CreateMap<Bus, BusDto>().ReverseMap();
                CreateMap<Car, CarDto>().ReverseMap();
                CreateMap<Car, CarUpdateDto>().ReverseMap();
        }
        }
    }
