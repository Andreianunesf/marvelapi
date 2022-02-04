namespace MarvelMasterApi.Models
{
    public class Group
    {
        public string name { get; set; }

        public List<int> itens { get; set; }

        public List<Group> _groups = new List<Group>();

        public void CreateGroup(string _name, List<int> _itens)
        {

             _groups.Add(new Group() { name = _name, itens = _itens });
            
        }
        public List<Group> ReturnGroup()
        {
            return _groups;
        }
    }
}
