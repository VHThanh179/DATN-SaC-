// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using BlazorAnimate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(WebLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/info/{id}")]
    public partial class Info : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 215 "D:\DATN\Project\SaCBackpack\Client\Pages\Info.razor"
       
    [Parameter]
    public string id { get; set; }
    private bool isPhoneNumberExisted = false;
    public Customer cus;
    private ToastParameters _toastParameters;
    [CascadingParameter] protected Task<AuthenticationState> AuthStat { get; set; }

    protected override async Task OnInitializedAsync()
    {
        if (string.IsNullOrWhiteSpace(id) || id == "0" || id == "0")
        {
            NavigationManager.NavigateTo("/");
        }
        else
        {
            var apiUrl = config.GetSection("API")["APIUrl"].ToString();
            var accessToken = sessionStorage.GetItem<string>("AccessToken");
            var accessTokenGoogle = AuthStat.Result.User.Claims.Where(_ => _.Type == "APIjwt").Select(_ => _.Value).FirstOrDefault();
            cus = new Customer();
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
                client.BaseAddress = new Uri(apiUrl);
                if (accessTokenGoogle != null && accessTokenGoogle != "")
                {
                    using (var response = await client.GetAsync("Customer/GetCustomerbyMail/?email=" + id))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        cus = JsonConvert.DeserializeObject<Customer>(apiResponse);
                    }
                }
                else
                {
                    using (var response = await client.GetAsync("Customer/?id=" + id))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        cus = JsonConvert.DeserializeObject<Customer>(apiResponse);
                    }
                }
            }
        }
    }

    private async void SubmitForm()
    {
        _toastParameters = new ToastParameters();
        var apiUrl = config.GetSection("API")["APIUrl"].ToString();
        var accessTokenGoogle = AuthStat.Result.User.Claims.Where(_ => _.Type == "APIjwt").Select(_ => _.Value).FirstOrDefault();
        var accessToken = sessionStorage.GetItem<string>("AccessToken");
        var customerId = sessionStorage.GetItem<int>("customerId");
        using (var client = new HttpClient())
        {
            if (accessToken != null && accessToken != "")
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            }
            if (accessTokenGoogle != null && accessTokenGoogle != "")
            {
                customerId = cus.CustomerId;
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessTokenGoogle);
            }
            client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            client.BaseAddress = new Uri(apiUrl);
            using (var resPhoneNumber = await client.GetAsync("Customer/CheckPhoneNumber/?phoneNumber=" + cus.PhoneNumber))
            {
                var phoneNumber = await resPhoneNumber.Content.ReadAsStringAsync();
                isPhoneNumberExisted = bool.Parse(phoneNumber);
            }
            if (!string.IsNullOrEmpty(cus.Address) && !string.IsNullOrEmpty(cus.PhoneNumber))
            {
                if (isPhoneNumberExisted)
                {
                    _toastParameters.Add(nameof(Notification.Title), "Số điện thoại đã tồn tại!");
                    _toastParameters.Add(nameof(Notification.IsSuccess), false);
                    toastService.ShowToast<Notification>(_toastParameters);
                }
                else
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(cus), System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PutAsync("customer/?id=" + customerId, content);
                    if (response.StatusCode != HttpStatusCode.OK)
                    {

                    }
                    else
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        if (apiResponse == "-1")
                        {
                            _toastParameters.Add(nameof(Notification.Title), "Chỉnh sửa thất bại!");
                            _toastParameters.Add(nameof(Notification.IsSuccess), false);
                            toastService.ShowToast<Notification>(_toastParameters);
                        }
                        else
                        {
                            _toastParameters.Add(nameof(Notification.Title), "Chỉnh sửa thành công!");
                            _toastParameters.Add(nameof(Notification.IsSuccess), true);
                            toastService.ShowToast<Notification>(_toastParameters);
                            await JSRuntime.InvokeVoidAsync("RefreshCustomer.refreshData");
                        }
                    }
                }
            }
            else
            {
                if (string.IsNullOrEmpty(cus.Address) && string.IsNullOrEmpty(cus.PhoneNumber))
                {
                    _toastParameters.Add(nameof(Notification.Title), "Vui lòng nhập địa chỉ và số điện thoại!");
                    _toastParameters.Add(nameof(Notification.IsSuccess), false);
                    toastService.ShowToast<Notification>(_toastParameters);
                }
                else
                {
                    if (string.IsNullOrEmpty(cus.Address))
                    {
                        _toastParameters.Add(nameof(Notification.Title), "Vui lòng nhập địa chỉ!");
                        _toastParameters.Add(nameof(Notification.IsSuccess), false);
                        toastService.ShowToast<Notification>(_toastParameters);
                    }
                    if (string.IsNullOrEmpty(cus.PhoneNumber))
                    {
                        _toastParameters.Add(nameof(Notification.Title), "Vui lòng nhập số điện thoại!");
                        _toastParameters.Add(nameof(Notification.IsSuccess), false);
                        toastService.ShowToast<Notification>(_toastParameters);
                    }
                }
            }
        }
    }

    private void Cancel()
    {
        NavigationManager.NavigateTo("/", true);
    }

    //private bool IsVisible { get; set; }

    //private void OpenDialog()
    //{
    //    IsVisible = true;
    //}

    //private void CloseDialog()
    //{
    //    IsVisible = false;
    //    NavigationManager.NavigateTo("/", true);
    //}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
