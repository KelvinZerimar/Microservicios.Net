namespace PlatformsService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app){
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {   
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }
        private static void SeedData(AppDbContext context)
        {
            if(!context.Platforms.Any()){
                Console.WriteLine("--> Seeding Data");

                context.Platforms.AddRange(
                    new Models.Platform(){ name = "Do Net", Publisher="Microsoft", Cost="Free "},
                    new Models.Platform(){ name = "SQL Server Express", Publisher="Microsoft", Cost="Free "},
                    new Models.Platform(){ name = "Kubernetes", Publisher="Cloud Native Computing Foundation", Cost="Free "}
                );

                context.SaveChanges();
            }else{
                Console.WriteLine("--> We already have data");
            }
        }
    }

    
}