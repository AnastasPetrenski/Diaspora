using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diaspora.Models
{
    public class Mapper
    {
        public Mapper()
        {
            this.EdgeId = Guid.NewGuid().ToString();
        }

        //Set Key with Fluent API
        public string EdgeId { get; set; }
        
        public string FromId{ get; set; }
        public virtual Node NodeFrom { get; set; }

        public string ToId { get; set; }
        public virtual Node NodeTo { get; set; }
    }
}
