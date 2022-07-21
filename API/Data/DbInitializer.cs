using System.Collections.Generic;
using System.Linq;
using API.Entities;
using Microsoft.AspNetCore.Identity;

namespace API.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(StoreContext context, UserManager<User> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new User  
                {
                    UserName = "Linda",
                    Email = "Linda@test.com"
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
                await userManager.AddToRoleAsync(user, "Member");

                var admin = new User  
                {
                    UserName = "Admin",
                    Email = "Admin@test.com"
                };

                await userManager.CreateAsync(admin, "Pa$$w0rd");
                await userManager.AddToRolesAsync(admin, new[] {"Member", "Admin"});
            }


            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Gray Angular Boots",
                    Description =
                        "These affordable boots are perfect for snow. They will keep your feet warm while adding a bit of style to your outfit.",
                    Price = 4000,
                    PictureUrl = "/images/products/Boots/Boots-Angular1.png",
                    Brand = "Angular",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                                new Product
                {
                    Name = "Red Angular Boots",
                    Description =
                        "These affordable boots are perfect for snow. They will keep your feet warm while adding a bit of style to your outfit.",
                    Price = 4000,
                    PictureUrl = "/images/products/Boots/Boots-Angular2.png",
                    Brand = "Angular",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                                new Product
                {
                    Name = "Orange Angular Boots",
                    Description =
                        "These affordable boots are perfect for snow. They will keep your feet warm while adding a bit of style to your outfit.",
                    Price = 4000,
                    PictureUrl = "/images/products/Boots/Boots-Angular3.png",
                    Brand = "Angular",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                                new Product
                {
                    Name = "Yellow Angular Boots",
                    Description =
                        "These affordable boots are perfect for snow. They will keep your feet warm while adding a bit of style to your outfit.",
                    Price = 4000,
                    PictureUrl = "/images/products/Boots/Boots-Angular4.png",
                    Brand = "Angular",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                                new Product
                {
                    Name = "Green Angular Boots",
                    Description =
                        "These affordable boots are perfect for snow. They will keep your feet warm while adding a bit of style to your outfit.",
                    Price = 4000,
                    PictureUrl = "/images/products/Boots/Boots-Angular5.png",
                    Brand = "Angular",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                                new Product
                {
                    Name = "Light Blue Angular Boots",
                    Description =
                        "These affordable boots are perfect for snow. They will keep your feet warm while adding a bit of style to your outfit.",
                    Price = 4000,
                    PictureUrl = "/images/products/Boots/Boots-Angular6.png",
                    Brand = "Angular",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                                new Product
                {
                    Name = "Blue Angular Boots",
                    Description =
                        "These affordable boots are perfect for snow. They will keep your feet warm while adding a bit of style to your outfit.",
                    Price = 4000,
                    PictureUrl = "/images/products/Boots/Boots-Angular7.png",
                    Brand = "Angular",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                                new Product
                {
                    Name = "Pink Angular Boots",
                    Description =
                        "These affordable boots are perfect for snow. They will keep your feet warm while adding a bit of style to your outfit.",
                    Price = 4000,
                    PictureUrl = "/images/products/Boots/Boots-Angular8.png",
                    Brand = "Angular",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                                new Product
                {
                    Name = "White Angular Boots",
                    Description =
                        "These affordable boots are perfect for snow. They will keep your feet warm while adding a bit of style to your outfit.",
                    Price = 4000,
                    PictureUrl = "/images/products/Boots/Boots-Angular9.png",
                    Brand = "Angular",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                                new Product
                {
                    Name = "Brown Angular Boots",
                    Description =
                        "These affordable boots are perfect for snow. They will keep your feet warm while adding a bit of style to your outfit.",
                    Price = 4000,
                    PictureUrl = "/images/products/Boots/Boots-Angular10.png",
                    Brand = "Angular",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                                new Product
                {
                    Name = "Purple Angular Boots",
                    Description =
                        "These affordable boots are perfect for snow. They will keep your feet warm while adding a bit of style to your outfit.",
                    Price = 4000,
                    PictureUrl = "/images/products/Boots/Boots-Angular11.png",
                    Brand = "Angular",
                    Type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Gray Code Gloves",
                    Description =
                        "These touch-screen compatible gloves are perfect for keeping your hands warm and using your mobile device efficiently. These gloves are warm enough to handle all but the chilliest sub-zero days.",
                    Price = 1500,
                    PictureUrl = "/images/products/Gloves/Glove-Code1.png",
                    Brand = "VS Code",
                    Type = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Red Code Gloves",
                    Description =
                        "These touch-screen compatible gloves are perfect for keeping your hands warm and using your mobile device efficiently. These gloves are warm enough to handle all but the chilliest sub-zero days.",
                    Price = 1500,
                    PictureUrl = "/images/products/Gloves/Glove-Code2.png",
                    Brand = "VS Code",
                    Type = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Orange Code Gloves",
                    Description =
                        "These touch-screen compatible gloves are perfect for keeping your hands warm and using your mobile device efficiently. These gloves are warm enough to handle all but the chilliest sub-zero days.",
                    Price = 1500,
                    PictureUrl = "/images/products/Gloves/Glove-Code3.png",
                    Brand = "VS Code",
                    Type = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Yellow Code Gloves",
                    Description =
                        "These touch-screen compatible gloves are perfect for keeping your hands warm and using your mobile device efficiently. These gloves are warm enough to handle all but the chilliest sub-zero days.",
                    Price = 1500,
                    PictureUrl = "/images/products/Gloves/Glove-Code4.png",
                    Brand = "VS Code",
                    Type = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Green Code Gloves",
                    Description =
                        "These touch-screen compatible gloves are perfect for keeping your hands warm and using your mobile device efficiently. These gloves are warm enough to handle all but the chilliest sub-zero days.",
                    Price = 1500,
                    PictureUrl = "/images/products/Gloves/Glove-Code5.png",
                    Brand = "VS Code",
                    Type = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Light Blue Code Gloves",
                    Description =
                        "These touch-screen compatible gloves are perfect for keeping your hands warm and using your mobile device efficiently. These gloves are warm enough to handle all but the chilliest sub-zero days.",
                    Price = 1500,
                    PictureUrl = "/images/products/Gloves/Glove-Code6.png",
                    Brand = "VS Code",
                    Type = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Blue Code Gloves",
                    Description =
                        "These touch-screen compatible gloves are perfect for keeping your hands warm and using your mobile device efficiently. These gloves are warm enough to handle all but the chilliest sub-zero days.",
                    Price = 1500,
                    PictureUrl = "/images/products/Gloves/Glove-Code7.png",
                    Brand = "VS Code",
                    Type = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pink Code Gloves",
                    Description =
                        "These touch-screen compatible gloves are perfect for keeping your hands warm and using your mobile device efficiently. These gloves are warm enough to handle all but the chilliest sub-zero days.",
                    Price = 1500,
                    PictureUrl = "/images/products/Gloves/Glove-Code8.png",
                    Brand = "VS Code",
                    Type = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "White Code Gloves",
                    Description =
                        "These touch-screen compatible gloves are perfect for keeping your hands warm and using your mobile device efficiently. These gloves are warm enough to handle all but the chilliest sub-zero days.",
                    Price = 1500,
                    PictureUrl = "/images/products/Gloves/Glove-Code9.png",
                    Brand = "VS Code",
                    Type = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Brown Code Gloves",
                    Description =
                        "These touch-screen compatible gloves are perfect for keeping your hands warm and using your mobile device efficiently. These gloves are warm enough to handle all but the chilliest sub-zero days.",
                    Price = 1500,
                    PictureUrl = "/images/products/Gloves/Glove-Code10.png",
                    Brand = "VS Code",
                    Type = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Purple Code Gloves",
                    Description =
                        "These touch-screen compatible gloves are perfect for keeping your hands warm and using your mobile device efficiently. These gloves are warm enough to handle all but the chilliest sub-zero days.",
                    Price = 1500,
                    PictureUrl = "/images/products/Gloves/Glove-Code11.png",
                    Brand = "VS Code",
                    Type = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Gray Core Snowboard",
                    Description =
                        "This snowboard is a versatile, easy-to-love all-mountain ride that doesn't penalize you for little mistakes. With a softer flex and Bite Free Edges, it helps make the most of every day on the mountain - perfect for expanding your range of abilities and moving up the learning curve with confidence.",
                    Price = 7500,
                    PictureUrl = "/images/products/Snowboards/Snowboard-Core1.png",
                    Brand = "NetCore",
                    Type = "Snowboards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Red Core Snowboard",
                    Description =
                        "This snowboard is a versatile, easy-to-love all-mountain ride that doesn't penalize you for little mistakes. With a softer flex and Bite Free Edges, it helps make the most of every day on the mountain - perfect for expanding your range of abilities and moving up the learning curve with confidence.",
                    Price = 7500,
                    PictureUrl = "/images/products/Snowboards/Snowboard-Core2.png",
                    Brand = "NetCore",
                    Type = "Snowboards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Orange Core Snowboard",
                    Description =
                        "This snowboard is a versatile, easy-to-love all-mountain ride that doesn't penalize you for little mistakes. With a softer flex and Bite Free Edges, it helps make the most of every day on the mountain - perfect for expanding your range of abilities and moving up the learning curve with confidence.",
                    Price = 7500,
                    PictureUrl = "/images/products/Snowboards/Snowboard-Core3.png",
                    Brand = "NetCore",
                    Type = "Snowboards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Yellow Core Snowboard",
                    Description =
                        "This snowboard is a versatile, easy-to-love all-mountain ride that doesn't penalize you for little mistakes. With a softer flex and Bite Free Edges, it helps make the most of every day on the mountain - perfect for expanding your range of abilities and moving up the learning curve with confidence.",
                    Price = 7500,
                    PictureUrl = "/images/products/Snowboards/Snowboard-Core4.png",
                    Brand = "NetCore",
                    Type = "Snowboards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Green Core Snowboard",
                    Description =
                        "This snowboard is a versatile, easy-to-love all-mountain ride that doesn't penalize you for little mistakes. With a softer flex and Bite Free Edges, it helps make the most of every day on the mountain - perfect for expanding your range of abilities and moving up the learning curve with confidence.",
                    Price = 7500,
                    PictureUrl = "/images/products/Snowboards/Snowboard-Core5.png",
                    Brand = "NetCore",
                    Type = "Snowboards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Light Blue Core Snowboard",
                    Description =
                        "This snowboard is a versatile, easy-to-love all-mountain ride that doesn't penalize you for little mistakes. With a softer flex and Bite Free Edges, it helps make the most of every day on the mountain - perfect for expanding your range of abilities and moving up the learning curve with confidence.",
                    Price = 7500,
                    PictureUrl = "/images/products/Snowboards/Snowboard-Core6.png",
                    Brand = "NetCore",
                    Type = "Snowboards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Blue Core Snowboard",
                    Description =
                        "This snowboard is a versatile, easy-to-love all-mountain ride that doesn't penalize you for little mistakes. With a softer flex and Bite Free Edges, it helps make the most of every day on the mountain - perfect for expanding your range of abilities and moving up the learning curve with confidence.",
                    Price = 7500,
                    PictureUrl = "/images/products/Snowboards/Snowboard-Core7.png",
                    Brand = "NetCore",
                    Type = "Snowboards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pink Core Snowboard",
                    Description =
                        "This snowboard is a versatile, easy-to-love all-mountain ride that doesn't penalize you for little mistakes. With a softer flex and Bite Free Edges, it helps make the most of every day on the mountain - perfect for expanding your range of abilities and moving up the learning curve with confidence.",
                    Price = 7500,
                    PictureUrl = "/images/products/Snowboards/Snowboard-Core8.png",
                    Brand = "NetCore",
                    Type = "Snowboards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "White Core Snowboard",
                    Description =
                        "This snowboard is a versatile, easy-to-love all-mountain ride that doesn't penalize you for little mistakes. With a softer flex and Bite Free Edges, it helps make the most of every day on the mountain - perfect for expanding your range of abilities and moving up the learning curve with confidence.",
                    Price = 7500,
                    PictureUrl = "/images/products/Snowboards/Snowboard-Core9.png",
                    Brand = "NetCore",
                    Type = "Snowboards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Brown Core Snowboard",
                    Description =
                        "This snowboard is a versatile, easy-to-love all-mountain ride that doesn't penalize you for little mistakes. With a softer flex and Bite Free Edges, it helps make the most of every day on the mountain - perfect for expanding your range of abilities and moving up the learning curve with confidence.",
                    Price = 7500,
                    PictureUrl = "/images/products/Snowboards/Snowboard-Core10.png",
                    Brand = "NetCore",
                    Type = "Snowboards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Purple Core Snowboard",
                    Description =
                        "This snowboard is a versatile, easy-to-love all-mountain ride that doesn't penalize you for little mistakes. With a softer flex and Bite Free Edges, it helps make the most of every day on the mountain - perfect for expanding your range of abilities and moving up the learning curve with confidence.",
                    Price = 7500,
                    PictureUrl = "/images/products/Snowboards/Snowboard-Core11.png",
                    Brand = "NetCore",
                    Type = "Snowboards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Gray CSS Scarf",
                    Description =
                        "This Warm Soft Knitted Scarf Feel Like Real Wool, It Is Also A Perfect Winter Gift For Your Family Or Friends! It Is A Must-Have For Cold Weather.",
                    Price = 1200,
                    PictureUrl = "/images/products/Scarves/Scarf-Css1.png",
                    Brand = "CSS",
                    Type = "Scarves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Red CSS Scarf",
                    Description =
                        "This Warm Soft Knitted Scarf Feel Like Real Wool, It Is Also A Perfect Winter Gift For Your Family Or Friends! It Is A Must-Have For Cold Weather.",
                    Price = 1200,
                    PictureUrl = "/images/products/Scarves/Scarf-Css2.png",
                    Brand = "CSS",
                    Type = "Scarves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Orange CSS Scarf",
                    Description =
                        "This Warm Soft Knitted Scarf Feel Like Real Wool, It Is Also A Perfect Winter Gift For Your Family Or Friends! It Is A Must-Have For Cold Weather.",
                    Price = 1200,
                    PictureUrl = "/images/products/Scarves/Scarf-Css3.png",
                    Brand = "CSS",
                    Type = "Scarves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Yellow CSS Scarf",
                    Description =
                        "This Warm Soft Knitted Scarf Feel Like Real Wool, It Is Also A Perfect Winter Gift For Your Family Or Friends! It Is A Must-Have For Cold Weather.",
                    Price = 1200,
                    PictureUrl = "/images/products/Scarves/Scarf-Css4.png",
                    Brand = "CSS",
                    Type = "Scarves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Green CSS Scarf",
                    Description =
                        "This Warm Soft Knitted Scarf Feel Like Real Wool, It Is Also A Perfect Winter Gift For Your Family Or Friends! It Is A Must-Have For Cold Weather.",
                    Price = 1200,
                    PictureUrl = "/images/products/Scarves/Scarf-Css5.png",
                    Brand = "CSS",
                    Type = "Scarves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Light Blue CSS Scarf",
                    Description =
                        "This Warm Soft Knitted Scarf Feel Like Real Wool, It Is Also A Perfect Winter Gift For Your Family Or Friends! It Is A Must-Have For Cold Weather.",
                    Price = 1200,
                    PictureUrl = "/images/products/Scarves/Scarf-Css6.png",
                    Brand = "CSS",
                    Type = "Scarves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Blue CSS Scarf",
                    Description =
                        "This Warm Soft Knitted Scarf Feel Like Real Wool, It Is Also A Perfect Winter Gift For Your Family Or Friends! It Is A Must-Have For Cold Weather.",
                    Price = 1200,
                    PictureUrl = "/images/products/Scarves/Scarf-Css7.png",
                    Brand = "CSS",
                    Type = "Scarves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pink CSS Scarf",
                    Description =
                        "This Warm Soft Knitted Scarf Feel Like Real Wool, It Is Also A Perfect Winter Gift For Your Family Or Friends! It Is A Must-Have For Cold Weather.",
                    Price = 1200,
                    PictureUrl = "/images/products/Scarves/Scarf-Css8.png",
                    Brand = "CSS",
                    Type = "Scarves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "White CSS Scarf",
                    Description =
                        "This Warm Soft Knitted Scarf Feel Like Real Wool, It Is Also A Perfect Winter Gift For Your Family Or Friends! It Is A Must-Have For Cold Weather.",
                    Price = 1200,
                    PictureUrl = "/images/products/Scarves/Scarf-Css9.png",
                    Brand = "CSS",
                    Type = "Scarves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Brown CSS Scarf",
                    Description =
                        "This Warm Soft Knitted Scarf Feel Like Real Wool, It Is Also A Perfect Winter Gift For Your Family Or Friends! It Is A Must-Have For Cold Weather.",
                    Price = 1200,
                    PictureUrl = "/images/products/Scarves/Scarf-Css10.png",
                    Brand = "CSS",
                    Type = "Scarves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Purple CSS Scarf",
                    Description =
                        "This Warm Soft Knitted Scarf Feel Like Real Wool, It Is Also A Perfect Winter Gift For Your Family Or Friends! It Is A Must-Have For Cold Weather.",
                    Price = 1200,
                    PictureUrl = "/images/products/Scarves/Scarf-Css11.png",
                    Brand = "CSS",
                    Type = "Scarves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Gray HTML EarMuffs",
                    Description =
                        "This Warm Soft Knitted Scarf Feel Like Real Wool, It Is Also A Perfect Winter Gift For Your Family Or Friends! It Is A Must-Have For Cold Weather.",
                    Price = 800,
                    PictureUrl = "/images/products/EarMuffs/EarMuffs-Html1.png",
                    Brand = "HTML",
                    Type = "EarMuffs",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Red HTML EarMuffs",
                    Description =
                        "This Warm Soft Knitted Scarf Feel Like Real Wool, It Is Also A Perfect Winter Gift For Your Family Or Friends! It Is A Must-Have For Cold Weather.",
                    Price = 800,
                    PictureUrl = "/images/products/EarMuffs/EarMuffs-Html2.png",
                    Brand = "HTML",
                    Type = "EarMuffs",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Orange HTML EarMuffs",
                    Description =
                        "This Warm Soft Knitted Scarf Feel Like Real Wool, It Is Also A Perfect Winter Gift For Your Family Or Friends! It Is A Must-Have For Cold Weather.",
                    Price = 800,
                    PictureUrl = "/images/products/EarMuffs/EarMuffs-Html3.png",
                    Brand = "HTML",
                    Type = "EarMuffs",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Yellow HTML EarMuffs",
                    Description =
                        "This Warm Soft Knitted Scarf Feel Like Real Wool, It Is Also A Perfect Winter Gift For Your Family Or Friends! It Is A Must-Have For Cold Weather.",
                    Price = 800,
                    PictureUrl = "/images/products/EarMuffs/EarMuffs-Html4.png",
                    Brand = "HTML",
                    Type = "EarMuffs",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Green HTML EarMuffs",
                    Description =
                        "This Warm Soft Knitted Scarf Feel Like Real Wool, It Is Also A Perfect Winter Gift For Your Family Or Friends! It Is A Must-Have For Cold Weather.",
                    Price = 800,
                    PictureUrl = "/images/products/EarMuffs/EarMuffs-Html5.png",
                    Brand = "HTML",
                    Type = "EarMuffs",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Light Blue HTML EarMuffs",
                    Description =
                        "This Warm Soft Knitted Scarf Feel Like Real Wool, It Is Also A Perfect Winter Gift For Your Family Or Friends! It Is A Must-Have For Cold Weather.",
                    Price = 800,
                    PictureUrl = "/images/products/EarMuffs/EarMuffs-Html6.png",
                    Brand = "HTML",
                    Type = "EarMuffs",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Blue HTML EarMuffs",
                    Description =
                        "This Warm Soft Knitted Scarf Feel Like Real Wool, It Is Also A Perfect Winter Gift For Your Family Or Friends! It Is A Must-Have For Cold Weather.",
                    Price = 800,
                    PictureUrl = "/images/products/EarMuffs/EarMuffs-Html7.png",
                    Brand = "HTML",
                    Type = "EarMuffs",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pink HTML EarMuffs",
                    Description =
                        "This Warm Soft Knitted Scarf Feel Like Real Wool, It Is Also A Perfect Winter Gift For Your Family Or Friends! It Is A Must-Have For Cold Weather.",
                    Price = 800,
                    PictureUrl = "/images/products/EarMuffs/EarMuffs-Html8.png",
                    Brand = "HTML",
                    Type = "EarMuffs",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Whire HTML EarMuffs",
                    Description =
                        "This Warm Soft Knitted Scarf Feel Like Real Wool, It Is Also A Perfect Winter Gift For Your Family Or Friends! It Is A Must-Have For Cold Weather.",
                    Price = 800,
                    PictureUrl = "/images/products/EarMuffs/EarMuffs-Html9.png",
                    Brand = "HTML",
                    Type = "EarMuffs",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Brown HTML EarMuffs",
                    Description =
                        "This Warm Soft Knitted Scarf Feel Like Real Wool, It Is Also A Perfect Winter Gift For Your Family Or Friends! It Is A Must-Have For Cold Weather.",
                    Price = 800,
                    PictureUrl = "/images/products/EarMuffs/EarMuffs-Html10.png",
                    Brand = "HTML",
                    Type = "EarMuffs",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Purple HTML EarMuffs",
                    Description =
                        "This Warm Soft Knitted Scarf Feel Like Real Wool, It Is Also A Perfect Winter Gift For Your Family Or Friends! It Is A Must-Have For Cold Weather.",
                    Price = 800,
                    PictureUrl = "/images/products/EarMuffs/EarMuffs-Html11.png",
                    Brand = "HTML",
                    Type = "EarMuffs",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Gray JavaScript IcePick",
                    Description =
                        "This Ice Pick is It also features a comfortable molded grip and high-quality pick that penetrates the hardest ice.",
                    Price = 6000,
                    PictureUrl = "/images/products/IcePicks/IcePick-JavaScript1.png",
                    Brand = "JavaScript",
                    Type = "IcePicks",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Red JavaScript IcePick",
                    Description =
                        "This Ice Pick is It also features a comfortable molded grip and high-quality pick that penetrates the hardest ice.",
                    Price = 6000,
                    PictureUrl = "/images/products/IcePicks/IcePick-JavaScript2.png",
                    Brand = "JavaScript",
                    Type = "IcePicks",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Orange JavaScript IcePick",
                    Description =
                        "This Ice Pick is It also features a comfortable molded grip and high-quality pick that penetrates the hardest ice.",
                    Price = 6000,
                    PictureUrl = "/images/products/IcePicks/IcePick-JavaScript3.png",
                    Brand = "JavaScript",
                    Type = "IcePicks",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Yellow JavaScript IcePick",
                    Description =
                        "This Ice Pick is It also features a comfortable molded grip and high-quality pick that penetrates the hardest ice.",
                    Price = 6000,
                    PictureUrl = "/images/products/IcePicks/IcePick-JavaScript4.png",
                    Brand = "JavaScript",
                    Type = "IcePicks",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Green JavaScript IcePick",
                    Description =
                        "This Ice Pick is It also features a comfortable molded grip and high-quality pick that penetrates the hardest ice.",
                    Price = 6000,
                    PictureUrl = "/images/products/IcePicks/IcePick-JavaScript5.png",
                    Brand = "JavaScript",
                    Type = "IcePicks",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Light Blue JavaScript IcePick",
                    Description =
                        "This Ice Pick is It also features a comfortable molded grip and high-quality pick that penetrates the hardest ice.",
                    Price = 6000,
                    PictureUrl = "/images/products/IcePicks/IcePick-JavaScript6.png",
                    Brand = "JavaScript",
                    Type = "IcePicks",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Blue JavaScript IcePick",
                    Description =
                        "This Ice Pick is It also features a comfortable molded grip and high-quality pick that penetrates the hardest ice.",
                    Price = 6000,
                    PictureUrl = "/images/products/IcePicks/IcePick-JavaScript7.png",
                    Brand = "JavaScript",
                    Type = "IcePicks",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pink JavaScript IcePick",
                    Description =
                        "This Ice Pick is It also features a comfortable molded grip and high-quality pick that penetrates the hardest ice.",
                    Price = 6000,
                    PictureUrl = "/images/products/IcePicks/IcePick-JavaScript8.png",
                    Brand = "JavaScript",
                    Type = "IcePicks",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "White JavaScript IcePick",
                    Description =
                        "This Ice Pick is It also features a comfortable molded grip and high-quality pick that penetrates the hardest ice.",
                    Price = 6000,
                    PictureUrl = "/images/products/IcePicks/IcePick-JavaScript9.png",
                    Brand = "JavaScript",
                    Type = "IcePicks",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Brown JavaScript IcePick",
                    Description =
                        "This Ice Pick is It also features a comfortable molded grip and high-quality pick that penetrates the hardest ice.",
                    Price = 6000,
                    PictureUrl = "/images/products/IcePicks/IcePick-JavaScript10.png",
                    Brand = "JavaScript",
                    Type = "IcePicks",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Purple JavaScript IcePick",
                    Description =
                        "This Ice Pick is It also features a comfortable molded grip and high-quality pick that penetrates the hardest ice.",
                    Price = 6000,
                    PictureUrl = "/images/products/IcePicks/IcePick-JavaScript11.png",
                    Brand = "JavaScript",
                    Type = "IcePicks",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Gray PHP Goggles",
                    Description =
                        "These traditionally styled snow goggles features an antifog dual-lens design and soft, hypoallergenic face foam for a comfortable day on the powder, all at an aggressively low price.",
                    Price = 2000,
                    PictureUrl = "/images/products/Goggles/Goggles-Php1.png",
                    Brand = "PHP",
                    Type = "Goggles",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Red PHP Goggles",
                    Description =
                        "These traditionally styled snow goggles features an antifog dual-lens design and soft, hypoallergenic face foam for a comfortable day on the powder, all at an aggressively low price.",
                    Price = 2000,
                    PictureUrl = "/images/products/Goggles/Goggles-Php2.png",
                    Brand = "PHP",
                    Type = "Goggles",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Orange PHP Goggles",
                    Description =
                        "These traditionally styled snow goggles features an antifog dual-lens design and soft, hypoallergenic face foam for a comfortable day on the powder, all at an aggressively low price.",
                    Price = 2000,
                    PictureUrl = "/images/products/Goggles/Goggles-Php3.png",
                    Brand = "PHP",
                    Type = "Goggles",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Yellow PHP Goggles",
                    Description =
                        "These traditionally styled snow goggles features an antifog dual-lens design and soft, hypoallergenic face foam for a comfortable day on the powder, all at an aggressively low price.",
                    Price = 2000,
                    PictureUrl = "/images/products/Goggles/Goggles-Php4.png",
                    Brand = "PHP",
                    Type = "Goggles",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Green PHP Goggles",
                    Description =
                        "These traditionally styled snow goggles features an antifog dual-lens design and soft, hypoallergenic face foam for a comfortable day on the powder, all at an aggressively low price.",
                    Price = 2000,
                    PictureUrl = "/images/products/Goggles/Goggles-Php5.png",
                    Brand = "PHP",
                    Type = "Goggles",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Light Blue PHP Goggles",
                    Description =
                        "These traditionally styled snow goggles features an antifog dual-lens design and soft, hypoallergenic face foam for a comfortable day on the powder, all at an aggressively low price.",
                    Price = 2000,
                    PictureUrl = "/images/products/Goggles/Goggles-Php6.png",
                    Brand = "PHP",
                    Type = "Goggles",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Blue PHP Goggles",
                    Description =
                        "These traditionally styled snow goggles features an antifog dual-lens design and soft, hypoallergenic face foam for a comfortable day on the powder, all at an aggressively low price.",
                    Price = 2000,
                    PictureUrl = "/images/products/Goggles/Goggles-Php7.png",
                    Brand = "PHP",
                    Type = "Goggles",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pink PHP Goggles",
                    Description =
                        "These traditionally styled snow goggles features an antifog dual-lens design and soft, hypoallergenic face foam for a comfortable day on the powder, all at an aggressively low price.",
                    Price = 2000,
                    PictureUrl = "/images/products/Goggles/Goggles-Php8.png",
                    Brand = "PHP",
                    Type = "Goggles",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "White PHP Goggles",
                    Description =
                        "These traditionally styled snow goggles features an antifog dual-lens design and soft, hypoallergenic face foam for a comfortable day on the powder, all at an aggressively low price.",
                    Price = 2000,
                    PictureUrl = "/images/products/Goggles/Goggles-Php9.png",
                    Brand = "PHP",
                    Type = "Goggles",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Brown PHP Goggles",
                    Description =
                        "These traditionally styled snow goggles features an antifog dual-lens design and soft, hypoallergenic face foam for a comfortable day on the powder, all at an aggressively low price.",
                    Price = 2000,
                    PictureUrl = "/images/products/Goggles/Goggles-Php10.png",
                    Brand = "PHP",
                    Type = "Goggles",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Purple PHP Goggles",
                    Description =
                        "These traditionally styled snow goggles features an antifog dual-lens design and soft, hypoallergenic face foam for a comfortable day on the powder, all at an aggressively low price.",
                    Price = 2000,
                    PictureUrl = "/images/products/Goggles/Goggles-Php11.png",
                    Brand = "PHP",
                    Type = "Goggles",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Gray Python Skis",
                    Description =
                        "These Skis are perfect for skiers who need a stable ride and want to advance their skills. These skis are Capable of cruising through crud and powder and carving the groomers like a champ.",
                    Price = 7000,
                    PictureUrl = "/images/products/Skis/Skis-Python1.png",
                    Brand = "Python",
                    Type = "Skis",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Red Python Skis",
                    Description =
                        "These Skis are perfect for skiers who need a stable ride and want to advance their skills. These skis are Capable of cruising through crud and powder and carving the groomers like a champ.",
                    Price = 7000,
                    PictureUrl = "/images/products/Skis/Skis-Python2.png",
                    Brand = "Python",
                    Type = "Skis",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Orange Python Skis",
                    Description =
                        "These Skis are perfect for skiers who need a stable ride and want to advance their skills. These skis are Capable of cruising through crud and powder and carving the groomers like a champ.",
                    Price = 7000,
                    PictureUrl = "/images/products/Skis/Skis-Python3.png",
                    Brand = "Python",
                    Type = "Skis",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Yellow Python Skis",
                    Description =
                        "These Skis are perfect for skiers who need a stable ride and want to advance their skills. These skis are Capable of cruising through crud and powder and carving the groomers like a champ.",
                    Price = 7000,
                    PictureUrl = "/images/products/Skis/Skis-Python4.png",
                    Brand = "Python",
                    Type = "Skis",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Green Python Skis",
                    Description =
                        "These Skis are perfect for skiers who need a stable ride and want to advance their skills. These skis are Capable of cruising through crud and powder and carving the groomers like a champ.",
                    Price = 7000,
                    PictureUrl = "/images/products/Skis/Skis-Python5.png",
                    Brand = "Python",
                    Type = "Skis",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Light Blue Python Skis",
                    Description =
                        "These Skis are perfect for skiers who need a stable ride and want to advance their skills. These skis are Capable of cruising through crud and powder and carving the groomers like a champ.",
                    Price = 7000,
                    PictureUrl = "/images/products/Skis/Skis-Python6.png",
                    Brand = "Python",
                    Type = "Skis",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Blue Python Skis",
                    Description =
                        "These Skis are perfect for skiers who need a stable ride and want to advance their skills. These skis are Capable of cruising through crud and powder and carving the groomers like a champ.",
                    Price = 7000,
                    PictureUrl = "/images/products/Skis/Skis-Python7.png",
                    Brand = "Python",
                    Type = "Skis",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pink Python Skis",
                    Description =
                        "These Skis are perfect for skiers who need a stable ride and want to advance their skills. These skis are Capable of cruising through crud and powder and carving the groomers like a champ.",
                    Price = 7000,
                    PictureUrl = "/images/products/Skis/Skis-Python8.png",
                    Brand = "Python",
                    Type = "Skis",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "White Python Skis",
                    Description =
                        "These Skis are perfect for skiers who need a stable ride and want to advance their skills. These skis are Capable of cruising through crud and powder and carving the groomers like a champ.",
                    Price = 7000,
                    PictureUrl = "/images/products/Skis/Skis-Python9.png",
                    Brand = "Python",
                    Type = "Skis",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Brown Python Skis",
                    Description =
                        "These Skis are perfect for skiers who need a stable ride and want to advance their skills. These skis are Capable of cruising through crud and powder and carving the groomers like a champ.",
                    Price = 7000,
                    PictureUrl = "/images/products/Skis/Skis-Python10.png",
                    Brand = "Python",
                    Type = "Skis",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Purple Python Skis",
                    Description =
                        "These Skis are perfect for skiers who need a stable ride and want to advance their skills. These skis are Capable of cruising through crud and powder and carving the groomers like a champ.",
                    Price = 7000,
                    PictureUrl = "/images/products/Skis/Skis-Python11.png",
                    Brand = "Python",
                    Type = "Skis",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Gray React Beanie",
                    Description =
                        "Great for a day on the hill or a day around town, the React Lightweight Logo beanie wraps your skull in the soft, breathable warmth of a stretchy acrylic-wool blend fabric.",
                    Price = 1000,
                    PictureUrl = "/images/products/Beanies/Beanie-React1.png",
                    Brand = "React",
                    Type = "Beanies",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Red React Beanie",
                    Description =
                        "Great for a day on the hill or a day around town, the React Lightweight Logo beanie wraps your skull in the soft, breathable warmth of a stretchy acrylic-wool blend fabric.",
                    Price = 1000,
                    PictureUrl = "/images/products/Beanies/Beanie-React2.png",
                    Brand = "React",
                    Type = "Beanies",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Orange React Beanie",
                    Description =
                        "Great for a day on the hill or a day around town, the React Lightweight Logo beanie wraps your skull in the soft, breathable warmth of a stretchy acrylic-wool blend fabric.",
                    Price = 1000,
                    PictureUrl = "/images/products/Beanies/Beanie-React3.png",
                    Brand = "React",
                    Type = "Beanies",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Yellow React Beanie",
                    Description =
                        "Great for a day on the hill or a day around town, the React Lightweight Logo beanie wraps your skull in the soft, breathable warmth of a stretchy acrylic-wool blend fabric.",
                    Price = 1000,
                    PictureUrl = "/images/products/Beanies/Beanie-React4.png",
                    Brand = "React",
                    Type = "Beanies",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Green React Beanie",
                    Description =
                        "Great for a day on the hill or a day around town, the React Lightweight Logo beanie wraps your skull in the soft, breathable warmth of a stretchy acrylic-wool blend fabric.",
                    Price = 1000,
                    PictureUrl = "/images/products/Beanies/Beanie-React5.png",
                    Brand = "React",
                    Type = "Beanies",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Light Blue React Beanie",
                    Description =
                        "Great for a day on the hill or a day around town, the React Lightweight Logo beanie wraps your skull in the soft, breathable warmth of a stretchy acrylic-wool blend fabric.",
                    Price = 1000,
                    PictureUrl = "/images/products/Beanies/Beanie-React6.png",
                    Brand = "React",
                    Type = "Beanies",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Blue React Beanie",
                    Description =
                        "Great for a day on the hill or a day around town, the React Lightweight Logo beanie wraps your skull in the soft, breathable warmth of a stretchy acrylic-wool blend fabric.",
                    Price = 1000,
                    PictureUrl = "/images/products/Beanies/Beanie-React7.png",
                    Brand = "React",
                    Type = "Beanies",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pink React Beanie",
                    Description =
                        "Great for a day on the hill or a day around town, the React Lightweight Logo beanie wraps your skull in the soft, breathable warmth of a stretchy acrylic-wool blend fabric.",
                    Price = 1000,
                    PictureUrl = "/images/products/Beanies/Beanie-React8.png",
                    Brand = "React",
                    Type = "Beanies",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "White React Beanie",
                    Description =
                        "Great for a day on the hill or a day around town, the React Lightweight Logo beanie wraps your skull in the soft, breathable warmth of a stretchy acrylic-wool blend fabric.",
                    Price = 1000,
                    PictureUrl = "/images/products/Beanies/Beanie-React9.png",
                    Brand = "React",
                    Type = "Beanies",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Brown React Beanie",
                    Description =
                        "Great for a day on the hill or a day around town, the React Lightweight Logo beanie wraps your skull in the soft, breathable warmth of a stretchy acrylic-wool blend fabric.",
                    Price = 1000,
                    PictureUrl = "/images/products/Beanies/Beanie-React10.png",
                    Brand = "React",
                    Type = "Beanies",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Purple React Beanie",
                    Description =
                        "Great for a day on the hill or a day around town, the React Lightweight Logo beanie wraps your skull in the soft, breathable warmth of a stretchy acrylic-wool blend fabric.",
                    Price = 1000,
                    PictureUrl = "/images/products/Beanies/Beanie-React11.png",
                    Brand = "React",
                    Type = "Beanies",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Gray Redis Sweater",
                    Description =
                        "Cozy and plush, our sweater has an oversized silhouette with a light feel. It features a rib pattern and a classic neckline with an incredibly soft texture for ultimate ease and comfort. Long lasting and resistant to pilling.",
                    Price = 3000,
                    PictureUrl = "/images/products/Sweaters/Sweater-Redis1.png",
                    Brand = "Redis",
                    Type = "Sweaters",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Red Redis Sweater",
                    Description =
                        "Cozy and plush, our sweater has an oversized silhouette with a light feel. It features a rib pattern and a classic neckline with an incredibly soft texture for ultimate ease and comfort. Long lasting and resistant to pilling.",
                    Price = 3000,
                    PictureUrl = "/images/products/Sweaters/Sweater-Redis2.png",
                    Brand = "Redis",
                    Type = "Sweaters",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Orange Redis Sweater",
                    Description =
                        "Cozy and plush, our sweater has an oversized silhouette with a light feel. It features a rib pattern and a classic neckline with an incredibly soft texture for ultimate ease and comfort. Long lasting and resistant to pilling.",
                    Price = 3000,
                    PictureUrl = "/images/products/Sweaters/Sweater-Redis3.png",
                    Brand = "Redis",
                    Type = "Sweaters",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Yellow Redis Sweater",
                    Description =
                        "Cozy and plush, our sweater has an oversized silhouette with a light feel. It features a rib pattern and a classic neckline with an incredibly soft texture for ultimate ease and comfort. Long lasting and resistant to pilling.",
                    Price = 3000,
                    PictureUrl = "/images/products/Sweaters/Sweater-Redis4.png",
                    Brand = "Redis",
                    Type = "Sweaters",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Green Redis Sweater",
                    Description =
                        "Cozy and plush, our sweater has an oversized silhouette with a light feel. It features a rib pattern and a classic neckline with an incredibly soft texture for ultimate ease and comfort. Long lasting and resistant to pilling.",
                    Price = 3000,
                    PictureUrl = "/images/products/Sweaters/Sweater-Redis5.png",
                    Brand = "Redis",
                    Type = "Sweaters",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Light Blue Redis Sweater",
                    Description =
                        "Cozy and plush, our sweater has an oversized silhouette with a light feel. It features a rib pattern and a classic neckline with an incredibly soft texture for ultimate ease and comfort. Long lasting and resistant to pilling.",
                    Price = 3000,
                    PictureUrl = "/images/products/Sweaters/Sweater-Redis6.png",
                    Brand = "Redis",
                    Type = "Sweaters",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Blue Redis Sweater",
                    Description =
                        "Cozy and plush, our sweater has an oversized silhouette with a light feel. It features a rib pattern and a classic neckline with an incredibly soft texture for ultimate ease and comfort. Long lasting and resistant to pilling.",
                    Price = 3000,
                    PictureUrl = "/images/products/Sweaters/Sweater-Redis7.png",
                    Brand = "Redis",
                    Type = "Sweaters",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pink Redis Sweater",
                    Description =
                        "Cozy and plush, our sweater has an oversized silhouette with a light feel. It features a rib pattern and a classic neckline with an incredibly soft texture for ultimate ease and comfort. Long lasting and resistant to pilling.",
                    Price = 3000,
                    PictureUrl = "/images/products/Sweaters/Sweater-Redis8.png",
                    Brand = "Redis",
                    Type = "Sweaters",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "White Redis Sweater",
                    Description =
                        "Cozy and plush, our sweater has an oversized silhouette with a light feel. It features a rib pattern and a classic neckline with an incredibly soft texture for ultimate ease and comfort. Long lasting and resistant to pilling.",
                    Price = 3000,
                    PictureUrl = "/images/products/Sweaters/Sweater-Redis9.png",
                    Brand = "Redis",
                    Type = "Sweaters",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Brown Redis Sweater",
                    Description =
                        "Cozy and plush, our sweater has an oversized silhouette with a light feel. It features a rib pattern and a classic neckline with an incredibly soft texture for ultimate ease and comfort. Long lasting and resistant to pilling.",
                    Price = 3000,
                    PictureUrl = "/images/products/Sweaters/Sweater-Redis10.png",
                    Brand = "Redis",
                    Type = "Sweaters",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Purple Redis Sweater",
                    Description =
                        "Cozy and plush, our sweater has an oversized silhouette with a light feel. It features a rib pattern and a classic neckline with an incredibly soft texture for ultimate ease and comfort. Long lasting and resistant to pilling.",
                    Price = 3000,
                    PictureUrl = "/images/products/Sweaters/Sweater-Redis11.png",
                    Brand = "Redis",
                    Type = "Sweaters",
                    QuantityInStock = 100
                },
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}