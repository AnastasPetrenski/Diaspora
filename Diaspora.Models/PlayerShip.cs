namespace Diaspora.Models
{
    public class PlayerShip
    {
        public int PlayerId { get; set; }
        public virtual Player Player { get; set; }

        public int ShipId { get; set; }
        public virtual Ship Ship { get; set; }

        //TODO: Add properties
    }
}
