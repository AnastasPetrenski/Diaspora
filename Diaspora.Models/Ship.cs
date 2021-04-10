using System.Collections.Generic;

namespace Diaspora.Models
{
    public class Ship
    {
        public Ship()
        {
            this.Guns = new HashSet<Gun>();
            this.PlayerShips = new HashSet<PlayerShip>();
            this.Equipments = new HashSet<Equipment>();
        }

        public int Id { get; set; }

        public string ImageUrl { get; set; }

        public int? PlanModelId { get; set; }
        public virtual PlanModel PlanModel { get; set; }

        public virtual ICollection<Gun> Guns { get; set; }

        public virtual ICollection<PlayerShip> PlayerShips { get; set; }

        public virtual ICollection<Equipment> Equipments { get; set; }
    }
}
