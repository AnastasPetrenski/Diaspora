namespace Diaspora.Models
{
    public class Equipment
    {
        public int ShipId { get; set; }
        public virtual Ship Ship { get; set; }

        public int PodId { get; set; }
        public virtual Pod Pod { get; set; }
    }
}
