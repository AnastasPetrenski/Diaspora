using Diaspora.Data;
using Diaspora.Models;
using Diaspora.Services.Contracts;
using System.Linq;

namespace Diaspora.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly ApplicationDbContext context;

        public PlayerService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Add(Models.Player player)
        {
            context.Players.Add(player);
            context.SaveChanges();
        }

        public bool CheckNameIsAvailable(string name)
        {
            var player = context.Players.FirstOrDefault(p => p.PlayerName == name);

            if (player is null)
            {
                return true;
            }

            return false;
        }

        public Player GetPlayer(string id)
        {
            return context.Players.FirstOrDefault(p => p.AplicationUserId == id);
        }
    }
}
