using Diaspora.Data;
using Diaspora.Models;
using Diaspora.Services.Contracts;
using System.Collections.Generic;
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

        public ICollection<PlanModel> GetPlansModels(List<int> plansIds)
        {
            var models = context.PlanModels.Where(x => plansIds.Contains(x.PlanId)).ToList();

            return models;
        }

        public Player GetPlayer(string userId)
        {
            return context.Players.FirstOrDefault(p => p.AplicationUserId == userId);
        }

        public ICollection<Plan> GetPlayerPlans(string userId)
        {
            var player = this.GetPlayer(userId);

            var plans = context.PlanPlayers.Where(x => x.PlayerId == player.Id).Select(x => x.Plan).ToList();

            return plans;
        }

        public ICollection<Ship> GetPlayerShips(string userId)
        {
            var player = this.GetPlayer(userId);

            var ships = context.PlayerShips.Where(x => x.PlayerId == player.Id).Select(x => x.Ship).ToList();

            return ships;
        }
    }
}
