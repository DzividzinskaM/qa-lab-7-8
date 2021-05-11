using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab7_8.Steps
{
    public class BaseSteps
    {
        public RestClient client = new RestClient("https://api.themoviedb.org/3/");
        public RestRequest request = new RestRequest();

        /*public void addApiKey()
        {
            string key = "923b6bad1181866112a736086aec0711";
            //request.AddParameter("api_key", key);
            //request.("api_key", key);
        }*/

        private void AddParam(string name, string key)
        {
            request.AddParameter(name, key);
        }

        public void AddApiKey()
        {
            string key = "923b6bad1181866112a736086aec0711";
            AddParam("api_key", key);
        }

        public void AddGuestSessionID()
        {
            string propName = "guest_session_id";
            string key = "3e506d399bb76ffa3de9df11230b95c5";
            AddParam(propName, key);
        }

        public void AddLanguage(string value = "en-US")
        {
            string parName = "language";
            AddParam(parName, value);
        }

        public void AddPage(int value = 1)
        {
            string parName = "page";
            AddParam(parName, value.ToString());
        }

        public void AddIncludeAdult(bool value = false)
        {
            string parName = "include_adult";
            AddParam(parName, value.ToString());
        }
    }
}
