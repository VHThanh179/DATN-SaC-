#pragma checksum "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e40635182c7b05394dd5f98143017bf7a22505d8"
// <auto-generated/>
#pragma warning disable 1591
namespace Server.Pages.ShipInfoes
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
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
using Share.Helpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/shipinfolist")]
    public partial class ShipInfoList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "<h1 class=\"col-6 font-weight-bold text-left\">\r\n            Danh sách vận chuyển\r\n        </h1>\r\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-6 text-right");
            __builder.AddMarkupContent(6, "<br>\r\n            ");
            __builder.OpenElement(7, "select");
            __builder.AddAttribute(8, "value", 
#nullable restore
#line 14 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
                            SearchPartner

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
                                                      SearchShipPartner

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(10, "option");
            __builder.AddAttribute(11, "value");
            __builder.AddMarkupContent(12, "Chọn đơn vị giao hàng");
            __builder.CloseElement();
#nullable restore
#line 16 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
                 foreach (Partner partner in Enum.GetValues(typeof(Partner)))
                {
                    if (partner == Partner.None)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "option");
            __builder.AddAttribute(14, "value", 
#nullable restore
#line 20 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
                                        partner

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(15, "Không có đơn vị");
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "option");
            __builder.AddAttribute(17, "value", 
#nullable restore
#line 24 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
                                        partner

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(18, 
#nullable restore
#line 24 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
                                                  partner

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
                    }
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "select");
            __builder.AddAttribute(21, "value", 
#nullable restore
#line 28 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
                            SearchShippingMethod

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
                                                             SearchShipMethod

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(23, "option");
            __builder.AddAttribute(24, "value");
            __builder.AddMarkupContent(25, "Chọn phương thức thanh toán");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "option");
            __builder.AddAttribute(28, "value", "True");
            __builder.AddMarkupContent(29, "Giao hàng tận nhà");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "option");
            __builder.AddAttribute(32, "value", "False");
            __builder.AddMarkupContent(33, "Lấy hàng trực tiếp");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "type", "text");
            __builder.AddAttribute(37, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
                                                                   SearchInfo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "placeholder", "Nhập thông tin tìm kiếm...");
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
                                            SearchString

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchString = __value, SearchString));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "class", "btn btn-outline-primary");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
                                                              OnInitialized

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(45, "Danh sách");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    <br>\r\n    <br>");
#nullable restore
#line 40 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
     if (shipinfoes == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(47, "<p><em>Loading ...</em></p>");
#nullable restore
#line 43 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(48, "table");
            __builder.AddAttribute(49, "class", "table table-hover text-center");
            __builder.OpenElement(50, "thead");
            __builder.AddAttribute(51, "class", "thead-dark");
            __builder.OpenElement(52, "tr");
            __builder.OpenElement(53, "th");
            __builder.AddAttribute(54, "scope", "col");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
                                                ()=>ShipInfoSorting("OrderId")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(56, "Mã đơn hàng");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                    ");
            __builder.OpenElement(58, "th");
            __builder.AddAttribute(59, "scope", "col");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
                                                ()=>ShipInfoSorting("CusName")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(61, "Tên khách hàng");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                    ");
            __builder.OpenElement(63, "th");
            __builder.AddAttribute(64, "scope", "col");
            __builder.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
                                                ()=>ShipInfoSorting("Address")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(66, "Địa chỉ giao");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.OpenElement(68, "th");
            __builder.AddAttribute(69, "scope", "col");
            __builder.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
                                                ()=>ShipInfoSorting("PhoneNumber")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(71, "Số điện thoại");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                    ");
            __builder.OpenElement(73, "th");
            __builder.AddAttribute(74, "scope", "col");
            __builder.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
                                                ()=>ShipInfoSorting("ShippingMethod")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(76, "Phương thức thanh toán");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                    ");
            __builder.AddMarkupContent(78, "<th scope=\"col\">Ghi chú</th>\r\n                    ");
            __builder.OpenElement(79, "th");
            __builder.AddAttribute(80, "scope", "col");
            __builder.AddAttribute(81, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
                                                ()=>ShipInfoSorting("Price")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(82, "Giá vận chuyển");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                    ");
            __builder.OpenElement(84, "th");
            __builder.AddAttribute(85, "scope", "col");
            __builder.AddAttribute(86, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
                                                ()=>ShipInfoSorting("Partner")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(87, "Đối tác giao hàng");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                    ");
            __builder.AddMarkupContent(89, "<th scope=\"col\">Chỉnh sửa</th>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n            ");
            __builder.OpenElement(91, "tbody");
#nullable restore
#line 61 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
                 foreach (var item in shipinfoes)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(92, "tr");
            __builder.OpenElement(93, "td");
            __builder.AddContent(94, 
#nullable restore
#line 64 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
                             item.OrderId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                        ");
            __builder.OpenElement(96, "td");
            __builder.AddContent(97, 
#nullable restore
#line 65 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
                             item.CusName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                        ");
            __builder.OpenElement(99, "td");
            __builder.AddContent(100, 
#nullable restore
#line 66 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
                             item.Address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                        ");
            __builder.OpenElement(102, "td");
            __builder.AddContent(103, 
#nullable restore
#line 67 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
                             item.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n                        ");
            __builder.OpenElement(105, "td");
#nullable restore
#line 69 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
                             if (item.ShippingMethod)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(106, "<span>Giao hàng tận nhà</span>");
#nullable restore
#line 72 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(107, "<span>Lấy hàng trực tiếp</span>");
#nullable restore
#line 76 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                        ");
            __builder.OpenElement(109, "td");
            __builder.AddContent(110, 
#nullable restore
#line 78 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
                             item.Notes

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                        ");
            __builder.OpenElement(112, "td");
            __builder.AddContent(113, 
#nullable restore
#line 79 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
                             item.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                        ");
            __builder.OpenElement(115, "td");
            __builder.AddContent(116, 
#nullable restore
#line 80 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
                             item.Partner.DisplayName()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n                        ");
            __builder.OpenElement(118, "td");
            __builder.OpenElement(119, "a");
            __builder.AddAttribute(120, "class", "btn btn-info");
            __builder.AddAttribute(121, "href", "/shipinfodialog/" + (
#nullable restore
#line 82 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
                                                                           item.ShipId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(122, "Sửa");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 85 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 88 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 91 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\ShipInfoes\ShipInfoList.razor"
       
    //[Parameter]
    public string SearchString { get; set; }
    public string SearchPartner { get; set; }
    public string SearchShippingMethod { get; set; }
    int ids = 0;

    public List<ShipInfo> shipinfoes { get; set; }

    //protected override void OnParametersSet()
    //{
    //    if (!string.IsNullOrEmpty(SearchString))
    //    {
    //        shipinfoes = _shipinfoSvc.GetAllShipInfo().Where(x => x.CusName.ToUpper().Contains(SearchString.ToUpper())).ToList();
    //    }
    //    else
    //    {
    //        shipinfoes = _shipinfoSvc.GetAllShipInfo();
    //    }
    //}

    protected void SearchInfo(ChangeEventArgs args)
    {
        SearchString = args.Value.ToString();
        if (!string.IsNullOrEmpty(SearchString))
        {
            shipinfoes = _shipinfoSvc.GetAllShipInfo().Where(x => x.CusName.ToUpper().Contains(SearchString.ToUpper())
            || x.Address.ToUpper().Contains(SearchString.ToUpper()) || x.PhoneNumber.Contains(SearchString)
            || x.Price.ToString().Contains(SearchString) || x.OrderId.ToString().Contains(SearchString)).ToList();
        }
        else
        {
            shipinfoes = _shipinfoSvc.GetAllShipInfo();
        }
    }

    protected void SearchShipPartner(ChangeEventArgs args)
    {
        SearchPartner = args.Value.ToString();
        if (!string.IsNullOrEmpty(SearchPartner))
        {
            shipinfoes = _shipinfoSvc.GetAllShipInfo().Where(x => x.Partner.ToString() == SearchPartner).ToList();
        }
        else
        {
            shipinfoes = _shipinfoSvc.GetAllShipInfo();
        }
    }

    protected void SearchShipMethod(ChangeEventArgs args)
    {
        SearchShippingMethod = args.Value.ToString();
        if (!string.IsNullOrEmpty(SearchShippingMethod))
        {
            shipinfoes = _shipinfoSvc.GetAllShipInfo().Where(x => x.ShippingMethod.ToString() == SearchShippingMethod).ToList();
        }
        else
        {
            shipinfoes = _shipinfoSvc.GetAllShipInfo();
        }
    }

    protected void ShipInfoSorting(string SortColumn)
    {
        shipinfoes = _shipinfoSvc.GetAllShipInfo();
        if (ids == 0)
        {
            ids = 1;

            switch (SortColumn)
            {
                case "OrderId":
                    shipinfoes = shipinfoes.OrderBy(x => x.OrderId).ToList();
                    break;
                case "CusName":
                    shipinfoes = shipinfoes.OrderBy(x => x.CusName).ToList();
                    break;
                case "Address":
                    shipinfoes = shipinfoes.OrderBy(x => x.Address).ToList();
                    break;
                case "PhoneNumber":
                    shipinfoes = shipinfoes.OrderBy(x => x.PhoneNumber).ToList();
                    break;
                case "ShippingMethod":
                    shipinfoes = shipinfoes.OrderBy(x => x.ShippingMethod).ToList();
                    break;
                case "Price":
                    shipinfoes = shipinfoes.OrderBy(x => x.Price).ToList();
                    break;
                case "Partner":
                    shipinfoes = shipinfoes.OrderBy(x => x.Partner).ToList();
                    break;
            }
        }
        else
        {
            ids = 0;

            switch (SortColumn)
            {
                case "OrderId":
                    shipinfoes = shipinfoes.OrderByDescending(x => x.OrderId).ToList();
                    break;
                case "CusName":
                    shipinfoes = shipinfoes.OrderByDescending(x => x.CusName).ToList();
                    break;
                case "Address":
                    shipinfoes = shipinfoes.OrderByDescending(x => x.Address).ToList();
                    break;
                case "PhoneNumber":
                    shipinfoes = shipinfoes.OrderByDescending(x => x.PhoneNumber).ToList();
                    break;
                case "ShippingMethod":
                    shipinfoes = shipinfoes.OrderByDescending(x => x.ShippingMethod).ToList();
                    break;
                case "Price":
                    shipinfoes = shipinfoes.OrderByDescending(x => x.Price).ToList();
                    break;
                case "Partner":
                    shipinfoes = shipinfoes.OrderByDescending(x => x.Partner).ToList();
                    break;
            }
        }
    }

    protected override void OnInitialized()
    {
        shipinfoes = _shipinfoSvc.GetAllShipInfo();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Share.Interfaces.IShipInfoSvc _shipinfoSvc { get; set; }
    }
}
#pragma warning restore 1591
