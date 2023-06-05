using System.Threading.Tasks;
using PlatformService.Dtos;
using PlatformsService.Dtos;

namespace PlatformService.SyncDataServices.Http
{
    public interface ICommandDataClient
    {
        Task SendPlatformToCommand(PlatformReadDto plat); 
    }
}