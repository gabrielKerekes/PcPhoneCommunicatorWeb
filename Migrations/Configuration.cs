namespace PcPhoneCommunicatorWeb.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using PcPhoneCommunicatorWeb.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<PcPhoneCommunicatorWeb.Models.PcPhoneCommunicatorWebContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PcPhoneCommunicatorWeb.Models.PcPhoneCommunicatorWebContext context)
        {
            context.Users.AddOrUpdate(u => u.Username,
                new User { Username = "nestel", Password = "gbld33", GcmId = "11" },
                new User { Username = "what", Password = "gbld33", GcmId = "11" },
                new User { Username = "the", Password = "gbld33", GcmId = "11" },
                new User { Username = "fuck", Password = "gbld33", GcmId = "11" });
        }
    }
}
