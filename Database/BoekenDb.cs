using ASPBoeken.Domein;

namespace ASPBoeken.Database
{
    public class BoekenDb : IBoekenDb
    {
        private int counter = 0;
        private List<Boek> boeks;
        public BoekenDb()
        {
            boeks = new List<Boek>();

            Insert(new Boek
            {
                Title = "Lord Of The Rings",
                Description = "The Rings Power",
                Genre = "Fantasy",
                Author = "J.R.R. Tolkien",
                Rating = 10,
                PublishDate = new DateTime(2022,5,20)
            });
            Insert(new Boek
            {
                Title = "Design Is Storytelling",
                Description = "UX Design",
                Genre = "Educative",
                Author = "Ellen Lupton",
                Rating = 7,
                PublishDate = new DateTime(2020, 6, 15)
            });
            Insert(new Boek
            {
                Title = "Steve Jobs",
                Description = "Apple",
                Genre = "Biography",
                Author = "Walter Isaacson",
                Rating = 8,
                PublishDate = new DateTime(2018, 4, 5)
            });
        }

        public Boek Insert(Boek boek)
        {
            boek.Id = counter++;
            boeks.Add(boek);
            return boek;
        }
        public Boek GetBoek(int id)
        {
            return boeks.FirstOrDefault(x => x.Id == id);
        }
        public IEnumerable<Boek> GetBoeks()
        {
            return boeks;
        }
        public void Update(int id, Boek updateBoek)
        {
            var boek = boeks.FirstOrDefault(x => x.Id == id);
            if (boek != null)
            {
                boek.Title = updateBoek.Title;
                boek.Description = updateBoek.Description;
                boek.Author = updateBoek.Author;
                boek.Genre = updateBoek.Genre;
                boek.Rating = updateBoek.Rating;
            }
        }
        public void Delete(int id)
        {
            var boek = boeks.FirstOrDefault(x=>x.Id == id);
            if (boek != null)
            {
                boeks.Remove(boek);
            }
        }
    }
}
