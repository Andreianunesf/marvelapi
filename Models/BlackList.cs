namespace MarvelMasterApi.Models
{
    public class BlackList
    {
        public int Id { get; set; }
        public List<BlackList> _BlackList { get; set; }

        public void InsertBackList(int id)
        {
            
            var _objBlackList = new BlackList();
            _BlackList = new List<BlackList>();

            _objBlackList = new BlackList() { Id = id };
            _BlackList.Add(_objBlackList);

        }
        public List<BlackList> ReturnBlackList()
        {
            return _BlackList;
        }

    }
}

