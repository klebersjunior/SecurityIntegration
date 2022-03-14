using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace SecurityIntegration.Library
{
    

    public class SonarQubeDataService
    {
        public string DefectDojotUrl { get; set; }
        public SecureString ApiToken { get; set; }

        public SonarQubeDataService(string defectDojotUrl, SecureString apiToken)
        {
            this.DefectDojotUrl = defectDojotUrl;
            this.ApiToken = apiToken;
        }

        public async Task<string> GetApiAsync(string arg)
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

                    var byteArray = Encoding.ASCII.GetBytes($"{ApiToken.ToUnsecureString()}:");
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

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

        public async Task<string> DeleteApiAsync(string arg)
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

                    var byteArray = Encoding.ASCII.GetBytes($"{ApiToken.ToUnsecureString()}:");
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

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

        public async Task<string> PutApiAsync(string body, string arg)
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
                    var byteArray = Encoding.ASCII.GetBytes($"{ApiToken.ToUnsecureString()}:");
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

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

        public async Task<string> PostApiAsync(string body, string arg)
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
                    var byteArray = Encoding.ASCII.GetBytes($"{ApiToken.ToUnsecureString()}:");
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));


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
