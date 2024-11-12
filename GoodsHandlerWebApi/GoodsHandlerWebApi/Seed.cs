using GoodsHandlerWebApi.Data;
using GoodsHandlerWebApi.Modells;
using System.Diagnostics.Metrics;

namespace GoodsHandlerWebApi
{
    public class Seed
    {

        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            if (!dataContext.Goods.Any())
            {
                var goods = new List<Goods>()
                {
                    new Goods()
                    {
                        PartNumber = "RCH45Q1A",
                        Name = "iPhone 14",
                        ItemDescription = "Mobiltelefon - 6,1\"-es OLED kijelző 2532 × 1170 felbontással, 128 GB belső tárhely, single + eSIM, Apple A15 Bionic processzor, kameramodul: 12Mpx (f/1,5) fő kamera + 12Mpx széles látószögű, 12Mpx felbontású előlapi kamera, GPS, NFC, LTE, 5G, Lightning port csatlakozó, IP68 vízálló, gyorstöltés 15W, vezeték nélküli töltés, megjelenés éve 2022, iOS operációs rendszer",
                        Price = 299990
                    },
                    new Goods()
                    {
                        PartNumber = "GBN62Z9P",
                        Name = "Dell Latitude 14 5440",
                        ItemDescription = "Intel® Core™ i7-1355U Processor (12M Cache, up to 5.00 GHz) • Ubuntu (Linux) • 16GB DDR4 3200MHz RAM • 512GB M.2 PCIe SSD • 14\" FullHD (1920 x 1080) matt LCD kijelző • Intel® Iris® Xe Graphics eligible integrált grafikus vezérlő • 1000Mbps RJ45 (1 db) • Wi-Fi 802.11 ax • Bluetooth 5.3 • HDMI (1db) • USB 3.0 (2db) • USB-C 4.0 (2db) • microSD-kártyaolvasó • FHD webkamera (beépített) • Garancia: 36 hónap",
                        Price = 469900
                    },
                    new Goods()
                    {
                        PartNumber = "FTR93Q2S",
                        Name = "Samsung Galaxy S23 5G",
                        ItemDescription = "Mobiltelefon - 6,1'-es AMOLED kijelző 2340 × 1080 felbontással (120Hz), 8 GB RAM, 128 GB belső tárhely, Dual SIM + eSIM, Qualcomm Snapdragon 8 Gen 2 processzor, kameramodul: 50Mpx (f/1,8) fő kamera + 12Mpx széles látószögű + 10Mpx teleobjektív, 12Mpx felbontású előlapi kamera, ujjlenyomat-olvasó, NFC, LTE, 5G, USB-C csatlakozó, IP68 vízálló, gyorstöltés 25W, vezeték nélküli töltés 15W, 3900 mAh kapacitású akkumulátor, megjelenés éve 2023, Android operációs rendszer",
                        Price = 249900
                    }
                };
                
                dataContext.Goods.AddRange(goods);
                dataContext.SaveChanges();
            }
            if (!dataContext.Logins.Any())
            {
                var login = new List<Login>()
                    {
                        new Login()
                        {
                            AccountName = "felhasznalo",
                            Password = "12345"
                        }
                    };

                dataContext.Logins.AddRange(login);
                dataContext.SaveChanges();
            }
        }
    }
}
