namespace Backend_basis
{
    public class Repository
    {
        List<cervezas> Beers = new List<cervezas>()
        {
            new cervezas(){Id=1, Name = "Minerva" },
            new cervezas(){Id=2, Name="Belcing Beaver"},
            new cervezas(){Id=3, Name="Corona"}
        };
        public List<cervezas> GetCervezas() => Beers;
        public cervezas? GetCerveza(int id) => Beers.Find(r => r.Id == id);
 
    }
    public class cervezas
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
