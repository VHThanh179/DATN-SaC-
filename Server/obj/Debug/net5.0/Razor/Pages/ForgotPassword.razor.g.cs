#pragma checksum "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\ForgotPassword.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "376bda056c7e998ea4442376b38113a7bc230c58"
// <auto-generated/>
#pragma warning disable 1591
namespace Server.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\ForgotPassword.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\ForgotPassword.razor"
           [AllowAnonymous]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/forgotPassword")]
    public partial class ForgotPassword : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row justify-content-center");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-xl-10 col-lg-12 col-md-9");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card o-hidden border-0 shadow-lg my-5");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-body p-0");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "row");
            __builder.AddMarkupContent(12, "<div class=\"col-lg-6 d-none d-lg-block bg-login-image\"></div>\r\n                        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-lg-6");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "p-5");
            __builder.AddMarkupContent(17, "<div class=\"text-center\"><h1 class=\"h4 text-gray-900 mb-4\">Quên mật khẩu?</h1></div>\r\n                                ");
            __builder.OpenElement(18, "form");
            __builder.AddAttribute(19, "class", "user");
            __builder.AddAttribute(20, "onsubmit", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 23 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\ForgotPassword.razor"
                                                                () => ForgotPass(email)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "form-group");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "type", "email");
            __builder.AddAttribute(25, "class", "form-control form-control-user");
            __builder.AddAttribute(26, "id", "email");
            __builder.AddAttribute(27, "aria-describedby", "emailHelp");
            __builder.AddAttribute(28, "placeholder", "Email");
            __builder.AddAttribute(29, "required");
            __builder.AddAttribute(30, "autofocus");
            __builder.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\ForgotPassword.razor"
                                                                  email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => email = __value, email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                                    ");
            __builder.AddMarkupContent(34, "<button class=\"btn btn-primary btn-user btn-block\" type=\"submit\">Quên mật khẩu</button>");
#nullable restore
#line 30 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\ForgotPassword.razor"
                                     if (!string.IsNullOrEmpty(error))
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "alert alert-danger mt-3 mb-3");
            __builder.AddContent(37, 
#nullable restore
#line 32 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\ForgotPassword.razor"
                                                                                    (MarkupString)error

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\ForgotPassword.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                                <hr>\r\n                                ");
            __builder.AddMarkupContent(39, "<div class=\"text-center\"><a class=\"small\" href=\"/login?returnUrl=/\">Đăng nhập</a></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\r\n");
            __builder.OpenComponent<Syncfusion.Blazor.Popups.SfDialog>(41);
            __builder.AddAttribute(42, "Width", "500px");
            __builder.AddAttribute(43, "Height", "250px");
            __builder.AddAttribute(44, "IsModal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 48 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\ForgotPassword.razor"
                                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 48 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\ForgotPassword.razor"
                                                                     IsVisible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "VisibleChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => IsVisible = __value, IsVisible))));
            __builder.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogTemplates>(48);
                __builder2.AddAttribute(49, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(50, "<i class=\"fa fa-envelope-open\" aria-hidden=\"true\"></i> Thông báo !");
                }
                ));
                __builder2.AddAttribute(51, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(52, "div");
                    __builder3.AddAttribute(53, "class", "ds");
                    __builder3.AddContent(54, 
#nullable restore
#line 51 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\ForgotPassword.razor"
                                  dialogContent

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogAnimationSettings>(56);
                __builder2.AddAttribute(57, "Effect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Popups.DialogEffect>(
#nullable restore
#line 53 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\ForgotPassword.razor"
                                     DialogEffect.FlipYRight

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 53 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\ForgotPassword.razor"
                                                                       500

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(59, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogButtons>(60);
                __builder2.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Popups.DialogButton>(62);
                    __builder3.AddAttribute(63, "Content", "OK");
                    __builder3.AddAttribute(64, "IsPrimary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 55 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\ForgotPassword.razor"
                                              true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(65, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\ForgotPassword.razor"
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
            __builder.AddMarkupContent(66, "\r\n\r\n\r\n}\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\ForgotPassword.razor"
      
    private string error;
    public string email = "";
    private Share.Models.User user { get; set; }

    private void ForgotPass(string mail)
    {
        Random random = new Random();
        error = "";
        if (mail != "")
        {
            if (_userSvc.CheckEmail(mail))
            {
                user = _userSvc.GetUserbyMail(email);
                var pass = random.Next(100, 300).ToString();
                _mailSvc.SendEmailAsync(mail, pass);
                user.Password = pass;
                _userSvc.EditUserbyMail(user.UserId, user);
                dialogContent = "Mật khẩu mới đã được gửi qua mail";
                OpenDialog();
            }
            else
            {
                dialogContent = "Email không tồn tại vui lòng thử lại";
                OpenDialog();
            }
        }
        else
        {
            dialogContent = "Vui lòng nhập mail";
            OpenDialog();
        }
    }

    private string dialogContent;
    private bool IsVisible { get; set; }

    private void OpenDialog()
    {
        IsVisible = true;
    }

    private void CloseDialog()
    {
        IsVisible = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Share.Interfaces.IEncodeHelper _encodeHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Share.Interfaces.IUserSvc _userSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Share.Interfaces.IMailSvc _mailSvc { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
