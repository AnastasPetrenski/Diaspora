using AutoMapper;
using Diaspora.Models;
using Diaspora.Services.Contracts;
using Diaspora.Web.ViewModels.Player;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Diaspora.Web.Controllers
{
    [Authorize]
    public class PlayerController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper mapper;
        private readonly ILogger<Player> _logger;
        private readonly IPlayerService _playerServices;

        public PlayerController(IMapper mapper,
            ILogger<Player> logger,
            UserManager<ApplicationUser> userManager,
            IPlayerService playerService)
        {
            this.mapper = mapper;
            this._logger = logger;
            this._userManager = userManager;
            this._playerServices = playerService;
        }

        public IActionResult Create()
        {
            var userid = this._userManager.GetUserId(this.User);

            var player = _playerServices.GetPlayer(userid);

            if (player != null)
            {
                return this.View("Index", player);
            }

            return View();
        }

        [HttpPost]
        public IActionResult Create(CreatePlayerViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Error", "Home");
            }

            if (!_playerServices.CheckNameIsAvailable(model.PlayerName))
            {
                return this.View();
            }
           
            var userid = this._userManager.GetUserId(this.User);

            var player = this.mapper.Map<Player>(model);
            player.AplicationUserId = userid;

            _playerServices.Add(player);

            return this.View("Index", player);
        }

       
    }
}
