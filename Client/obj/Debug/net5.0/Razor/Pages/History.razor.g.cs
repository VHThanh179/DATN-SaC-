#pragma checksum "D:\DATN\Project\SaCBackpack\Client\Pages\History.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c22c3cf6a6af643716166ff5f4a64bb7d43c061b"
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(WebLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/history")]
    public partial class History : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .lastest-product {\r\n    }\r\n</style>\r\n<br>\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "latest-products text-center");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
            __builder.AddMarkupContent(7, "<div class=\"col-md-12\"><div class=\"section-heading h2 text-center\">LỊCH SỬ ĐẶT HÀNG</div></div>\r\n            ");
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table");
            __builder.AddMarkupContent(10, @"<thead><tr><th>
                            Ngày đặt
                        </th>
                        <th>
                            Tổng tiền
                        </th>
                        <th>
                            Trạng thái
                        </th>
                        <th>
                            Ghi chú
                        </th>
                        <th>
                            Địa chỉ
                        </th>
                        <th></th></tr></thead>
                ");
            __builder.OpenElement(11, "tbody");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "<td>\r\n                            20/10/2021\r\n                        </td>\r\n                        ");
            __builder.AddMarkupContent(14, "<td>\r\n                            200000\r\n                        </td>\r\n                        ");
            __builder.AddMarkupContent(15, "<td>\r\n                            Đã giao\r\n                        </td>\r\n                        ");
            __builder.AddMarkupContent(16, "<td>\r\n                            ABC\r\n                        </td>\r\n                        ");
            __builder.AddMarkupContent(17, "<td>\r\n                            SG\r\n                        </td>\r\n                        ");
            __builder.OpenElement(18, "td");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "class", "btn btn-light btn-user btn");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "D:\DATN\Project\SaCBackpack\Client\Pages\History.razor"
                                                                              () => modal.Show<OrderDetails>("Chi tiết đơn hàng")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(22, "Chi tiết đơn hàng");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                            ");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "class", "btn btn-light btn-user btn");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "D:\DATN\Project\SaCBackpack\Client\Pages\History.razor"
                                                                              () => modal.Show<ShipInfoPage>("Thông tin vận chuyển")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(27, "Thông tin vận chuyển");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "tr");
            __builder.AddMarkupContent(30, "<td>\r\n                            20/10/2021\r\n                        </td>\r\n                        ");
            __builder.AddMarkupContent(31, "<td>\r\n                            200000\r\n                        </td>\r\n                        ");
            __builder.AddMarkupContent(32, "<td>\r\n                            Đã giao\r\n                        </td>\r\n                        ");
            __builder.AddMarkupContent(33, "<td>\r\n                            ABC\r\n                        </td>\r\n                        ");
            __builder.AddMarkupContent(34, "<td>\r\n                            SG\r\n                        </td>\r\n                        ");
            __builder.OpenElement(35, "td");
            __builder.OpenElement(36, "a");
            __builder.AddAttribute(37, "class", "btn btn-light btn-user btn");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "D:\DATN\Project\SaCBackpack\Client\Pages\History.razor"
                                                                              () => modal.Show<OrderDetails>("Chi tiết đơn hàng")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(39, "Chi tiết đơn hàng");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                            ");
            __builder.OpenElement(41, "a");
            __builder.AddAttribute(42, "class", "btn btn-light btn-user btn");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "D:\DATN\Project\SaCBackpack\Client\Pages\History.razor"
                                                                              () => modal.Show<ShipInfoPage>("Thông tin vận chuyển")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(44, "Thông tin vận chuyển");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService modal { get; set; }
    }
}
#pragma warning restore 1591
