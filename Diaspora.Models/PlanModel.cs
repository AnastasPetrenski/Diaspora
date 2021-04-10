using System.Collections.Generic;

namespace Diaspora.Models
{
    public class PlanModel
    {
        public PlanModel()
        {
            this.Ships = new HashSet<Ship>();
        }

        public int Id { get; set; }

        public int PlanId { get; set; }
        public virtual Plan Plan { get; set; }

        public int ModelId { get; set; }
        public virtual Model Model { get; set; }

        //TODO: int or double
        public double Hull { get; set; }

        public int Cargo { get; set; }

        public int GunSlots { get; set; }

        public int Speed { get; set; }

        public int PodSlots { get; set; }

        public int Evasion { get; set; }

        public int Sheald { get; set; }

        public int Range { get; set; }

        public int Price { get; set; }

        public int Damage { get; set; }

        public virtual ICollection<Ship> Ships { get; set; }

    }
}
