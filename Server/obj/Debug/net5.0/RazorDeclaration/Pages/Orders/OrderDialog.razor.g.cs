// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Server.Pages.Orders
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
#line 2 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderDialog.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderDialog.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderDialog.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/orderdialog/{id}")]
    public partial class OrderDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "D:\DATN\Project\SaCBackpack\Server\Pages\Orders\OrderDialog.razor"
       
        [Parameter]
        public string id { get; set; }
private Share.Models.Order order { get; set; }

    protected override void OnInitialized()
    {
        if (string.IsNullOrWhiteSpace(id) || id == "0")
        {
            navigation.NavigateTo("orderlist", true);
        }
        else
        {
            order = _orderService.GetOrder(int.Parse(id));
        }
    }
    private void SubmitForm()
    {
        _orderService.EditOrder(order.OrderId, order);
        navigation.NavigateTo("Orderlist");
    }
    public void Cancel()
    {
        navigation.NavigateTo("OrderList", true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment env { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Share.Interfaces.IOrderSvc _orderService { get; set; }
    }
}
#pragma warning restore 1591
