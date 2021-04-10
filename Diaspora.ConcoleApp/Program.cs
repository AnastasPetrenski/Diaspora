using Diaspora.Data;
using Diaspora.Models;
using Diaspora.Services;
using Diaspora.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Diaspora.ConcoleApp
{
    public class Program
    {
        private static string Even(int[] numbers)
        {
            string result = string.Empty;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result += i + " ";
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine(Even(numbers));

            var serviceCollection = new ServiceCollection();
            ConfigureCervies(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();

            using var context = serviceProvider.GetService<ApplicationDbContext>();

            //ResetDatabase(context, shouldDropDatabase: false);
            //var players = new List<Player>();
            //Player player = new Player();

            //foreach (var user in context.Users)
            //{
            //    player = context.Players.FirstOrDefault(x => x.AplicationUserId == user.Id);//.GetAwaiter().GetResult();

            //    if (player is null)
            //    {
            //        var addNewPlayer = new Player()
            //        {
            //            AplicationUserId = user.Id,
            //            PlayerName = user.UserName.Substring(0, user.UserName.IndexOf('@')),
            //            Money = 1000,
            //            Experience = 0
            //        };

            //        players.Add(addNewPlayer);
            //    }
            //}

            //context.AddRange(players);
            //context.SaveChanges();

            //if (!context.Plans.Any())
            //{

            //    var plans = new List<Plan>();
            //    var jsonString = File.ReadAllText("plans.json");

            //    var result = JsonConvert.DeserializeObject<Plan[]>(jsonString);

            //    foreach (var plan in result)
            //    {
            //        plans.Add(plan);
            //    }

            //    context.AddRange(plans);
            //    context.SaveChanges();
            //}



            //if (!context.Models.Any())
            //{

            //    var models = new List<Model>();
            //    var jsonString = File.ReadAllText("models.json");

            //    var result = JsonConvert.DeserializeObject<Model[]>(jsonString);

            //    foreach (var model in result)
            //    {
            //        models.Add(model);
            //    }

            //    context.AddRange(models);
            //    context.SaveChanges();
            //}

            //if (!context.PlanModels.Any())
            //{
            //    var planModels = new List<PlanModel>();
            //    var jsonString = File.ReadAllText("PlanModels.json");

            //    var result = JsonConvert.DeserializeObject<PlanModel[]>(jsonString);

            //    foreach (var stats in result)
            //    {
            //        planModels.Add(stats);
            //    }

            //    context.AddRange(planModels);
            //    context.SaveChanges();
            //}

            //if (!context.Ships.Any())
            //{
            //    var planModels = new List<Ship>();
            //    var jsonString = File.ReadAllText("ships.json");

            //    var result = JsonConvert.DeserializeObject<Ship[]>(jsonString);

            //    foreach (var ship in result)
            //    {
            //        planModels.Add(ship);
            //    }

            //    context.AddRange(planModels);
            //    context.SaveChanges();
            //}

            //foreach (var item in context.Players)
            //{
            //    item.PlanPlayers.Add(new PlanPlayer() { PlanId = 1 });
            //}

            //foreach (var item in context.Players)
            //{
            //    item.PlayerShips.Add(new PlayerShip() { ShipId = 1 });
            //}

            //context.SaveChanges();

            //var nodes = new List<Node>();
            //Node node;
            //int x = 0;
            //int y = 10;

            //for (int i = 1001; i < 1016; i++)
            //{

            //    node = new Node()
            //    {
            //        NodeId = i.ToString(),
            //        CoordinatePixels = $"{x+=10}, {y+=10}"
            //    };

            //    nodes.Add(node);

            //    //context.Update(node);

            //    //context.ChangeTracker.TrackGraph(node, e =>
            //    //{
            //    //    e.Entry.State = EntityState.Unchanged;

            //    //    if ((e.Entry.Entity as Player) != null)
            //    //    {
            //    //        if (e.Entry.IsKeySet)
            //    //        {
            //    //            e.Entry.State = EntityState.Modified;
            //    //        }
            //    //        else
            //    //        {
            //    //            e.Entry.State = EntityState.Added;
            //    //        }
            //    //    }
            //    //});
            //    //context.SaveChanges();
            //}

            //context.AddRange(nodes);
            //context.SaveChanges();

            //var mapper = new List<Mapper>()
            //{
            //    new Mapper()
            //    {
                    
            //        FromId = "1001",
            //        ToId = "1002",
            //    },
            //    new Mapper()
            //    {
                    
            //        FromId = "1002",
            //        ToId = "1003",
            //    },
            //    new Mapper()
            //    {
                    
            //        FromId = "1003",
            //        ToId = "1004",
            //    },
            //    new Mapper()
            //    {
                    
            //        FromId = "1004",
            //        ToId = "1005",
            //    },
            //    new Mapper()
            //    {
                    
            //        FromId = "1005",
            //        ToId = "1006",
            //    },
            //    new Mapper()
            //    {
                    
            //        FromId = "1006",
            //        ToId = "1007",
            //    },
            //    new Mapper()
            //    {
                    
            //        FromId = "1007",
            //        ToId = "1008",
            //    },
            //    new Mapper()
            //    {
                    
            //        FromId = "1008",
            //        ToId = "1009",
            //    },
            //    new Mapper()
            //    {
                    
            //        FromId = "1009",
            //        ToId = "1010",
            //    },
            //    new Mapper()
            //    {
                    
            //        FromId = "1010",
            //        ToId = "1011",
            //    },
            //    new Mapper()
            //    {
                    
            //        FromId = "1011",
            //        ToId = "1012",
            //    },
            //    new Mapper()
            //    {
                    
            //        FromId = "1012",
            //        ToId = "1013",
            //    },
            //    new Mapper()
            //    {
                    
            //        FromId = "1013",
            //        ToId = "1001",
            //    },
            //    new Mapper()
            //    {
                    
            //        FromId = "1001",
            //        ToId = "1014",
            //    },
            //    new Mapper()
            //    {
                    
            //        FromId = "1014",
            //        ToId = "1015",
            //    },
            //    new Mapper()
            //    {
                    
            //        FromId = "1015",
            //        ToId = "1008",
            //    },
            //};

            //context.Mappers.AddRange(mapper);
            //context.SaveChanges();

            //Get All user Ids
            var getUserIds = context.Users.Select(x => x.Id).ToList();

            //Get player
            foreach (var userId in getUserIds)
            {
                var current = context
                    .Players
                    .Include(x => x.PlayerShips)
                    .ThenInclude(s => s.Ship)
                    .ThenInclude(t => t.PlanModel)
                    .FirstOrDefault(x => x.AplicationUserId == userId);
                foreach (var item in current.PlayerShips)
                {
                    Console.WriteLine(item.ShipId);
                    Console.WriteLine(item.Ship.PlanModel.Cargo);
                    Console.WriteLine(item.Ship.ImageUrl);
                }

            }

            var allShips = context
                .Ships
                .Include(x => x.PlanModel)
                .ToList();

            foreach (var item in allShips)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine($"Pod solts: {item.PlanModel.PodSlots}");
                Console.WriteLine($"Gun solts: {item.PlanModel.GunSlots}");
                Console.WriteLine(item.ImageUrl);
            }
            

            //TODO: implemente services
            var getServices = serviceProvider.GetService<IDiasporaService>();
            getServices.Add();
        }

        private static void ConfigureCervies(IServiceCollection services)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddDefaultIdentity<ApplicationUser>(options =>
                options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddTransient<IDiasporaService, DiasporaService>();
            services.AddTransient<IPlayerService, PlayerService>();
        }

        private static void ResetDatabase(DbContext context, bool shouldDropDatabase = false)
        {
            if (shouldDropDatabase)
            {
                context.Database.EnsureDeleted();
            }

            if (context.Database.EnsureCreated())
            {
                return;
            }

            //var disableIntegrityChecksQuery = "EXEC sp_MSforeachtable @command1='ALTER TABLE ? NOCHECK CONSTRAINT ALL'";
            //context.Database.ExecuteSqlCommand(disableIntegrityChecksQuery);

            //var deleteRowsQuery = "EXEC sp_MSforeachtable @command1='SET QUOTED_IDENTIFIER ON;DELETE FROM ?'";
            //context.Database.ExecuteSqlCommand(deleteRowsQuery);

            //var enableIntegrityChecksQuery =
            //    "EXEC sp_MSforeachtable @command1='ALTER TABLE ? WITH CHECK CHECK CONSTRAINT ALL'";
            //context.Database.ExecuteSqlCommand(enableIntegrityChecksQuery);

            //var reseedQuery =
            //    "EXEC sp_MSforeachtable @command1='IF OBJECT_ID(''?'') IN (SELECT OBJECT_ID FROM SYS.IDENTITY_COLUMNS) DBCC CHECKIDENT(''?'', RESEED, 0)'";
            //context.Database.ExecuteSqlCommand(reseedQuery);
        }
    }
}
