using Diaspora.Data;

namespace Diaspora.Services.Contracts
{
    public class DiasporaService : IDiasporaService
    {
        private readonly ApplicationDbContext context;

        public DiasporaService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Add()
        {
            throw new System.NotImplementedException();
        }

        public void SelectShip()
        {
            throw new System.NotImplementedException();
        }
    }
}
