#pragma checksum "D:\DATN\Project\SaCBackpack\Client\Pages\ChangePassword.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36b6189b5b5b4c9024b37a3bd6a69fa8d54181df"
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
using Newtonsoft.Json;

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
            __builder.AddMarkupContent(0, "<style>\r\n:root {\r\n    --input-padding-x: 1.5rem;\r\n    --input-padding-y: .75rem;\r\n}\r\n\r\n.card-signin {\r\n    border: 0;\r\n    border-radius: 1rem;\r\n    box-shadow: 0 0.5rem 1rem 0 rgba(0, 0, 0, 0.1);\r\n}\r\n\r\n.card-signin .card-title {\r\n    margin-bottom: 2rem;\r\n    font-weight: 300;\r\n    font-size: 1.5rem;\r\n}\r\n\r\n.card-signin .card-body {\r\n    padding: 2rem;\r\n}\r\n\r\n.form-signin {\r\n    width: 100%;\r\n}\r\n\r\n.form-signin .btn {\r\n    font-size: 80%;\r\n    border-radius: 5rem;\r\n    letter-spacing: .1rem;\r\n    font-weight: bold;\r\n    padding: 1rem;\r\n    transition: all 0.2s;\r\n}\r\n\r\n.form-label-group {\r\n    position: relative;\r\n    margin-bottom: 1rem;\r\n}\r\n\r\n.form-label-group input {\r\n    height: auto;\r\n    border-radius: 2rem;\r\n}\r\n\r\n.form-label-group > input,\r\n.form-label-group > label {\r\n    padding: var(--input-padding-y) var(--input-padding-x);\r\n}\r\n\r\n.form-label-group > label {\r\n    position: absolute;\r\n    top: 0;\r\n    left: 0;\r\n    display: block;\r\n    width: 100%;\r\n    margin-bottom: 0;\r\n    line-height: 1.5;\r\n    color: #495057;\r\n    border: 1px solid transparent;\r\n    border-radius: .25rem;\r\n    transition: all .1s ease-in-out;\r\n}\r\n\r\n.form-label-group input::-webkit-input-placeholder {\r\n    color: transparent;\r\n}\r\n\r\n.form-label-group input:-ms-input-placeholder {\r\n    color: transparent;\r\n}\r\n\r\n.form-label-group input::-ms-input-placeholder {\r\n    color: transparent;\r\n}\r\n\r\n.form-label-group input::-moz-placeholder {\r\n    color: transparent;\r\n}\r\n\r\n.form-label-group input::placeholder {\r\n    color: transparent;\r\n}\r\n\r\n.form-label-group input:not(:placeholder-shown) {\r\n    padding-top: calc(var(--input-padding-y) + var(--input-padding-y) * (2 / 3));\r\n    padding-bottom: calc(var(--input-padding-y) / 3);\r\n}\r\n\r\n.form-label-group input:not(:placeholder-shown) ~ label {\r\n    padding-top: calc(var(--input-padding-y) / 3);\r\n    padding-bottom: calc(var(--input-padding-y) / 3);\r\n    font-size: 12px;\r\n    color: #777;\r\n}\r\n\r\n.btn-google {\r\n    color: white;\r\n    background-color: #ea4335;\r\n}\r\n\r\n.btn-facebook {\r\n    color: white;\r\n    background-color: #3b5998;\r\n}\r\n\r\n    /* Fallback for Edge\r\n    -------------------------------------------------- */\r\n\r\n</style>\r\n<br>\r\n<br>\r\n");
            __builder.OpenComponent<BlazorAnimate.Animate>(1);
            __builder.AddAttribute(2, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 123 "D:\DATN\Project\SaCBackpack\Client\Pages\ChangePassword.razor"
                    Animations.FadeUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 123 "D:\DATN\Project\SaCBackpack\Client\Pages\ChangePassword.razor"
                                                 TimeSpan.FromSeconds(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, @"<div class=""mt-2""><div class=""container""><div class=""row""><div class=""col-sm-9 col-md-7 col-lg-5 mx-auto""><div class=""card card-signin my-5""><div class=""card-body""><h5 class=""card-title text-center fw-bold"">ĐỔI MẬT KHẨU</h5>
                            <form><div class=""form-label-group""><input type=""password"" id=""oldPassword"" class=""form-control"" placeholder=""Mật khẩu cũ"" required>
                                    <label for=""oldPassword"">Mật khẩu cũ</label></div>
                                <div class=""form-label-group""><input type=""password"" id=""inputPassword"" class=""form-control"" placeholder=""Mật khẩu mới"" required>
                                    <label for=""inputPassword"">Mật khẩu</label></div>
                                <div class=""form-label-group""><input type=""password"" id=""inputConfirmPassword"" class=""form-control"" placeholder=""Xác nhận mật khẩu"" required>
                                    <label for=""inputConfirmPassword"">Xác nhận mật khẩu</label></div>
                                <div class=""d-grid""><input value=""Lưu"" type=""submit"" class=""btn btn-lg btn-dark btn-block text-uppercase""></div></form></div></div></div></div></div></div>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime IJSRuntime { get; set; }
    }
}
#pragma warning restore 1591
