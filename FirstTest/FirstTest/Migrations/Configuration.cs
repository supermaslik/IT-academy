namespace FirstTest.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<FirstTest.Controllers.ImageDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(FirstTest.Controllers.ImageDB context)
        {
            List<Models.ImageLinkInfo> ListOfModels = new List<Models.ImageLinkInfo>() {
            new Models.ImageLinkInfo()
            {
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ImageUrl = "https://www.smashingmagazine.com/wp-content/uploads/2015/06/10-dithering-opt.jpg",
                SiteUrl = "https://www.google.by/search?q=image&source=lnms&tbm=isch&sa=X&ved=0ahUKEwjk77qa483XAhUnCZoKHeDHByQQ_AUICigB&biw=1920&bih=974#imgrc=OWH8_JM7S2IcxM:",
                Title = "Here we are"
            },
             new Models.ImageLinkInfo()
            {
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ImageUrl = "https://cdn.pixabay.com/photo/2016/06/18/17/42/image-1465348_960_720.jpg",
                SiteUrl = "https://pixabay.com/ru/%D0%B8%D0%B7%D0%BE%D0%B1%D1%80%D0%B0%D0%B6%D0%B5%D0%BD%D0%B8%D0%B5-%D1%81%D1%82%D0%B0%D1%82%D1%83%D1%8F-%D0%BB%D0%B0%D1%82%D1%83%D0%BD%D1%8C-%D1%80%D0%B5%D0%B1%D0%B5%D0%BD%D0%BE%D0%BA-1465348/",
                Title = "Here we are"
            },
              new Models.ImageLinkInfo()
            {
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ImageUrl = "https://www.imagejournal.org/wp-content/uploads/bb-plugin/cache/Ivory-billed_Woodpecker_by_Jerry_A._Payne-panorama.jpg",
                SiteUrl = "https://www.google.by/search?q=image&source=lnms&tbm=isch&sa=X&ved=0ahUKEwjgkbCxyYbYAhVMJ1AKHcpgA0MQ_AUICigB&biw=1920&bih=974#imgrc=RLHXpAfV70Z6hM:",
                Title = "Here we are"
            }
            };

            ListOfModels.ForEach(x => context.ImageLinksInfo.AddOrUpdate(x));
            context.SaveChanges();
        }
    }
}
