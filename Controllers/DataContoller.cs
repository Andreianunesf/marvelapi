using MarvelMasterApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace MarvelMasterApi.Controllers
{
    public class DataContoller : Controller
    {
        public static RetornoIndex Dados()
        {
            int limit = 20;
            dynamic resultado = resultadoApi(limit);
            int[] arrayPersonagemID = new int[limit];
            string[] arrayPersonagemNome = new string[limit];
            string[] arrayPersonagemDescricao = new string[limit];
            string[] arrayIdade = new string[limit];
            int[] intArrayIdade = new int[limit];

            string stringName = "";
            string stringDescription = "";
            string stringIdade = "";
            

            Personagem _personagens = new Personagem();
            Age idade = new Age();

            for (int i = 0; i < limit; i++)
            {
                stringName = resultado.data.results[i].name;
                stringDescription = resultado.data.results[i].description;
                stringIdade = resultado.data.results[i].modified;
                _personagens.CriarPersonagem(i, stringName, stringDescription);

                arrayPersonagemID[i] = i;
                arrayPersonagemNome[i] = stringName;
                arrayPersonagemDescricao[i] = stringDescription;
                arrayIdade[i] = stringIdade;
                intArrayIdade[i] = idade.ReturnIdade(stringIdade);


            }

            // teste black list 

            BlackList blackList = new BlackList();

            blackList.InsertBackList(2);
            blackList.InsertBackList(3);
            List<int> black = blackList.ReturnBlackList();

            List<int> personagensValidos = new List<int>();

            personagensValidos = blackList.ExceptBlackList(arrayPersonagemID, black);

            // teste favoritos

            Favorite favorite = new Favorite();

            favorite.InsertFavorite(1);
            favorite.InsertFavorite(5);
            favorite.InsertFavorite(3);
            favorite.DeleteFavorite(1);

            List<int> fav = favorite.ReturnFavorite();

            // teste grupos 

            Group group = new Group();
            List<int> personagensGroup = new List<int>() { 1, 3, 4, 5, 6 };
            group.CreateGroup("grupo1", personagensGroup);
            List<Group> grupo1 = group.ReturnGroup();



            RetornoIndex retorno1 = new RetornoIndex();
            retorno1.limit = limit;
            retorno1.personagensValidos = personagensValidos;
            retorno1.arrayIdade = intArrayIdade;
            retorno1.fav = fav;
            retorno1.black = black;
            retorno1.arrayPersonagemID = arrayPersonagemID;
            retorno1.arrayPersonagemNome = arrayPersonagemNome;
            retorno1.arrayPersonagemDescricao = arrayPersonagemDescricao;
            retorno1.groups = grupo1;


            return retorno1;

        }
        public static dynamic resultadoApi(int limit)
        {
            dynamic resultado;
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                // parametros da url

                string ts = "1642539689";
                string publicKey = "89737e2b5be01e946ade4173055a5522";
                string hash = "2cd7277ab38669204ee5f5758d7e8037";
                string url = "http://gateway.marvel.com/v1/public/";
                string linkUrl = url + "characters?ts=" + ts + "&apikey=" + publicKey + "&hash=" + hash + "&limit=" + limit;

                HttpResponseMessage response = client.GetAsync(linkUrl).Result;

                response.EnsureSuccessStatusCode();
                string conteudo = response.Content.ReadAsStringAsync().Result;

                resultado = JsonConvert.DeserializeObject(conteudo);
            }

            return resultado;
        }
    }
}
