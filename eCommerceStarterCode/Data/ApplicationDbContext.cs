using eCommerceStarterCode.Configuration;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eCommerceStarterCode.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<BMP> BMPs { get; set; }
        public DbSet<BMPList> BMPLists { get; set; }
        public DbSet<CBC> CBCs { get; set; }
        public DbSet<CBCList> CBCLists { get; set; }
        public DbSet<Condition> Conditions { get; set; }
        public DbSet<ConditionList> ConditionLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Condition>()
                .HasData(
                    new Condition { Id = 1, Name = "Hypokalemia", Description = "A blood level that is below normal in potassium, an important body chemical.", Image = "https://canadianinsulin.com/wp-content/uploads/2021/05/Hypokalemia-Low-Potassium-Signs-Symptoms-Causes-and-Treatment.png", DescriptionExtended = "If you have hypokalemia, that means you have low levels of potassium in your blood. Potassium is a mineral your body needs to work normally. It helps muscles to move, cells to get the nutrients they need, and nerves to send their signals. It’s especially important for cells in your heart. It also helps keep your blood pressure from getting too high." },
                    new Condition { Id = 2, Name = "Hyponatremia", Description = "Occurs when the concentration of sodium (electrolyte) in your blood is abnormally low.", Image = "https://sarcoidosisnews.com/wp-content/uploads/2016/10/shutterstock_366005219.jpg", DescriptionExtended = "Hyponatremia occurs when the concentration of sodium in your blood is abnormally low. Sodium is an electrolyte, and it helps regulate the amount of water that's in and around your cells." },
                    new Condition { Id = 3, Name = "Diabetes Mellitus", Description = "Chronic health condition that affects how your body converts consumables into energy.", Image = "https://solutionpharmacy.in/wp-content/uploads/2021/05/Diabetes-mellitus-1024x670.jpg", DescriptionExtended = "Diabetes is a chronic (long-lasting) health condition that affects how your body turns food into energy. Most of the food you eat is broken down into sugar(also called glucose) and released into your bloodstream.When your blood sugar goes up, it signals your pancreas to release insulin.Insulin acts like a key to let the blood sugar into your body’s cells for use as energy. If you have diabetes, your body either doesn’t make enough insulin or can’t use the insulin it makes as well as it should.When there isn’t enough insulin or cells stop responding to insulin, too much blood sugar stays in your bloodstream." },
                    new Condition { Id = 4, Name = "Glomerulonephritis", Description = "Glomerulonephritis is a group of diseases that injure the part of the kidney that filters blood (called glomeruli).", Image = "https://www.mayoclinic.org/-/media/kcms/gbs/patient-consumer/images/2013/11/15/17/35/ds00280_-ds00360_-ds00503_-ds00682_-ds00856_-ds01047_im00767_r7_kidneysectionthu_2_jpg.jpg", DescriptionExtended = "Glomerulonephritis is a group of diseases that injure the part of the kidney that filters blood (called glomeruli). Other terms you may hear used are nephritis and nephrotic syndrome. When the kidney is injured, it cannot get rid of wastes and extra fluid in the body. If the illness continues, the kidneys may stop working completely, resulting in kidney failure." },
                    new Condition { Id = 5, Name = "Alkalosis", Description = "Alkalosis occurs when your body has too many bases.", Image = "https://pharmacygyan.com/wp-content/uploads/2020/03/20200301_094733.jpg", DescriptionExtended = "Alkalosis occurs when your body has too many bases. It can occur due to decreased blood levels of carbon dioxide, which is an acid. It can also occur due to increased blood levels of bicarbonate, which is a base. This condition has a variety of origins such as metabolic and respiratory" },
                    new Condition { Id = 6, Name = "Bacterial Infection", Description = "Disease state caused by bacteria-propagated pathogenicity", Image = "https://img.webmd.com/dtmcms/live/webmd/consumer_assets/site_images/article_thumbnails/video/incremental_bacterial_and_viral_infections_video/650x350_incremental_bacterial_and_viral_infections_video.jpg", DescriptionExtended = "Bacteria are living things that have only one cell. Under a microscope, they look like balls, rods, or spirals. They are so small that a line of 1,000 could fit across a pencil eraser. Most types of don't make you sick. Many types are helpful. Some of them help to digest food, destroy disease-causing cells, and give the body needed vitamins. Bacteria are also used in making healthy foods like yogurt and cheese. But infectious bacteria can make you ill.They reproduce quickly in your body.Many give off chemicals called toxins, which can damage tissue and make you sick.Examples of bacteria that cause infections include Streptococcus, Staphylococcus, and E.coli." },
                    new Condition { Id = 7, Name = "Mononucleosis", Description = "Mononucleosis (mono) is a contagious infection caused by a herpes virus called Epstein-Barr.", Image = "https://www.microscopyu.com/assets/gallery-images/pathology_mononucleosis40x02.jpg", DescriptionExtended = "Mononucleosis is an illness that commonly affects teenagers and young adults, but can affect children as well. Viruses, most commonly Epstein-Barr Virus (EBV), and certain infections cause the illness. Mono is sometimes called “the kissing disease” because it spreads easily through bodily fluids like saliva." },
                    new Condition { Id = 8, Name = "Anemia", Description = "Anemia is a condition in which you lack enough healthy red blood cells to carry adequate oxygen to your body's tissues.", Image = "https://images.emedicinehealth.com/images/article/main_image/anemia-1.jpg", DescriptionExtended = "Anemia is a condition in which you lack enough healthy red blood cells to carry adequate oxygen to your body's tissues. Having anemia, also referred to as low hemoglobin, can make you feel tired and weak. There are many forms of anemia, each with its own cause.Anemia can be temporary or long term and can range from mild to severe.In most cases, anemia has more than one cause." },
                    new Condition { Id = 9, Name = "Immune Thrombocytopenia", Description = "Immune thrombocytopenia (ITP) is a disorder that can lead to easy or excessive bruising and bleeding.", Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT8yaSvH3nV1h9Z7r6ViZrw3RB84iO-t_vCDA&usqp=CAU", DescriptionExtended = "Immune thrombocytopenia (ITP) is a disorder that can lead to easy or excessive bruising and bleeding. The bleeding results from unusually low levels of platelets — the cells that help blood clot. Formerly known as idiopathic thrombocytopenic purpura,ITP can cause purple bruises, as well as tiny reddish - purple dots that look like a rash." }
                );

            modelBuilder.Entity<BMPList>()
                .HasKey(c => new { c.UserId, c.BMPId });
            modelBuilder.Entity<CBCList>()
                .HasKey(c => new { c.UserId, c.CBCId });
            modelBuilder.Entity<ConditionList>()
               .HasKey(c => new { c.UserId, c.ConditionId });

            modelBuilder.ApplyConfiguration(new RolesConfiguration());
        }

    }
}
