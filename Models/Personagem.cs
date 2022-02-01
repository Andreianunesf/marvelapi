namespace MarvelMasterApi.Models
{
    public class Personagem
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        private List<Personagem> _listPersonagem { get; set; }

        public  void CriarPersonagem(int comandID, string comandName, string comandDescricao)
        {
            try
            {
                _listPersonagem = new List<Personagem>()
            {
                new Personagem(){Id = comandID, Nome = comandName, Descricao = comandDescricao },

            };
            }
            catch (System.Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


    }

    
}
