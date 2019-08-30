using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MarketStore.Models;




namespace MarketStore.Models
{

    public class StoreData : DropCreateDatabaseIfModelChanges<MarketStoreEntities>
    {

        protected override void Seed(MarketStoreEntities context)

        {



            GetProducts().ForEach(p => context.Products.Add(p));
            GetSuppliers().ForEach(q => context.Suppliers.Add(q));
            GetCategories().ForEach(n => context.Categories.Add(n));


        }


        

        // I will create now a list of categories and fill it up with categories for this online market store

        public static List<Category> GetCategories()


        {

            //Here is the list of all different product categories for the online supermarket MarketStore

            var categories = new List<Category>

            {
                

                new Category {CategoryId = 1, CategoryName = "Fresh Food"},

                new Category {CategoryId = 2, CategoryName = "Frozen Food" },

                new Category {CategoryId = 3,  CategoryName = "Bakery"},

                new Category {CategoryId = 4,  CategoryName = "Drinks"},

                new Category {CategoryId = 5, CategoryName = "Baby"},

                new Category {CategoryId = 6, CategoryName = "Health & Beauty"},

                new Category {CategoryId = 7, CategoryName = "Household"},

                new Category {CategoryId = 8, CategoryName = "Pets"},

                new Category {CategoryId = 9, CategoryName = "Home Ent"},

                new Category {CategoryId = 10, CategoryName = "Other"},


            };




            //Now i will return the method result as I have filled up the category list with all data

                        return categories;

        }



        //Here is the list of thirty (30) suppliers of products found in the online supermarket MarketStore product
                        
        public static List<Supplier> GetSuppliers()

        {


            var suppliers = new List<Supplier>

            {

                new Supplier{SupplierId = 1, SupplierName = "Glanbia Consumer Foods Ireland"},

                new Supplier{SupplierId = 2 ,SupplierName = "Alpro Products UK"},

                new Supplier{SupplierId = 3, SupplierName = "Koko Dairy Free" },

                new Supplier{SupplierId = 4 , SupplierName = "Kerrygold"},

                new Supplier{SupplierId = 5, SupplierName = "JDS Foods Ltd"},

                new Supplier{SupplierId = 6, SupplierName = "Ornua Co-operative Ltd" },

                new Supplier{SupplierId = 7, SupplierName = "Unilever Ireland Ltd"},

                new Supplier{SupplierId = 8 ,SupplierName = "Procter & Gamble"},

                new Supplier{SupplierId = 9, SupplierName = "Brennans"},

                new Supplier{SupplierId = 10 , SupplierName = "Irwin's Bakery"},

                new Supplier{SupplierId = 11, SupplierName = "Kerry Group"},

                new Supplier{SupplierId = 12, SupplierName = "Lyon's Tea"},

                new Supplier{SupplierId = 13 ,SupplierName = "Barry's Tea"},

                new Supplier{SupplierId = 14, SupplierName = "Jacobs Douwe Egberts"},

                new Supplier{SupplierId = 15, SupplierName = "Donegal Creameries"},

                new Supplier{SupplierId = 16, SupplierName = "Flahavan's"},

                new Supplier{SupplierId = 17, SupplierName = "Tayto"},
                
                new Supplier{SupplierId = 18, SupplierName = "Keoghs Farm"},

                new Supplier{SupplierId = 19 ,SupplierName = "Artizan Food Co."},

                new Supplier{SupplierId = 20, SupplierName = "Irish Dog Food Ltd"},

                new Supplier{SupplierId = 21, SupplierName = "Colgate-Palmolive"},

                new Supplier{SupplierId = 22, SupplierName = "Beirdsdorf UK Ltd"},

                new Supplier{SupplierId = 23, SupplierName = "Reckitt Benckiser"},

                new Supplier{SupplierId = 24, SupplierName = "Johnsson & Johnsson Ltd"},

                new Supplier{SupplierId = 25, SupplierName = "Nutricia Ltd"},

                new Supplier{SupplierId = 26, SupplierName = "Mars Ireland"},

                new Supplier{SupplierId = 27, SupplierName = "Irish Yeast Company"},

                new Supplier{SupplierId = 28, SupplierName = "Guinness and Co."},

                new Supplier{SupplierId = 29, SupplierName = "Heineken Ireland Ltd"},


                new Supplier{SupplierId = 30, SupplierName = "Tesco supplier"},



            };


                 return suppliers;

        }


        

        //Now I will fill up the database list with products for all categories by inserting product details into them

        public static List<Product> GetProducts()

