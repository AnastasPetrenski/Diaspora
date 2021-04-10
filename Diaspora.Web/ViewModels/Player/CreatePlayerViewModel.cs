using Diaspora.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Diaspora.Web.ViewModels.Player
{
    public class CreatePlayerViewModel
    {
        [Required]
        [RegularExpression(@"[A-Za-z]{4,}")]
        //[Remote("IsAlreadySigned", "Register", HttpMethod = "POST", ErrorMessage = "EmailId already exists in database.")]
        public string PlayerName { get; set; }
    }
}
