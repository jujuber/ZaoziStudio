using Newtonsoft.Json.Linq;
using Synyi.Framework.Kernel.Security;
using Synyi.Framework.Wpf.Mvvm;
using System;
using System.ComponentModel;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Zaozi.Code.TestUI;

namespace WebApiTest.ViewModels
{
    [Plugin(ZaoziConst.Plugins.WebApiTestView, "web测试", "web测试")]
    public class WebApiTestViewModel : PluginViewModelBase
    {
        private readonly HttpClient _httpClient;
        private string _apiUrl;
        private string _username;
        private string _keyId;
        private string _responseContent;
        public ActionCommand SendRequestCommand { get; }
        public ActionCommand SwitchOrgCommand { get; }
        public WebApiTestViewModel()
        {
            _httpClient = new HttpClient();
            this.SendRequestCommand = new ActionCommand(async () => await ExecuteSendRequestCommand());
            this.SwitchOrgCommand = new ActionCommand(async () => await ExecuteSwitchOrgCommand());
        }

        public string ApiUrl
        {
            get => _apiUrl;
            set
            {
                if (_apiUrl != value)
                {
                    _apiUrl = value; 
                }
            }
        }

        public string Username
        {
            get => _username;
            set
            {
                if (_username != value)
                {
                    _username = value; 
                }
            }
        }

        public string KeyId
        {
            get => _keyId;
            set
            {
                if (_keyId != value)
                {
                    _keyId = value; 
                }
            }
        }

        public string ResponseContent
        {
            get => _responseContent;
            set
            {
                if (_responseContent != value)
                {
                    _responseContent = value; 
                }
            }
        }
        //http://192.168.100.28:8004/Pipes/Com/Basics/User/LoginPAT
        private async Task ExecuteSendRequestCommand()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ApiUrl))
                {
                    ResponseContent = "请输入API地址";
                    return;
                }
                var user = new { Code = "00", SignKey = "8705B7F30F3D4EE4AD957CB0D857AAD4" };
                var json = System.Text.Json.JsonSerializer.Serialize(user);
                 
                using HttpContent content = new StringContent(json);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var response = await this._httpClient.PostAsync(ApiUrl, content).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                var resultJson = await response.Content.ReadAsStringAsync();
                ResponseContent = resultJson;
                //using (var content = new StringContent(json))
                //{
                //    var response = await _httpClient.PostAsync(ApiUrl, content);
                //    var responseContent = await response.Content.ReadAsStringAsync();

                //    ResponseContent = $"状态码: {(int)response.StatusCode} {response.StatusCode}\n\n{responseContent}";
                //}
            }
            catch (Exception ex)
            {
                ResponseContent = $"发生错误：{ex.Message}";
            }
        }
        //https://localhost:56891/Pipes/Com/Basics/User/SwitchOrg
        private async Task ExecuteSwitchOrgCommand()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ApiUrl))
                {
                    ResponseContent = "请输入API地址";
                    return;
                }
                var Org = new { OrgId = "HHG00101" };
                var json = System.Text.Json.JsonSerializer.Serialize(Org);

                using HttpContent content = new StringContent(json);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                this._httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", KeyId);
                var response = await this._httpClient.PostAsync(ApiUrl, content).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                var resultJson = await response.Content.ReadAsStringAsync();
                ResponseContent = resultJson;
                //using (var content = new StringContent(json))
                //{
                //    var response = await _httpClient.PostAsync(ApiUrl, content);
                //    var responseContent = await response.Content.ReadAsStringAsync();

                //    ResponseContent = $"状态码: {(int)response.StatusCode} {response.StatusCode}\n\n{responseContent}";
                //}
            }
            catch (Exception ex)
            {
                ResponseContent = $"发生错误：{ex.Message}";
            }
        }

        protected override Task DoOnNavigatedTo(NavigationContext context)
        {
            return  Task.CompletedTask;
        }
    } 
} 