        {


            var products = new List<Product>{ 



     // Fresh Food Products - Category 1
            

                    new Product {

                             ProductName = "Tesco 6 Free Range Eggs pack",
                             CategoryId = 1,
                             Category= "Fresh Food",

                             Price = 1.59M,

                             SupplierId = 30,
                             Supplier = "Tesco supplier",
                             ProductDescr = "Freshly laid eggs by hens with freedom to roam outdoors during the day from the Tesco product family",
                             ProductPic ="/Content/Images/EggsFreeRange6pack.jpg"

                                },

                    new Product {
                             ProductName = "Tesco 12 Free Range Eggs pack",
                             CategoryId = 1,
                             Category = "Fresh Food",

                             Price = 3.19M,

                             SupplierId = 30,
                             Supplier = "Tesco supplier",
                             ProductDescr = "Freshly laid by hens with freedom to roam outdoors during the day from the Tesco product family",
                             ProductPic ="/Content/Images/EggsFreeRange12pack.jpg"

                             },



                    new Product {

                          ProductName = "Tesco Organic Eggs pack",
                          CategoryId = 1,
                          Category = "Fresh Food",

                          Price = 4.80M,

                          SupplierId = 30,
                          Supplier = "Tesco supplier",
                          ProductDescr = "Fresh Organic Eggs from the Tesco product family",
                          ProductPic = "/Content/Images/EggsOrganicFreeRange6pack.jpg"

                            },


                    new Product{

                            ProductName = "Tesco Omega-3 eggs 6pack",
                            CategoryId = 1,
                            Category= "Fresh Food",

                            Price = 4.20M,

                            SupplierId = 30,
                            Supplier = "Tesco supplier",
                            ProductDescr = "Omega-3 farm eggs from the Tesco product family",
                            ProductPic = "/Content/Images/Omega3Eggs.jpg"

                            },

                   new Product {

                          ProductName = "Tesco Medium eggs 18pack",
                          CategoryId = 1,
                          Category = "Fresh Food",

                          Price = 2.85M,

                          SupplierId = 30,
                          Supplier = "Tesco supplier",
                          ProductDescr = "18 medium size Irish eggs from the Tesco product family",
                          ProductPic = "/Content/Images/EggsMedium18pack.jpg"

                            },


                   new Product{

                            ProductName = "Tesco Fresh Whole Milk 2lt",
                            CategoryId = 1,
                            Category = "Fresh Food",

                            Price = 1.49M,

                            SupplierId = 30,
                            Supplier = "Tesco supplier",

                            ProductDescr = "Pasteurised and Homogenised Fresh Milk 2ltr from the Tesco family product",
                            ProductPic = "/Content/Images/TescoFreshWholeMilk2lt.jpg"

                            },

                   new Product{

                            ProductName = "Tesco Full Fat Milk 3lt",
                            CategoryId = 1,
                            Category = "Fresh Food",

                            Price = 2.00M,

                            SupplierId = 30,
                            Supplier = "Tesco supplier",
                            ProductDescr = "Pasteurised and Homogenised Fresh Milk 3ltr from the Tesco product family",
                            ProductPic = "/Content/Images/TescoFullFatMilk3lt.jpg"

                             },

                     new Product{

                            ProductName = "Tesco Low Fat Milk 2lt",
                            CategoryId = 1,
                            Category = "Fresh Food",

                            Price = 1.49M,

                            SupplierId = 30,
                            Supplier = "Tesco supplier",
                            ProductDescr = "Pasteurised and Homogenised Skimmed Milk 2ltr manufactured by Tesco",
                            ProductPic = "/Content/Images/TescoLowFatMilk2lt.jpg"

                               },


                     new Product{

                            ProductName = "Tesco Low Fat Milk 3lt",
                            CategoryId = 1,
                            Category = "Fresh Food",

                            Price = 2.00M,

                            SupplierId = 30,
                            Supplier = "Tesco supplier",
                            ProductDescr = "Pasteurised and Homogenised Skimmed Milk 3ltr from the Tesco product family",
                            ProductPic = "/Content/Images/TescoLowFatMilk3lt.jpg"

                            },



                       new Product {

                            ProductName = "Avonmore Milk 2ltr",
                            CategoryId = 1,
                            Category = "Fresh Food",

                            Price = 1.89M,

                            SupplierId = 1,
                            Supplier = "Glanbia Consumer Foods Ireland",
                            ProductDescr = "Pasteurised and Homogenized Milk. At Avonmore, we take great pride in the fact that " +
                                        "no one does more to bring you the finest quality, freshest milk every time. Little wonder"+
                                        "then, that Avonmore is Ireland's favourite milk." +
                                        "3.5% fat" +
                                        "Farm fresh guarantee - peak fresh" +
                                        "The National Dairy Council - Farmed in the Republic of Ireland",
                           ProductPic = "/Content/Images/AvonmoreMilk2l.jpg"


                                },


                       new Product {

                            ProductName = "Avonmore Milk 2.75ltr",
                            CategoryId = 1,
                            Category = "Fresh Food",

                            Price = 2.49M,

                            SupplierId = 1,
                            Supplier = "Glanbia Consumer Foods Ireland",
                            ProductDescr = "Pasteurised and Homogenized Milk. At Avonmore, we take great pride in the fact that " +
                                        "no one does more to bring you the finest quality, freshest milk every time. Little wonder"+
                                        "then, that Avonmore is Ireland's favourite milk." +
                                        "3.5% fat" +
                                        "Farm fresh guarantee - peak fresh" +
                                        "The National Dairy Council - Farmed in the Republic of Ireland",
                           ProductPic = "/Content/Images/AvonmoreFreshMilk2.75l.jpg"


                                },

                       new Product {

                            ProductName = "Avonmore Super Milk 1.75ltr",
                            CategoryId = 1,
                            Category = "Fresh Food",

                            Price = 1.99M,

                            SupplierId = 1,
                            Supplier = "Glanbia Consumer Foods Ireland",
                            ProductDescr = "Pasteurised and Homogenized Milk. At Avonmore, we take great pride in the fact that " +
                                        "no one does more to bring you the finest quality, freshest milk every time. Little wonder"+
                                        "then, that Avonmore is Ireland's favourite milk." +
                                        "3.5% fat" +
                                        "Farm fresh guarantee - peak fresh" +
                                        "The National Dairy Council - Farmed in the Republic of Ireland",
                           ProductPic = "/Content/Images/AvonmoreWholeSuperMilk1.75l.jpg"

                                    },



                       new Product{

                            ProductName = "Avonmore Vanilla Milk 500ml",
                            CategoryId = 1,
                            Category = "Fresh Food",

                            Price = 2.20M,

                            SupplierId = 1,
                            Supplier = "Glanbia Consumer Foods Ireland",
                            ProductDescr = "Pasteurised, Homogenised, Fortified, 1% Low Fat Vanilla Flavoured Milk Drink with sweetener"+
                                        "Enjoy as part of a varied and balanced diet and healthy lifestyle"+
                                        "27g Protein: " +
                                        "We've added extra quality protein to give you 27g protein per 500ml serving" +
                                        "Protein contributes to the growth and maintenance of muscle mass"+
                                        "Whey & Casein"+
                                        "The additional protein in Avonmore Protein milk comes from high quality whey and"+
                                        "casein in the proportions naturally found in milk"+
                                        "1% Fat"+
                                        "Avonmore Protein Milk is great tasting and low in fat with only 5g of fat per serving"+
                                        "Try one of our other 500ml flavours for on the go protein"+
                                        "27g protein"+
                                        "1 % fat"+
                                        "Flavoured milk with extra protein"+
                                        "Contains naturally occurring sugars",

                           ProductPic = "/Content/Images/AvonmoreVanillaMilk.jpg"

                                },




                      new Product{

                            ProductName = "Avonmore Protein Milk 500ml",
                            CategoryId = 1,
                            Category = "Fresh Food",

                            Price = 2.45M,

                            SupplierId = 1,
                            Supplier = "Glanbia Consumer Foods Ireland",
                            ProductDescr = "Pasteurised and Homogenized Milk.  Little wonder then, that Avonmore is Ireland's favourite milk" +
                                        "3.5 % fat Farm fresh guarantee - peak fresh" +
                                        "The National Dairy Council - Farmed in the Republic of Ireland",

                            ProductPic = "/Content/Images/AvonmoreProteinMilk500.jpg"

                          },


                    new Product{

                            ProductName = "Avonmore Protein Milk 1lt",
                            CategoryId = 1,
                            Category = "Fresh Food",

                            Price = 2.45M,

                            SupplierId = 1,
                            Supplier = "Glanbia Consumer Foods Ireland",
                            ProductDescr =

                                    "Pasteurised and Homogenized Milk.  Little wonder then, that Avonmore is Ireland's favourite milk" +
                                    "3.5 % fat Farm fresh guarantee - peak fresh" +
                                    "The National Dairy Council - Farmed in the Republic of Ireland",

                            ProductPic = "/Content/Images/AvonmoreProteinMilk1l.jpg"

                          },



                    new Product {

                            ProductName = "Avonmore Low Fat Super Milk ",
                            CategoryId = 1,
                            Category = "Fresh Food",

                            Price = 1.23M,

                            SupplierId = 1,
                            Supplier = "Glanbia Consumer Foods Ireland",

                            ProductDescr = "Super Milk is fortified with nutrients for which the Irish population has inadequate"+
                                        "intakes. Super milk is fortified with vitamins B, D, E, folic acid and calcium, it is a great choice for all the family",
                            ProductPic = "/Content/Images/AvonmoreLowFatSuperMilk.jpg"

                        },



                    new Product {

                            ProductName = "Avonmore Lactose Free Milk",
                            CategoryId = 1,
                            Category = "Fresh Food",

                            Price = 1.23M,

                            SupplierId = 1,
                            Supplier = "Glanbia Consumer Foods Ireland",

                            ProductDescr = "Pasteurised, Homogenised, Fortified, Lactose Free Low Fat Milk Drink"+
                                        "Enjoy each 200ml glass of Lactose Free milk daily as part of a varied and balanced diet and healthy lifestyle"+

                                        "What is lactose intolerance?"+
                                        "Lactose is the natural sugar found in milk and milk products. If you suffer from lactose intolerance you lack the natural enzyme"+
                                        "lactase', and so cannot digest lactose"+
                                        "This can result in symptoms such as cramps and bloating after consuming milk products"+
                                        "With Avonmore Lactose Free milk you can enjoy the delicious taste and nutritional goodness of fresh milk, without the lactose"+

                                        "Calcium is necessary for normal bones and teeth, Protein contributes to muscle growth and maintenance"+
                                        "Vitamin D helps to absorb calcium, Vitamin B2 contributes to the maintenance of normal skin"+
                                        "Vitamin B12 contributes to healthy blood and maintains a healthy blood and maintains a healthy nervous system"+

                                        "With Avonmore Lactose Free milk you get real dairy goodness without the lactos"+
                                        "At Avonmore we believe everyone should be able to enjoy the delicious taste of fresh milk, even if you are lactose intolerant"+

                                        "1.5 % fat"+
                                        "High in calcium and protein"+
                                        "Ireland's favourite milk"+
                                        "It's milk, only without the lactose!"+
                                        "The National Dairy Council -farmed in the Republic of Ireland"+
                                        "Lactose free, High in calcium High in protein",

                         ProductPic = "/Content/Images/AvonmoreLactoseFreeMilk.jpg"

                        },



                    new Product{

                        ProductName = "Avonmore Cooking Cream 250MI",
                        CategoryId = 1,
                        Category = "Frozen Food",

                        Price = 2.45M,

                        SupplierId = 1,
                        Supplier = "Glanbia Consumer Foods Ireland",

                        ProductDescr = "Pasteurised 18% Fat Cooking Cream"+
                                    "50%* less fat than standard cream"+
                                    "*Avonmore Fresh cream contains 38% fat"+

                                    "A luxuriously thick cream ready to add into your favourite dish"+
                                    "Gluten free"+
                                    "Suitable for vegetarians",


                        ProductPic = "/Content/Images/AvonmoreCookingCream.jpg"


                },



                new Product
                {

                    ProductName = "Alpro Coconut Almond",
                    CategoryId = 1,
                    Category = "Fresh Food",

                    Price =  3.10M,

                    SupplierId = 2,
                    Supplier = "Alpro Products UK",

                    ProductDescr = "Discover the refreshing taste of coconut combined with the subtle taste of Almonds"+
                                "perfectly blended to become Alpro® Coconut Almond. Source of calcium and vitamin D,"+
                                "contributing to the maintenance of healthy bones. Alpro® drinks use less land and water and generate less CO2 than dairy milk"+

                                "BENEFITS"+

                                "Refreshing anytime & anywhere"+
                                "100% plant-based"+
                                "A source of calcium and vitamins B2, B12, D and E"+
                                "Low in fat and sugars"+
                                "Free from colours & preservatives",


                    ProductPic = "/Content/Images/AlproCoconutAlmond.jpg"


                },


                   new Product
                {

                    ProductName = "Alpro Coconut Chocolate",
                    CategoryId = 1,
                    Category = "Fresh Food",

                    Price = 3.10M,

                    SupplierId = 2,
                    Supplier = "Alpro Products UK",

                    ProductDescr = "Coconut drink, chocolate flavour, with added calcium and vitamins"+
                                "A varied, balanced diet and a healthy lifestyle is recommended for good health"+

                                "Good for the planet"+
                                "Alpro® drinks use less land and water and generate less CO2 than dairy milk"+

                                "Alpro caring for people & planet"+
                                "Like us on Facebook at even more on www.alpro.com"+

                                "Calcium & vit.B12, D, 100 % plant - based, Naturally low in fat"+
                                "Easy to digest as naturally lactose free"+
                                "Free from dairy, gluten and wheat"+
                                "Free from colours and preservatives"+
                                "Suitable for vegans"+
                                "Naturally low in fat",

                    ProductPic = "/Content/Images/AlproCoconutChocolate.jpg"


                },


                   new Product
                   {

                       ProductName = "Alpro Organic Almond",
                       CategoryId = 1,
                       Category = "Fresh Food",

                       Price = 2.70M,

                       SupplierId = 2,
                       Supplier = "Alpro Products UK",


                       ProductDescr = "Alpro Organic Almond Unsweetened drink is a deliciously virtuous drink"+
                                   "Made from organically-sourced European almonds with a subtle roasted taste,"+
                                   "it’s plant-based and 100% tasty… all without any sugars"+


                                   "Alpro caring for people & planet"+
                                   "Like us on Facebook at even more on www.alpro.com"+


                                    "BENEFITS"+
                                    "100% plant-based and organic"+
                                    "No sugars"+
                                    "Low in calories"+
                                    "Naturally low in saturated fats"+
                                    "Easy to digest as naturally lactose free"+
                                    "A varied, balanced diet and a healthy lifestyle is recommended for good health",

                       ProductPic = "/Content/Images/AlproOrganicAlmond.jpg"

                   },



                new Product
                {
                    ProductName = "KokoOriginalMilk",
                    CategoryId = 1,
                    Category = "Fresh Food",

                    Price = 2.29M,

                    SupplierId =  3,
                    Supplier = "Koko Dairy Free",

                    ProductDescr = "Dairy Free alternative to milk made with Coconut Milk, Calcium + Vitamins B12 & D2"+

                                    "Find out more at www.kokodairyfree.com"+

                                    "Made with freshly pressed coconut milk"+
                                    "Every day fresh, ripe coconuts are pressed within hours of picking so we can guarantee that all of our products are of the very highest quality"+

                                    "Fresh tasting & versatile"+
                                    "With added calcium + vitamins D2 & B12"+
                                    "Free from animal fats"+
                                    "Dairy, lactose, soya and gluten free"+
                                    "Free from artificial flavours, preservatives and colourings"+
                                    "Vegetarians Society approved"+
                                    "Suitable for coeliacs, vegans and those with nut allergies",


                    ProductPic = "/Content/Images/KokoOriginalMilk.jpg"


                },


                new Product
                {

                    ProductName = "KokoSuperMilk",
                    CategoryId = 1,
                    Category = "Fresh Food",

                    Price = 2.29M,

                    SupplierId = 3,
                    Supplier = "Koko Dairy Free",
                    ProductDescr  =  "Dairy Free alternative to milk made with Coconut Milk, Calcium + Vitamins B12 & D2"+

                                    "Find out more at www.kokodairyfree.com"+

                                    "Made with freshly pressed coconut milk"+
                                    "Every day fresh, ripe coconuts are pressed within hours of picking so we can guarantee that all of our products are of the very highest quality"+

                                    "Fresh tasting & versatile"+
                                    "With added calcium + vitamins D2 & B12"+
                                    "Free from animal fats"+
                                    "Dairy, lactose, soya and gluten free"+
                                    "Free from artificial flavours, preservatives and colourings"+
                                    "Vegetarians Society approved"+
                                    "Suitable for coeliacs, vegans and those with nut allergies",


                    ProductPic = "/Content/Images/KokoSuperMilk.jpg"
                },



                   new Product
                {

                        ProductName = "MoojuMilkChocolate750",
                        CategoryId = 1,
                        Category = "Fresh Food",

                        Price =  1.69M,

                        SupplierId = 1,
                        Supplier = "Glanbia Consumer Foods",

                        ProductDescr  = "Pasteurised, Homogenised 1% fat chocolate milk drink"+

                                      "Enjoy each 250ml glass daily as part of a varied and balanced diet and healthy lifestyle"+

                                      "Get Your Mooju Back!"+
                                      "Great tasting Mooju fresh chocolate milk made with Avonmore fresh milk so you know it's full of good stuff"+

                                      "High in Protein"+
                                      "Protein contributes to the maintenance of muscle mass"+
                                      "This pack contains 35g of protein. (Each 250ml serving contains 11.7g of protein)"+

                                      "The National Dairy Council - farmed in the Republic of Ireland"+
                                      "1% fat milk"+
                                      "High in protein"+
                                      "No preservatives"+
                                      "No artificial sweeteners or colours",

                        ProductPic = "/Content/Images/MoojuMilkChocolate750.jpg"
                },



                    new Product
                {
                        ProductName = "MoojuMilkStrawberry750",
                        CategoryId = 1,
                        Category = "Fresh Food",

                        Price = 1.69M,

                        SupplierId = 1,
                        Supplier = "Glanbia Consumer Foods",


                        ProductDescr  =  "Pasteurised, Homogenised 1% fat strawberry milk drink"+

                                    "Enjoy each 250ml glass daily as part of a varied and balanced diet and healthy lifestyle"+

                                    "Get Your Mooju Back!"+
                                    "Great tasting Mooju fresh chocolate milk made with Avonmore fresh milk so you know it's full of good stuff"+

                                    "High in Protein"+
                                    "Protein contributes to the maintenance of muscle mass"+
                                    "This pack contains 35g of protein. (Each 250ml serving contains 11.7g of protein)"+

                                    "The National Dairy Council - farmed in the Republic of Ireland"+
                                    "1% fat milk"+
                                    "High in protein"+
                                    "No preservatives"+
                                    "No artificial sweeteners or colours",


                        ProductPic = "/Content/Images/MoojuMilkStrawberry750.jpg"
                },


                  new Product
                       {

                        ProductName = "MoojuMilkBanana750",
                        CategoryId = 1,
                        Category = "Fresh Food",

                        Price = 1.69M,

                        SupplierId = 1,
                        Supplier = "Glanbia Consumer Foods",


                        ProductDescr  =  "Pasteurised, Homogenised 1% fat banana milk drink"+

                                    "Enjoy each 250ml glass daily as part of a varied and balanced diet and healthy lifestyle"+

                                    "Get Your Mooju Back!"+
                                    "Great tasting Mooju fresh chocolate milk made with Avonmore fresh milk so you know it's full of good stuff"+

                                    "High in Protein"+
                                    "Protein contributes to the maintenance of muscle mass"+
                                    "This pack contains 35g of protein. (Each 250ml serving contains 11.7g of protein)"+

                                    "The National Dairy Council - farmed in the Republic of Ireland"+
                                    "1% fat milk"+
                                    "High in protein"+
                                    "No preservatives"+
                                    "No artificial sweeteners or colours",


                        ProductPic = "/Content/Images/MoojuMilkBanana750.jpg"
                },




   // Frozen Food products - Category 2


                      new Product

                      {

                        ProductName = "Avonmore Freshly Whipped Cream 250MI",
                        CategoryId = 2,
                        Category = "Frozen Food",

                        Price = 2.20M,

                        SupplierId = 1,
                        Supplier = "Glanbia Consumer Foods Ireland",

                        ProductDescr =

                                "Pasteurised Fresh Whipped Cream"+
                                "It's ready to serve straight from the pot. No mess, no fuss, just delicious Avonmore Freshly Whipped Cream, perfect for spooning onto desserts"+
                                "cakes, pastries & all your favourite treats"+
                                "Ready to serve"+
                                "Suitable for vegetarians",

                        ProductPic = "/Content/Images/AvonmoreFreshlyWhippedCream.jpg"

                      },




                new Product

                    {

                      ProductName = "DairyMaid butter spread 500g" ,
                      CategoryId = 2,
                      Category = "Frozen Food",

                      Price = 1.50m,

                      SupplierId = 4,
                      Supplier = "JDS Foods Ltd",

                      ProductDescr =

                                "Blended Spread 59%"+

                                "Green Palm Sustainability"+
                                "Dairymaid supports sustainable palm oil production through the Green Palm programme"+
                                 "Dairymaid Buttery is the only spread that combines the natural goodness and flavour of Irish butter and cream"+

                                "James Daly first started trading butter at Cork's famous Butter Market in 1871 where butter was brought by horse and cart from farms all over Ireland"+
                                "In 1905 James Daly and Sons first began producing Dairy Spreads using the finest natural ingredients. Located in Cork and still family owned, " +
                                "the proud tradition continues to this day"+

                                "With fresh Irish butter &cream"+
                                "Best for baking"+
                                "Free from hydrogenated oil"+
                                "28 % less fat than buttery"+

                                "Suitable for vegetarians",

                      ProductPic = "/Content/Images/DairymaidButterySpread500g.jpg",

                            },


                  new Product {

                            ProductName = "DairyMaid premium buttery 454" ,
                            CategoryId = 2,
                            Category = "Frozen Food",

                            Price = 1.50m,

                            SupplierId = 4,
                            Supplier = "JDS Foods Ltd",

                            ProductDescr =

                                    "Blended Spread 64%"+

                                    "Green Palm Sustainability"+
                                    "Dairymaid supports sustainable palm oil production through the Green Palm programme"+

                                    "James Daly first started trading butter at Cork's famous Butter Market in 1871 where butter was brought by horse and cart from farms all over Ireland"+
                                    "In 1905 James Daly and Sons first began producing Dairy Spreads using the finest natural ingredients. Located in Cork and still family owned, "+
                                    "the proud tradition continues to this day"+

                                    "Irish made"+
                                    "Fresh cream"+
                                    "Best for baking"+
                                    "100 % natural ingredients"+
                                    "Free from hydrogenated oil"+
                                    "20 % less fat than butter"+
                                    "Suitable for vegetarians",

                            ProductPic = "/Content/Images/DairymaidButteryPremium454g",

                            },




                new Product {

                                ProductName = "Pilgrims Choice Extra Mature Chedder Cheese 350g",

                                CategoryId = 2,
                                Category = "Frozen Food",

                                Price = 1.20m,
                                SupplierId = 6,
                                Supplier = "Ornua Co-operative Ltd",
                                ProductDescr =
                                           "Suitable for vegetarians"+

                                            "Cheddar hand selected by our expert graders"+

                                            "Pilgrims Choice® extra mature cheddar"+

                                            "You know when you find something that little bit special ? Well, this is it.Matured for around 12 months, and chosen for its exceptional taste"+
                                            "It's a favourite of all at Pilgrims Choice®."+
                                            "Crunchy, crumbly and moreish, it's ideal for slicing, grating or just nibbling(But don't get caught ). A perfect all rounder it can even be found " +
                                            "on the cheese board Delicious"+

                                            "Kevin Beer, Head Cheese Grader"+
                                            "...Our other Pilgrims Choice® variants ? Look out for our Vintage Cheddar, handmade in the West Country"+

                                            "To find out out more...about our delicious cheddar, and how Kevin sources and grades only the best, please visit www.pilgrimschoice.com"+

                                            "Allergy Information"+
                                            "Allergy Other Text: Contains cow's milk"+

                                            "Contains: Milk",

                             ProductPic =  "/Content/Images/PilgrimsChoiceExtraMatureChedderCheese350g.jpg"


                            },






                new Product {

                                ProductName = "Pilgrims Choice Extra Mature Chedder Cheese 550g",

                                CategoryId = 2,
                                Category = "Frozen Food",

                                Price = 1.20m,
                                SupplierId = 6,
                                Supplier = "Ornua Co-operative Ltd",
                                ProductDescr =

                                            "Mature Cheddar"+
                                            "For delicious recipes, visit www.pilgrimschoice.com or join us on Facebook, Twitter and Instagram"+
                                            "Hand selected for a better flavour"+

                                            "Our cheese experts never compromise on flavour, consistency or taste.They grade each batch to ensure only"+
                                            "the best cheese makes our packs"+

                                            "This Mature Cheddar is rich, smooth and wonderfully well rounded"+
                                            "Like you, we think the world should be packed full of flavour"+
                                            "We're anti-bland and pro-punchy, in cheese and in life. It's how we think, act and it's how our cheddar will"+
                                            "always taste"+

                                            "Our Mature Cheddar is rich, smooth and wonderfully well rounded"+
                                            "We love cheese.We love it so much our cheese experts hand select only the very best, chosen for its superior"+
                                            "flavour, texture and aroma"+
                                            "Pilgrims Choice.Well Chosen"+
                                            "No matter whether you're a cheese lover, a taste enthusiast or a midnight fridge raider, we promise to always strive to " +
                                            "fill your life with flavour"+
                                            "with the unapologetic, unashamed, unmistakable taste of Pilgrims Choice"+
                                            "Pilgrims Choice.Fill your life with flavour"+
                                            "Packaged in a protective atmosphere"+

                                            "Well chosen - hand selected for a better flavour"+
                                            "Fill your life with flavour with this timeless classic.With a smooth texture and lasting flavour it is undeniably moreish." +
                                            " Not that anyone can say no to our cheddar anyway"+
                                            "Smooth & rich" +
                                            "Suitable for vegetarians"+
                                            "Pack size: 550g",



                           ProductPic =  "/Content/Images/PilgrimsChoiceExtraMatureChedderCheese550g.jpg"


                            },



                new Product {

                                ProductName = "Tesco Grated Mozzarella 250g",

                                CategoryId = 2,
                                Category = "Frozen Food",

                                Price = 1.20m,
                                SupplierId = 6,
                                Supplier = "Tesco supplier",
                                ProductDescr =
                                                "Grated full fat Mozzarella soft cheese"+
                                                "Taste of Italy Mild and creamy grated mozzarella that melts into a rich topping"+
                                                "Taste of Italy Mild and creamy grated mozzarella that melts into a rich topping"+

                                                "Safety Warnings"+
                                                "Packaged in a protective atmosphere"+

                                                "This product is suitable for Vegetarians"+

                                                "Pack Quantity: 250g e"+

                                                "Usage Count: 8 Servings"+

                                                "Recycling Info: Film - Plastic not currently recycled",

                            ProductPic =  "/Content/Images/TescoGratedMozzarella250g.jpg"


                            },



                new Product   {

                                ProductName = "KerryGold Butter 500g ",
                                CategoryId = 2,
                                Category = "Frozen Food",

                                Price = 3.75m,
                                SupplierId = 4,
                                Supplier = "KerryGold",

                                ProductDescr =
                                                "Irish Creamery Butter"+
                                                "Enjoy the delicious taste of Kerrygold, Ireland's favourite butter"+
                                                "Suitable for vegetarians",

                                ProductPic = "/Content/Images/KerrygoldButter500g.jpg"


                              },


                new Product {

                                ProductName = "Tesco Olive Spread 500g",

                                CategoryId = 2,
                                Category = "Frozen Food",

                                Price = 1.20m,
                                SupplierId = 30,
                                Supplier = "Tesco supplier",
                                ProductDescr =
                                            "Reduced Fat Spread (59%) made with Olive Oil (21%)"+

                                            "Tesco Olive Spread (21%)"+
                                            "Made with Olive oil (21%)"+

                                            "Allergy Information"+
                                            "Contains milk. Allergy Advice! For allergens, see ingredients in bold",


                            ProductPic =  "/Content/Images/TescoOliveSpread500g.jpg"


                            },


                new Product {

                                ProductName = "Tesco Chicken Breast Fillets 300g",
                                CategoryId = 2,
                                Category = "Frozen Food",

                                Price = 2.99m,
                                SupplierId = 30,
                                Supplier = "Tesco supplier",

                                ProductDescr =
                                            "Chicken breast mini fillets with added water in breadcrumbs"+
                                            "Tender chicken breast mini fillet covered in crispy golden breadcrumb"+

                                            "Safety Warnings"+
                                            "Caution: This product contains raw meat.Caution: Although every care has been taken to remove bones, some may remain",


                                ProductPic = "/Content/Images/TescoChickenBreastFillets300g.jpg"
                            },




                new Product

                            {

                                ProductName = "Tesco Butter Chicken Kievs 500g",
                                CategoryId = 2,
                                Category = "Frozen Food",

                                Price = 2.49m,
                                SupplierId = 30,
                                Supplier = "Tesco supplier",

                                ProductDescr =

                                            "Chopped and shaped chicken breast filled with garlic butter in a breadcrumb coating"+

                                            "Classic chicken kievs are a real family favourite and it's easy to see why. Fuss free, quick cooking for hungry tummies at teatime. These frozen chicken"+
                                            "kievs, made with 100% breast meat in a crispy breadcrumb coating, have a tasty garlic butter centre and cook from frozen in just 30 minutes. " +
                                            "Make a teatime treat with herby new potatoes and petits pois or for simple suppers team your kievs with potato waffles, frozen peas and a dollop"+
                                            "of tomato ketchup. This product is made with 100% chopped and shaped chicken breast with no artificial preservatives, flavours or colours"+
                                            "Succulent chicken kievs filled with delicious garlic butter",


                                ProductPic = "/Content/Images/TescoButterChickenKievs500g.jpg"
                            },



                new Product
                            {

                                ProductName = "Tesco Fried Chicken Wings 1kg",
                                CategoryId = 2,
                                Category = "Frozen Food",

                                Price = 4.00m,
                                SupplierId = 30,
                                Supplier = "Tesco supplier",

                                ProductDescr =

                                            "Chicken wings in a southern fried breadcrumb coating"+

                                            "Tear up the takeaway menus and check out these tasty southern fried chicken wings. Tender chicken coated in crispy, seasoned southern " +
                                            "fried breadcrumbs to tempt your tastebuds. Make them into a meal and serve with oven chips, a large bowl of salad and BBQ, ketchup and mayo dips."+
                                            "Perfect for parties and great for sharing cook from frozen in 30 minutes and team with corn on the cob, coleslaw and potato wedges for a finger"+
                                            "licking feast.This product is made with 100 % chicken wings and produced in the UK with no artificial flavours, colours or preservatives"+
                                            "A selection of chicken wings coated in crispy seasoned breadcrumbs",

                                ProductPic = "/Content/Images/TescoFriedWings1kg.jpg"
                            },



                new Product {

                                ProductName = "Tesco Chicken Steaks 380g",
                                CategoryId = 2,
                                Category = "Frozen Food",

                                Price = 2.50m,
                                SupplierId = 30,
                                Supplier = "Tesco supplier",

                                ProductDescr =

                                                "Chopped and shaped chicken breast in a batter coating"+

                                                "Take a bite of our tasty chicken steaks made with 100% chicken breast meat in a light and crispy batter. " +
                                                "Totally tasty in simple suppers with oven chips, frozen peas and a squirt of tomato ketchup perfect to please those fussy eaters. " +
                                                "These frozen chicken steaks cook in just 27 minutes and are great freezer fillers to be served any way you like. For something different " +
                                                "try making tasty chicken burgers, loading up a burger bun with a crispy chicken steak, a slice of beef tomato and fresh lettuce leaves." +
                                                "This product is made with 100 % chopped and shaped chicken breast with no artificial preservatives, flavours or colours"+
                                                "4 Crispy Battered Chicken Steaks JUICY & TENDER Made with 100 % chicken breast coated in a light, crispy batter",


                                ProductPic = "/Content/Images/TescoChickenSteaks380g.jpg"
                            },




                        new Product {

                                ProductName = "Tesco Cod Fillets 500g",

                                CategoryId = 2,
                                Category = "Frozen Food",

                                Price = 2.15m,
                                SupplierId = 30,
                                Supplier = "Tesco supplier",

                                ProductDescr =

                                            "4 Skinless and boneless cod (Gadus morhua) fillets, formed from pieces of 100% cod fillet coated in crisp batter"+
                                            "Formed from 100% cod fillet in a light, crispy batter",

                                ProductPic = "/Content/Images/TescoCodFillets500g.jpg"
                            },



                         new Product {


                                ProductName = "Tesco Cod Fillet Fish Fingers 400g",
                                CategoryId = 2,
                                Category = "Frozen Food",

                                Price = 2.15m,
                                SupplierId = 10,
                                Supplier = "Tesco supplier",

                                ProductDescr =

                                            "Finest chunky Cod Fillet Fish Fingers IN CRISP GOLDEN CRUMB. WE'VE USED MOIST WHOLE CHUNKY COD FILLETS, " +
                                            "FOR THESE DELICIOUSLY SUCCULENT FISH FINGERS. PERFECT IN CIABATTA FOR A LUXURY FISH FINGER SANDWICH."+
                                            "100% cod fillet fish fingers coated in crispy breadcrumbs",


                                ProductPic = "/Content/Images/TescoCodFilletFishFingers400g.jpg"
                            },



                         new Product {

                                    ProductName = "Tesco Large Raw King Prawns",
                                    CategoryId = 2,
                                    Category = "Frozen Food",

                                    Price = 2.15m,
                                    SupplierId = 10,
                                    Supplier = "Tesco supplier",

                                    ProductDescr =

                                         "Peeled raw king prawns (Penaeus Vannamei) with protective ice glaze"+
                                         "Chosen for size and individually frozen to help manage portions",

                                   ProductPic = "/Content/Images/TescoLargeRawKingPrawns170g.jpg"
                            },



                         new Product {

                                ProductName = "Tesco Chocolate Sandwich 8x90ml",
                                CategoryId = 2,
                                Category = "Frozen Food",

                                Price = 2.30m,
                                SupplierId = 10,
                                Supplier = "Tesco supplier",

                                ProductDescr =

                                            "8 Individually wrapped strawberry, vanilla and chocolate flavoured ice creams in biscuit wafers, dipped in a chocolate flavour coating"+
                                            "8 Neapolitan Choc Sandwich"+
                                            "A classic ice cream combination sandwiched between wafers for a treat",


                                ProductPic = "/Content/Images/TescoChocolateSandwich8x90ml.jpg"
                            },




                         new Product {

                                ProductName = "Tesco Tail Breaded Scampi 280g",
                                CategoryId = 2,
                                Category = "Frozen Food",

                                Price = 2.15m,
                                SupplierId = 10,
                                Supplier = "Tesco supplier",

                                ProductDescr =

                                            "Clusters of wholetail scampi (Nephrops norvegicus) pieces with added water, coated in breadcrumbs"+
                                            "Covered in a golden crumb for a crispy coating",

                                ProductPic = "/Content/Images/TescoTailBreadedScampi280g.jpg"
                            },




                          new Product {

                                ProductName = "Ben & Kerry Chocolate Ice Cream",
                                CategoryId = 2,
                                Category = "Frozen Food",

                                Price = 4.00m,
                                SupplierId = 5,
                                Supplier = "Unilever Ireland Ltd",

                                ProductDescr =

                                            "Chocolate ice cream with marshmallow (15%), caramel (10%) and chocolatey shaped fish (7.5%)"+

                                            "Chocolate ice cream with gooey marshmallow, caramel swirls and fudge fish. It’s delicious, but how did it come to be?"+
                                            "Ben had been pondering the lack of a good marshmallow ice cream for years. “Most attempts at marshmallow were wispy." +
                                            "You can see the white streaks, but you can't taste them, you can't feel them, you can't experience the true glorious marshmallowness of it all,” " +
                                            "Ben remembers"+
                                            "Well, back in 1995, we suggested to the rock band Phish that we celebrate our shared Vermont, USA, roots by creating a Phish flavour." +
                                            "As the wheel started turning on the collaboration, " +
                                            "Ben saw an opportunity to solve the marshmallow conundrum once and for all.Starting with a base of rich chocolate ice cream, he and our " +
                                            "flavour gurus started bringing the band test tubs " +
                                            "of the evolving concoction. “We ate a lot of test tubs around the table with Phish.We’ve done flavours with other artists and entities, " +
                                            "but nobody was more involved in creating the flavour " +
                                            "than Phish was,” Jerry says.The band was instrumental, for example, in calling for caramel swirl, an addition that pushed the flavour over the top"+
                                            "We work with Fairtrade certified producers for cocoa, sugar and vanilla, and our Caring Dairy farmers produce the milk and cream in this tub in a " +
                                            "sustainable way.All of Ben & Jerry’s " +
                                            "ice cream is made with non - GMO sourced ingredients and cage - free eggs.Ben & Jerry’s uses responsibly sourced packaging"+

                                            "Ben & Jerry's Phish Food ice cream tub"+
                                            "Chocolate ice cream with marshmallow, caramel and chocolatey shaped fish"+
                                            "We operate on a three - part mission that aims to create linked prosperity for everyone that’s connected to our business: suppliers, employees, " +
                                            "farmers, franchisees, customers, and neighbours alike"+
                                            "Includes Fairtrade certified cocoa, sugar, and vanilla"+
                                            "Kosher certified dairy"+
                                            "Ben & Jerry’s uses responsibly sourced packaging",



                              ProductPic = "/Content/Images/BenAndJerryPhishIceCream500ml.jpg"
                            },



                          new Product {

                                ProductName = "Hb Chocolate Ice Vanilla 90ml",
                                CategoryId = 2,
                                Category = "Frozen Food",

                                Price = 2.15m,
                                SupplierId = 10,
                                Supplier = "Tesco supplier",

                                ProductDescr =

                                            "Ice cream with chocolate flavour coating (20%)"+
                                            "www.sharehappy.com"+

                                            "Choc Ice is a classic that family will love!"+

                                            "HB is proud to be Ireland's favourite Ice cream, making the Nation smile for over 80 years! We use selected ingredients " +
                                            "so that you can feel happier about giving your family a little treat. That's why you'll find no artificial colours or flavours " +
                                            "in this product. With luscious ice cream covered in a melt-in-the-mouth chocolate flavour coating"+

                                            "Choc-tastic ice cream"+
                                            "Without artificial colours and flavours",


                                ProductPic = "/Content/Images/HbChocolateIceVanilla90ml.jpg"
                            },





                                   new Product {

                                ProductName = "Pilgrims Choice Extra Mature Chedder Cheese 350g",

                                CategoryId = 2,
                                Category = "Frozen Food",

                                Price = 1.20m,
                                SupplierId = 6,
                                Supplier = "Ornua Co-operative Ltd",
                                ProductDescr =
                                            "Reduced Fat Spread (59%) made with Olive Oil (21%)"+

                                            "Tesco Olive Spread (21%)"+
                                            "Made with Olive oil (21%)"+

                                            "Allergy Information"+
                                            "Contains milk. Allergy Advice! For allergens, see ingredients in bold",


                            ProductPic =  "/Content/Images/PilgrimsChoiceExtraMatureChedderCheese350g.jpg"


                            },


// Bakery Products - Category 3

                new Product
                {


                            ProductName = "Tesco Ancient Grain Roll",
                            CategoryId = 3,
                            Category = "Bakery",

                            Price = 0.39M,
                            SupplierId = 30,
                            Supplier = "Tesco supplier",

                            ProductDescr = " Stone baked roll with seed inclusions and topped with quinoa, buckwheat, spelt, brown linseed, chia seeds and millet"+

                                        "Stone baked roll with seed inclusions and topped with a blend of ancient grains"+

                                        "Lifestyle"+
                                        "Suitable for Vegetarians"+

                                        "Quantity - Number of Units: 1"+

                                        "Pack Quantity: 80g"+
                                        "Usage Count: 1 Servings"+

                                        "Origin Country Name: Ireland",

                            ProductPic = "/Content/Images/TescoAncientGrainRoll.jpg"

                },



                new Product
                {

                            ProductName = "Brennans Half Pan Premium",
                            CategoryId = 3,
                            Category = "Bakery",

                            Price = 4.86M,

                            SupplierId = 9,
                            Supplier = "Brennans",
                            ProductDescr = "White Bread Half Pan Premium",

                            ProductPic = "/Content/Images/BrennansHalfPanPremium.jpg"
                },


                new Product
                {

                            ProductName = "Brennans Sliced Pan White 800g",
                            CategoryId = 3,
                            Category = "Bakery",

                            Price = 1.50M,

                            SupplierId = 9,
                            Supplier = "Brennans",

                            ProductDescr = "Family Pan Premium White Bread"+

                                        "No added sugar*"+
                                        "*Contains naturally occurring sugars"+

                                        "Our Guarantee"+
                                        "At Brennans Family Bakery we guarantee our breads' freshness and quality. Made from the finest ingredients and baked with special care, " +
                                        "it comes hot from our ovens to reach each shelf within hours, so you can be sure it's today's bread today."+

                                        "Joe Brennan"+

                                        "Low fat"+
                                        "1st quality freshness taste"+
                                        "Quality certified"+
                                        "Suitable for vegetarians"+

                                        "Low fat No added sugar"+
                                        "Allergy Information"+
                                        "Lifestyle"+
                                        "Low Fat"+
                                        "No Added Sugar"+
                                        "Suitable for Vegetarians"+

                                        "Pack Quantity: 800g ℮"+

                                        "Usage Content: 20 slices per pack"+
                                        "Usage Count: 20 Servings"+

                                        "Storage type: Ambient",

                            ProductPic = "/Content/Images/BrennansSlicedPanWhite.jpg"

                },


                new Product
                {


                            ProductName = "Brennans Whole grain Sliced Bread 800g",
                            CategoryId = 3,
                            Category = "Bakery",

                            Price = 1.60M,

                            SupplierId = 9,
                            Supplier = "Brennans",


                            ProductDescr = "Wholegrain Brown Bread"+

                                        "No added sugar*"+
                                        "*Contains naturally occurring sugars"+

                                        "Our Guarantee"+
                                        "At Brennans Family Bakery we guarantee our breads' freshness and quality. Made from the finest ingredients and baked with special care, it comes"+
                                        "hot from our ovens to reach each shelf within hours, so you can be sure it's today's bread today."+

                                        "Joe Brennan"+

                                        "Source of fibre"+
                                        "Low fat"+
                                        "Quality certified"+
                                        "Suitable for vegetarians"+

                                        "Source of fibre Low fat No added sugar"+
                                        "Lifestyle"+
                                        "Low Fat"+
                                        "No Added Sugar"+
                                        "Suitable for Vegetarians"+

                                        "Pack Quantity: 800g ℮"+

                                        "Usage Text: 20 slices per pack"+

                                        "Storage type: Ambient",

                            ProductPic = "/Content/Images/BrennansWholegrainSlicedBread800g.jpg"
               },



                new Product

                {


                            ProductName = "Butter Brioche Rolls 8 pack",
                            CategoryId = 3,
                            Category = "Bakery",

                            Price = 2.26M,

                            Supplier = "Irwin's Bakery",
                            ProductDescr = "Butter Brioche Roll 8 pack",

                            ProductPic = "/Content/Images/ButterBriocheRolls8pack.jpg"
                },


                new Product

                {

                            ProductName = "Brennans Sliced Pan White",
                            CategoryId = 3,
                            Category = "Bakery",

                            Price = 3.56M,

                            SupplierId = 19,
                            Supplier = "Brennans",

                            ProductDescr = "White bread",
                            ProductPic = "/Content/Images/BrennansSlicedPanWhite.jpg"

                },

                 new Product


                 {

                            ProductName = "Ciabatta Rolls 4pack",
                            CategoryId = 3,
                            Category = "Bakery",

                            Price = 1.50M,

                            SupplierId = 30,
                            Supplier = "Tesco supplier",

                            ProductDescr = " Snack Ciabatta Roll (4 pack)"+

                                        "Safety Warnings"+
                                        "May contain milk"+

                                        "Lifestyle"+
                                        "Suitable for Vegetarians"+

                                        "Quantity"+
                                        "Number of Units - 4"+

                                        "Pack Quantity"+
                                        "307g e(4 Pack)"+

                                        "Usage Count"+
                                        "1 Servings"+

                                         "Origin Country Name: Ireland"+

                                         "INGREDIENTS: Wheat Flour (Wheat Flour, Calcium Carbonate, Iron, Niacin, Thiamin), Water, Extra Virgin Olive Oil"+
                                         "Salt, Yeast, Rapeseed Oil, Malted Wheat Flour, Flour Treatment Agent (Ascorbic Acid), Palm Oil.",


                            ProductPic = "/Content/Images/CiabiattaRolls4pack.jpg"

                },


                    new Product {

                                ProductName = "Tesco Demi Baguette 140g",
                                CategoryId = 3,
                                Category = "Bakery",
                                Price = 0.39M,

                                SupplierId  = 30,
                                Supplier = "Tesco supplier",
                                ProductDescr = "3 pack white bread baguette",


                                ProductPic = "/Content/Images/TescoDemiBaguette140g.jpg"

                            },



                    

                new Product {

                                ProductName = "Tesco Demi Baguette 140g",
                                CategoryId = 3,
                                Category = "Bakery",
                                Price = 0.39M,

                                SupplierId  = 30,
                                Supplier = "Tesco supplier",
                                ProductDescr = "3 pack white bread baguette",


                                ProductPic = "/Content/Images/TescoDemiBaguette140g.jpg"

                            },



                new Product {

                                ProductName = "Tesco Homemade Baguettes 4pack",
                                CategoryId = 3,
                                Category = "Bakery",
                                Price = 0.39M,

                                SupplierId  = 30,
                                Supplier = "Tesco supplier",
                                ProductDescr = "4 Part baked white bread baguettes"+

                                            "Made in France Simply pop in the oven for a warm and crisp baguette"+
                                            "Part baked to finish off at home for a soft inside and golden crust"+
                                            "Safety Warnings"+
                                            "Packaged in a protective atmosphere"+

                                            "Suitable for Vegans"+
                                            "Quantity - Number of Units - 4"+

                                            "Pack Quantity: 600g"+

                                            "Usage Count: 8 Servings"+

                                            "Origin Country Name: France",


                                ProductPic = "/Content/Images/TescoHomemadeBaguettes4pack.jpg"

                            },





                new Product {

                                ProductName = "Brennans Half Wholemeal Bread 400g ",
                                CategoryId = 3,
                                Category = "Bakery",
                                Price = 0.39M,

                                SupplierId  = 9,
                                Supplier = "Brennans",
                                ProductDescr = "100% Wholemeal Bread"+

                                            "Our Guarantee"+
                                            "At Brennans Family Bakery we guarantee our breads' freshness and quality. Made from the finest ingredients and baked with special care, it comes hot " +
                                            "from our ovens to reach each shelf within hours, so you can be sure it's today's bread today"+

                                            "Joe Brennan"+
                                            "Low fat"+

                                            "High fibre"+
                                            "Quality certified"+
                                            "No added sugar - contains naturally occurring sugars"+
                                            "Suitable for vegetarians"+

                                            "Low fat High fibre No added sugar"+

                                            "Safety Warnings"+
                                            "Safety First: This pack contains a cardboard end piece.Please dispose carefully"+

                                            "Allergy Information"+
                                            "Lifestyle"+
                                            "Low Fat"+
                                            "No Added Sugar"+

                                            "Pack Quantity: 400g"+

                                            "Usage Text: 10 slices per pack"+
                                            "Usage Count: 10 Servings"+
                                            "Storage type: Ambient",


                                ProductPic = "/Content/Images/TescoDemiBaguette140g.jpg"

                            },





                new Product {

                                ProductName = "Tesco Brown Sliced Bread 800g",
                                CategoryId = 3,
                                Category = "Bakery",
                                Price = 0.79M,

                                SupplierId  = 30,
                                Supplier = "Tesco supplier",
                                ProductDescr = "Wholemeal sliced bread"+

                                            "Safety Warnings"+
                                            "Warning: Plastic bags can be dangerous.To avoid danger of suffocation, keep this bag away from babies and small children"+

                                            "Allergy Information"+
                                            "Contains gluten, wheat and soya. For allergens, including cereals containing gluten, see ingredients in bold"+

                                            "Lifestyle"+
                                            "Suitable for Vegans"+

                                            "Pack Quantity: 800g e"+
                                            "Usage Count:20 Servings"+

                                            "Recycling Info"+
                                            "Bag - Plastic check local recycling",

                                ProductPic = "/Content/Images/TescoBrownSlicedBread800g.jpg"

                            },



 // DRINKS - Category 4

             
                //TEA products


                        new Product {


                                ProductName = "Barry's Tea Gold 80 Teabags 250g",

                                CategoryId = 4,
                                Category = "Drinks",

                                Price = 3.49m,
                                SupplierId = 13,
                                Supplier = "Barry's Tea",

                                ProductDescr = "Gold Blend 80 Tea Bags"+

                                            "Find us on Twitter and Facebook"+

                                            "We at Barry's Tea always blend to Irish taste, which is why our Gold Blend is consistent in its quality and bright golden colour and has becom"+
                                            "Ireland's favourite tea"+

                                            "Tea is a great source of hydration and is naturally low in calories"+

                                            "An Expert Blend in Every Drop"+
                                            "As a family owned Irish company since 1901, we understand the importance of tea in Ireland. In fact we have spent years perfecting our signature Gold Blend, " +
                                            "a unique blend that has been passed on through generations of our family. Since the beginning our Master Blender has never compromised in his absolute"+
                                            "commitment to fine the quality tea"+

                                            "Our Master Blender tastes our blends three times a day to ensure that every moment you spend with our tea is as rewarding as the last"+

                                            "For over 110 years, our tea journey has always begun in the world's finest tea gardens"+
                                            "That's why at every harvest, we get first pick of the most exceptional teas, sourcing the finest leaves from Kenya, Rwanda and the Assam Valley of India to " +
                                            "give Barry's Tea its much loved taste and unmistakable quality"+

                                            "Expertly blended in Ireland since 1901"+

                                                "Expertly blended in Ireland"+
                                                "Our most loved signature blend"+
                                                "Every cup tells a story"+

                                            "Pack Quantity: 250g ℮",


                                ProductPic = "/Content/Images/BarrysTeaGold80Teabags250g.jpg"

                            },


                    new Product {


                                ProductName = "Barry's Tea Gold 80 Teabags",

                                CategoryId = 4,
                                Category = "Drinks",

                                Price = 3.49m,
                                SupplierId = 13,
                                Supplier = "Barry's Tea",

                                ProductDescr =

                                                "Gold Blend 80 Tea Bags"+

                                                "Find us on Twitter and Facebook"+

                                                "We at Barry's Tea always blend to Irish taste, which is why our Gold Blend is consistent in its quality and bright golden " +
                                                "colour and has become Ireland's"+
                                                "favourite tea. Tea is a great source of hydration and is naturally low in calories"+

                                                "An Expert Blend in Every Drop"+

                                                "As a family owned Irish company since 1901, we understand the importance of tea in Ireland. In fact we have spent" +
                                                "years perfecting our signature Gold Blend,"+
                                                "a unique blend that has been passed on through generations of our family. Since the beginning our Master Blender has" +
                                                "never compromised in his absolute"+
                                                "commitment to fine the quality tea. Our Master Blender tastes our blends three times a day to ensure that every moment" +
                                                "you spend with our tea is as rewarding"+
                                                "as the last"+

                                                "For over 110 years, our tea journey has always begun in the world's finest tea gardens"+
                                                "That's why at every harvest, we get first pick of the most exceptional teas, sourcing the finest leaves from Kenya," +
                                                "Rwanda and the Assam Valley of India to"+
                                                "give Barry's Tea its much loved taste and unmistakable quality"+

                                                "Expertly blended in Ireland since 1901"+

                                                "Expertly blended in Ireland"+
                                                "Our most loved signature blend"+
                                                "Every cup tells a story"+


                                                "Pack Quantity: 250g ℮"+
                                                "Usage Text: Serving size one teabag per cup, 80 servings per box of teabags"+

                                                "Usage Count: 80 Servings",



                                ProductPic = "/Content/Images/BarrysTeaGold80Teabags250g.jpg"

                            },




            // Coffees


                    new Product
                    {

                                ProductName = "Maxwell House Coffee 100g",


                                CategoryId = 4,
                                Category = "Drinks",

                                Price = 3.00m,
                                SupplierId = 14,
                                Supplier = "Jacobs Douwe Egberts",

                                ProductDescr =

                                                "Instant Coffee Powder"+

                                                "Only one thing can make the mild smooth taste of Maxwell House even better. Sharing with friends"+
                                                "Good to the last drop!  Made for sharing"+
                                                "Pack Quantity: 100g ℮"+
                                                "Storage type: Ambient",


                                ProductPic = "/Content/Images/MaxwellHouseCoffee100g.jpg",


                    },


                     new Product
                    {

                                ProductName = "Tesco Gold Decaffeinated Instant Coffee 100g",

                                CategoryId = 4,
                                Category = "Drinks",

                                Price = 2.69m,
                                SupplierId = 30,
                                Supplier = "Tesco supplier",

                                ProductDescr = "Decaffeinated freeze dried instant coffee"+

                                            "Tesco Decaff Gold RICH & SMOOTH Robusta and Arabica beans. Our farmers harvest coffee at the height of the season when the coffee cherry is at perfect ripeness."+
                                            "We carefully blend Robusta and Arabica beans for just the right rich, velvety balance."+
                                            "RICH & SMOOTH Robusta and Arabica beans.Our farmers harvest coffee at the height of the season when the coffee cherry is at perfect ripeness.We carefully blend Robusta " +
                                            "and Arabica beans for just the right rich velvety balance"+

                                            "Pack Quantity: 100g"+
                                            "Usage Count: 55 Servings"+

                                            "Preparation and Usage"+
                                            "Add 1-2 teaspoons per cup, use hot, not boiling water and add milk if preferred."+
                                            "Origin Country Name: Spain",


                              ProductPic = "/Content/Images/TescoGoldDecaffeinatedInstantCoffee100g.jpg",


                    },




                       new Product {

                                ProductName = "Nescafe Azera Americano Instant Coffee 60G",

                                CategoryId = 4,
                                Category = "Drinks",

                                Price = 4.39m,
                                SupplierId = 5,
                                Supplier = "JDS Foods Ltd",

                                ProductDescr =

                                            "Soluble coffee with finely ground roasted coffee"+

                                            "Discover our Instagram @nescafeazera"+
                                            "Follow us on Twitter @nescafeazera"+
                                            "Join us at facebook.com/NescafeUK"+
                                            "Visit nescafe.co.uk/azera"+

                                            "Experience barista-style coffee moments at home. NESCAFÉ AZERA Americano is a carefully crafted blend of Arabica and Robusta beans " +
                                            "that have been made into a premium instant coffee"+

                                            "It All Starts With a NESCAFÉ"+

                                            "NESCAFÉ is the world's favourite coffee brand, enjoyed in over 180 countries worldwide. With over 75 years of experience in selecting, roasting and" +
                                            "blending the very best coffee, it's no surprise that over 5,500 cups of NESCAFÉ coffee are drunk every second!"+

                                            "The NESCAFÉ Plan"+

                                            "Did you know? As part of the NESCAFÉ Plan, we work directly with farmers and provide them with training and local assistance. Find out more about " +
                                            "the NESCAFÉ Plan at www.nescafe.co.uk/nescafe-plan."+

                                            "Why not explore the rest of our barista-style range? Discover a full-bodied coffee with NESCAFÉ AZERA Intenso, a premium cappuccino with NESCAFÉ AZERA " +
                                            "Cappuccino and enjoy an americano when you're out and about with NESCAFÉ AZERA Coffee To Go Americano."+

                                            "Discover barista-style instant coffee with NESCAFÉ AZERA Americano"+
                                            "Crafted from a selection of Arabica and Robusta beans"+
                                            "A special blend of instant and finely ground roasted coffee"+
                                            "Enjoy a layer of velvety coffee crema with every cup"+
                                            "Savour a fruity aroma and a well-balanced flavour"+


                                            "Pack Quantity: 60g ℮"+

                                            "Usage Text: Makes 33 mugs"+
                                            "Usage Count:33 Servings",


                           ProductPic = "/Content/Images/NescafeAzeraCoffee60g.jpg  "

                            },



                         new Product {



                                    ProductName = "Tesco Classic Instant Coffee 200g",

                                    CategoryId = 4,
                                    Category= "Drinks",

                                    Price = 1.79m,
                                    SupplierId = 30,
                                    Supplier = "Tesco supplier",

                                    ProductDescr =
                                                        "Instant coffee"+

                                                        "Tesco Classic MELLOW & SMOOTH Robusta and Arabica beans, roasted for richness Our farmers harvest coffee at the height of the " +
                                                        "season when the coffee cherry is at perfect ripeness.We carefully blend Robusta and Arabica beans for just the right balance of rich " +
                                                        "and mellow"+

                                                        "MELLOW & SMOOTH Robusta and Arabica beans, roasted for richness Our farmers harvest coffee at the height of the season when the coffee " +
                                                        "cherry is at perfect ripeness.We carefully blend Robusta and Arabica beans for just the right balance of rich and mellow."+


                                                        "Lifestyle"+
                                                        "Suitable for Vegans"+

                                                        "Pack Quantity: 200g ℮"+

                                                        "Usage Count: 111 Servings"+

                                                        "Preparation and Usage"+
                                                        "Add 1 - 2 teaspoons per cup, use hot, not boiling water and add milk if preferred",


                                         ProductPic =  "/Content/Images/TescoClassicInstantCoffee200g.jpg"

                                },





                new Product {

                                ProductName = "Tesco Gold Instant Coffee 100G",

                                CategoryId = 4,
                                Category = "Drinks",

                                Price = 1.50m,
                                SupplierId = 30,
                                Supplier = "Tesco supplier",



                                ProductDescr = "Freeze dried instant coffee"+

                                            "Tesco Gold RICH & SMOOTH Robusta and Arabica beans. Our farmers harvest coffee at the height of the season when the coffee cherry is at perfect " +
                                            "ripeness. We carefully blend Robusta and Arabica beans for just the right rich, velvety balance"+
                                            "RICH & SMOOTH Robusta and Arabica beans.Our farmers harvest coffee at the height of the season when the coffee cherry is at perfect ripeness." +
                                            "We carefully blend Robusta and Arabica beans for just the right rich, velvety balance"+

                                            "Lifestyle: Suitable for Vegans"+

                                            "Pack Quantity: 100g"+

                                            "Usage Count: 55 Servings",


                              ProductPic = "/Content/Images/TescoGoldInstantCoffee100g.jpg"

                            },



                new Product {

                                ProductName = "Tesco Gold Instant Coffee 100G",

                                CategoryId = 4,
                                Category = "Drinks",

                                Price = 1.50m,

                                SupplierId = 20,
                                Supplier = "Tesco supplier",



                                ProductDescr = "Freeze dried instant coffee"+

                                            "Tesco Gold RICH & SMOOTH Robusta and Arabica beans. Our farmers harvest coffee at the height of the season when the coffee cherry is at perfect " +
                                            "ripeness. We carefully blend Robusta and Arabica beans for just the right rich, velvety balance"+
                                            "RICH & SMOOTH Robusta and Arabica beans.Our farmers harvest coffee at the height of the season when the coffee cherry is at perfect ripeness." +
                                            "We carefully blend Robusta and Arabica beans for just the right rich, velvety balance"+


                                            "Lifestyle: Suitable for Vegans"+

                                            "Pack Quantity: 100g"+

                                            "Usage Count: 55 Servings",


                              ProductPic = "/Content/Images/TescoGoldInstantCoffee100g.jpg"

                            },





                 new Product {

                                ProductName = "Nescafe Irish Cream Latte Coffee 8x22g",

                                CategoryId = 4,
                                Category = "Drinks",

                                Price = 2.67m,
                                SupplierId = 1,
                                Supplier = "JDS Foods Ltd",

                                ProductDescr =

                                    "A blend of Instant Coffee, Finely Ground Roasted Coffee Beans with Skimmed Milk Powder, Natural Flavour, Sugar and Vegetable Oil"+

                                    "Check out our YouTube Channel at Youtube.com/user/UKNescafe"+
                                    "Join us at facebook.com/NescafeUK"+
                                    "Follow us @nescafegolduki"+
                                    "Visit Nescafe.co.uk"+

                                    "Sit back with a NESCAFÉ GOLD Irish Latte and take a moment to enjoy this creamy liquor tasting flavour and aroma of this expertly crafted drink. Prepare this special"+
                                    "drink whenever you fancy a break.  It All Starts With a NESCAFÉ"+

                                    "NESCAFÉ is the world's favourite coffee brand, enjoyed in over 180 countries worldwide. With over 75 years of experience in selecting, roasting and blending the very best "+
                                    "coffee, it's no surprise that over 5,500 cups of NESCAFÉ coffee are drunk every second!"+

                                    "The NESCAFÉ Plan"+

                                    "Great coffee starts at the source, which is why we've developed the NESCAFÉ Plan. We work with coffee farmers around the world, to support them in growing healthy," +
                                    "higher yielding crops and helping to protect the future of coffee farming for everyone. The result is high quality coffee that comes from sources you can trust."+

                                    "Enjoy your latte with a twist? Why not explore the other flavours we offer, such as NESCAFÉ GOLD Vanilla Latte and NESCAFÉ GOLD Caramel Latte."+

                                    "Discover our delightful latte with a hint of creamy liquor tasting flavour"+
                                    "Crafted using natural high quality coffee beans"+
                                    "Made using fresh milk sourced from British farmers 8 single - serve instant coffee sachets for easy preparation",



                                ProductPic = "/Content/Images/NescafeIrishCreamLatteCoffee8x22g.jpg"

                            },



                //Beers



                new Product {


                                ProductName = "Guinness Draught Can 500ml",
                                CategoryId = 4,
                                Category = "Drinks",

                                Price = 1.99m,
                                SupplierId = 30,
                                Supplier = "Guinness and Co.",

                                ProductDescr =

                                        "With over two centuries of expert brewing craft behind it, Guinness hardly needs any introduction"+
                                        "One of the world's best-loved beers, from the first velvety sip to the last, lingering drop, every deep-dark satisfying mouthful in between is pure beauty… " +
                                        "pure Guinness. Guinness has a long history supporting rugby and took this to a new level by becoming title sponsor on the Guinness Six Nations from 2019"+

                                        "Estd 1759"+
                                        "The sweetness of the malt perfectly balances the bitterness of the hops which are both beautifully complimented by the characteristic flavour of our Guinness roasted barley"+
                                        "Tilt the glass at 45 degrees, pour slowly, let the surge settle and enjoy. Serve extra cold"+
                                        "Guinness brewers were the first to introduce the combination of nitrogen and carbon dioxide to draught beer. The result was Guinness Draught, famous for its smooth velvety " +
                                        "texture and unique surge and settle"+
                                        "Beer drinkers who are looking for a quality beer from a trusted brand"+

                                        "Famous for its smooth velvety texture and unique surge and settle"+
                                        "This is our greatest innovation" +
                                        "Truly unique, Perfectly balanced, Made of More"+

                                       "Allergy Information"+
                                       "Contains: Barley"+

                                        "Pack Quantity: 500ml ℮"+

                                        "Preparation and Usage"+
                                        "Temperature - Serve extra cold"+
                                        "Tilt - Hold glass at 45 degrees"+
                                        "Time - Pour slowly.Let the surge settle.Enjoy"+

                                        "Origin Country Name Ireland"+

                                        "Recycling Info"+
                                        "Can - Recyclable"+

                                        "Storage type: Ambient"+

                                        "Minimum Age Statutory: 18 Years"+
                                        "Alcohol Volume Percentage: 4.2"+
                                        "Alcohol Content Units: 1.7, Alcohol type: Beer"+
                                        "Minimum Age Statutory: 18 Years",


                                ProductPic = "/Content/Images/GuinnessDraughtCan500ml.jpg"

                            },


                new Product {


                                ProductName = "Heineken Can 500ml ",
                                CategoryId = 4,
                                Category = "Drinks",

                                Price = 2.15m,
                                SupplierId = 29,
                                Supplier = "Heineken Ireland Ltd",

                                ProductDescr =
                                            "Lager Beer"+

                                            "Premium quality"+
                                            "Original recipe"+

                                            "Pack Quantity: 500ml ℮"+
                                            "Preparation and Usage"+
                                            "Serve cold"+

                                            "Storage type: Ambient"+

                                            "Minimum Age Statutory:18 Years"+

                                           "Alcohol Volume Percentage:4.3"+
                                            "Alcohol Content Units: 2.15"+

                                            "Alcohol Type:Beer"+
                                            "Minimum Age Statutory:18 Years",


                                ProductPic = "/Content/Images/HeinekenCan500ml.jpg"


                            },




                new Product {

                                ProductName = "Heineken Bottles 6x330ml",

                                CategoryId = 4,
                                Category = "Drinks",

                                Price = 10.00m,
                                SupplierId = 29,
                                Supplier = "Heineken Ireland Ltd",

                                ProductDescr =

                                        "Premium Lager Beer"+

                                        "Heineken is a Proud sponsor of the UEFA Champions League"+

                                        "Premium quality is The original recipe"+
                                        "Quantity - Number of Units: 6"+

                                        "Pack Quantity: 6 x 330ml ℮"+

                                        "Preparation and Usage"+
                                        "Serve cold"+

                                        "Recycling Info"+
                                        "Sleeve - Recyclable"+

                                        "Storage type:Ambient"+

                                        "Minimum Age Statutory: 18 Years"+

                                        "Alcohol Volume Percentage: 4.3"+
                                        "Alcohol Type: Beer",


                                ProductPic = "/Content/Images/HeinekenBottles6x330ml.jpg"

                            },





                new Product {ProductName = "Heineken Alcohol Free Beer 4X330",

                                CategoryId = 4,
                                Category = "Drinks",

                                Price = 6.00m,
                                SupplierId = 29,
                                Supplier = "Heineken Ireland Ltd",

                                ProductDescr =


                                            "Alcohol Free Beer with Natural Flavourings"+
                                            "For more information visit: www.heineken.com / GB"+

                                            "A refreshing alcohol free beer characterised by fruity and fresh malt notes and a lightbody"+
                                            "At just 69 calories this is a great refreshing drink for all"+

                                            "Brewing a great tasting alcohol free beer, is it even possible ? Our master brewers started from zero and spent years exploring, brewing and " +
                                            "tasting before they finally created " +
                                            "a recipe defined by its refreshing fruity notes and soft malty body - perfectly balanced with only 69 calories"+

                                             "A refreshing alcohol free beer characterised by fruity and fresh malt notes and a lightbody.At just 69 calories this is a great refreshing drink for all"+


                                            "ABV: Contains no more than 0.05 % alcohol by volume"+

                                             "AROMA: Baking bread with delicate tropical fruit notes and a hint of satsuma"+
                                             "FLAVOUR: Sweet and fresh wholemeal grains"+

                                            "MOUTHFEEL: Rounded, light body"+

                                            "FINISH: Dry with a delicate tropical fruit finish"+

                                            "FOOD MATCH: Charred mediterranean vegetables or vanilla cheesecake"+


                                            "Brewed with the uncompromising Heineken characteristics since 1873.And made with natural ingredients including Heineken's unique A-Yeast. " +
                                            "It wasn't easy, but not impossible"+
                                            "Heineken® 0.0 has the seal of approval from the Heineken family - a rare honour as there are very few Heineken® variants"+

                                            "The non - alcoholic version of the flagship lager contains just 69 calories"+

                                            "Rather than remove the alcohol from Heineken® our master brewer, Willem van Waesberge, brewed the beer from scratch to deliver the best tasting zero" +
                                            "alcohol beer"+

                                            "Alcohol Free Beer"+

                                            "Quantity"+
                                            "Number of Units - 6"+

                                            "Pack Quantity"+
                                            "6 x 330ml ℮"+

                                            "Preparation and Usage"+
                                            "Serve cold"+

                                            "Origin Country Name"+
                                            "Netherlands"+

                                            "Recycling Info"+
                                            "Can - Metal - Widely Recycled"+
                                            "Carton - Card - Widely Recycled"+

                                            "Storage type: Ambient"+
                                            "Alcohol type: Beer",


                               ProductPic = "/Content/Images/HeinekenAlcoholFreeBeer4X330.jpg"

                            },



                new Product
                {
                            ProductName = "Guinness Draught Can 8X500ml",

                            CategoryId = 4,
                            Category = "Drinks",

                            Price = 14.00m,
                            SupplierId = 29,
                            Supplier = "Guinness and Co.",

                            ProductDescr =


                                "With over two centuries of expert brewing craft behind it, Guinness hardly needs any introduction"+
                                "One of the world's best-loved beers, from the first velvety sip to the last, lingering drop, every deep-dark satisfying mouthful in between is pure beauty… pure Guinness"+
                                "Guinness has a long history supporting rugby and took this to a new level by becoming title sponsor on the Guinness Six Nations from 2019"+

                                "Established in 1759"+
                                "The sweetness of the malt perfectly balances the bitterness of the hops which are both beautifully complimented by the characteristic flavour of our Guinness roasted barley"+
                                "Tilt the glass at 45 degrees, pour slowly, let the surge settle and enjoy. Serve extra cold"+

                                "Guinness brewers were the first to introduce the combination of nitrogen and carbon dioxide to draught beer. The result was Guinness Draught, famous for its smooth velvety"+
                                "texture and unique surge and settle"+

                                "Beer drinkers who are looking for a quality beer from a trusted brand.With over two centuries of expert brewing craft behind it, Guinness hardly needs any introduction"+
                                "One of the world's best-loved beers, from the first velvety sip to the last, lingering drop, every deep-dark satisfying mouthful in between is pure beauty… pure Guinness"+

                                "Famous for its smooth velvety texture and unique surge and settle"+
                                "This is our greatest innovation"+
                                "Truly unique, Perfectly balanced"+

                                "Allergy Information: This product contains: Barley"+

                                "Quantity: Number of Units - 8"+

                                "Pack Quantity: 8 x 500ml ℮"+

                                "Origin Country Name: Ireland"+

                                "Storage type:Ambient",



                            ProductPic = "/Content/Images/GuinnessDraughtCan8X500.jpg"



                },





 // Baby Products - Category 5


       

            new Product {


                                    ProductName = "Pampers Mats 12 pack",


                                    CategoryId = 5,
                                    Category = "Baby",

                                    Price = 7.59m,
                                    SupplierId = 8,
                                    Supplier = "Procter & Gamble",

                                    ProductDescr =

                                            "Pampers Change Mats are absorbent disposable mats for use when making nappy changes on the go."+
                                            "Change Mats are small enough to fit into your bag, so that you can take them with you whenever you have to change your baby - "+
                                            "whether it is at a friend's place, out shopping or in the car."+
                                            "When changing your baby, you can count on Change Mats to protect your baby from what's underneath, while providing a clean and comfortable surface. " +
                                            "Its waterproof back sheet also protects the surface under your baby!"+

                                            "Waterproof back sheet protects like a change mat"+
                                            "Super Absorbent Core absorbs like a nappy"+
                                            "Easy to fold and small enough to fit into a bag"+
                                            "Size 60x60 cm",



                                    ProductPic = "/Content/Images/PampersMats12pack.jpg"
                            },





                           new Product {

                                    ProductName = "Pampers Baby Dry 3Pack 50 nappies",


                                    CategoryId = 5,
                                    Category = "Baby",

                                    Price = 8.99m,
                                    SupplierId = 8,
                                    Supplier = "Procter & Gamble",

                                    ProductDescr =

                                                "Air channels for dry bottoms with Pampers baby - dry nappies.As a parent you understand the importance of fresh air against your baby’s skin,"+
                                                "which is why you may like to let your baby have some nappy - free time during the day.Pampers baby - dry nappies create space for air to flow freely " +
                                                "inside the nappy, giving your baby that fresh air feeling.With up to 12 hours of Breathable Dryness, your baby’s bottom stays dry throughout the night " +
                                                "for a comfortable sleep.Use with Pampers wipes."+


                                                "Pampers baby - dry nappies with unique Air Channels for overnight breathable dryness"+
                                                "An Extra Dry - Layer to help distribute wetness evenly and keep it away from baby’s skin"+
                                                "An absorbent core with Micro Pearls to lock away wetness.For up to 12 hours"+
                                                "Stretchy sides provide a comfortable fit for great overnight leakage protection"+
                                                "A soft like cotton top layer next to baby’s skin(does not contain cotton)"+
                                                "Fun exterior graphics to enjoy our fun designs & characters with your baby"+
                                                "Want to know more about the components Pampers uses ? Visit pampers.co.uk, pampers.ie",



                                    ProductPic = "/Content/Images/PampersBabyDry3Pack50nappies.jpg"
                            },



                           new Product {


                                ProductName = "Vaseline  Original Petroleum Jelly 100ml",


                                CategoryId = 5,
                                Category = "Baby",

                                Price = 2.69m,
                                SupplierId = 8,
                                Supplier = "Procter & Gamble",

                                ProductDescr =

                                            "Vaseline Jelly is the original skin protectant – it has been used to protect and help heal dry skin since 1870, and to this day, it effectively"+
                                            "cares for your skin. Vaseline Petroleum Jelly Original is triple-purified petrolatum and hypoallergenic. Vaseline Jelly is the ideal product for"+
                                            "a multitude of uses, and vaseline benefits include use as a moisturiser for sensitive skin. Petroleum Jelly uses also include hydrating your lips"+
                                            "and moisturising your cuticles. Petroleum jelly is great for all types of dry skin."+

                                            "Vaseline Petroleum Jelly original is a product you can trust. Its triple-purification seal guarantees each jar of Vaseline Jelly has been purified " +
                                            "not once, but three times to remove impurities, ensuring pure petroleum jelly. It is dermatologist recommended and is appropriate for use by those " +
                                            "with sensitive skin.Vaseline Petroleum Jelly original is also a fragrance free, hypoallergenic moisturiser that is a non - irritating and non - " +
                                            "comedogenic(it won’t clog your pores)"+
                                            "Original Vaseline Jelly has many uses, including personal care, baby care and beauty.Unlike some topical lotions and creams, Vaseline Jelly penetrates " +
                                            "into surface skin layers and locks in moisture to create a protective barrier.By sealing in moisture, it assists the skins natural recover to help dry"+
                                            "skin heal.This can rejuvenate visibly dry skin and help reduce the appearance of fine, dry lines"+
                                            "Vaseline Jelly creates a protective barrier that protects skin against environmental factors, such as windburn – and has been used for over 100 years " +
                                            "to protect minor cuts, scrapes, and burns"+
                                            "A moisturiser for sensitive skin should be gentle on the skin, safe and effective at moisturising and protecting your skin.Vaseline Petroleum Jelly " +
                                            "combines all of these properties in one convenient, flip - cap jar.Regular use of this hypoallergenic moisturiser will help you gently care for your" +
                                            "skin and maintain smooth, deeply moisturised skin"+

                                            "Vaseline Petroleum Jelly Original has a variety of preventative and protective uses, including dry skin relief, and protection from minor cuts"+
                                            "100 % pure petroleum jelly, triple - purified, purity guaranteed, can be used as a nappy cream"+
                                            "Gentle on your skin, hypoallergenic and non - comedogenic(won't clog pores) Can be used after baby wipes"+
                                            "Reduces the appearance of fine, dry lines"+
                                            "Protects your skin from windburn and chapping"+
                                            "Helps protect minor cuts, scrapes and burns",


                                 ProductPic = "/Content/Images/VaselinePetroleumJelly100ml.jpg"
                            },




            new Product {


                                    ProductName = "Johnsons Baby Shampoo 500ml",


                                    CategoryId = 5,
                                    Category = "Baby",

                                    Price = 3.89m,
                                    SupplierId = 24,
                                    Supplier = "Procter & Gamble",

                                    ProductDescr =

                                          "Baby Shampoo"+

                                        "When a baby is born, their skin is at its most delicate. That's why we perfected our formulas over 125 years so they're now even more gentle for all"+
                                        "Hypoallergenic*"+
                                        "* Formulated to minimise the risk of allergies."+

                                        "We only choose high quality ingredients that are gentle for baby.That's why we've rejected over 400 ingredients that don't meet our Best"+
                                        "for Baby™ Standards"+

                                        "No more tears®"+
                                        "Pure & gentle daily care"+
                                        "Our mildest formula"+
                                        "As gentle to eyes as pure water"+
                                        "Free from parabens, sulphates & dyes"+
                                        "Gently cleanses to keep delicate hair & scalp feeling healthy"+
                                        "pH ideal for baby's delicate skin"+
                                        "Paediatrician & dermatologist tested"+


                                        "Safety Warnings"+
                                        "WARNING: Keep out of reach of children.For external use only"+


                                        "Pack Quantity: 500ml ℮"+


                                    "Preparation and Usage"+
                                    "To Use: Wet baby's hair, pour a small amount of shampoo onto hand, gently lather into hair and then rinse"+


                                        "Origin Country Name"+
                                        "Italy",

                                    ProductPic = "/Content/Images/JohnsonsBabyShampoo500ml.jpg"
                            },


              new Product {

                                    ProductName = "Johnson's Kids No More Tangles Conditioner Spray 200Ml",


                                    CategoryId = 5,
                                    Category = "Baby",

                                    Price = 3.00m,
                                    SupplierId = 24,
                                    Supplier = "Procter & Gamble",

                                    ProductDescr =

                                                "Kids Conditioner Spray"+

                                        "Routine proven to unlock 75% more knots and tangles†"+
                                        "†vs shampoo without conditioning agent."+

                                        "Hypoallergenic* & paediatrician-tested"+
                                        "*Formulated to minimise the risk of allergies."+

                                        "Children's hair and scalp is still developing and needs special care"+

                                        "No more tears"+
                                        "For easy combing hair"+
                                        "Free from parabens, sulphates & phthalates"+
                                        "Specifically designed to be gentle versus regular adult products"+


                                    "Safety Warnings"+
                                    "WARNING: Keep out of reach of children. Packaging contains small parts, which could cause a choking hazard. For external use only"+


                                    "Pack Quantity: 200ml ℮"+


                                    "Preparation and Usage"+
                                    "Our 3-step routine unlocks 75% more knots†"+
                                    "Shampoo + Conditioner + Detangler"+
                                    "†vs shampoo without conditioning agent"+

                                    "To Use: Spray on wet hair and gently comb through"+


                                    "Origin Country Name: Greece",


                                    ProductPic = "/Content/Images/Johnson'sKidsNoMoreTanglesConditionerSpray200Ml.jpg"
                            },



               new Product{


                                        ProductName = "Johnsons Baby Relaxing Shampoo 500Ml",
                                        CategoryId = 6,
                                        Category = "Health & Beauty",

                                        Price = 3.99m,
                                        SupplierId =23,
                                        Supplier = "Johnsson & Johnsson Ltd",
                                        ProductDescr = "Bedtime Baby Shampoo"+

                                                    "Our baby shampoo, with its unique No More Tears® formula is gentle to the eyes and ophthalmologist tested. " +
                                                    "Its formula leaves hair baby-soft and the fragrance of lavender is designed to help calm the senses"+

                                                    "JOHNSON'S® Baby, trusted by parents for over 125 years"+

                                                    "Free from: parabens, phthalates, soap & dye"+
                                                    "No More Tears® formula is gentle to the eyes"+
                                                    "Relaxing aroma"+

                                                    "Safety Warnings"+
                                                    "WARNING: Keep out of reach of children. External use only"+

                                                    "Pack Quantity"+
                                                    "500ml ℮"+

                                                    "Preparation and Usage"+
                                                    "To use: Wet baby's hair, pour a small amount of shampoo onto hand, gently lather into hair, rinse and snuggle"+

                                                    "Origin Country Name: Italy",

                                        ProductPic  = "/Content/Images/JohnsonsBabyRelaxingShampoo500ml.jpg"


                                    },




// Health & Beauty Products - Category 6




                new Product {

                                ProductName = "Nivea 2 in 1 Cleanser and Toner 200ml",

                                CategoryId = 6,
                                Category = "Health & Beauty",

                                Price = 5.99m,
                                SupplierId = 22,
                                Supplier =  "Beirsdorff UK Ltd",

                                ProductDescr =

                                            "2 in 1 Cleanser & toner"+

                                            "NIVEA® Daily Essentials 2 in 1 Cleanser & Toner"+
                                            "Removes daily impurities and make up"+
                                            "Moisturises the skin to help keep its natural moisture balance"+
                                            "The formula with Vitamin E gently yet effectively cleanses the skin"+

                                            "See and Feel Beautiful Skin"+
                                            "The skin is deeply cleansed, toned and refreshed"+

                                            "Normal & combination skin"+
                                            "Cleanses deeply, tones & moisturises for sensational fresh skin"+
                                            "With Vitamin E & Hydra IQ"+
                                            "Skin compatibility dermatologically approved"+

                                            "Pack Quantity: 200ml ℮"+

                                            "Preparation and Usage"+
                                            "Application"+
                                            "Apply on your skin by gently massaging in small circles to face and neck with finger tips or cotton wool. Remove with a cotton wool or water,"+
                                            "avoiding the eye area"+

                                            "Origin Country Name: Germany",

                                ProductPic = "/Content/Images/Nivea2in1CleanserAndToner200ml.jpg"

                            },




                new Product {

                                ProductName = "Colgate Plax Cool Mint Mouthwash 500ml",

                                CategoryId = 6,
                                Category = "Health & Beauty",

                                Price = 5.29m,
                                SupplierId = 21,
                                Supplier = "Colgate Palmolive",

                                ProductDescr =
                                                    "Mouthwash"+

                                                    "Save Water"+
                                                    "Turn off the tap while brushing"+

                                                    "10x longer cooling†"+
                                                    "†vs brushing alone"+

                                                    "Colgate Plax FreshFX is our latest freshness technology delivering a pleasurable cooling sensation that lasts 10x longer than brushing " +
                                                    "alone. Colgate Plax is a clinically proven formula that effectively fights bacteria and provides 24/7 plaque protection*"+

                                                    "*when used twice daily"+

                                                    "Zero alcohol"+
                                                    "Fresher smiles between brushings"+
                                                    "Clinically tested by dentists"+
                                                    "Contains fluoride for cavity protection"+


                                                    "Safety Warnings"+
                                                    "Do not swallow. Not recommended for children under 6. Keep away from reach of children"+

                                                    "Pack Quantity: 500ml ℮"+

                                                    "Preparation and Usage"+
                                                    "Use Colgate Plax twice a day for a healthier, fresher mouth"+

                                                    "Storage Type: Ambient"+

                                                    "Minimum Age Advisory: 6 Years",

                                ProductPic = "/Content/Images/ColgatePlaxCoolMintMouthwash500ml.jpg"

                            },




                        new Product


                            {

                                ProductName = "Colgate Advanced Whitening Pump Toothpaste 100ml",

                                CategoryId = 6,
                                Category = "Health & Beauty",

                                Price = 4.09m,
                                SupplierId = 21,

                                Supplier = "Colgate Palmolive",

                                ProductDescr =

                                                "Advanced White Toothpaste Pump"+

                                                "Save Water"+
                                                "Turn of the tap while brushing"+

                                                "Colgate Advance White with active micro-cleansing crystals is clinically proven to gently polish and effectively whiten you teeth"+
                                                "It also helps prevent new stains from adhering so your teeth stay whiter for longer"+

                                                "Whiter Teeth in 14 days!"+
                                                "Clinically proven whiter teeth"+
                                                "With micro - cleansing crystals"+

                                                "Pack Quantity: 100ml ℮"+

                                                "Preparation and Usage"+
                                                "Directions for use: Not for use of children under 7 years old.In the unlikely event of the pump not functioning, hold actuator down"+
                                                "whilst pushing up centre of base firmly"+

                                                "Storage type: Ambient"+

                                                "Minimum Age Advisory: 7 Years",

                                ProductPic = "/Content/Images/ColgateWhiteningToothpaste100ml.jpg"

                                },


                        new Product
                        {


                                    ProductName = "NIVEA 2-in-1 Cleanser & Toner",
                                    CategoryId = 6,
                                    Category = "Health & Beauty",

                                    Price = 3.99m,

                                    SupplierId = 22,
                                    Supplier = "Beirdroff UK Ltd",

                                     ProductDescr =
                                                  "Normal and combination skin needs effective moisturisation, even during cleansing: its natural moisture balance should be respected to " +
                                                  "keep it fresh and supple all day long.&#160;Nivea have developed&#160;Nivea Daily Essentials 2 in 1 Cleanser and Toner&#160; to meet the specific"+
                                                  "cleansing needs of normal and combination skin"+

                                                  "Nivea Daily Essentials 2 in 1 Cleanser and Toner&#160; combines 2 cleansing steps in one: mild cleansing and toning:"+
                                                  "Enriched with Lotus Extract & Vitamins it respects the skin&rsquos natural moisture balance while removing impurities and make - up"+
                                                  "The 2 in 1 Express formula cleanses and clarifies in one single step without leaving residue",

                                     ProductPic = "/Content/Images/Nivea2in1CleanserAndToner200ml.jpg"


                                     },





 // Household Items - Category 7


           new Product
                    {
                            ProductName = "Tesco Think Bleach 750ml",
                            CategoryId = 7,
                            Category = "Household",

                            Price = 0.62m,
                            SupplierId = 30,
                            Supplier = "Tesco supplier",

                            ProductDescr =

                                    "Tesco Thick Bleach Fresh 750ml"+
                                    "Kills 99.9 % of bacteria / Eliminates germs & tough stains"+

                                    "Proven to kill bacteria, fungi and the H1N1 flu virus, Helps prevent limescale"+


                                    "Safety Warnings"+
                                    "DANGER"+

                                    "Contains Contains SODIUM HYPOCHLORITE,"+
                                    "SODIUM LAURETH SULFATE,"+
                                    "May be corrosive to metals.,"+
                                    "Causes severe skin burns and eye damage.,"+
                                    "Very toxic to aquatic life with long lasting effects,"+
                                    "If medical advice is needed, have product container or label at hand.,"+
                                    "Keep out of reach of children.,"+
                                    "Read label before use.,"+
                                    "Keep only in original packaging.,"+
                                    "Avoid release to the environment.,"+
                                    "Wear protective gloves / protective clothing / eye protection / face protection.,"+
                                    "IF ON SKIN(or hair): Remove / Take off immediately all contaminated clothing.Rinse skin with water[or shower].,"+
                                    "IF IN EYES: Rinse cautiously with water for several minutes. Remove contact lenses, if present and easy to do.Continue rinsing.,"+
                                    "Immediately call a POISON CENTER / doctor.,"+
                                    "Absorb spillage to prevent material damage.,"+
                                    "Store locked up.,"+
                                    "Dispose of contents/ container in accordance with local requirements for domestic waste disposal.,"+
                                    "Warning!Do not use together with other products.May release dangerous gases(chlorine).",


                            ProductPic = "/Content/Images/TescoThickBleach750ml.jpg"

                    },


           new Product
                    {
                            ProductName = "Tesco Think Bleach Lemon 750ml",
                            CategoryId = 7 ,
                            Category = "Household",

                            Price = 0.62m,
                            SupplierId = 30,
                            Supplier = "Tesco supplier",

                            ProductDescr =

                                    "Tesco Thick Bleach Fresh 750ml"+
                                    "Kills 99.9 % of bacteria / Eliminates germs & tough stains"+

                                    "Proven to kill bacteria, fungi and the H1N1 flu virus, Helps prevent limescale"+


                                    "Safety Warnings"+
                                    "DANGER"+

                                    "Contains Contains SODIUM HYPOCHLORITE,"+
                                    "SODIUM LAURETH SULFATE,"+
                                    "May be corrosive to metals.,"+
                                    "Causes severe skin burns and eye damage.,"+
                                    "Very toxic to aquatic life with long lasting effects,"+
                                    "If medical advice is needed, have product container or label at hand.,"+
                                    "Keep out of reach of children.,"+
                                    "Read label before use.,"+
                                    "Keep only in original packaging.,"+
                                    "Avoid release to the environment.,"+
                                    "Wear protective gloves / protective clothing / eye protection / face protection.,"+
                                    "IF ON SKIN(or hair): Remove / Take off immediately all contaminated clothing.Rinse skin with water[or shower].,"+
                                    "IF IN EYES: Rinse cautiously with water for several minutes. Remove contact lenses, if present and easy to do.Continue rinsing.,"+
                                    "Immediately call a POISON CENTER / doctor.,"+
                                    "Absorb spillage to prevent material damage.,"+
                                    "Store locked up.,"+
                                    "Dispose of contents/ container in accordance with local requirements for domestic waste disposal.,"+
                                    "Warning!Do not use together with other products.May release dangerous gases(chlorine).",


                            ProductPic = "/Content/Images/TescoThickBleach24HourCitrus750ml.jpg"

                    },





                      new Product
                                  {

                                     ProductName = "Tesco Bathroom Spray Cleaner 500ml",
                                     CategoryId = 7,
                                     Category = "Household",

                                     Price = 0.59m,
                                     SupplierId = 30,
                                     Supplier = "Tesco supplier",

                                     ProductDescr =

                                           "Tesco Anti Bac Bathroom Surface Cleaning Spray 500ml"+
                                            "Kills 99.9% of bacteria Cuts through soap scum and limescale"+
                                            "Tesco Anti-Bacterial Bathroom Surface Cleaning Spray Proven to kill 99.9% of bacteria including E. coli, Staph. A, Pseudomonas and MRSA. " +
                                            "Specially formulated for bathroom surfaces",



                                    ProductPic = "/Content/Images/TescoBathroomCleanerSpray500ml.jpg"
                                  },


                      


                         new Product
                          {
                              ProductName = "Tesco Antibacterial Cleaner Spray 500Ml",
                              CategoryId = 7,
                              Category = "Household",

                              Price = 0.62m,
                              SupplierId = 30,
                              Supplier = "Tesco supplier",

                              ProductDescr =

                                        "Tesco Anti Bac Multi Purpose Cleaning Spray 500ml"+
                                        "Kills 99.9% of bacteria Cuts through grease & grime"+
                                        "Tesco anti-bacterial multi-purpose cleaning spray original Proven to kill 99.9% of bacteria including E. coli, Listeria, Salmonella and MRSA. Kills H1N1 flu virus. Kills the Rotavirus A virus. Specially formulated for kitchens, nurseries and bathrooms",

                              
                               ProductPic = "/Content/Images/TescoAntibacterialCleanerSpray500Ml.jpg"
                          },


                         new Product
                          {
                              ProductName = "Tesco Lime scale Remove 750ml",
                              CategoryId = 7,
                              Category = "Household",

                              Price = 1.49m,
                              SupplierId = 30,
                              Supplier = "Tesco supplier",

                              ProductDescr =

                                            "Tesco Limescale Remover Toilet Gel 750ml"+
                                            "Kills 99.9% of bacteria Dissolves 100% of limescale Removes stains"+
                                            "Tesco Limescale Remover Toilet Gel Dissolves 100% of limescale Kills 99.9% of bacteria, viruses and fungi"+


                                            "Safety Warnings"+
                                            "IF SWALLOWED: Rinse mouth. Do NOT induce vomiting.,"+

                                            "May be corrosive to metals.,"+
                                            "Causes severe skin burns and eye damage.,"+
                                            "Harmful to aquatic life with long lasting effects.,"+
                                            "If medical advice is needed, have product container or label at hand.,"+
                                            "Keep out of reach of children.,"+
                                            "Read label before use.,"+
                                            "Keep only in original packaging.,"+
                                            "Avoid release to the environment.,"+
                                            "Wear protective gloves/protective clothing/eye protection/face protection.,"+
                                            "IF ON SKIN (or hair): Remove/Take off immediately all contaminated clothing. Rinse skin with water/shower.,"+
                                            "IF IN EYES: Rinse cautiously with water for several minutes. Remove contact lenses, if present and easy to do.Continue rinsing.,"+
                                            "Immediately call a POISON CENTER / doctor.,"+
                                            "Absorb spillage to prevent material damage.,"+
                                            "Store locked up.,"+
                                            "Dispose of contents/ container in accordance with local requirements on waste disposal.,"+


                                            "Pack Quantity"+
                                            "750ml e"+


                                        "Preparation and Usage"+
                                        "Remove cap by squeezing, pads on either side and unscrew. Always leave the toilet seat in the upright position.Direct carefully around the bowl and " +
                                        "under the rim.Leave for at least 10 minutes to eliminate build - up of limescale.To remove stains, brush with a toilet brush then flush the toilet." +
                                        "For stubborn stains leave overnight.To disinfect, leave for a minimum of 15 minutes, then brush with a toilet brush and flush the toilet.Replace cap " +
                                        "tightly after use.Safe for use with septic tanks."+
                                        "Use only in the toilet bowl.Do not use on stainless steel."+


                                        "Origin Country Name"+
                                        "Belgium",




                          ProductPic = "/Content/Images/TescoLimescaleRemove750ml.jpg"
                          },





                         new Product
                          {
                              ProductName = "Tesco Window Cleaner Spray 500Ml",
                              CategoryId = 7,
                              Category = "Household",

                              Price = 0.45m,
                              SupplierId = 30,
                              Supplier = "Tesco supplier",

                              ProductDescr =

                                        "Tesco Window & Glass Cleaning spray 500ml"+
                                        "Dissolves grease & smudge marks Leaves a streak free shine"+
                                        "Tesco window & glass cleaning spray. Formulated with vinegar to dissolve grease, grime, dirt and smudge marks. Suitable for windows(inside and out),"+
                                        "household appliances, mirrors, tiles and chrome"+

                                        "Pack Quantity: 500ml"+

                                        "Preparation and Usage"+
                                        "Turn the spray nozzle to the ON position.Spray from 20cm.Wipe with a clean cloth.Use only in a well - ventilated area.Direct spray away from"+
                                        "face.Safe for use with septic tanks.After use, return the spray nozzle to the OFF position"+
                                        "Mop up any spillages immediately.Use only as directed.Do not use on LCD and plasma screens.Avoid contact with marble, finished wooden surfaces and " +
                                        "appliance lettering.On surfaces other than glass, mirror, tiles, test on an inconspicuous area first"+

                                        "Origin Country Name: United Kingdom",



                               ProductPic = "/Content/Images/TescoWindowCleanerSpray500ml.jpg"
                          },



                         new Product
                          {
                              ProductName = "Tesco Limescale Prevention Tablets 40 Pack",


                              CategoryId = 7,
                              Category = "Household",

                              Price = 3.25m,
                              SupplierId = 30,
                              Supplier = "Tesco supplier",

                              ProductDescr =

                                      "Tesco Limescale Prevention Tablets 40's"+
                                      "Softens hard water Protects & cleans your machine"+
                                      "Tesco Limescale Prevention Tablets Protects* & cleans** your washing machine with every wash, helping to prevent the build up of limescale and bad odours"+
                                      "*Helps protect heating element from overworking and breaking down. *Helps protect drum and plastic parts from becoming encrusted. **Helps keep"+
                                      "cleaner machine as dirt and detergent residues can rinse away more easily"+

                                    "Safety Warnings"+
                                    "WARNING"+
                                    "Contains"+
                                    "Causes serious eye irritation.,"+
                                    "If medical advice is needed, have product container or label at hand.,"+
                                    "Keep out of reach of children.,"+
                                    "Read label before use.,"+
                                    "Wash hands thoroughly after handling.,"+
                                    "IF IN EYES: Rinse cautiously with water for several minutes. Remove contact lenses, if present and easy to do.Continue rinsing.,"+
                                    "If eye irritation persists: Get medical advice / attention."+

                                    "Quantity"+
                                    "Number of Units - 40"+

                                    "Pack Quantity: 600 g e(40 X 15g)"+

                                    "Preparation and Usage£"+
                                    "Use one tablet per wash in addition to your detergent. Unwrap 1 tablet and place at the back and bottom of the washing machine drum before adding garments. " +
                                    "Not suitable for pre - wash programmes.Pull tab to open.Close box after use"+
                                    "Do not break or crush tablets"+

                                    "Origin Country Name: Luxembourg",



                               ProductPic = "/Content/Images/TescoLimescalePreventionTablets40Pack.jpg"
                          },




            // Pets - Category 8


                            new Product
                                  {
                                      ProductName = "WhiskasPoultryCatFoodPouches",
                                      CategoryId = 8,
                                      Category = "Pets",

                                      Price = 4.19m,

                                      SupplierId = 26,
                                      Supplier = "Mars Ireland",
                                      ProductDescr =

                                            "Complete Pet Food for Adult Cats"+

                                            "Whiskas® delicious meals and cat treats are formulated for your cat's diet"+
                                            "100 % Complete and Balanced pet food"+
                                            "12x100g Whiskas wet cat food pouches for adult felines"+
                                            "Whiskas cat food pouches, Poultry Selection in Jelly"+
                                            "Delicious cat food slices for a convenient and fresh meal"+

                                            "Our WHISKAS® 1 + range offers a variety of tailored meals, that are perfectly balanced to help your cat stay happy and healthy"+
                                            "Our tasty meals, made with a combination of selected ingredients + vitamins + minerals, provide everything she nutritionally needs for a healthy life"+


                                            "At the WHISKAS® brand we understand what your cat naturally needs and loves.That's why we use delicious, nutritious ingredients she'll " +
                                            "instinctively love.All WHISKAS® cat food recipes are carefully prepared to give your cat everything she naturally needs at each stage of her life, " +
                                            "keeping her happy and healthy from kitten through to senior.Developed by our experts at Waltham,"+
                                            "the world's leading authority on petcare and nutrition, each cat food meal is complete and balanced to help you provide the best possible care for your cat"+
                                            "And with our variety, she can enjoy something different each day."+


                                            "Delicious cat food slices for a convenient and fresh meal"+
                                            "Wet cat food pouches for adult cats made with carefully prepared recipes"+
                                            "With zinc and sunflower oil, a natural source of omega 6 fatty acids, which help to support a healthy skin & coat"+
                                            "With balanced mineral levels to support urinary tract health"+
                                            "Nutritionally complete & balanced to help her stay happy and healthy"+

                                            "Quantity"+
                                            "Number of Units - 12"+

                                            "Pack Quantity"+
                                            "12 x 100g ℮",


                                        ProductPic = "/Content/Images/WhiskasPoultryCatFoodPouches.jpg"
                                  },




                               new Product
                                  {
                                      ProductName = "Whiskas Fish Tinned Cat Food 6x390g ",
                                      CategoryId = 8,
                                      Category = "Pets",

                                      Price = 6.49m,
                                      SupplierId = 26,
                                      Supplier = "Mars Ireland",

                                      ProductDescr =

                                          "Complete pet food of adult cats"+

                                            "Whiskas® delicious meals and cat treats are formulated for your cat's diet"+

                                            "100 % Complete and Balanced pet food"+
                                            "6 x 390g Can Whiskas wet cat food for adult cats"+

                                            "Fish Selection in Jelly Whiskas cat food tins"+
                                            "Cat food contains no artificial colours, flavours or preservatives"+
                                            "Cat food with mouth - watering morsels in a juicy jelly.Best served together with WHISKAS® dry cat food to provide a full and balanced diet for your" +
                                            "adult cat.Available in 390g WHISKAS® cat food tins"+

                                            "At the WHISKAS® brand we understand what your cat naturally needs and loves.That's why we use delicious, nutritious ingredients she'll instinctively " +
                                            "love.All WHISKAS® cat food recipes are carefully prepared to give your cat everything she naturally needs at each stage of her life, keeping her happy " +
                                            "and healthy from kitten through to senior.Developed by our experts at The Waltham Centre for Pet Nutrition, the world's leading authority on petcare and " +
                                            "nutrition, each cat food meal is complete and balanced to help you provide the best possible care for your cat. And with our variety, she can enjoy " +
                                            "something different each day."+

                                            "WHISKAS® cat food with mouth - watering morsels in a juicy jelly for a scrumptious meal they'll love"+
                                            "6 x 390g cat food cans for adult cats made with carefully prepared recipes using"+
                                            "With balanced mineral levels to support a healthy urinary tract"+
                                            "With zinc which helps ensure a healthy skin &coat"+
                                            "No added artificial flavours, colours or preservatives"+


                                            "Quantity"+
                                            "Number of Units -6"+

                                            "Pack Quantity"+
                                            "6 x 390g ℮",


                                      ProductPic = "/Content/Images/WhiskasFishTinnedCatFood6x390g.jpg"
                                  },




                                  new Product{


                                      ProductName = "Whiskas Meat Jelly Cat Food Pouches 12x100g",
                                      CategoryId = 8,
                                      Category = "Pets",

                                      Price = 4.19m,
                                      SupplierId = 26,
                                      Supplier = "Mars Ireland",

                                      ProductDescr =

                                            "Complete Pet Food for Adult Cats."+

                                            "Whiskas® delicious meals and cat treats are formulated for your cat's diet"+

                                            "100 % Complete and Balanced pet food"+

                                            "12x100g Whiskas wet cat food pouches for adult felines"+

                                            "Whiskas cat food pouches, Meaty Selection in Jelly"+

                                            "Succulent cat food slices for a convenient and fresh meal.Everything your adult cat naturally needs to live happy and healthy " +
                                            "in her adult life. Available in 100g WHISKAS® individual packets"+

                                            "At the WHISKAS® brand we understand what your cat naturally needs and loves.That's why we use delicious, nutritious ingredients" +
                                            "she'll instinctively love"+

                                            "All WHISKAS® cat food recipes are carefully prepared to give your cat everything she naturally needs at each stage of her life, " +
                                            "keeping her happy and " +
                                            "healthy from kitten through to senior.Developed by our experts at The Waltham Centre for Pet Nutrition, the world's leading authority" +
                                            "on petcare " +
                                            "and nutrition, each cat food meal is complete and balanced to help you provide the best possible care for your cat. And with our "+
                                            "variety, she can enjoy " +
                                            "something different each day"+

                                            "Yummy cat food slices for a convenient and fresh meal 12 x 100g moist cat food pouches for adult cats made with carefully prepared " +
                                            "recipes"+
                                            "100 % complete and balanced meal with no artificial flavours, colours or preservatives"+
                                            "With balanced mineral levels to support a healthy urinary tract and Zinc which helps ensure a healthy skin & coat"+
                                            "WHISKAS® cat food pouch contains nutritious and tasty pieces to give your cat the meals she loves"+
                                            "Quality, protein ingredients in every single meal, ideal for everyday feeding"+
                                            "Simple, nutritional cuisine suitable for all breeds that contribute towards your special pets wellness",


                                   ProductPic = "/Content/Images/WhiskasMeatJellyCatFoodPouches12x100g.jpg"


                                  },



                             new Product

                                  {
                                      ProductName = "Whiskas Cat Milk 3 x 200ml",
                                      CategoryId = 8,
                                      Category = "Pets",

                                      Price = 3.39m,
                                      SupplierId = 26,
                                      Supplier = "Mars Ireland",

                                      ProductDescr =

                                                "Complementary pet food for cats and kittens over 6 weeks old"+

                                                "Whiskas® delicious cat food and cat treats are formulated for your cat's diet"+

                                                "3 x 200ml Whiskas cat milk perfect for your kitten and adult cat"+

                                                "Great taste your pet will love"+

                                                "Cat treat free from any artificial colours, flavours or preservatives"+

                                                "Whiskas® Cat Milk is specially made with reduced lactose so that it is good for indoor domestic cats.Unlike regular milk"+
                                                "As a family owned Irish company since 1901, we understand the importance of tea in Ireland. In fact we have spent years perfecting our signature Gold Blend,"+
                                                "a unique blend that has been passed on through generations of our family. Since the beginning our Master Blender has never compromised in his absolute"+
                                                "commitment to fine the quality tea. Our Master Blender tastes our blends three times a day to ensure that every moment you spend with our tea is as rewarding"+
                                                "as the last"+

                                                "For over 110 years, our tea journey has always begun in the world's finest tea gardens"+
                                                "That's why at every harvest, we get first pick of the most exceptional teas, sourcing the finest leaves from Kenya, Rwanda and the Assam Valley of India to"+
                                                "give Barry's Tea its much loved taste and unmistakable quality"+

                                                "Expertly blended in Ireland since 1901"+

                                                "Expertly blended in Ireland"+
                                                "Our most loved signature blend"+
                                                "Every cup tells a story"+


                                                "Pack Quantity: 250g ℮"+
                                                "Usage Text: Serving size one teabag per cup, 80 servings per box of teabags"+

                                                "Usage Count: 80 Servings ,It has been specially " +
                                                "developed by top nutritionists and veterinarians to contain less than 0.2 % lactose.Cats love the yummy taste of Whiskas® Cat Milk and because " +
                                                "it contains calcium and vitamins every lap is full of goodness.Whiskas® Cat Milk - Deliciously Good.Easy addition to everyday feeding routines" +

                                                "At the WHISKAS® brand we understand what your cat naturally needs and loves.That's why we use delicious, nutritious ingredients she'll instinctively love." +
                                                "All WHISKAS® cat food recipes are carefully prepared to give your cat everything she naturally needs at each stage of her life, keeping her happy and " +
                                                "healthy from kitten through to senior.Developed by our experts at The Waltham Centre for Pet Nutrition, the world's leading authority on petcare and " +
                                                "nutrition, each cat food meal is complete and balanced to help you provide the best possible care for your cat. And with our variety, she can enjoy " +
                                                "something different each day"+


                                                "Whiskas® Cat Milk has a great taste your cat will love!"+
                                                "It a healthier alternative for cats and kittens, developed by top nutritionists which contains less than 0.2 % lactose"+
                                                "This ensures your feline friend won't have stomach any problems because Whiskas® Cat Milk contains low lactose compared to cow's milk"+
                                                "Balanced mineral levels to treat your cat to all the best stuff they need, like calcium, fibre and protein"+
                                                "Free from any artificial colours, flavours or preservatives",



                                   ProductPic = "/Content/Images/WhiskasCatMilk3x200ml.jpg"


                                  },



                             new Product

                                  {
                                      ProductName = "Pedigree Can Tinned Food 12x385g",
                                      CategoryId = 8,
                                      Category = "Pets",

                                      Price = 13.09m,
                                      SupplierId = 26,
                                      Supplier = "Mars Ireland",

                                      ProductDescr =


                                                    "Complete Wet pet food for adult dogs"+

                                                    "Pedigree® offer a complete range of tasty and wholesome dog food and dog treats"+

                                                     "100 % Complete and Balanced pet food"+
                                                     "12 x 385g Pedigree wet dog food for Adult dogs"+

                                                     "Mixed Selection in Jelly Pedigree dog food tins"+

                                                    "Dog food contains no artificial colours, flavours or preservatives"+
                                                    "100 % complete and balanced, Pedigree tins are not only nutritious wet dog food but also make for highly enjoyable everyday meals that " +
                                                    "will bring out their infectious enthusiasm"+

                                                    "Developed with the help of vets and nutritionists at Waltham Pet Nutrition Centre, Pedigree dog food has all the essential nutrients to " +
                                                    "support optimal digestion, a healthy skin and coat, strong natural defences and healthy bones"+

                                                    "Pedigree tinned dog food contains no artificial colorants, flavours or preservatives"+

                                                    "At Pedigree, we believe that dogs are good for us.Every day, their wonderful innocence brings out the good in us"+
                                                    "Pedigree's complete range of tasty and healthy dog food and dog treats delivers everything that is essential to support, protect and spark all " +
                                                    "dogs' exuberant love of life"+
                                                    "So that day after day, dog owners can feed the good in their dogs"+
                                                    "With a wide range of tasty, complete and balanced dog food meals, Pedigree has everything all dogs need to thrive.Meals that taste good " +
                                                    "in ways that get tails wagging, and feed the good in ways you can see"+

                                                    "100 % Complete and delicious wet dog food for adult dogs"+
                                                    "Served on its own or on top of dry dog food, it makes for enjoyable healthy meals"+
                                                    "Nutrition for dogs that helps support healthy bones, good digestion, a healthy skin & coat and a strong natural defences"+
                                                    "Dog food developed with our vets and nutritionists at Waltham Pet Nutrition Centre"+
                                                    "This pet food contains no artificial colours, flavours or preservatives"+

                                                    "Quantity"+
                                                    "Number of Units - 12"+


                                                    "Pack Quantity"+
                                                    "12 x 385g ℮",



                                        ProductPic = "/Content/Images/PedigreeCanTinnedFood12x385g.jpg"


                                  },




                                new Product

                                  {
                                      ProductName = "PedigreeBeefVegetableDryFood2.6kg",
                                      CategoryId = 8,
                                      Category = "Pets",

                                      Price = 8.99m,
                                      SupplierId = 26,
                                      Supplier = "Mars Ireland",

                                      ProductDescr =

                                                        "Complete pet food for adult dogs"+
                                                        "Pedigree® offer a complete range of tasty and wholesome dog food and dog treats"+

                                                        "100 % Complete and Balanced pet food"+
                                                        "2.6kg Pedigree complete dry food for Adult dogs"+

                                                        "Pedigree dry dog food with Beef and Vegetables"+
                                                        "Dog food contains no artificial colours, flavours or preservatives"+

                                                        "100 % complete and balanced, Pedigree Vital Protection is a tasty and nutritious Dry dog food perfect for everyday meals"+
                                                        "Developed with the help of vets and nutritionists at Waltham Centre for Pet Nutrition, Pedigree dry dog food has all the essential nutrients " +
                                                        "to support optimal digestion, a healthy skin and coat, a strong natural defences and good dental care"+

                                                        "The special texture of the kibbles helps clean and support healthy teeth in adult dogs and is ideal to complement a daily oral care routine"+
                                                        "At Pedigree, we believe that dogs are good for us.Every day, their wonderful innocence brings out the good in us"+

                                                        "Pedigree's complete range of tasty and healthy dog food and dog treats delivers everything that is essential to support, protect and spark " +
                                                        "all dogs' exuberant love of life So that day after day, dog owners can feed the good in their dogs"+

                                                        "With a wide range of tasty, complete and balanced dog food meals, Pedigree has everything all dogs need to thrive.Meals that taste good in ways " +
                                                        "that get tails wagging, and feed the good in ways you can see."+


                                                        "100 % complete and balanced, tasty dry dog food for adult dogs"+
                                                        "Nutrition for dogs that helps support oral care, a good digestion, a healthy skin & coat and strong natural defences"+
                                                        "Dry dog food Kibbles with a special texture that helps clean and support healthy teeth"+
                                                        "Pet food developed with our vets and nutritionists at Waltham Centre for Pet Nutrition"+

                                                        "No artificial colours or flavours"+

                                                        "Safety Warnings"+
                                                        "To avoid suffocation, keep bags away from babies, young children and pets"+

                                                        "Pack Quantity: 2.6kg ℮",



                                        ProductPic = "/Content/Images/PedigreeBeefVegetableDryFood2.6kg.jpg"

                                        },



                         new Product

                                  {
                                      ProductName = "Pedigree Large Dog Dentastix Daily Chews 28 Sticks",
                                      CategoryId = 8,
                                      Category = "Pets",

                                      Price = 8.99m,
                                      SupplierId = 26,
                                      Supplier = "Mars Ireland",

                                      ProductDescr =

                                                    "Complementary pet food for dogs over 4 months"+

                                                    "Pack of chewable DentaStix® dog chews"+
                                                    "Pedigree® DentaStix® dental sticks are recommended by Vet and developed with the help of vets and nutritionists at Waltham™ Centre for Pet Nutrition"+

                                                    "Pedigree® -feed the good in your dog"+
                                                    "28 chewy dog sticks"+

                                                    "Complementary pet food"+

                                                    "Pedigree® Daily DentaStix® are uniquely X shaped dental sticks that are scientifically proven to help reduce tartar build - up by up to 80 %, when fed daily"+
                                                    "Pedigree® Daily DentaStix® are designed to be chewed for long enough to be effective, with a gently abrasive texture and active ingredients that help to reduce" +
                                                    "the build - up of plaque and tartar"+

                                                    "Dog oral hygiene is equally as important as ours"+
                                                    "Dogs use their mouth for everything, so having healthy teeth and gums is absolutely essential for them to be the best version of themselves"+
                                                    "With the help of vets and nutritionists at Waltham™ Centre for Pet Nutrition, Pedigree® has developed a range of tasty dog chews that reduce plaque and tartar"+
                                                    "build-up"+

                                                    "At Pedigree®, we believe that dogs are good for us.Every day, their wonderful innocence brings out the good in us"+
                                                    "The Pedigree® complete range of tasty and wholesome dog food and dog treats delivers everything that is essential to support and fuel all dogs' exuberant"+
                                                    "love of life. So that day after day, dog owners can feed the good in their dogs"+

                                                    "DentaStix® dog chews are scientifically proven to reduce tartar build up by up to 80 % when fed daily"+
                                                    "The combination of special chewy texture and active ingredients is what makes Pedigree® DentaStix® dog chews effective"+
                                                    "Dental Dog treats that are low in fat, with no added sugar and free from artificial colours and flavours, ideal for everyday"+
                                                    "Super tasty pet chews available in different sizes to provide oral care for small, medium and large canine dogs"+

                                                            "Low in fat With no added sugar"+

                                                            "Quantity: Number of Units - 4"+

                                                            "Pack Quantity: 4 x 270g ℮"+

                                                            "Preparation and Usage"+
                                                            "Feeding instructions: Large dogs, e.g.Labrador, feed 1 stick per day.This is a chewy treat that is not suitable for dogs under 25 kg or for young puppies" +
                                                            "under 4 months. Fresh drinking water should always be available",



                                        ProductPic = "/Content/Images/PedigreeLargeDogDentasticChews28sticks.jpg"

                                        },






            // Home Entertainment - Category 9


                           new Product {


                                         ProductName = "Tresemme Fast Dry 2000",
                                         CategoryId = 9,
                                         Category = "Home Ent",

                                         Price = 15.00M,

                                         SupplierId =  30,
                                         Supplier = "Tesco supplier",

                                         ProductDescr = "Lightweight and compact, the TreSemmé Fast Dry 2000 is a powerful 2000W hairdryer that delivers a fast airflow meaning less time drying,"+
                                                    "more time styling and perfecting your desired look. Equipped with a cool shot button for minimising frizz, the hairdryer also comes with a"+
                                                    "concentrator nozzle for a polished finish and an easy clean filter for fuss-free maintenance"+

                                                    "2000W power output"+
                                                    "Cool shot button"+
                                                    "1.8m cord length"+

                                                    "Quantity"+
                                                    "Number of Units - 1",



                                        ProductPic = "/Content/Images/TresemmeFastDry2000.jpg"

                            },



                           new Product {

                                         ProductName = "Tesco Aluminium Frying Pan 30cm",
                                         CategoryId = 9,
                                         Category = "Home Ent",

                                         Price = 1.90M,

                                         SupplierId =  30,

                                         Supplier = "Tesco supplier",

                                         ProductDescr = "- Suitable for all hob types including induction"+
                                                    "- Non Stick"+
                                                    "- Dishwasher safe"+

                                                    "Tesco's Aluminium range provides exceptional non-stick performance and durability. The aluminium coating ensures heat is distributed evenly " +
                                                    "and also makes it compatible with all heat sources, including induction"+

                                                    "Quantity - Number of Units - 1",

                                        ProductPic = "/Content/Images/TescoAluminiumFryingPan30cm.jpg"

                            },


                           new Product {


                                         ProductName = "Tesco Aluminium Saucepan 20cm",
                                         CategoryId = 9,
                                         Category = "Home Ent",

                                         Price = 1.90M,

                                         SupplierId =  30,
                                         Supplier = "Tesco supplier",

                                         ProductDescr = "  - Suitable for all hob types including induction"+
                                                    "- Non Stick"+
                                                    "- Dishwasher safe"+

                                                    "Tesco's Aluminium range provides exceptional non-stick performance and durability"+
                                                    "The aluminium coating ensures heat is distributed evenly and also makes it compatible with all heat sources, including induction"+

                                                    "Quantity"+
                                                    "Number of Units - 1",


                                        ProductPic = "/Content/Images/TescoAluminiumSaucepan20cm.jpg"

                            },

                     

         //Other products category



                           new Product {


                                        ProductName = "Tesco A4 Dividers",

                                        CategoryId = 10,
                                        Category = "Other",

                                        Price = 1.90M,

                                        SupplierId =  30,
                                        Supplier = "Tesco supplier",

                                        ProductDescr = "Keep both your notes and important documents organised with this pack of 10 A4 file subject dividers from Tesco"+
                                                    "Including 5 different colours, each A4 subject divider features a tab for easy organisation"+

                                                    "Quantity - Number of Units - 1",

                                        ProductPic = "/Content/Images/TescoA4Dividers10.jpg"

                            },





                           new Product {


                                        ProductName = "Tesco A4 Dividers 10",
                                        CategoryId = 10,
                                        Category = "Other",

                                        Price = 1.90M,

                                        SupplierId =  30,
                                        Supplier = "Tesco supplier",

                                        ProductDescr = "Tesco 68 pc Fitted Sheet Double Teal, White, Grey, Cream, Navy, Red, Mocha, Black"+
                                                    "52% POLYESTER 48% COTTON"+

                                                    "Quantity: Number of Units - 1"+

                                                    "Preparation and Usage"+
                                                    "WASH BAFORE USE WASH SIMILAR COLOR TOGETHER COLOR SAFE DETERGENTS RECOMMENDED IRON ON REVERSE FOR A PRISTINE FINISH IF REQUIRED"+
                                                    "MAXIMUM TEMPERATURE 40 C GENTLE WASH DO NOT BLEACH TUMBLE DRY LOW HEAT IRON WARM DO NOT DRY CLEAN",

                                        ProductPic = "/Content/Images/TescoA4Dividers10.jpg"

                                        },

                             new Product {


                                        ProductName = "Tesco Synthetic Oil 4L",
                                        CategoryId = 10,
                                        Category = "Other",

                                        Price = 26.00M,

                                        SupplierId =  30,
                                        Supplier = "Tesco supplier",

                                        ProductDescr =  "Lower ash content to reduce particulate build up - Reduces environmental impact through reduced emissions"+
                                                     "Suitable for petrol & diesel engines",


                                        ProductPic = "/Content/Images/TescoSyntheticOil4L.jpg"

                            },



                                    new Product {


                                        ProductName = "Tesco 3D Leaf New Car Air Freshener",
                                        CategoryId = 10,
                                        Category = "Other",

                                        Price = 26.00M,

                                        SupplierId =  30,
                                        Supplier = "Tesco supplier",

                                        ProductDescr =

                                                        "T. 3D LEAF NEW CAR"+

                                                        "- Long-Lasting Fragrance"+
                                                        "- 3D design"+
                                                        "- Modern look"+

                                                    "Scented polymer freshener for air vent grill packed in blister pack"+

                                                    "Safety Warnings"+
                                                    "1-(1,2,3,4,5,6,7,8-octahydro-2,3,8,8-tetramethyl-2-naphthyl)ethan-1-one, Benzyl salicylate, Citronellol, Coumarin, d-limonene, Eugenol,"+
                                                    "Hexyl cinnam-aldehyde, Linalool,"+

                                                    "according to the separated collection system used in your municipality."+

                                                    "Quantity"+
                                                    "Number of Units - 1"+

                                                    "Pack Quantity"+
                                                    "13 g"+

                                                    "Preparation and Usage"+
                                                    "Remove the product from its packaging.Hang the product freely so it does not obstruct the driver’s vision.Avoid direct product with"+
                                                    "surfaces.Damage may occur if used incorrectly"+

                                                    "Recycling Info"+
                                                    "Backing - Card widely recycled"+
                                                    "Blister - Plastic check local recycling",

                                        ProductPic = "/Content/Images/Tesco3DLeafNewCarAirFreshener.jpg"

                            },




                        new Product {


                                        ProductName = "Irish Daily Star Newspaper",
                                        CategoryId = 10,
                                        Category = "Other",

                                        Price = 1.60M,

                                        SupplierId = 30,
                                        Supplier = "Tesco supplier",

                                        ProductDescr = "The Irish Daily Star Newspaper delivered every day at Tesco supermarket outlets for all our customers",
                                        ProductPic = "/Content/Images/IrishDailyStarNewspaper.jpg"

                            },



                        new Product {


                                        ProductName = "Daily Mirror Newspaper",
                                        CategoryId = 10,
                                        Category = "Other",

                                        Price = 1.40M,

                                        SupplierId = 30,
                                        Supplier = "Tesco supplier",

                                        ProductDescr = "The Daily Mirror Newspaper delivered every day at Tesco supermarket outlets for all our customers",
                                        ProductPic = "/Content/Images/DailyMirrorNewspaper.jpg"

                                    },



                        new Product {


                                        ProductName = "John Player Blue 2O cigarettes",
                                        CategoryId = 10,
                                        Category = "Other",

                                        Price = 12.50M,

                                        SupplierId = 30,
                                        Supplier = "Tesco supplier",

                                        ProductDescr = "John Player cigarettes delivered weekly at Tesco supermarket outlets for all our customers",
                                        ProductPic = "/Content/Images/JohnPlayerBlue2O.jpg"

                                    },



                new Product {

                                    ProductName = "Carrolls Number One 2O cigarettes",
                                    CategoryId = 10,
                                    Category =  "Other",

                                    Price = 13.00M,
                                    SupplierId = 30,
                                    Supplier = "Tesco supplier",

                                    ProductDescr = "Carrolls Number One cigarettes 20 delivered weekly at Tesco supermarket outlets for all our customers",
                                    ProductPic = "/Content/Images/CarrollsNumberOne2O.jpg"

                            },




                new Product {

                                    ProductName = "Rothmans King Size Original 2O cigarettes",
                                    CategoryId = 10,
                                    Category = "Other",

                                    Price = 13.00M,
                                    SupplierId = 30,
                                    Supplier = "Tesco supplier",

                                    ProductDescr = "Carrolls King Size Original 2O delivered weekly at Tesco supermarket outlets for all our customers"+

                                                "Original Cigarettes"+

                                                "Quantity"+
                                                "Number of Units - 20"+

                                                "Pack Quantity"+
                                                "20 x Cigarettes"+

                                                "Storage type: Ambient"+

                                                "Minimum Age Statutory: 18 Years"+
                                                "Minimum Age Statutory:  18 Years",


                                    ProductPic = "/Content/Images/RothmansKingSizeOriginal2O.jpg"

                            },


                

                   new Product {

                                    ProductName = "Marie Claire",
                                    CategoryId = 10,
                                    Category = "Other",

                                    Price = 5.64M,
                                    SupplierId = 30,
                                    Supplier = "Tesco supplier",

                                    ProductDescr = "Marie Claire puts a strong emphasis on fashion but also covers many items of interest to the intelligent woman including"+
                                                "in depth reports on subjects of current and international concern. Marie Claire puts a high priority on quality whether it be paper,"+
                                                "printing, photographs or editorial. It's target market is ABC1 women ranging in age from 20+.",


                                    ProductPic = "/Content/Images/MarieClaireMagazine.jpg"

                            },




                   new Product {

                                    ProductName = "AmateurPhotographer",
                                    CategoryId = 10,
                                    Category = "Other",

                                    Price = 13.00M,
                                    SupplierId = 1,
                                    Supplier = "Tesco supplier",

                                    ProductDescr = "Amateur Photographer magazine delivered every week at Tesco supermarket outlets for all our customers",
                                    ProductPic = "/Content/Images/AmateurPhotographer.jpg"

                            },




                   new Product {

                                    ProductName = "Red Travel Edition",
                                    CategoryId = 10,
                                    Category = "Other",

                                    Price = 13.00M,
                                    SupplierId = 1,
                                    Supplier = "Tesco supplier",

                                    ProductDescr = "Red Travel Edition magazine delivered weekly at Tesco supermarket outlets for all our customers",
                                    ProductPic = "/Content/Images/RedTravelEdition.jpg"

                            },



                        };



            //  Now I call the method to return the products that I have created above all entries


            return products;


        }



            //   }.ForEach(a => context.Products.Add(a));



                
        }
    }










            
 
 
 
 