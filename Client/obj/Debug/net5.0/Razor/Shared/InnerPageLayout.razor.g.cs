#pragma checksum "D:\DATN\Project\SaCBackpack\Client\Shared\InnerPageLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77a95dfcea0786ffb3275a789dfac33f132c337f"
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
#line 9 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using Newtonsoft.Json;

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
#line 12 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using Share.Models;

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
#line 18 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\DATN\Project\SaCBackpack\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
    public partial class InnerPageLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    main {\r\n        min-height: 500px;\r\n    }\r\n</style>\r\n");
            __builder.AddMarkupContent(1, @"<header id=""header"" class=""fixed-top d-flex align-items-center""><div class=""container d-flex align-items-center""><div class=""logo me-auto""><h1><a href=""/"">SaC Backpack</a></h1></div>

        <nav id=""navbar"" class=""navbar order-last order-lg-0""><ul><li><a class=""nav-link scrollto"" href=""/"">Trang chủ</a></li>
                <li class=""dropdown""><a style=""cursor:pointer""><span>Tài khoản</span> <i class=""bi bi-chevron-down""></i></a>
                    <ul><li><a class=""nav-link scrollto"" href=""/login"">Đăng nhập</a></li>
                        <li><a class=""nav-link scrollto"" href=""/register"">Đăng ký</a></li></ul></li></ul></nav></div></header>

");
            __builder.OpenElement(2, "main");
            __builder.AddAttribute(3, "id", "main");
            __builder.AddContent(4, 
#nullable restore
#line 35 "D:\DATN\Project\SaCBackpack\Client\Shared\InnerPageLayout.razor"
     Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenComponent<Blazored.Toast.BlazoredToasts>(6);
            __builder.AddAttribute(7, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazored.Toast.Configuration.ToastPosition>(
#nullable restore
#line 37 "D:\DATN\Project\SaCBackpack\Client\Shared\InnerPageLayout.razor"
                          Blazored.Toast.Configuration.ToastPosition.TopRight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "Timeout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 37 "D:\DATN\Project\SaCBackpack\Client\Shared\InnerPageLayout.razor"
                                                                                        2

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.AddMarkupContent(10, @"<footer id=""footer""><div class=""footer-top""><div class=""container""><div class=""row""><div class=""col-lg-3 col-md-6""><div class=""footer-info""><h3>SaC Backpack</h3>
                        <p>
                            CVPM Quang Trung <br>
                            Quận 12, TP. HCM<br><br></p></div></div>

                <div class=""col-lg-3 col-md-6 footer-links""><h4>LỐI TẮT</h4>
                    <ul><li><i class=""bx bx-chevron-right""></i> <a href=""/"">Trang chủ</a></li>
                        <li><i class=""bx bx-chevron-right""></i> <a href=""/login"">Đăng nhập</a></li></ul></div>
                <div class=""col-lg-3 col-md-6 footer-links""><h4>DỊCH VỤ CỦA CHÚNG TÔI</h4>
                    <ul><li><i class=""bx bx-chevron-right""></i> <a href=""/products"">Sản phẩm</a></li></ul></div>
                <div class=""col-lg-3 col-md-6 footer-newsletter""><h4>LIÊN HỆ</h4>
                    <strong>SĐT:</strong> 033 278 0105<br>
                    <strong>Email:</strong> web.sacbackpack@gmail.com<br></div></div></div></div>

    <div class=""container""><div class=""credits"">

            Designed by <b>4Dev</b></div></div></footer>");
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "D:\DATN\Project\SaCBackpack\Client\Shared\InnerPageLayout.razor"
       
    protected override async Task OnInitializedAsync()
    {
        await JSRuntime.InvokeVoidAsync("mainJS");
    }

    //string email;
    //int customerid;
    //protected override async Task OnInitializedAsync()
    //{
    //    email = sessionStorage.GetItem<string>("Email");

    //    customerid = sessionStorage.GetItem<int>("customerId");
    //}
    //protected void o()
    //{
    //    email = sessionStorage.GetItem<string>("Email");
    //}
    //protected void Logout()
    //{
    //    sessionStorage.RemoveItem("AccessToken");
    //    sessionStorage.RemoveItem("Email");
    //    NavigationManager.NavigateTo("/");
    //}
    //protected void Logout()
    //{
    //    sessionStorage.RemoveItem("AccessToken");
    //    sessionStorage.RemoveItem("Email");
    //    navigationManager.NavigateTo("/", true);
    //}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
