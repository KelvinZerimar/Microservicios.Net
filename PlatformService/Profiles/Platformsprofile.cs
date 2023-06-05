using AutoMapper;
using PlatformService.Dtos;
using PlatformsService.Dtos;
using PlatformsService.Models;

namespace PlatformsService.Profiles
{
    public class PlatformsProfile: Profile
    {
        public PlatformsProfile()
        {
            // Source -> Target
            CreateMap<Platform, PlatformReadDto>();
            CreateMap<PlatformCreateDto, Platform>();
        }
    }
    
}