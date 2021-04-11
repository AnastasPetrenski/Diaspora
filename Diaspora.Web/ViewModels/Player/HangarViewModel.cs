using Diaspora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diaspora.Web.ViewModels.Player
{
    public class HangarViewModel
    {
        public ICollection<Ship> Ships { get; set; }

        public ICollection<Plan> Plans { get; set; }

        public ICollection<PlanModel> PlanModels { get; set; }

    }
}
