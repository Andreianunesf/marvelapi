namespace MarvelMasterApi.Models
{
    public class Favorite
    {
        public List<int> Id = new List<int>();


        public void InsertFavorite(int id)
        {
            Id.Add(id);

        }

        public void DeleteFavorite(int id)
        {
            Id.Remove(id);

        }

        public List<int> ReturnFavorite()
        {
            return Id;
        }

    }
}
