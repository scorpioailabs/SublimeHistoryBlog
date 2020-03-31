using AutoMapper;
using HardcoreHistory.Blazor.Client.ViewModels;
using HardcoreHistory.Client.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HardcoreHistory.Blazor.Client
{
    public class MapperConfiguration : Profile
    {
        public MapperConfiguration()
        {
        }

        public MapperConfiguration(string profileName) : base(profileName)
        {
            CreateMap<UsersViewModel, ApplicationUser>();
        }
    }
}
