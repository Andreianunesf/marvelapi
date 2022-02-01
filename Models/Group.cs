namespace MarvelMasterApi.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Group> _Group { get; set; }

    }
}
