#pragma checksum "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ShipInfoPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f4993dfb34a43e6325210a7cd752c64ee0a9212"
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
#line 18 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ShipInfoPage.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ShipInfoPage.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ShipInfoPage.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ShipInfoPage.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ShipInfoPage.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/shipinfo/{id}")]
    public partial class ShipInfoPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Thông tin vận chuyển</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "<hr>\r\n    ");
            __builder.OpenElement(3, "dl");
            __builder.AddAttribute(4, "class", "row");
#nullable restore
#line 14 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ShipInfoPage.razor"
         if (ships.ShippingMethod)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<dt class=\"col-sm-4\">Phương thức vận chuyển</dt>\r\n            ");
            __builder.AddMarkupContent(6, "<dd class=\"col-sm-8\">\r\n                Giao hàng tận nhà\r\n            </dd>");
            __builder.AddMarkupContent(7, "<dt class=\"col-sm-4\">Mã đơn hàng</dt>\r\n            ");
            __builder.OpenElement(8, "dd");
            __builder.AddAttribute(9, "class", "col-sm-8");
            __builder.AddContent(10, 
#nullable restore
#line 23 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ShipInfoPage.razor"
                 ships.OrderId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "<dt class=\"col-sm-4\">Tên khách hàng</dt>\r\n            ");
            __builder.OpenElement(12, "dd");
            __builder.AddAttribute(13, "class", "col-sm-8");
            __builder.AddContent(14, 
#nullable restore
#line 28 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ShipInfoPage.razor"
                 ships.CusName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "<dt class=\"col-sm-4\">Địa chỉ nhận hàng</dt>\r\n            ");
            __builder.OpenElement(16, "dd");
            __builder.AddAttribute(17, "class", "col-sm-8");
            __builder.AddContent(18, 
#nullable restore
#line 33 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ShipInfoPage.razor"
                 ships.Address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "<dt class=\"col-sm-4\">Số điện thoại</dt>\r\n            ");
            __builder.OpenElement(20, "dd");
            __builder.AddAttribute(21, "class", "col-sm-8");
            __builder.AddContent(22, 
#nullable restore
#line 38 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ShipInfoPage.razor"
                 ships.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "<dt class=\"col-sm-4\">Số tiền thu hộ</dt>\r\n            ");
            __builder.OpenElement(24, "dd");
            __builder.AddAttribute(25, "class", "col-sm-8");
            __builder.AddContent(26, 
#nullable restore
#line 43 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ShipInfoPage.razor"
                 ships.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "<dt class=\"col-sm-4\">Đối tác giao hàng</dt>\r\n            ");
            __builder.OpenElement(28, "dd");
            __builder.AddAttribute(29, "class", "col-sm-8");
#nullable restore
#line 48 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ShipInfoPage.razor"
                 if (ships.Partner == Partner.None)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(30, "<span>Chưa có đơn vị vận chuyển</span>");
#nullable restore
#line 51 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ShipInfoPage.razor"
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, 
#nullable restore
#line 54 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ShipInfoPage.razor"
                     ships.Partner

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 54 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ShipInfoPage.razor"
                                  
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "<dt class=\"col-sm-4\">Ghi chú</dt>\r\n            ");
            __builder.OpenElement(33, "dd");
            __builder.AddAttribute(34, "class", "col-sm-8");
            __builder.AddContent(35, 
#nullable restore
#line 60 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ShipInfoPage.razor"
                 ships.Notes

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 62 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ShipInfoPage.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(36, "<dt class=\"col-sm-4\">Phương thức vận chuyển</dt>\r\n            ");
            __builder.AddMarkupContent(37, "<dd class=\"col-sm-8\">\r\n                Lấy hàng trực tiếp\r\n            </dd>");
            __builder.AddMarkupContent(38, "<dt class=\"col-sm-4\">Mã đơn hàng</dt>\r\n            ");
            __builder.OpenElement(39, "dd");
            __builder.AddAttribute(40, "class", "col-sm-8");
            __builder.AddContent(41, 
#nullable restore
#line 72 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ShipInfoPage.razor"
                 ships.OrderId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "<dt class=\"col-sm-4\">Tên khách hàng</dt>\r\n            ");
            __builder.OpenElement(43, "dd");
            __builder.AddAttribute(44, "class", "col-sm-8");
            __builder.AddContent(45, 
#nullable restore
#line 77 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ShipInfoPage.razor"
                 ships.CusName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "<dt class=\"col-sm-4\">Số điện thoại</dt>\r\n            ");
            __builder.OpenElement(47, "dd");
            __builder.AddAttribute(48, "class", "col-sm-8");
            __builder.AddContent(49, 
#nullable restore
#line 82 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ShipInfoPage.razor"
                 ships.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "<dt class=\"col-sm-4\">Ghi chú</dt>\r\n            ");
            __builder.OpenElement(51, "dd");
            __builder.AddAttribute(52, "class", "col-sm-8");
            __builder.AddContent(53, 
#nullable restore
#line 87 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ShipInfoPage.razor"
                 ships.Notes

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 89 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ShipInfoPage.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
            __builder.AddMarkupContent(55, "<div><a class=\"btn btn-info\" href=\"/\">Trang chủ</a> |\r\n    <a class=\"btn\" href=\"/History\">Danh sách</a></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 96 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\ShipInfoPage.razor"
       
    [Parameter]
    public string id { get; set; }
    private string Title = "";
    protected string temp = "";
    // Giống Bên History
    private string emailGoogle = "";
    public ShipInfo ships;
    // Giống Bên History
    [CascadingParameter] protected Task<AuthenticationState> AuthStat { get; set; }

    protected override async Task OnInitializedAsync()
    {
        if (string.IsNullOrWhiteSpace(id) || id == "0")
        {
            NavigationManager.NavigateTo("/History", true); ;
        }
        else
        {
            // Giống Bên History
            emailGoogle = AuthStat.Result.User.Claims.Where(_ => _.Type == "email").Select(_ => _.Value).FirstOrDefault();
            var apiUrl = config.GetSection("API")["APIUrl"].ToString();
            var accessToken = sessionStorage.GetItem<string>("AccessToken");
            // Nếu maillGG khác null thì gán tokenGG cho accessToken, tương tự cho CHeckout, OrderDetails
            if (emailGoogle != null && emailGoogle != "")
            {
                accessToken = AuthStat.Result.User.Claims.Where(_ => _.Type == "APIjwt").Select(_ => _.Value).FirstOrDefault();
            }
            ships = new ShipInfo();
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
                client.BaseAddress = new Uri(apiUrl);
                using (var respone = await client.GetAsync("ShipInfo/?orderId=" + id))
                {
                    string apiResponse = await respone.Content.ReadAsStringAsync();
                    ships = JsonConvert.DeserializeObject<ShipInfo>(apiResponse);
                }

            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
