using System.Collections.Generic;

namespace Diaspora.Models
{
    public class Model
    {
        public Model()
        {
            this.PlanModels = new HashSet<PlanModel>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        //public int ShipId { get; set; }
        //public Ship Ship { get; set; }

        public virtual ICollection<PlanModel> PlanModels { get; set; }
    }
}
