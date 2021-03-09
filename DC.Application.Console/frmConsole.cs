using DC.Resources.Utils.Converter;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;

namespace DC.Application.Console
{
    public partial class frmConsole : Form
    {
        public static HttpClient client = new HttpClient();
        private CustomerResponseDTO[] _customerResponse = null;
        private AuthenticationResponseDTO[] _authenticationResponse;

        public frmConsole()
        {
            InitializeComponent();
            this.lblMessageToken.Text = string.Empty;
            this.lblMessageCreateUser.Text = string.Empty;
            this.txtToken.Text = string.Empty;
            _customerResponse = new CustomerResponseDTO[] { };
            _authenticationResponse = new AuthenticationResponseDTO[] { };
        }

        private void frmConsole_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            #region Passo variáveis simulando um cadastro de usuário na base
            var input = new CustomerRequestDTO
            {
                email = this.txtMail.Text, //Email 
                codeIn = this.txtCodeIn.Text, //Senha
                repeatCodeIn = this.txtRepeatCodeIn.Text,//Repete Senha
                nickName = this.txtNickName.Text
            };
            #endregion

            if (string.IsNullOrWhiteSpace(input.email))
            {
                this.lblMessageCreateUser.Text = "Informe seu e-mail!";
            }
            else if (string.IsNullOrWhiteSpace(input.codeIn) && string.IsNullOrWhiteSpace(input.repeatCodeIn))
            {
                this.lblMessageCreateUser.Text = "Informe uma senha!";
            }
            else if (string.IsNullOrWhiteSpace(input.codeIn) && !string.IsNullOrWhiteSpace(input.repeatCodeIn))
            {
                this.lblMessageCreateUser.Text = "Informe uma senha!";
            }
            else if (!string.IsNullOrWhiteSpace(input.codeIn) && string.IsNullOrWhiteSpace(input.repeatCodeIn))
            {
                this.lblMessageCreateUser.Text = "Repita a senha!";
            }
            else if (input.codeIn != input.repeatCodeIn)
            {
                this.lblMessageCreateUser.Text = "As senhas não conferem!";
            }
            else if (string.IsNullOrWhiteSpace(input.nickName))
            {
                this.lblMessageCreateUser.Text = "Informe um Nick Name!";
            }
            else
            {
                #region Crio uma criptografia dos dados sensíveis a serem transitado pela API (Senha e Repetição de Senha)
                var request = new HttpRequestMessage();
                input.codeIn = EncodeDecode.CrashIn(input.codeIn);
                input.repeatCodeIn = EncodeDecode.CrashIn(input.repeatCodeIn);
                #endregion

                #region Crio o usuário na base
                _customerResponse = CallCreateUser(input);
                this.lblMessageCreateUser.Text = _customerResponse.FirstOrDefault().message;
                #endregion
            }
        }


        private void btnCreateToken_Click(object sender, EventArgs e)
        {
            #region Crio token de acesso ao Sistema para o usuário anterior
            if (_customerResponse != null)
            {
                if (_customerResponse.Count() > 0)
                {
                    if (_customerResponse.FirstOrDefault().hasSuccess == true && _customerResponse.FirstOrDefault().logged == true)
                    {
                        #region Crio o Token de acesso ao sistema
                        _authenticationResponse = CallCreateToken(new AuthenticationRequestDTO
                        {
                            email = this.txtMail.Text,
                            nameSystem = "ExemploNomeAplicacao",
                            sKey = _customerResponse.FirstOrDefault().guid,
                            userName = this.txtNickName.Text
                        });
                        #endregion

                        this.txtToken.Text = _authenticationResponse.FirstOrDefault().token;
                        this.lblMessageToken.Text = (_authenticationResponse.FirstOrDefault().statusCode == HttpStatusCode.OK) ? "Token gerado com sucesso!" : "Ocorreu um erro na geração do token de acesso!";
                    }
                }
                else
                {
                    this.lblMessageToken.Text = "Efetue o cadastro do Usuário!";
                }
                var source = new BindingSource();
                source.DataSource = _authenticationResponse.ToList();
                this.dtgUserData.DataSource = source;
            }
            #endregion
        }

