using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Texac.Domain;


namespace Texac.RestClient
{
    class RestClient
    {
        public string httpPost(string url, string json)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage res = httpClient.PostAsync(url, stringContent).Result;
                    return res.Content.ReadAsStringAsync().Result;

                } catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return "{}";
                }
            }
        }

        public async Task<HttpResponseMessage> httpPostAsync(string url, string json)
        {

            using (var httpClient = new HttpClient())
            {
                var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
                var res = httpClient.PostAsync(url, stringContent);
                return await res;
            }
        }


        public string httpGet(string url)
        {
            using (var httpClient = new HttpClient())
            {
                
                try
                {
                    Uri uri = new Uri(url);
                    var response = httpClient.GetStringAsync(uri).Result;
                    return response;

                } catch(Exception ex)
                {
                    var t = ex.Message;
                }
            }
            return "";
        }

        protected string getApiEntityPath(Type type)
        {
            object[] attr = type.GetCustomAttributes(typeof(EntityPath), false);
            if (attr.Length == 0)
                return "";
            else
                return ((EntityPath)attr[0]).path;
        }


        public T getEntyty<T>(long id)
        {
            String entityPath = getApiEntityPath(typeof(T));
            if(entityPath=="")
                return default(T);

            String apiPath = Properties.Settings.Default.api_path;
            String url = String.Format("{0}/{1}/{2}",apiPath, entityPath, id);
            string json = httpGet(url);
            T obj = JsonConvert.DeserializeObject<T>(json);
            return obj;
        }

        public List<T> getEntytyList<T>()
        {
            String entityPath = getApiEntityPath(typeof(T));
            if (entityPath == "")
                return default(List<T>);

            String apiPath = Properties.Settings.Default.api_path;
            String url = String.Format("{0}/{1}", apiPath, entityPath);
            string json = httpGet(url);
            List<T> obj = JsonConvert.DeserializeObject<List<T>>(json);
            return obj;
        }

        public T saveEntity<T>(T entity)
        {
            String entityPath = getApiEntityPath(typeof(T));
            if (entityPath == "")
                return default(T);

            String apiPath = Properties.Settings.Default.api_path;
            String url = String.Format("{0}/{1}", apiPath, entityPath);

            string json = JsonConvert.SerializeObject(entity, Formatting.None, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });

            string j = httpPost(url, json);
            T obj = JsonConvert.DeserializeObject<T>(j);
            return obj;
        }
    }
}
