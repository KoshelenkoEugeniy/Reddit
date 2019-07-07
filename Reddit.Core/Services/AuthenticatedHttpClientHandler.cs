//using System;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Net.Http.Headers;
//using System.Threading;
//using System.Threading.Tasks;
//using ModernHttpClient;
//using MvvmCross.Platform;
//using MvvmCross.Platform.Platform;
//using Newtonsoft.Json;

//namespace Reddit.Core.Services
//{
//    public class AuthenticatedHttpClientHandler: NativeMessageHandler
//    {
//        private readonly Func<string> _getToken; //#if DEBUG //        private IMvxTrace Logger { get; set; } //#endif //        private string Caller { get => nameof(AuthenticatedHttpClientHandler); } //        //private IConnectionState _connectionState;  //        private static HttpStatusCode[] _errorCodes = { //                HttpStatusCode.BadRequest, //                HttpStatusCode.NotFound, //                HttpStatusCode.Forbidden, //                HttpStatusCode.PaymentRequired //         } ;  //        public AuthenticatedHttpClientHandler(Func<string> getTokenFunc) //        { //            _getToken = getTokenFunc ?? throw new ArgumentNullException(nameof(getTokenFunc)); //#if DEBUG //            Logger = Mvx.Resolve<IMvxTrace>(); //#endif //        }  //        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) //        { //            //if (!_connectionState.IsConnected) //                //throw new MommrNoConnectionException(Resources.AppStrings.NoInternetConnection);  //            var auth = request.Headers.Authorization; //            if (auth != null) //                request.Headers.Authorization = new AuthenticationHeaderValue(auth.Scheme, _getToken.Invoke());  //            var result = await base.SendAsync(request, cancellationToken); //            if (_errorCodes.Contains(result.StatusCode) || !result.IsSuccessStatusCode) //            { //                var errorResponse = await result.Content.ReadAsStringAsync(); //                if (!string.IsNullOrEmpty(errorResponse)) //                { //#if DEBUG //                    ////var errorDto = JsonConvert.DeserializeObject<ErrorResponseDto>(errorResponse); //                    //if (errorDto != null && errorDto.Errors != null && errorDto.Errors.Any()) //                    //{ //                      //throw new MommrException(errorDto.Errors.FirstOrDefault().Message); //                    //} //#else //                    //throw new MommrException(Resources.AppStrings.ErrorMessageGeneral); //#endif //                } //            }  //#if DEBUG //           var response = await result.Content.ReadAsStringAsync(); //           Logger.Trace(MvxTraceLevel.Diagnostic, Caller, $"{ request.Method.Method}: { request.RequestUri.AbsolutePath}"); //           Logger.Trace(MvxTraceLevel.Diagnostic, Caller, $"StatusCode: { (int)result.StatusCode}. Response: { response}"); //#endif //            return result;

//        }
//    }
//}
