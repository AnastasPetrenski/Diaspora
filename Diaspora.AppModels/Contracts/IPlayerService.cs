using Diaspora.Models;

namespace Diaspora.Services.Contracts
{
    public interface IPlayerService
    {
        bool CheckNameIsAvailable(string name);

        void Add(Player player);

        Player GetPlayer(string id);
    }
}
