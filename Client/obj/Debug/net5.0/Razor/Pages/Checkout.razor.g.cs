#pragma checksum "D:\DATN\Project\SaCBackpack\Client\Pages\Checkout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4b18cb89806e98988fb6815df1de8b83c54f050"
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
#line 6 "D:\DATN\Project\SaCBackpack\Client\Pages\Checkout.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DATN\Project\SaCBackpack\Client\Pages\Checkout.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\DATN\Project\SaCBackpack\Client\Pages\Checkout.razor"
using Share.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\DATN\Project\SaCBackpack\Client\Pages\Checkout.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/checkout")]
    public partial class Checkout : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .my-custom-scrollbar {\r\n        position: relative;\r\n        height: 400px;\r\n        overflow: auto;\r\n    }\r\n\r\n    .table-wrapper-scroll-y {\r\n        display: block;\r\n    }\r\n\r\n    .payment-info {\r\n        background: blue;\r\n        padding: 10px;\r\n        border-radius: 6px;\r\n        color: #fff;\r\n        font-weight: bold\r\n    }\r\n\r\n    .product-details {\r\n        padding: 10px\r\n    }\r\n\r\n    body {\r\n        background: #eee\r\n    }\r\n\r\n    .cart {\r\n        background: #fff\r\n    }\r\n\r\n    .p-about {\r\n        font-size: 12px\r\n    }\r\n\r\n    .table-shadow {\r\n        -webkit-box-shadow: 5px 5px 15px -2px rgba(0, 0, 0, 0.42);\r\n        box-shadow: 5px 5px 15px -2px rgba(0, 0, 0, 0.42)\r\n    }\r\n\r\n    .type {\r\n        font-weight: 400;\r\n        font-size: 10px\r\n    }\r\n\r\n    label.radio {\r\n        cursor: pointer\r\n    }\r\n\r\n        label.radio input {\r\n            position: absolute;\r\n            top: 0;\r\n            left: 0;\r\n            visibility: hidden;\r\n            pointer-events: none\r\n        }\r\n\r\n        label.radio span {\r\n            padding: 1px 12px;\r\n            border: 2px solid #ada9a9;\r\n            display: inline-block;\r\n            color: #8f37aa;\r\n            border-radius: 3px;\r\n            text-transform: uppercase;\r\n            font-size: 11px;\r\n            font-weight: 300\r\n        }\r\n\r\n        label.radio input:checked + span {\r\n            border-color: #fff;\r\n            background-color: blue;\r\n            color: #fff\r\n        }\r\n\r\n    .credit-inputs {\r\n        background: rgb(102, 102, 221);\r\n        color: #fff !important;\r\n        border-color: rgb(102, 102, 221)\r\n    }\r\n\r\n        .credit-inputs::placeholder {\r\n            color: #fff;\r\n            font-size: 13px\r\n        }\r\n\r\n    .credit-card-label {\r\n        font-size: 9px;\r\n        font-weight: 300\r\n    }\r\n\r\n    .form-control.credit-inputs:focus {\r\n        background: rgb(102, 102, 221);\r\n        border: rgb(102, 102, 221)\r\n    }\r\n\r\n    .line {\r\n        border-bottom: 1px solid rgb(102, 102, 221)\r\n    }\r\n\r\n    .information span {\r\n        font-size: 12px;\r\n        font-weight: 500\r\n    }\r\n\r\n    .information {\r\n        margin-bottom: 5px\r\n    }\r\n\r\n    .items {\r\n        -webkit-box-shadow: 5px 5px 4px -1px rgba(0, 0, 0, 0.25);\r\n        box-shadow: 5px 5px 4px -1px rgba(0, 0, 0, 0.08)\r\n    }\r\n\r\n    .spec {\r\n        font-size: 11px\r\n    }\r\n\r\n    .button:focus {\r\n        outline: none;\r\n    }\r\n</style>\r\n\r\n");
            __builder.OpenComponent<BlazorAnimate.Animate>(1);
            __builder.AddAttribute(2, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 133 "D:\DATN\Project\SaCBackpack\Client\Pages\Checkout.razor"
                    Animations.FadeUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 133 "D:\DATN\Project\SaCBackpack\Client\Pages\Checkout.razor"
                                                 TimeSpan.FromSeconds(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "container p-3 rounded cart");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row no-gutters");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-md-8");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "product-details mr-2");
                __builder2.AddMarkupContent(13, "<div class=\"d-flex justify-content-between\"><b>PHƯƠNG THỨC VẬN CHUYỂN - THANH TOÁN</b></div>\r\n                    <hr>\r\n                    ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "table-wrapper-scroll-y my-custom-scrollbar");
                __builder2.OpenElement(16, "form");
                __builder2.AddAttribute(17, "class", "col-11 m-auto");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "row");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group col-8");
                __builder2.AddMarkupContent(22, "<label class=\"control-label\">Mã giảm giá</label>\r\n                                    ");
                __builder2.OpenElement(23, "input");
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 147 "D:\DATN\Project\SaCBackpack\Client\Pages\Checkout.razor"
                                                                       vouchercode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => vouchercode = __value, vouchercode));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n                                ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group col-4");
                __builder2.OpenElement(30, "input");
                __builder2.AddAttribute(31, "class", "btn btn-outline-success");
                __builder2.AddAttribute(32, "value", "Áp dụng");
                __builder2.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 150 "D:\DATN\Project\SaCBackpack\Client\Pages\Checkout.razor"
                                                                                                     CheckVoucher

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n\r\n                            ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "row mt-2");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-group col-6");
                __builder2.AddMarkupContent(39, "<label class=\"control-label\">Tên khách hàng</label>\r\n                                    ");
                __builder2.OpenElement(40, "input");
                __builder2.AddAttribute(41, "class", "form-control");
                __builder2.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 157 "D:\DATN\Project\SaCBackpack\Client\Pages\Checkout.razor"
                                                                       shipInfo.CusName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => shipInfo.CusName = __value, shipInfo.CusName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n\r\n                                ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group col-6");
                __builder2.AddMarkupContent(47, "<label class=\"control-label\">Địa chỉ giao hàng</label>\r\n                                    ");
                __builder2.OpenElement(48, "input");
                __builder2.AddAttribute(49, "class", "form-control");
                __builder2.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 162 "D:\DATN\Project\SaCBackpack\Client\Pages\Checkout.razor"
                                                                       shipInfo.Address

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => shipInfo.Address = __value, shipInfo.Address));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n\r\n                            ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "row mt-2");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group col-6");
                __builder2.AddMarkupContent(57, "<label class=\"control-label\">Số điện thoại</label>\r\n                                    ");
                __builder2.OpenElement(58, "input");
                __builder2.AddAttribute(59, "class", "form-control");
                __builder2.AddAttribute(60, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 169 "D:\DATN\Project\SaCBackpack\Client\Pages\Checkout.razor"
                                                                       shipInfo.PhoneNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => shipInfo.PhoneNumber = __value, shipInfo.PhoneNumber));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n\r\n                                ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "form-label-group col-6");
                __builder2.AddMarkupContent(65, "<label class=\"control-label\">Hình thức vận chuyển</label>\r\n                                    <br>\r\n                                    ");
                __builder2.OpenElement(66, "select");
                __builder2.AddAttribute(67, "class", "form-control");
                __builder2.AddAttribute(68, "required");
                __builder2.AddAttribute(69, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 175 "D:\DATN\Project\SaCBackpack\Client\Pages\Checkout.razor"
                                                                        display

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => display = __value, display));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(71, "option");
                __builder2.AddAttribute(72, "value");
                __builder2.AddMarkupContent(73, "Chọn phương thức");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n                                        ");
                __builder2.OpenElement(75, "option");
                __builder2.AddAttribute(76, "value", "0");
                __builder2.AddMarkupContent(77, "Lấy hàng trực tiếp");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n                                        ");
                __builder2.OpenElement(79, "option");
                __builder2.AddAttribute(80, "value", "1");
                __builder2.AddMarkupContent(81, "Giao hàng tận nhà");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n                            ");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "form-group mt-2");
                __builder2.AddMarkupContent(85, "<label class=\"control-label\">Ghi chú</label>\r\n                                ");
                __builder2.OpenElement(86, "textarea");
                __builder2.AddAttribute(87, "class", "form-control");
                __builder2.AddAttribute(88, "cols", "30");
                __builder2.AddAttribute(89, "rows", "6");
                __builder2.AddAttribute(90, "maxlength", "200");
                __builder2.AddAttribute(91, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 184 "D:\DATN\Project\SaCBackpack\Client\Pages\Checkout.razor"
                                                                                                         shipInfo.Notes

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(92, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => shipInfo.Notes = __value, shipInfo.Notes));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n                            ");
                __builder2.OpenElement(94, "div");
                __builder2.AddAttribute(95, "class", "row mt-2");
                __builder2.AddAttribute(96, "id", "moreInfoShipping");
                __builder2.AddAttribute(97, "style", "visibility:hidden");
                __builder2.OpenElement(98, "div");
                __builder2.AddAttribute(99, "class", "form-group col-6");
                __builder2.AddMarkupContent(100, "<label class=\"control-label\">Giá vận chuyển</label>\r\n                                    ");
                __builder2.OpenElement(101, "input");
                __builder2.AddAttribute(102, "type", "number");
                __builder2.AddAttribute(103, "class", "form-control");
                __builder2.AddAttribute(104, "readonly");
                __builder2.AddAttribute(105, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 189 "D:\DATN\Project\SaCBackpack\Client\Pages\Checkout.razor"
                                                                                     shipInfo.Price

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(106, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => shipInfo.Price = __value, shipInfo.Price, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n\r\n                                ");
                __builder2.OpenElement(108, "div");
                __builder2.AddAttribute(109, "class", "form-label-group col-6");
                __builder2.AddMarkupContent(110, "<label class=\"control-label\">Đơn vị vận chuyển</label>\r\n                                    <br>\r\n                                    ");
                __builder2.OpenElement(111, "select");
                __builder2.AddAttribute(112, "class", "form-control");
                __builder2.AddAttribute(113, "required");
                __builder2.AddAttribute(114, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 195 "D:\DATN\Project\SaCBackpack\Client\Pages\Checkout.razor"
                                                                        shipPartner

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(115, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => shipPartner = __value, shipPartner));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(116, "option");
                __builder2.AddAttribute(117, "value");
                __builder2.AddMarkupContent(118, "Chọn đơn vị");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\r\n                                        ");
                __builder2.OpenElement(120, "option");
                __builder2.AddAttribute(121, "value", "1");
                __builder2.AddContent(122, "Grab");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\r\n                                        ");
                __builder2.OpenElement(124, "option");
                __builder2.AddAttribute(125, "value", "2");
                __builder2.AddContent(126, "Now");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(127, "\r\n                                        ");
                __builder2.OpenElement(128, "option");
                __builder2.AddAttribute(129, "value", "3");
                __builder2.AddContent(130, "Gojek");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(131, "\r\n            ");
                __builder2.OpenElement(132, "div");
                __builder2.AddAttribute(133, "class", "col-md-4");
                __builder2.OpenElement(134, "div");
                __builder2.AddAttribute(135, "class", "payment-info");
                __builder2.AddMarkupContent(136, "<hr class=\"line\">\r\n                    ");
                __builder2.OpenElement(137, "div");
                __builder2.AddAttribute(138, "class", "d-flex justify-content-between information");
                __builder2.AddMarkupContent(139, "<span>Tiền hàng</span>");
                __builder2.OpenElement(140, "span");
                __builder2.AddContent(141, 
#nullable restore
#line 213 "D:\DATN\Project\SaCBackpack\Client\Pages\Checkout.razor"
                                                                                                         string.Format("{0:#,0}", orderCart.Total)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(142, " VNĐ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(143, "\r\n                    ");
                __builder2.OpenElement(144, "div");
                __builder2.AddAttribute(145, "class", "d-flex justify-content-between information");
                __builder2.AddMarkupContent(146, "<span>Giảm giá</span>");
                __builder2.OpenElement(147, "span");
                __builder2.AddContent(148, 
#nullable restore
#line 214 "D:\DATN\Project\SaCBackpack\Client\Pages\Checkout.razor"
                                                                                                        displayvalue

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(149, "\r\n                    ");
                __builder2.OpenElement(150, "div");
                __builder2.AddAttribute(151, "class", "d-flex justify-content-between information");
                __builder2.AddMarkupContent(152, "<span>Shipping</span>");
                __builder2.OpenElement(153, "span");
                __builder2.AddContent(154, 
#nullable restore
#line 215 "D:\DATN\Project\SaCBackpack\Client\Pages\Checkout.razor"
                                                                                                        string.Format("{0:#,0}", shipInfo.Price)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(155, " VNĐ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(156, "\r\n                    ");
                __builder2.OpenElement(157, "div");
                __builder2.AddAttribute(158, "class", "d-flex justify-content-between information");
                __builder2.AddMarkupContent(159, "<span>Tổng cộng</span>\r\n                        ");
                __builder2.OpenElement(160, "span");
#nullable restore
#line 219 "D:\DATN\Project\SaCBackpack\Client\Pages\Checkout.razor"
                             if (vouchervalue != 0)
                            {
                                if (vouchervalue <= 1)
                                {
                                    total = (orderCart.Total + shipInfo.Price) - ((orderCart.Total + shipInfo.Price) * vouchervalue);
                                }
                                else
                                {
                                    total = (orderCart.Total + shipInfo.Price) - vouchervalue;
                                }
                            }
                            else
                            {
                                total = orderCart.Total + shipInfo.Price;
                            }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(161, "span");
                __builder2.AddAttribute(162, "id", "totalPrice");
                __builder2.AddAttribute(163, "style", "display:none;");
                __builder2.AddContent(164, 
#nullable restore
#line 234 "D:\DATN\Project\SaCBackpack\Client\Pages\Checkout.razor"
                                                                          total

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(165, "\r\n                            ");
                __builder2.AddContent(166, 
#nullable restore
#line 235 "D:\DATN\Project\SaCBackpack\Client\Pages\Checkout.razor"
                             string.Format("{0:#,0}", total)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(167, " VNĐ\r\n                        ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(168, "\r\n                    <div id=\"paypal-button-container\"></div>\r\n                    ");
                __builder2.OpenElement(169, "button");
                __builder2.AddAttribute(170, "class", "btn-outline-success");
                __builder2.AddAttribute(171, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 239 "D:\DATN\Project\SaCBackpack\Client\Pages\Checkout.razor"
                                                                  OrderCart

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(172, "Thanh toán");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(173, "\r\n            ");
                __builder2.OpenElement(174, "div");
                __builder2.AddAttribute(175, "class", "row");
                __builder2.OpenElement(176, "div");
                __builder2.AddAttribute(177, "class", "col-12 text-end");
                __builder2.OpenElement(178, "input");
                __builder2.AddAttribute(179, "type", "button");
                __builder2.AddAttribute(180, "class", "ml-2 btn btn-dark");
                __builder2.AddAttribute(181, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 244 "D:\DATN\Project\SaCBackpack\Client\Pages\Checkout.razor"
                                                                              Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(182, "value", "Quay lại");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 252 "D:\DATN\Project\SaCBackpack\Client\Pages\Checkout.razor"
       
    [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }
    [CascadingParameter] protected Task<AuthenticationState> AuthStat { get; set; }
    public ShipInfo shipInfo { get; set; }
    public Customer customer { get; set; }
    public APICart apiCart { get; set; }
    public int cusId;
    public string emailAddress;
    public string emailGoogle;
    public Cart orderCart;
    private int display;
    private int shipPartner;
    public double vouchervalue = 0;
    public string displayvalue = "";
    public string vouchercode { get; set; }
    public Voucher voucher;
    public List<Voucher> listvoucher;
    public double total = 0;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JSRuntime.InvokeVoidAsync("PaypalButton");
        }
        if (display == 0)
        {
            Console.WriteLine(display + "non display");
            await JSRuntime.InvokeVoidAsync("noneDisplayMoreInfoShipping");
        }
        else
        {
            Console.WriteLine(display + "display");
            await JSRuntime.InvokeVoidAsync("displayMoreInfoShipping");
        }
    }
    protected override async Task OnInitializedAsync()
    {
        customer = new Customer();
        shipInfo = new ShipInfo();
        var cart = sessionStorage.GetItem<string>("cart");
        if (cart == null)
        {
            orderCart = new Share.Models.ViewModels.Cart();
        }
        else
        {
            orderCart = JsonConvert.DeserializeObject<Cart>(cart);
            if (orderCart.Total <= 1000000)
            {
                shipInfo.Price = 30000;
            }
            else if (orderCart.Total <= 2000000)
            {
                shipInfo.Price = 20000;
            }
            else
            {
                shipInfo.Price = 10000;
            }
        }

        cusId = sessionStorage.GetItem<int>("customerId");
        emailAddress = sessionStorage.GetItem<string>("Email");
        emailGoogle = AuthStat.Result.User.Claims.Where(_ => _.Type == "email").Select(_ => _.Value).FirstOrDefault();
        var apiUrl = config.GetSection("API")["APIUrl"].ToString();
        var accessToken = sessionStorage.GetItem<string>("AccessToken");
        customer = new Customer();
        if (emailAddress != null && emailAddress != "")
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
                client.BaseAddress = new Uri(apiUrl);
                using (var response = await client.GetAsync("Customer/?id=" + cusId))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    customer = JsonConvert.DeserializeObject<Customer>(apiResponse);
                }
            }
            shipInfo.CusName = customer.FullName;
            shipInfo.Address = customer.Address;
            shipInfo.PhoneNumber = customer.PhoneNumber;
        }
        if (emailGoogle != null && emailGoogle != "")
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
                client.BaseAddress = new Uri(apiUrl);
                using (var response = await client.GetAsync("Customer/GetCustomerbyMail/?email=" + emailGoogle))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    customer = JsonConvert.DeserializeObject<Customer>(apiResponse);
                }
            }
            shipInfo.CusName = customer.FullName;
            shipInfo.Address = customer.Address;
            shipInfo.PhoneNumber = customer.PhoneNumber;
        }

        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            client.BaseAddress = new Uri(apiUrl);
            using (var response = await client.GetAsync("Voucher"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                listvoucher = JsonConvert.DeserializeObject<List<Voucher>>(apiResponse);
            }
        }
    }

    private async Task OrderCart()
    {
        if (display == 0)
        {
            shipInfo.ShippingMethod = true;
        }
        else
        {
            shipInfo.ShippingMethod = false;
        }

        if (shipPartner == 1)
        {
            shipInfo.Partner = Partner.Grab;
        }
        else if (shipPartner == 2)
        {
            shipInfo.Partner = Partner.Now;
        }
        else if (shipPartner == 3)
        {
            shipInfo.Partner = Partner.Gojek;
        }
        else
        {
            shipInfo.Partner = Partner.None;
        }


        var apiUrl = config.GetSection("API")["APIUrl"].ToString();
        var accessToken = sessionStorage.GetItem<string>("AccessToken");
        orderCart.CustomerId = customer.CustomerId;

        apiCart = new APICart();
        apiCart.cart = orderCart;
        apiCart.shipInfo = shipInfo;
        apiCart.voucherCode = vouchercode;

        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            StringContent content = new StringContent(JsonConvert.SerializeObject(apiCart), System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(apiUrl + "Cart", content);
            if (response.StatusCode != HttpStatusCode.OK)
            {

            }
            else
            {
                sessionStorage.RemoveItem("cart");
                navigationManager.NavigateTo("/history");
            }
        }
    }

    private void Cancel()
    {
        ModalInstance.CloseAsync(ModalResult.Ok<ShipInfo>(shipInfo));
    }

    private void CheckVoucher()
    {
        voucher = new Voucher();
        foreach (var item in listvoucher)
        {
            if (vouchercode == item.VoucherCode)
            {
                voucher = item;
            }
        }
        if (voucher.VoucherCode != null)
        {
            if (voucher.Status)
            {
                if (voucher.VoucherQuantity > 0)
                {
                    if (voucher.CategoryDiscount == CategoryDiscount.Cash)
                    {
                        vouchervalue = voucher.Value;
                        displayvalue = string.Format("{0:#,0}", vouchervalue) + " VNĐ";
                    }
                    else
                    {
                        vouchervalue = voucher.Value / 100;
                        displayvalue = voucher.Value.ToString() + " %";
                    }
                }
                else
                {
                    Console.WriteLine("Voucher hết số lượng");
                }

            }
            else
            {
                vouchervalue = 0;
                displayvalue = "";
                Console.WriteLine("Voucher hết hạn");
            }
        }
        else
        {
            vouchervalue = 0;
            displayvalue = "";
            Console.WriteLine("Mã voucher sai");
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
