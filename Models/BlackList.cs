namespace MarvelMasterApi.Models
{
    public class BlackList
    {
        public List<int> Id = new List<int>();


        public void InsertBackList(int id)
        {
                Id.Add(id);

        }
        public List<int> ReturnBlackList()
        {
            return Id;
        }

    }
}