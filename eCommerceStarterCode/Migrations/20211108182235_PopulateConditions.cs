using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class PopulateConditions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81e34252-c9b1-4164-b184-7ed2fe7e11db");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bba7eb09-959e-4f22-82fe-0126c8dd4134");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d13227c9-2dd3-49f2-8331-9d970b17ff8b", "0eef2092-a33d-4821-9722-6f7325558f39", "User", "USER" },
                    { "b48c30a6-7813-4218-807e-2a2f796da8af", "663f4d95-b586-4797-af54-53f2528860a7", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "Description", "DescriptionExtended", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "A blood level that is below normal in potassium, an important body chemical.", "If you have hypokalemia, that means you have low levels of potassium in your blood. Potassium is a mineral your body needs to work normally. It helps muscles to move, cells to get the nutrients they need, and nerves to send their signals. It’s especially important for cells in your heart. It also helps keep your blood pressure from getting too high.", "https://canadianinsulin.com/wp-content/uploads/2021/05/Hypokalemia-Low-Potassium-Signs-Symptoms-Causes-and-Treatment.png", "Hypokalemia" },
                    { 2, "Occurs when the concentration of sodium (electrolyte) in your blood is abnormally low.", "Hyponatremia occurs when the concentration of sodium in your blood is abnormally low. Sodium is an electrolyte, and it helps regulate the amount of water that's in and around your cells.", "https://sarcoidosisnews.com/wp-content/uploads/2016/10/shutterstock_366005219.jpg", "Hyponatremia" },
                    { 3, "Chronic health condition that affects how your body converts consumables into energy.", "Diabetes is a chronic (long-lasting) health condition that affects how your body turns food into energy. Most of the food you eat is broken down into sugar(also called glucose) and released into your bloodstream.When your blood sugar goes up, it signals your pancreas to release insulin.Insulin acts like a key to let the blood sugar into your body’s cells for use as energy. If you have diabetes, your body either doesn’t make enough insulin or can’t use the insulin it makes as well as it should.When there isn’t enough insulin or cells stop responding to insulin, too much blood sugar stays in your bloodstream.", "https://solutionpharmacy.in/wp-content/uploads/2021/05/Diabetes-mellitus-1024x670.jpg", "Diabetes Mellitus" },
                    { 4, "Glomerulonephritis is a group of diseases that injure the part of the kidney that filters blood (called glomeruli).", "Glomerulonephritis is a group of diseases that injure the part of the kidney that filters blood (called glomeruli). Other terms you may hear used are nephritis and nephrotic syndrome. When the kidney is injured, it cannot get rid of wastes and extra fluid in the body. If the illness continues, the kidneys may stop working completely, resulting in kidney failure.", "https://www.mayoclinic.org/-/media/kcms/gbs/patient-consumer/images/2013/11/15/17/35/ds00280_-ds00360_-ds00503_-ds00682_-ds00856_-ds01047_im00767_r7_kidneysectionthu_2_jpg.jpg", "Glomerulonephritis" },
                    { 5, "Alkalosis occurs when your body has too many bases.", "Alkalosis occurs when your body has too many bases. It can occur due to decreased blood levels of carbon dioxide, which is an acid. It can also occur due to increased blood levels of bicarbonate, which is a base. This condition has a variety of origins such as metabolic and respiratory", "https://pharmacygyan.com/wp-content/uploads/2020/03/20200301_094733.jpg", "Alkalosis" },
                    { 6, "Disease state caused by bacteria-propagated pathogenicity", "Bacteria are living things that have only one cell. Under a microscope, they look like balls, rods, or spirals. They are so small that a line of 1,000 could fit across a pencil eraser. Most types of don't make you sick. Many types are helpful. Some of them help to digest food, destroy disease-causing cells, and give the body needed vitamins. Bacteria are also used in making healthy foods like yogurt and cheese. But infectious bacteria can make you ill.They reproduce quickly in your body.Many give off chemicals called toxins, which can damage tissue and make you sick.Examples of bacteria that cause infections include Streptococcus, Staphylococcus, and E.coli.", "https://img.webmd.com/dtmcms/live/webmd/consumer_assets/site_images/article_thumbnails/video/incremental_bacterial_and_viral_infections_video/650x350_incremental_bacterial_and_viral_infections_video.jpg", "Bacterial Infection" },
                    { 7, "Mononucleosis (mono) is a contagious infection caused by a herpes virus called Epstein-Barr.", "Mononucleosis is an illness that commonly affects teenagers and young adults, but can affect children as well. Viruses, most commonly Epstein-Barr Virus (EBV), and certain infections cause the illness. Mono is sometimes called “the kissing disease” because it spreads easily through bodily fluids like saliva.", "https://www.microscopyu.com/assets/gallery-images/pathology_mononucleosis40x02.jpg", "Mononucleosis" },
                    { 8, "Anemia is a condition in which you lack enough healthy red blood cells to carry adequate oxygen to your body's tissues.", "Anemia is a condition in which you lack enough healthy red blood cells to carry adequate oxygen to your body's tissues. Having anemia, also referred to as low hemoglobin, can make you feel tired and weak. There are many forms of anemia, each with its own cause.Anemia can be temporary or long term and can range from mild to severe.In most cases, anemia has more than one cause.", "https://images.emedicinehealth.com/images/article/main_image/anemia-1.jpg", "Anemia" },
                    { 9, "Immune thrombocytopenia (ITP) is a disorder that can lead to easy or excessive bruising and bleeding.", "Immune thrombocytopenia (ITP) is a disorder that can lead to easy or excessive bruising and bleeding. The bleeding results from unusually low levels of platelets — the cells that help blood clot. Formerly known as idiopathic thrombocytopenic purpura,ITP can cause purple bruises, as well as tiny reddish - purple dots that look like a rash.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT8yaSvH3nV1h9Z7r6ViZrw3RB84iO-t_vCDA&usqp=CAU", "Immune Thrombocytopenia" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b48c30a6-7813-4218-807e-2a2f796da8af");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d13227c9-2dd3-49f2-8331-9d970b17ff8b");

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bba7eb09-959e-4f22-82fe-0126c8dd4134", "67c0e665-f4c2-4c24-8666-29582d1fc4c3", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "81e34252-c9b1-4164-b184-7ed2fe7e11db", "a54e5586-bb2d-40f4-8350-1e1dd18342d9", "Admin", "ADMIN" });
        }
    }
}
