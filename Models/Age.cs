using System.Globalization;
using System.Threading;



namespace MarvelMasterApi.Models

{
    public class Age
    {
        public int ReturnIdade(string data)
        {
         
            var strDia = data.Substring(3, 2);
            var strMes = data.Substring(0, 2);
            var strAno = data.Substring(6, 4);

            int intDia = Convert.ToInt32(strDia);
            int intMes = Convert.ToInt32(strMes);
            int intAno = Convert.ToInt32(strAno);

            DateTime dtData = new DateTime(intAno, intMes, intDia);
            // var dtDate = DateTime.ParseExact(substring, format, provider);

            DateTime getdate = DateTime.Today;

            TimeSpan ts = getdate.Subtract(dtData);
            DateTime diferenca = new DateTime(ts.Ticks);

            int idade = diferenca.Year;

            return idade;
        }

    }
}
