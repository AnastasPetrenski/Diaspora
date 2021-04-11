using Diaspora.Models;
using System.Collections.Generic;

namespace Diaspora.Services.Contracts
{
    public interface IPlayerService
    {
        bool CheckNameIsAvailable(string name);

        void Add(Player player);

        Player GetPlayer(string userId);

        ICollection<Ship> GetPlayerShips(string userId);

        ICollection<Plan> GetPlayerPlans(string userId);

        ICollection<PlanModel> GetPlansModels(List<int> plansIds);
    }
}
