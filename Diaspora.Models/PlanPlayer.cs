namespace Diaspora.Models
{
    public class PlanPlayer
    {
        public int PlayerId { get; set; }
        public virtual Player Player { get; set; }

        public int PlanId { get; set; }
        public virtual Plan Plan { get; set; }
    }
}
