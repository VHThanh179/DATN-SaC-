#pragma checksum "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cb4c84acd3d12de153eb89d1fce627ef836ac21"
// <auto-generated/>
#pragma warning disable 1591
namespace Server.Pages.Users
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
using Share.Helpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/userlist")]
    public partial class UserList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"font-weight-bold text-center\">Danh sách người dùng</h1>");
#nullable restore
#line 7 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
 if (users == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading ...</em></p>");
#nullable restore
#line 10 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "text-right");
            __builder.AddMarkupContent(4, "<a style=\"text-decoration:none;\" href=\"/userdialog/0\"><button type=\"button\" class=\"btn btn-success btn-circle btn-md\"><i class=\"fa fa-plus\" style=\"color:white;font-size:20px;\"></i></button></a>\r\n        <br>\r\n        <br>\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
                                       SearchString

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchString = __value, SearchString));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "class", "btn btn-outline-success");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
                                                              OnParametersSet

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(15, "<i class=\"fa fa-search\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "btn btn-outline-primary");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
                                                              OnInitialized

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(20, "Danh sách");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        <br>\r\n        <br>");
            __builder.CloseElement();
            __builder.OpenElement(22, "table");
            __builder.AddAttribute(23, "class", "table table-hover text-center");
            __builder.AddMarkupContent(24, @"<thead class=""thead-dark""><tr><th>Tài khoản</th>
                <th>Họ tên</th>
                <th>Email</th>
                <th>Ngày sinh</th>
                <th>Vai trò</th>
                <th>Trạng thái</th>
                <th></th></tr></thead>
        ");
            __builder.OpenElement(25, "tbody");
#nullable restore
#line 41 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
             foreach (var item in users)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "tr");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 44 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
                         item.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 45 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
                         item.FullName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 46 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
                         item.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 47 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
                         item.DoB.Date.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 48 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
                         item.Roles.DisplayName()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "td");
#nullable restore
#line 50 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
                         if (item.Status)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(43, "<span>Hoạt động</span>");
#nullable restore
#line 53 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(44, "<span>Không hoạt động</span>");
#nullable restore
#line 57 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.OpenElement(46, "td");
            __builder.OpenElement(47, "a");
            __builder.AddAttribute(48, "class", "btn btn-info");
            __builder.AddAttribute(49, "href", "/userdialog/" + (
#nullable restore
#line 60 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
                                                                   item.UserId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(50, "Sửa");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 63 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 66 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "D:\DATN\Project\SaCBackpack\Server\Pages\Users\UserList.razor"
       
    [Parameter]
    public string SearchString { get; set; }
    public List<User> users;
    protected override void OnInitialized()
    {
        users = _userService.GetAllUser();
    }

    protected override void OnParametersSet()
    {
        if (!string.IsNullOrEmpty(SearchString))
        {
            users = _userService.GetAllUser().Where(x => x.FullName.ToUpper().Contains(SearchString.ToUpper())).ToList();
        }
        else
        {
            users = _userService.GetAllUser();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Share.Interfaces.IUserSvc _userService { get; set; }
    }
}
#pragma warning restore 1591
