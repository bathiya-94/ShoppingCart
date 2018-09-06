using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingCart.Models;

namespace ShoppingCart.Data
{
    public class DbInitializer
    {
        public static void Initialize(ShoppingContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Cateogaries.Any())
            {
                return;   // DB has been seeded
            }

            var cateogaries = new Cateogary[]
            {

            new Cateogary{Title="Mobile Phones",Imagepath="https://www.smartphonecompany.co.uk/assets/img/features/gs9-hero.jpg"},
            new Cateogary{Title="Laptops",Imagepath="http://www.freestufffinder.com/wp-content/uploads/2017/11/IntelLaptops-660x402.jpg"},
            new Cateogary{Title="Tablets",Imagepath="https://s.tmocache.com/content/dam/tmo/en-g/q3-2017/4520-fg-lg-gpadx2-alcatel-a30.png"},
            new Cateogary{Title="Portable Hard Disks",Imagepath="https://ae01.alicdn.com/kf/HTB15RrFmjuhSKJjSspjq6Ai8VXaJ/KESU-2-5-Inch-External-Hard-Drive-1TB-USB-3-0-HDD-Portable-External-HD-Hard.jpg_220x220.jpg"},
            new Cateogary{Title="Gaming Equipment",Imagepath="https://ph-test-11.slatic.net/p/2/aesopcom-m200-gaming-keyboard-led-hd-bass-headset-and-usb-7-ledmouse-bundle-black-9058-85669712-d874a729e2f63618fccd12e992178441-catalog_233.jpg"},
            new Cateogary{Title="Computer Parts",Imagepath="https://2.bp.blogspot.com/-KU5p-Sleqig/V7iH7cxAeKI/AAAAAAAAAGQ/dIwhEK16wiMGQHmg3yAM3nzw5j6kD9jdACLcB/s1600/1550234_0_original.jpg"},

            };
            foreach (Cateogary s in cateogaries)
            {
                context.Cateogaries.Add(s);
            }
            context.SaveChanges();

            var products = new Product[]
            {
                // Mobile Phones
            new Product{Title="iphone X",Imagepath="https://cdn2.gsmarena.com/vv/pics/apple/apple-iphone-x-new-1.jpg",Price=200000,CateogaryID=1},
            new Product{Title="Google Pixel 2",Imagepath="https://drop.ndtv.com/TECH/product_database/images/104201774316PM_635_google_pixel_2.jpeg",Price=175000,CateogaryID=1},
            new Product{Title="One plus 6",Imagepath="https://image01.oneplus.net/shop/201805/31/625/f4a19f69328227f6988ece740e6fe5ee.jpg",Price=95000,CateogaryID=1},
            new Product{Title="Huwaei P20",Imagepath="https://cf4.s3.souqcdn.com/item/2018/04/04/33/10/43/16/item_XL_33104316_126283119.jpg",Price=110000,CateogaryID=1},
            new Product{Title="One plus 5",Imagepath="https://static.toiimg.com/photo/59251001/OnePlus-5.jpg",Price=60000,CateogaryID=1},
             
            // Laptops
            new Product{Title="Apple Mac Pro",Imagepath="http://harrisma.id/images/product/bb3f3c2b519afdb89735e50b4e606d9d.jpg",Price=300000,CateogaryID=2},
            new Product{Title="Asus ZenBook",Imagepath="https://www.asus.com/us/Laptops/ASUS-ZenBook-Pro-UX501JW/websites/global/products/I3sIS77qlI2vhzYM/img/01/fg02.png",Price=95000,CateogaryID=2},
            new Product{Title="Lenovo Yoga",Imagepath="https://www.jbhifi.co.nz/FileLibrary/ProductResources/Images/27187-L-LO.jpg",Price=200000,CateogaryID=2},
            new Product{Title="Apple Macbook Air",Imagepath="https://i04.hsncdn.com/is/image/HomeShoppingNetwork/prodfull/apple-macbook-air-133-core-i5-128gb-ssd-laptop-d-20171005164138387~584936.jpg",Price=175000,CateogaryID=2},
            new Product{Title="HP Envy",Imagepath="http://www.hpobchod.sk/library/configuration/notebooky/HP-Envy-15-x360-bp-bq-natural-silver_0a.jpg",Price=160000,CateogaryID=2},

            // Tablets
            new Product{Title="Samsung Galaxy tab",Imagepath="https://s7d2.scene7.com/is/image/SamsungUS/smt813nzkexar-hero-0812?$product-details-jpg$",Price=30000,CateogaryID=3},
            new Product{Title="Ipad Pro",Imagepath="https://www.t-mobile.com/content/dam/t-mobile/en-p/internet-devices/apple/ipad-pro-10/rose-gold/Apple-iPad-Pro-105-RoseGold-1-3x.jpg",Price=110000,CateogaryID=3},
            new Product{Title="Ipad Mini",Imagepath="https://images-na.ssl-images-amazon.com/images/I/719%2B0VxmmYL._SL1341_.jpg",Price=75000,CateogaryID=3},
          
            //Portable Hard Disks
             new Product{Title="Seagate 1TB",Imagepath="https://www.webantics.com/content/images/thumbs/002/0021664_seagate-backup-plus-1tb-slim-portable-usb30-external-hard-drive-silver_600.jpeg",Price=9000,CateogaryID=4},

            //Gaming Euipments
             new Product{Title="MSI keyboard",Imagepath="https://www.evetech.co.za/repository/components/msi-interceptor-ds4100-gaming-keyboard-300px-v1.jpg",Price=10000,CateogaryID=5},
             new Product{Title="Razor Gaming Mouse",Imagepath="https://imgmanagercb-a.akamaihd.net/mouse/razer-abyssus-laser_300x300-PU397b2_1.jpg",Price=6000,CateogaryID=5},
            
             //Computer Parts
             new Product{Title="4GB Ram",Imagepath="https://images-na.ssl-images-amazon.com/images/I/613w1e%2BtvML._SX425_.jpg",Price=1000,CateogaryID=6},
             new Product{Title="PC Power Supply",Imagepath="https://img.bhs4.com/1c/b/1cbe2e6f05af17a035c3f9833e12bfa402c133bd_large.jpg",Price=2000,CateogaryID=6}


            };
            foreach (Product c in products)
            {
                context.Products.Add(c);
            }
            context.SaveChanges();

        }
    }

}
