using System.Collections.Generic;

namespace Diaspora.Models
{
    public class Pod
    {
        public Pod()
        {
            this.Equipments = new HashSet<Equipment>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Value { get; set; }

        public virtual ICollection<Equipment> Equipments { get; set; }
    }
}
