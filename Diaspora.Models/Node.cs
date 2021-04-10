using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Diaspora.Models
{
    public class Node
    {
        public Node()
        {
            //this.NodeId = Guid.NewGuid().ToString();
            this.Players = new HashSet<Player>();
            this.MapsFrom = new HashSet<Mapper>();
            this.MapsTo = new HashSet<Mapper>();
        }

        public string NodeId { get; set; }

        public string Type { get; set; }

        public string Pick { get; set; }

        public string CoordinatePixels { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public virtual ICollection<Mapper> MapsFrom { get; set; }

        public virtual ICollection<Mapper> MapsTo { get; set; }
    }
}
