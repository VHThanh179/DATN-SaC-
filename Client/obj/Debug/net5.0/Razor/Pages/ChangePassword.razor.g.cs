#pragma checksum "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ChangePassword.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccc11e951a2d2fda2e261f5be4fe7ee7f41ba7e9"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using BlazorAnimate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ChangePassword.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ChangePassword.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ChangePassword.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ChangePassword.razor"
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
            __builder.AddMarkupContent(0, "<style>\r\n    :root {\r\n        --input-padding-x: 1.5rem;\r\n        --input-padding-y: .75rem;\r\n    }\r\n\r\n    .card-signin {\r\n        border: 0;\r\n        border-radius: 1rem;\r\n        box-shadow: 0 0.5rem 1rem 0 rgba(0, 0, 0, 0.1);\r\n    }\r\n\r\n        .card-signin .card-title {\r\n            margin-bottom: 2rem;\r\n            font-weight: 300;\r\n            font-size: 1.5rem;\r\n        }\r\n\r\n        .card-signin .card-body {\r\n            padding: 2rem;\r\n        }\r\n\r\n    .form-signin {\r\n        width: 100%;\r\n    }\r\n\r\n        .form-signin .btn {\r\n            font-size: 80%;\r\n            border-radius: 5rem;\r\n            letter-spacing: .1rem;\r\n            font-weight: bold;\r\n            padding: 1rem;\r\n            transition: all 0.2s;\r\n        }\r\n\r\n    .form-label-group {\r\n        position: relative;\r\n        margin-bottom: 1rem;\r\n    }\r\n\r\n        .form-label-group input {\r\n            height: auto;\r\n            border-radius: 2rem;\r\n        }\r\n\r\n        .form-label-group > input,\r\n        .form-label-group > label {\r\n            padding: var(--input-padding-y) var(--input-padding-x);\r\n        }\r\n\r\n        .form-label-group > label {\r\n            position: absolute;\r\n            top: 0;\r\n            left: 0;\r\n            display: block;\r\n            width: 100%;\r\n            margin-bottom: 0;\r\n            line-height: 1.5;\r\n            color: #495057;\r\n            border: 1px solid transparent;\r\n            border-radius: .25rem;\r\n            transition: all .1s ease-in-out;\r\n        }\r\n\r\n        .form-label-group input::-webkit-input-placeholder {\r\n            color: transparent;\r\n        }\r\n\r\n        .form-label-group input:-ms-input-placeholder {\r\n            color: transparent;\r\n        }\r\n\r\n        .form-label-group input::-ms-input-placeholder {\r\n            color: transparent;\r\n        }\r\n\r\n        .form-label-group input::-moz-placeholder {\r\n            color: transparent;\r\n        }\r\n\r\n        .form-label-group input::placeholder {\r\n            color: transparent;\r\n        }\r\n\r\n        .form-label-group input:not(:placeholder-shown) {\r\n            padding-top: calc(var(--input-padding-y) + var(--input-padding-y) * (2 / 3));\r\n            padding-bottom: calc(var(--input-padding-y) / 3);\r\n        }\r\n\r\n            .form-label-group input:not(:placeholder-shown) ~ label {\r\n                padding-top: calc(var(--input-padding-y) / 3);\r\n                padding-bottom: calc(var(--input-padding-y) / 3);\r\n                font-size: 12px;\r\n                color: #777;\r\n            }\r\n\r\n    .btn-google {\r\n        color: white;\r\n        background-color: #ea4335;\r\n    }\r\n\r\n    .btn-facebook {\r\n        color: white;\r\n        background-color: #3b5998;\r\n    }\r\n\r\n    /* Fallback for Edge\r\n    -------------------------------------------------- */\r\n\r\n</style>\r\n<br>\r\n<br>\r\n");
            __builder.OpenComponent<BlazorAnimate.Animate>(1);
            __builder.AddAttribute(2, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 124 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ChangePassword.razor"
                    Animations.FadeUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 124 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ChangePassword.razor"
                                                 TimeSpan.FromSeconds(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "mt-2");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "container");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "row");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-sm-9 col-md-7 col-lg-5 mx-auto");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "card card-signin my-5");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "card-body");
                __builder2.AddMarkupContent(17, "<h5 class=\"card-title text-center fw-bold\">ĐỔI MẬT KHẨU</h5>\r\n                            ");
                __builder2.OpenElement(18, "form");
                __builder2.AddAttribute(19, "onsubmit", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 133 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ChangePassword.razor"
                                             SubmitForm

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-label-group");
                __builder2.OpenElement(22, "input");
                __builder2.AddAttribute(23, "type", "password");
                __builder2.AddAttribute(24, "id", "oldPassword");
                __builder2.AddAttribute(25, "class", "form-control");
                __builder2.AddAttribute(26, "placeholder", "Mật khẩu cũ");
                __builder2.AddAttribute(27, "required");
                __builder2.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 136 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ChangePassword.razor"
                                                                                                         oldPass

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => oldPass = __value, oldPass));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                                    ");
                __builder2.AddMarkupContent(31, "<label for=\"oldPassword\">Mật khẩu cũ</label>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                                ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-label-group");
                __builder2.OpenElement(35, "input");
                __builder2.AddAttribute(36, "type", "password");
                __builder2.AddAttribute(37, "id", "inputPassword");
                __builder2.AddAttribute(38, "class", "form-control");
                __builder2.AddAttribute(39, "placeholder", "Mật khẩu mới");
                __builder2.AddAttribute(40, "required");
                __builder2.AddAttribute(41, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 140 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ChangePassword.razor"
                                                                                                           newPass

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newPass = __value, newPass));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                                    ");
                __builder2.AddMarkupContent(44, "<label for=\"inputPassword\">Mật khẩu</label>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                                ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "form-label-group");
                __builder2.OpenElement(48, "input");
                __builder2.AddAttribute(49, "type", "password");
                __builder2.AddAttribute(50, "id", "inputConfirmPassword");
                __builder2.AddAttribute(51, "class", "form-control");
                __builder2.AddAttribute(52, "placeholder", "Xác nhận mật khẩu");
                __builder2.AddAttribute(53, "required");
                __builder2.AddAttribute(54, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 144 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ChangePassword.razor"
                                                                                                                  confirmPass

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => confirmPass = __value, confirmPass));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n                                    ");
                __builder2.AddMarkupContent(57, "<label for=\"inputConfirmPassword\">Xác nhận mật khẩu</label>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                                ");
                __builder2.AddMarkupContent(59, "<div class=\"d-grid\"><input value=\"Lưu\" type=\"submit\" class=\"btn btn-lg btn-dark btn-block text-uppercase\"></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(60, "\r\n\r\n");
            __builder.OpenComponent<Syncfusion.Blazor.Popups.SfDialog>(61);
            __builder.AddAttribute(62, "Width", "500px");
            __builder.AddAttribute(63, "Height", "250px");
            __builder.AddAttribute(64, "IsModal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 160 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ChangePassword.razor"
                                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 160 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ChangePassword.razor"
                                                                     IsVisible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "VisibleChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => IsVisible = __value, IsVisible))));
            __builder.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogTemplates>(68);
                __builder2.AddAttribute(69, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(70, " Thông báo !");
                }
                ));
                __builder2.AddAttribute(71, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(72, 
#nullable restore
#line 163 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ChangePassword.razor"
                  dialogContent

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(73, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogAnimationSettings>(74);
                __builder2.AddAttribute(75, "Effect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Popups.DialogEffect>(
#nullable restore
#line 165 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ChangePassword.razor"
                                     DialogEffect.FlipYRight

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(76, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 165 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ChangePassword.razor"
                                                                       500

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(77, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogButtons>(78);
                __builder2.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Popups.DialogButton>(80);
                    __builder3.AddAttribute(81, "Content", "OK");
                    __builder3.AddAttribute(82, "IsPrimary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 167 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ChangePassword.razor"
                                              true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(83, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 167 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ChangePassword.razor"
                                                             () => CloseDialog(reset)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 171 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ChangePassword.razor"
       
        // NOTE: Các property cần có
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
                            dialogContent = "Đổi mật khẩu thất bại";
                        }
                        else // Change pass successfully
                        {
                            dialogContent = "Đổi mật khẩu thành công, vui lòng đăng nhập lại";
                            reset = true;
                            OpenDialog();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Mật khẩu mới và xác nhận mật khẩu mới không khớp");
                    dialogContent = "Mật khẩu mới và xác nhận mật khẩu mới không khớp";
                    OpenDialog();
                }
            }
            else
            {
                Console.WriteLine("Mật khẩu cũ không đúng");
                dialogContent = "Mật khẩu cũ không đúng, vui lòng kiểm tra";
                OpenDialog();
            }
        }
    }

    private string dialogContent;
    private bool IsVisible { get; set; }
    private bool reset { get; set; } = false;

    private void OpenDialog()
    {
        IsVisible = true;
    }

    private void CloseDialog(bool navigate)
    {
        if (navigate)
        {
            IsVisible = false;
            NavigationManager.NavigateTo("/logout", true);
        }
        else
        {
            IsVisible = false;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime IJSRuntime { get; set; }
    }
}
#pragma warning restore 1591
