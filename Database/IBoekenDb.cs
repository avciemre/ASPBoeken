using ASPBoeken.Domein;

//Methods voor DB

namespace ASPBoeken.Database
{
    public interface IBoekenDb //interface gebruiken!!
    {
        Boek Insert(Boek boek);

        Boek GetBoek(int id);
        IEnumerable<Boek> GetBoeks();
        void Update(int id, Boek boek);
        void Delete(int id);
    }
}
