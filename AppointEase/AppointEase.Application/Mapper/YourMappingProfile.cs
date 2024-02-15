﻿using AppointEase.Application.Contracts.Models;
using AppointEase.Application.Contracts.Models.DbModels;
using AppointEase.Application.Contracts.ModelsDto;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AppointEase.Application.Mapper
{
    public class YourMappingProfile : Profile
    {
        public YourMappingProfile()
        {
            CreateMap<Person, PersonDto>().ReverseMap();
            CreateMap<TblPacient, PatientRequest>().ReverseMap();
            CreateMap<TblAdmin, AdminRequest>().ReverseMap();
            CreateMap<TblClinic, ClinicRequest>().ReverseMap();
            CreateMap<TblDoctor, DoctorRequest>().ReverseMap();

        }
    }
}