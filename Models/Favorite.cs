namespace MarvelMasterApi.Models
{
    public class Favorite
    {
        public int Id { get; set; }
        private List<Favorite> _Favorite { get; set; }

        public void InsertFavorite(int id)
        {
            var _objFavorite = new Favorite();
            _Favorite = new List<Favorite>();

            _objFavorite = new Favorite() { Id = id };
            _Favorite.Add(_objFavorite);

        }

        public  void DeleteFavorite(int id)
        {
            var _objFavorite = new Favorite();
            _Favorite = new List<Favorite>();

            _Favorite.Remove(_objFavorite);
        }

        public List<Favorite> ReturnFavorite()
        {
            return _Favorite;
        }

    }
}
