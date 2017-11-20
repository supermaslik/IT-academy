namespace FirstTest.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FirstTest.Controllers.ImageDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FirstTest.Controllers.ImageDB context)
        {
            var NewModel = new Models.ImageLinkInfo()
            {
                Description = "Some random description",
                ImageUrl = "https://www.smashingmagazine.com/wp-content/uploads/2015/06/10-dithering-opt.jpg",
                SiteUrl = "https://www.google.by/search?q=image&source=lnms&tbm=isch&sa=X&ved=0ahUKEwjk77qa483XAhUnCZoKHeDHByQQ_AUICigB&biw=1920&bih=974#imgrc=OWH8_JM7S2IcxM:",
                Title = "Here we are"
            };

            context.ImageLinksInfo.Add(NewModel);
        }
    }
}
