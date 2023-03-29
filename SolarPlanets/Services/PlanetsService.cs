using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolarPlanets.Models;

namespace SolarPlanets.Services
{
    class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the smallest planet in the Solar System and the closest to the Sun. Its orbit around the Sun takes 87.97 Earth days, the shortest of all the Sun's planets. It is named after the Roman god Mercurius.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://www.nasa.gov/sites/default/files/styles/full_width_feature/public/images/755626main_PIA17280-full_full.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/75_mercury_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                },
            },new()
            {
                Name = "Venus",
                Subtitle = "The pressure cooker",
                HeroImage = "venus.png",
                Description = "Of all the planets, it's the most similar to Earth. In fact, venus is sometimes called Earth's \"sister\" or \"twin\" planet as it is almost as large and has a similar composition.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/143_Venus-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/147_Hubble_Venus_Clouds-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/146_venus_carousel_3.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/144_PIA00485_Venus_Caldera-800.jpg",
                },
            },
        };

        public static List<Planet> GetAllPlanets() => planets;

        public static List<Planet> GetFeaturedPlanets()
        {
            var rnd = new Random();
            var randomizedPlanets = planets.OrderBy(item => rnd.Next());

            return randomizedPlanets.Take(2).ToList();
        }


    }
}
