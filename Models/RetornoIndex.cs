namespace MarvelMasterApi.Models
{
    public class RetornoIndex
    {
        public int limit { get; set; }
        public List<int> fav { get; set; }
        public List<int> black { get; set; }
        public List<int> personagensValidos { get; set; }
        public int[] arrayPersonagemID { get; set; }
        public int[] arrayIdade { get; set; }
        public string[] arrayPersonagemNome { get; set; }
        public string[] arrayPersonagemDescricao { get; set; }
        public List<Group> groups { get; set; }

    }
}
