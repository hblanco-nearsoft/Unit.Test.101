using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit.Testing._101
{
    public interface INumberAdapter
    {
        string Execute(RestRequest request); 
     }
    

    public class NumbersAdapter : INumberAdapter
    {
        public string Execute(RestRequest request)
        {
            var numbers = new RestClient("http://numbersapi.com/");
            var response = numbers.Execute(request);
            return response.Content;
        }
    }
}
