using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Repo
{
   public class CoffeeRepository
    {
        public List<Coffee> GetAll()
        {
            return new List<Coffee>
            {
                new Coffee
                {
                     ImagePath="Icons/mehmetEfendi.png",
                      Name="Mehmet E.",
                       Price=7
                },
                new Coffee
                {
                     ImagePath="/Icons/patchRoast.png",
                      Name="Patch Roast",
                       Price=30                     
                },
                new Coffee
                {
                     ImagePath="/Icons/lambocoy.png",
                      Name="Lambocoy",
                       Price=17
                },
                new Coffee
                {
                    ImagePath="/Icons/peetsCoffee.png",
                      Name="Peets",
                       Price=23.5
                },
                new Coffee
                {
                     ImagePath="/Icons/paperbag.png",
                      Name="Paper Bag",
                       Price=18.80
                },
                new Coffee
                {
                     ImagePath="/Icons/melitta.png",
                      Name="Melitta",
                       Price=13
                }
            };
        }
    }
}