        /// <summary>
        /// Método responsável pela chamada de criação do token de autenticação
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static AuthenticationResponseDTO[] CallCreateToken(AuthenticationRequestDTO data)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            var result = new AuthenticationResponseDTO[] { };
            if (client.BaseAddress == null)
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["api-base"]);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");

            var response = client.PostAsync("api/security/accesstoken", content).Result;
            if(response.StatusCode == HttpStatusCode.Unauthorized)
            {
                result = new AuthenticationResponseDTO[] {
                    new AuthenticationResponseDTO{
                        message = "Ação não autorizada. Cadastre um novo usuário!",
                        hasAccess = false
                    }
                };

                return result;
            }
            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
                result = JsonConvert.DeserializeObject<AuthenticationResponseDTO[]>(response.Content.ReadAsStringAsync().Result);
            return result;
        }

        /// <summary>
        /// Método responsável pela chamada de serviço para criação do usuário na base
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static CustomerResponseDTO[] CallCreateUser(CustomerRequestDTO data)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            var result = new CustomerResponseDTO[] { };
            if (client.BaseAddress == null)
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["api-base"]);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");

            var response = client.PostAsync("api/security/createuser", content).Result;
            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
                result = JsonConvert.DeserializeObject<CustomerResponseDTO[]>(response.Content.ReadAsStringAsync().Result);
            return result;
        }


        public static AuthenticationResponseDTO[] CallGetUser(AuthenticationRequestDTO data)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            var result = new AuthenticationResponseDTO[] { };
            if (client.BaseAddress == null)
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["api-base"]);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");

            var response = client.PostAsync("api/security/getloginuser", content).Result;
            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
                result = JsonConvert.DeserializeObject<AuthenticationResponseDTO[]>(response.Content.ReadAsStringAsync().Result);
            return result;
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }


    /// <summary>
    /// Entidade responsável pelo input de dados para cadastro de usuário
    /// </summary>
    public class CustomerRequestDTO
    {
        public string customerCode { get; set; }
        public string ip { get; set; }
        public string nickName { get; set; }
        public string email { get; set; }
        public string codeIn { get; set; }
        public string nameSystem { get; set; }
        public string repeatCodeIn { get; set; }
        public string name { get; set; }
        public string descriptionTitleOne { get; set; }
        public string descriptionSubTitleOne { get; set; }
        public string idCustomer { get; set; }
        public string url { get; set; }
    }

    /// <summary>
    /// Entidade responsável pelo output do cadastro do usuário na base
    /// </summary>
    public class CustomerResponseDTO
    {
        public CustomerResponseDTO()
        {
            this.logged = false;
            this.hasSuccess = false;
            this.hasExist = false;
        }
        public string nickName { get; set; }
        public string url { get; set; }
        public string guid { get; set; }
        public string message { get; set; }
        public bool logged { get; set; }
        public bool hasSuccess { get; set; }
        public bool hasExist { get; set; }
        public HttpStatusCode statusCode { get; set; }
    }

    /// <summary>
    /// Entidade responsável pelo output de dados para retorno do token de autenticação
    /// </summary>
    public class AuthenticationResponseDTO
    {
        public AuthenticationResponseDTO()
        {
            this.hasAccess = false;
        }
        public string guid { get; set; }
        public string email { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public bool generateToken { get; set; }
        public bool hasAccess { get; set; }
        public string message { get; set; }
        public string token { get; set; }
        public string url { get; set; }
        public string haskKeyUser { get; set; }
        public DateTime processDate { get; set; }
        public string nameSystem { get; set; }
        public DateTimeOffset? expires { get; set; }
        public HttpStatusCode statusCode { get; set; }
    }

    /// <summary>
    /// Entidade responsável pelo input de dados de autenticação
    /// </summary>
    public class AuthenticationRequestDTO
    {
        public string userName { get; set; }
        public string codeIn { get; set; }
        public string nameSystem { get; set; }
        public string email { get; set; }
        public string sKey { get; set; }
    }
}
