using System.Collections.Generic;

namespace Diaspora.Models
{
    public class Plan
    {
        public Plan()
        {
            this.PlanModels = new HashSet<PlanModel>();
            this.PlanPlayers = new HashSet<PlanPlayer>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<PlanModel> PlanModels { get; set; }

        public virtual ICollection<PlanPlayer> PlanPlayers { get; set; }
    }
}
