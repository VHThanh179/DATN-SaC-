#pragma checksum "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\History.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e637671aff2506c54633be8d895dec71db2c2fc"
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
#line 2 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\History.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\History.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\History.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\History.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\History.razor"
using Microsoft.AspNetCore.Components.Authorization;

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
                            Khách hàng
                        </th>
                        <th>
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
                        </th></tr></thead>
                ");
            __builder.OpenElement(11, "tbody");
#nullable restore
#line 47 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\History.razor"
                     foreach (var item in orders)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "tr");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 51 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\History.razor"
                                 item.Customer.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                            ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 54 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\History.razor"
                                 item.OrderDate.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                            ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 57 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\History.razor"
                                 string.Format("{0:#,0}", item.Total)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                            ");
            __builder.OpenElement(22, "td");
#nullable restore
#line 60 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\History.razor"
                                 if (item.OrderStatus == OrderStatus.CurOrder)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(23, "<span>Mới đặt</span>");
#nullable restore
#line 63 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\History.razor"
                                }
                                else if (item.OrderStatus == OrderStatus.Delivering)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(24, "<span>Đang giao</span>");
#nullable restore
#line 67 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\History.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(25, "<span>Đã giao</span>");
#nullable restore
#line 71 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\History.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                            ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 74 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\History.razor"
                                 item.Notes

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                            ");
            __builder.OpenElement(30, "td");
            __builder.OpenElement(31, "a");
            __builder.AddAttribute(32, "class", "btn btn-light btn-user btn");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\History.razor"
                                                                                  () => ShowOrderDetail(item.OrderId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(34, "Chi tiết đơn hàng");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                                ");
            __builder.OpenElement(36, "a");
            __builder.AddAttribute(37, "class", "btn btn-light btn-user btn");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\History.razor"
                                                                                  () => ShowShipInfo(item.OrderId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(39, "Thông tin vận chuyển");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 81 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\History.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 88 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\History.razor"
       
    private string email;
    // tao bien mail Goole
    private string emailGoogle;
    public List<Order> orders = new List<Order>();
    public Share.Models.ViewModels.Cart giohang;
    public Customer customer;
    // tao bien State xac thuc
    [CascadingParameter] protected Task<AuthenticationState> AuthStat { get; set; }
    private double total = 0;
    protected string imgUrl = "";
    protected string temp = "";

    protected override async Task OnInitializedAsync()
    {
        // gan = mail Goole
        emailGoogle = AuthStat.Result.User.Claims.Where(_ => _.Type == "email").Select(_ => _.Value).FirstOrDefault();
        email = sessionStorage.GetItem<string>("Email");
        int customerId = sessionStorage.GetItem<int>("customerId");
        imgUrl = config.GetSection("API")["ImgUrl"].ToString();
        var accessToken = sessionStorage.GetItem<string>("AccessToken");
        var apiUrl = config.GetSection("API")["APIUrl"].ToString();
        imgUrl = config.GetSection("API")["ImgUrl"].ToString();
        orders = new List<Order>();
        using (var client = new HttpClient())
        {
            Dictionary<string, string> query = new Dictionary<string, string>();
            client.DefaultRequestHeaders.Authorization = new
            System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            client.BaseAddress = new Uri(apiUrl);
            // Tạo mới object Cusomer
            customer = new Customer();
            // neu maillGG không null va rỗng thì get customer bằng email rồi gán customerId = customer.customerId được get từ db
            if (emailGoogle != null && emailGoogle != "")
            {
                using (var response = await client.GetAsync("Customer/GetCustomerbyMail/?email=" + emailGoogle))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    customer = Newtonsoft.Json.JsonConvert.DeserializeObject<Customer>(apiResponse);
                }
                customerId = customer.CustomerId;
            }
            using (var response = await client.GetAsync("Order/?id=" + customerId))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                orders = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Order>>(apiResponse);
            }
        }
    }
    void ShowOrderDetail(int orderId)
    {
        var parameter = new ModalParameters();
        parameter.Add(nameof(OrderDetails.id), orderId.ToString());
        modal.Show<OrderDetails>("Chi tiết đơn hàng", parameter);
    }
    void ShowShipInfo(int orderId)
    {
        var parameterr = new ModalParameters();
        parameterr.Add(nameof(ShipInfoPage.id), orderId.ToString());
        modal.Show<ShipInfoPage>("Thông tin vận chuyển", parameterr);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService modal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
