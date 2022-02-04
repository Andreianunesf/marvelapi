using System.Linq;

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
        public List<int> ExceptBlackList(int[] listItens, List<int> listBack)
        {
            var lException = listItens.Except(listBack);
            List<int> personagensValidos = new List<int>();

            foreach (var item in lException)
            {
                personagensValidos.Add(item);
            }

            return personagensValidos;
        }

    }
}