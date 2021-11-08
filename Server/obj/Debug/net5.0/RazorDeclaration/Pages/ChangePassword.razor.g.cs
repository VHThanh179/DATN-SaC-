// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Server.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\_Imports.razor"
using Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\_Imports.razor"
using Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ChangePassword.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ChangePassword.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/changepass")]
    public partial class ChangePassword : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ChangePassword.razor"
       
    public string oldPass, newPass, confirmPass;

    [CascadingParameter] protected Task<AuthenticationState> AuthStat { get; set; }
    string id;
    User user = new User();
    protected override void OnInitialized()
    {
        id = AuthStat.Result.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        user = _userService.GetUser(int.Parse(id));
    }

    public void ChangePass()
    {
        if (!string.IsNullOrEmpty(oldPass) || !string.IsNullOrEmpty(newPass) || !string.IsNullOrEmpty(confirmPass))
        {
            if (string.Equals(user.Password, _encodeHelper.Encode(oldPass)))
            {
                if (string.Equals(newPass, confirmPass))
                {
                    user.Password = _encodeHelper.Encode(newPass);
                    user.ConfirmPass = user.Password;
                    _userService.EditUser(int.Parse(id), user);
                    navigationManager.NavigateTo("/", true);
                }
            }
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Share.Interfaces.IEncodeHelper _encodeHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Share.Interfaces.IUserSvc _userService { get; set; }
    }
}
#pragma warning restore 1591
