﻿using AutoMapper;
using back.DTOs;
using back.Entities;
using back.Entities.User;

namespace back.Mappings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, UserDto>();
            CreateMap<UserRequestDTO, AppUser>();
            CreateMap<UserProfile, ProfileDto>(); 
            CreateMap<ProfileRequestDTO, UserProfile>();
        }
    }
}
