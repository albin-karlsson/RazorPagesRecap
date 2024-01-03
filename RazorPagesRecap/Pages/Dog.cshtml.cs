using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesRecap.Models;

namespace RazorPagesRecap.Pages
{
    public class DogModel : PageModel
    {
        // Dummy-databas
        public List<Dog> dogs = new()
        {
            new Dog()
            {
                Name = "Schnauzer",
                Info =  "Schnauzer är en hundras från Tyskland. Schnauzern, eller mellanschnauzern som den tidigare kallades, är den ursprungliga varianten medan dvärgschnauzern är framavlad av mindre exemplar. Riesenschnauzern är däremot en boskapshund som avlats för att se ut som en schnauzer. På engelska kallas schnauzern för Standard Schnauzer."
            },
            new Dog()
            {
                Name = "Chihuahua",
                Info =  "The Chihuahua (or Spanish: Chihuahueño) is a Mexican breed of toy dog. It is named for the Mexican state of Chihuahua and is among the smallest of all dog breeds. It is usually kept as a companion animal or for showing."
            },
            new Dog()
            {
                Name = "Poodle",
                Info =  "The Poodle, called the Pudel in German and the Caniche in French, is a breed of water dog. The breed is divided into four varieties based on size, the Standard Poodle, Medium Poodle, Miniature Poodle and Toy Poodle, although the Medium Poodle is not universally recognised. They have a distinctive thick, curly coat that comes in many colors and patterns, with only solid colors recognized by breed registries. Poodles are active and intelligent, and are particularly able to learn from humans. Poodles tend to live 10–18 years, with smaller varieties tending to live longer than larger ones."
            },
        };

        public string? Name { get; set; }
        public string? Info { get; set; }

        public void OnGet(string dog)
        {
            Dog? selectedDog = dogs.FirstOrDefault(d => d.Name!.ToUpper() == dog.ToUpper());

            if (selectedDog != null)
            {
                // Sätt namn och info till två properties i modellen
                Name = selectedDog.Name;
                Info = selectedDog.Info;
            }
        }
    }
}
