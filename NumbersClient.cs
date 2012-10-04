using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit.Testing._101
{
    public static class Extensions
    {
        public static String GetString(this NumbersClient.NumbersType enumValue)
        {
            return enumValue.ToString().ToLower();
        }
    }



    public class NumbersClient
    {
        public enum NumbersType
        {
            Trivia,  //Default if ommited
            Math,
            Date,
            Year
        }


        public string GetRandomFact()
        {
            var numbers = new RestClient("http://numbersapi.com/");
            var request = new RestRequest("{type}/{number}", Method.GET);

            request.RequestFormat = DataFormat.Json;
            request.AddUrlSegment("number", NumbersType.Date.GetString());
            request.AddUrlSegment("type", "random");

            var resp = numbers.Execute(request);
            var content = resp.Content;

            return content;
        }
    }
}
