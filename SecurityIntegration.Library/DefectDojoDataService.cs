using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security;
using System.Text;
using System.Threading.Tasks;


namespace SecurityIntegration.Library
{
    public enum DefectDojotApiVersion
    {
        v1,
        v2
    }

    public class DefectDojoDataService
    {
        public string DefectDojotUrl { get; set; }
        public SecureString ApiTokenV1 { get; set; }
        public SecureString ApiTokenV2 { get; set; }

        public DefectDojoDataService(string defectDojotUrl, SecureString apiTokenV1, SecureString apiTokenV2)
        {
            this.DefectDojotUrl = defectDojotUrl;
            this.ApiTokenV1 = apiTokenV1;
            this.ApiTokenV2 = apiTokenV2;
        }

        public async Task<string> GetApiAsync(DefectDojotApiVersion apiVersion, string arg)
        {
            var result = "";
            var _urlapisf = DefectDojotUrl;
            var _argument = arg;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(_urlapisf);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.Timeout = new TimeSpan(0, 1, 0);

                    switch (apiVersion)
                    {
                        case DefectDojotApiVersion.v1:
                            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Token", ApiTokenV1.ToUnsecureString());
                            break;
                        case DefectDojotApiVersion.v2:
                            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Token", ApiTokenV2.ToUnsecureString());
                            break;
                    }

                    
                    try
                    {
                        using (HttpResponseMessage response = await client.GetAsync(_argument))
                        {
                            if (response.IsSuccessStatusCode)
                            {
                                using (HttpContent content = response.Content)
                                {
                                    result = await content.ReadAsStringAsync();
                                }
                            }
                            else
                            {
                                throw new Exception(response.StatusCode.ToString());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public async Task<string> DeleteApiAsync(DefectDojotApiVersion apiVersion, string arg)
        {
            var result = "";
            var _urlapisf = DefectDojotUrl;
            var _argument = arg;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(_urlapisf);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    switch (apiVersion)
                    {
                        case DefectDojotApiVersion.v1:
                            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Token", ApiTokenV1.ToUnsecureString());
                            break;
                        case DefectDojotApiVersion.v2:
                            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Token", ApiTokenV2.ToUnsecureString());
                            break;
                    }
                    try
                    {
                        using (HttpResponseMessage response = await client.DeleteAsync(_argument))
                        {
                            if (response.IsSuccessStatusCode)
                            {
                                using (HttpContent content = response.Content)
                                {
                                    result = await content.ReadAsStringAsync();
                                }
                            }
                            else
                            {
                                throw new Exception(response.StatusCode.ToString());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public async Task<string> PutApiAsync(DefectDojotApiVersion apiVersion, string body, string arg)
        {
            var result = "";
            var _urlapisf = DefectDojotUrl;
            var _argument = arg;
            var _body = body;

            var _bodyContent = new StringContent(_body, Encoding.UTF8, "application/json");

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(_urlapisf);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");
                    switch (apiVersion)
                    {
                        case DefectDojotApiVersion.v1:
                            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Token", ApiTokenV1.ToUnsecureString());
                            break;
                        case DefectDojotApiVersion.v2:
                            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Token", ApiTokenV2.ToUnsecureString());
                            break;
                    }
                    try
                    {
                        using (HttpResponseMessage response = await client.PutAsync(_argument, _bodyContent))
                        {
                            if (response.IsSuccessStatusCode)
                            {
                                using (HttpContent content = response.Content)
                                {
                                    result = await content.ReadAsStringAsync();
                                }
                            }
                            else
                            {
                                using (HttpContent content = response.Content)
                                {
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
        }

        public async Task<string> PostApiAsync(DefectDojotApiVersion apiVersion, string body, string arg)
        {
            var result = "";
            var _urlapisf = DefectDojotUrl;
            var _argument = arg;
            var _bodyContent = new StringContent(body, Encoding.UTF8, "application/json");

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(_urlapisf);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");
                    switch (apiVersion)
                    {
                        case DefectDojotApiVersion.v1:
                            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Token", ApiTokenV1.ToUnsecureString());
                            break;
                        case DefectDojotApiVersion.v2:
                            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Token", ApiTokenV2.ToUnsecureString());
                            break;
                    }

                    try
                    {
                        using (HttpResponseMessage response = await client.PostAsync(arg, _bodyContent))
                        {
                            if (response.IsSuccessStatusCode)
                            {
                                using (HttpContent content = response.Content)
                                {
                                    result = await content.ReadAsStringAsync();
                                }
                            }
                            else
                            {
                                using (HttpContent content = response.Content)
                                {
                                    result = await content.ReadAsStringAsync();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
        }
    }
}
