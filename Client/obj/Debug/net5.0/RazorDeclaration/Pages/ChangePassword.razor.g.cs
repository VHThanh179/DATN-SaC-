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
#line 2 "D:\DATN\Project\SaCBackpack\Client\Pages\ChangePassword.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DATN\Project\SaCBackpack\Client\Pages\ChangePassword.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DATN\Project\SaCBackpack\Client\Pages\ChangePassword.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DATN\Project\SaCBackpack\Client\Pages\ChangePassword.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DATN\Project\SaCBackpack\Client\Pages\ChangePassword.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DATN\Project\SaCBackpack\Client\Pages\ChangePassword.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(WebLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/changepass")]
    public partial class ChangePassword : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 266 "D:\DATN\Project\SaCBackpack\Client\Pages\ChangePassword.razor"
       
    // NOTE: Các property cần có
    private ToastParameters _toastParameters;
    public Customer customer { get; set; }
    public int customerId { get; set; }
    public string oldPass = "";
    public string newPass = "";
    public string confirmPass = "";
    public string encodePass = "";
    private async Task SubmitForm()
    {
        // NOTE: Lấy id của khách hàng bằng session
        customerId = sessionStorage.GetItem<int>("customerId");
        var apiUrl = config.GetSection("API")["APIUrl"].ToString();
        var accessToken = sessionStorage.GetItem<string>("AccessToken");
        customer = new Customer();
        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            client.BaseAddress = new Uri(apiUrl);
            using (var response = await client.GetAsync("customer/GetPass/?pass=" + oldPass))
            {
                // NOTE: Mật khẩu cũ sau khi encode sẽ gán cho biến encodePass
                encodePass = await response.Content.ReadAsStringAsync();
                Console.WriteLine(encodePass);
            }
            customer = new Customer();
            // NOTE: Lấy ra khách hàng theo id
            using (var response = await client.GetAsync("customer/?id=" + customerId))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                customer = JsonConvert.DeserializeObject<Customer>(apiResponse);
            }
            // NOTE: So sánh pass cũ đã encode với pass trong db
            if (string.Equals(encodePass, customer.Password))
            {
                // NOTE: So sánh pass mới với confirm pass
                if (string.Equals(newPass, confirmPass))
                {
                    // NOTE: Gán pass của customer hiện tại = pass mới
                    // NOTE: Phải gán cả cho confirmPass của customer hiện tại nếu không sẽ bị lỗi confirmPass is null
                    customer.Password = newPass;
                    customer.ConfirmPassword = newPass;
                    StringContent content = new StringContent(JsonConvert.SerializeObject(customer), System.Text.Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PutAsync("customer/?id=" + customerId, content);
                    if (response.StatusCode != HttpStatusCode.OK) { }
                    else
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        if (apiResponse == "-1")
                        {
                            _toastParameters.Add(nameof(Notification.Title), "Đổi mật khẩu thất bại!");
                            _toastParameters.Add(nameof(Notification.IsSuccess), false);
                            toastService.ShowToast<Notification>(_toastParameters);
                        }
                        else // Change pass successfully
                        {
                            OpenDialog();
                        }
                    }
                }
                else
                {
                    _toastParameters.Add(nameof(Notification.Title), "Mật khẩu mới và xác nhận mật khẩu mới không khớp!");
                    _toastParameters.Add(nameof(Notification.IsSuccess), false);
                    toastService.ShowToast<Notification>(_toastParameters);
                }
            }
            else
            {
                _toastParameters.Add(nameof(Notification.Title), "Mật khẩu cũ không đúng!");
                _toastParameters.Add(nameof(Notification.IsSuccess), false);
                toastService.ShowToast<Notification>(_toastParameters);
            }
        }
    }

    private bool IsVisible { get; set; }

    private void OpenDialog()
    {
        IsVisible = true;
    }

    private void Confirm()
    {
        NavigationManager.NavigateTo("/logout", true);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime IJSRuntime { get; set; }
    }
}
#pragma warning restore 1591
