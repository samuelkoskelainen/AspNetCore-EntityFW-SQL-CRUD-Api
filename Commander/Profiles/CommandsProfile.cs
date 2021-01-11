using AutoMapper;
using Commander.Dtos;
using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            // Get
            // Source - Target
            CreateMap<Command, CommandReadDto>();

            // Post
            // Target - Source
            CreateMap<CommandCreateDto, Command>();

            // Put
            // Target - Source
            CreateMap<CommandUpdateDto, Command>();

            // Patch
            // Source - Target
            CreateMap<Command, CommandUpdateDto>();
        }
    }
}
