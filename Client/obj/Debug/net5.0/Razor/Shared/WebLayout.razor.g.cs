#pragma checksum "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Shared\WebLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3a7a11141768daab4d811e5428fd096e2dc7627"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Shared
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
#line 9 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Newtonsoft.Json;

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
#line 12 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Share.Models;

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
#line 18 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Shared\WebLayout.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Shared\WebLayout.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Shared\WebLayout.razor"
using Pages;

#line default
#line hidden
#nullable disable
    public partial class WebLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .blazored-modal {\r\n        width: 960px;\r\n    }\r\n\r\n    main {\r\n        min-height: 500px;\r\n    }\r\n</style>\r\n\r\n");
            __builder.OpenElement(1, "header");
            __builder.AddAttribute(2, "id", "header");
            __builder.AddAttribute(3, "class", "fixed-top d-flex align-items-center");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container d-flex align-items-center");
            __builder.AddMarkupContent(6, "<div class=\"logo me-auto\"><h1><a href=\"/\">SaC Backpack</a></h1></div>\r\n\r\n        ");
            __builder.OpenElement(7, "nav");
            __builder.AddAttribute(8, "id", "navbar");
            __builder.AddAttribute(9, "class", "navbar order-last order-lg-0");
            __builder.OpenElement(10, "ul");
            __builder.AddMarkupContent(11, "<li><a href=\"/\" class=\"nav-link\" style=\"cursor:pointer\" onclick=\"document.getElementById(\'hero\').scrollIntoView({behavior:\'smooth\'})\">Trang chủ</a></li>\r\n                ");
            __builder.OpenElement(12, "li");
            __builder.OpenElement(13, "a");
            __builder.AddAttribute(14, "class", "nav-link");
            __builder.AddAttribute(15, "style", "cursor:pointer");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Shared\WebLayout.razor"
                                                                           () => modal.Show<CartLayout>("Thông tin giỏ hàng")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(17, "Giỏ hàng");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.AddMarkupContent(19, "<li><a href=\"/products\" class=\"nav-link\" style=\"cursor:pointer\">Sản phẩm</a></li>\r\n                ");
            __builder.AddMarkupContent(20, "<li><a class=\"nav-link\" style=\"cursor:pointer\" onclick=\"document.getElementById(\'contact\').scrollIntoView({behavior:\'smooth\'})\">Liên hệ</a></li>\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(21);
            __builder.AddAttribute(22, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(23, "li");
                __builder2.AddAttribute(24, "class", "dropdown");
                __builder2.OpenElement(25, "a");
                __builder2.AddAttribute(26, "style", "cursor:pointer");
                __builder2.OpenElement(27, "span");
                __builder2.AddContent(28, 
#nullable restore
#line 40 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Shared\WebLayout.razor"
                                                             context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, " <i class=\"bi bi-chevron-down\"></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                            ");
                __builder2.OpenElement(31, "ul");
                __builder2.AddMarkupContent(32, "<li><a class=\"nav-link \" href=\"/history\">Lịch sử đặt hàng</a></li>\r\n                                ");
                __builder2.OpenElement(33, "li");
                __builder2.OpenElement(34, "a");
                __builder2.AddAttribute(35, "class", "nav-link ");
                __builder2.AddAttribute(36, "style", "cursor:pointer");
                __builder2.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Shared\WebLayout.razor"
                                                                                          BeginSignOut

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(38, "Đăng xuất");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(39, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 48 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Shared\WebLayout.razor"
                         if (emailAddress != null && emailAddress != "")
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(40, "li");
                __builder2.AddAttribute(41, "class", "dropdown");
                __builder2.OpenElement(42, "a");
                __builder2.AddAttribute(43, "style", "cursor:pointer");
                __builder2.OpenElement(44, "span");
                __builder2.AddContent(45, 
#nullable restore
#line 51 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Shared\WebLayout.razor"
                                                                 cusName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, " <i class=\"bi bi-chevron-down\"></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                                ");
                __builder2.OpenElement(48, "ul");
                __builder2.OpenElement(49, "li");
                __builder2.OpenElement(50, "a");
                __builder2.AddAttribute(51, "class", "nav-link ");
                __builder2.AddAttribute(52, "href", "/info/" + (
#nullable restore
#line 53 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Shared\WebLayout.razor"
                                                                          customerId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(53, "Thông tin cá nhân");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                                    ");
                __builder2.AddMarkupContent(55, "<li><a class=\"nav-link \" href=\"/history\">Lịch sử đặt hàng</a></li>\r\n                                    ");
                __builder2.AddMarkupContent(56, "<li><a class=\"nav-link \" href=\"/changepass\">Đổi mật khẩu</a></li>\r\n                                    ");
                __builder2.AddMarkupContent(57, "<li><a class=\"nav-link \" href=\"/logout\">Đăng xuất</a></li>");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 59 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Shared\WebLayout.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(58, @"<li class=""dropdown""><a style=""cursor:pointer""><span>Tài khoản</span> <i class=""bi bi-chevron-down""></i></a>
                                <ul><li><a class=""nav-link "" href=""/login"">Đăng nhập</a></li>
                                    <li><a class=""nav-link "" href=""/register"">Đăng ký</a></li></ul></li>");
#nullable restore
#line 69 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Shared\WebLayout.razor"
                        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n            <i class=\"bi bi-list mobile-nav-toggle\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n\r\n");
            __builder.OpenElement(61, "main");
            __builder.AddAttribute(62, "id", "main");
            __builder.AddContent(63, 
#nullable restore
#line 86 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Shared\WebLayout.razor"
     Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n");
            __builder.OpenComponent<Blazored.Modal.CascadingBlazoredModal>(65);
            __builder.AddAttribute(66, "HideHeader", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean?>(
#nullable restore
#line 88 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Shared\WebLayout.razor"
                                    true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(67, "\r\n\r\n");
            __builder.AddMarkupContent(68, @"<footer id=""footer""><div class=""footer-top""><div class=""container""><div class=""row""><div class=""col-lg-3 col-md-6""><div class=""footer-info""><h3>SaC Backpack</h3>
                        <p>
                            CVPM Quang Trung <br>
                            Quận 12, TP. HCM<br><br></p></div></div>

                <div class=""col-lg-3 col-md-6 footer-links""><h4>LỐI TẮT</h4>
                    <ul><li><i class=""bx bx-chevron-right""></i> <a href=""#"">Trang chủ</a></li>
                        <li><i class=""bx bx-chevron-right""></i> <a href=""#"">Đăng nhập</a></li></ul></div>
                <div class=""col-lg-3 col-md-6 footer-links""><h4>DỊCH VỤ CỦA CHÚNG TÔI</h4>
                    <ul><li><i class=""bx bx-chevron-right""></i> <a href=""#"">Sản phẩm</a></li>
                        <li><i class=""bx bx-chevron-right""></i> <a href=""#"">Dịch vụ</a></li></ul></div>
                <div class=""col-lg-3 col-md-6 footer-newsletter""><h4>LIÊN HỆ</h4>
                    <strong>SĐT:</strong> +1 5589 55488 55<br>
                    <strong>Email:</strong> info@example.com<br></div></div></div></div>

    <div class=""container""><div class=""credits"">

            Designed by <b>4Dev</b></div></div></footer>");
        }
        #pragma warning restore 1998
#nullable restore
#line 138 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Shared\WebLayout.razor"
      
    string emailAddress;
    string cusName;
    int customerId;
    public Customer cus;

    protected override async Task OnInitializedAsync()
    {
        emailAddress = sessionStorage.GetItem<string>("Email");
        customerId = sessionStorage.GetItem<int>("customerId");
        if (customerId != 0)
        {
            var apiUrl = config.GetSection("API")["APIUrl"].ToString();
            var accessToken = sessionStorage.GetItem<string>("AccessToken");
            cus = new Customer();
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
                client.BaseAddress = new Uri(apiUrl);
                using (var response = await client.GetAsync("Customer/?id=" + customerId))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    cus = JsonConvert.DeserializeObject<Customer>(apiResponse);
                }
                cusName = cus.FullName;
            }
        }

    }

    private async Task BeginSignOut(MouseEventArgs args)
    {
        await SignOutManager.SetSignOutState();
        navigationManager.NavigateTo($"authentication/logout");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService modal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignOutSessionStateManager SignOutManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
