using AutoMapper;
using Diaspora.Data;
using Diaspora.Models;
using Diaspora.Web.ViewModels.Player;

namespace Diaspora.Web.MappingConfiguration
{
    public class DiasporaProfile : Profile
    {
        private readonly ApplicationDbContext context = new ApplicationDbContext();

        public DiasporaProfile()
        {
            //this.CreateMap<Ship, Player>()
            //    .ForMember(x => x.Id, z => z.MapFrom(s => s.Id));

            //Player
            this.CreateMap<CreatePlayerViewModel, Player>()
                .ForMember(x => x.PlayerName, y => y.MapFrom(s => s.PlayerName));
        }
    }
}
