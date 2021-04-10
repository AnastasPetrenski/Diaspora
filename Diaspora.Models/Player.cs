using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diaspora.Models
{
    public class Player
    {
        public Player()
        {
            this.PlayerShips = new HashSet<PlayerShip>();
            this.PlanPlayers = new HashSet<PlanPlayer>();
        }

        public int Id { get; set; }

        public string AplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public string PlayerName { get; set; }

        public int Money { get; set; }

        public int Experience { get; set; }

        [ForeignKey("NodeId")]
        public string NodeId { get; set; }
        public virtual Node Node { get; set; }

        public virtual ICollection<PlayerShip> PlayerShips { get; set; }

        public virtual ICollection<PlanPlayer> PlanPlayers { get; set; }
    }
}
