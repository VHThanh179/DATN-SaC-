#pragma checksum "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Orders\OrderDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a562a077b327429038a5ba8148bf09e686d4acbc"
// <auto-generated/>
#pragma warning disable 1591
namespace Server.Pages.Orders
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
#line 2 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Orders\OrderDialog.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Orders\OrderDialog.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Orders\OrderDialog.razor"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-xl-6 mx-auto");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card card-signin flex-row shadow-lg card-signup");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-body");
            __builder.AddMarkupContent(10, "<h2 class=\"card-title text-center font-weight-bold text-uppercase\">Chỉnh sửa đơn hàng</h2>\r\n                    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-md-12");
            __builder.OpenElement(13, "form");
            __builder.AddAttribute(14, "asp-action", "Edit");
            __builder.AddAttribute(15, "class", "form-signin");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(16);
            __builder.AddAttribute(17, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 18 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Orders\OrderDialog.razor"
                                              order

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 18 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Orders\OrderDialog.razor"
                                                                     SubmitForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(20);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n                                ");
                __builder2.OpenElement(22, "input");
                __builder2.AddAttribute(23, "type", "hidden");
                __builder2.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Orders\OrderDialog.razor"
                                                            order.OrderId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => order.OrderId = __value, order.OrderId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                                ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-label-group");
                __builder2.AddMarkupContent(29, "<label class=\"control-lable\">Khách hàng</label>\r\n                                    ");
                __builder2.OpenElement(30, "input");
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "disabled", "disabled");
                __builder2.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Orders\OrderDialog.razor"
                                                  order.Customer.FullName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => order.Customer.FullName = __value, order.Customer.FullName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n                                    ");
                __builder2.OpenElement(36, "input");
                __builder2.AddAttribute(37, "class", "form-control");
                __builder2.AddAttribute(38, "style", "display:none");
                __builder2.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Orders\OrderDialog.razor"
                                                  order.CustomerId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => order.CustomerId = __value, order.CustomerId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n\r\n                                ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-label-group");
                __builder2.AddMarkupContent(44, "<label class=\"control-lable\">Email</label>\r\n                                    ");
                __builder2.OpenElement(45, "input");
                __builder2.AddAttribute(46, "class", "form-control");
                __builder2.AddAttribute(47, "disabled", "disabled");
                __builder2.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Orders\OrderDialog.razor"
                                                  order.Customer.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => order.Customer.Email = __value, order.Customer.Email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n\r\n                                ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "form-label-group");
                __builder2.AddMarkupContent(53, "<label class=\"control-lable\">Địa chỉ</label>\r\n                                    ");
                __builder2.OpenElement(54, "input");
                __builder2.AddAttribute(55, "class", "form-control");
                __builder2.AddAttribute(56, "disabled", "disabled");
                __builder2.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Orders\OrderDialog.razor"
                                                  order.Customer.Address

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => order.Customer.Address = __value, order.Customer.Address));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n\r\n                                ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "form-label-group mt-3");
                __builder2.AddMarkupContent(62, "<label class=\"control-lable\">Ngày đặt</label>\r\n                                    ");
                __builder2.OpenElement(63, "input");
                __builder2.AddAttribute(64, "type", "date");
                __builder2.AddAttribute(65, "class", "form-control");
                __builder2.AddAttribute(66, "disabled");
                __builder2.AddAttribute(67, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Orders\OrderDialog.razor"
                                                              order.OrderDate

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(68, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => order.OrderDate = __value, order.OrderDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                                    <span asp-validation-for=\"OrderDate\" class=\"text-danger\"></span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n\r\n                                ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "form-label-group mt-3");
                __builder2.AddMarkupContent(73, "<label class=\"control-lable\">Tổng tiền</label>\r\n                                    ");
                __builder2.OpenElement(74, "input");
                __builder2.AddAttribute(75, "type", "number");
                __builder2.AddAttribute(76, "class", "form-control");
                __builder2.AddAttribute(77, "disabled");
                __builder2.AddAttribute(78, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Orders\OrderDialog.razor"
                                                                order.Total

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(79, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => order.Total = __value, order.Total, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n                                    <span asp-validation-for=\"Tongtien\" class=\"text-danger\"></span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n\r\n                                ");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "form-label-group mt-3");
                __builder2.AddMarkupContent(84, "<label class=\"control-lable\">Trạng thái</label>\r\n                                    ");
                __Blazor.Server.Pages.Orders.OrderDialog.TypeInference.CreateInputSelect_0(__builder2, 85, 86, "form-control", 87, 
#nullable restore
#line 51 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Orders\OrderDialog.razor"
                                                               order.OrderStatus

#line default
#line hidden
#nullable disable
                , 88, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => order.OrderStatus = __value, order.OrderStatus)), 89, () => order.OrderStatus, 90, (__builder3) => {
                    __builder3.OpenElement(91, "option");
                    __builder3.AddAttribute(92, "value", 
#nullable restore
#line 52 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Orders\OrderDialog.razor"
                                                        OrderStatus.CurOrder

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(93, "Mới đặt");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(94, "\r\n                                        ");
                    __builder3.OpenElement(95, "option");
                    __builder3.AddAttribute(96, "value", 
#nullable restore
#line 53 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Orders\OrderDialog.razor"
                                                        OrderStatus.Delivering

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(97, "Đang giao");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(98, "\r\n                                        ");
                    __builder3.OpenElement(99, "option");
                    __builder3.AddAttribute(100, "value", 
#nullable restore
#line 54 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Orders\OrderDialog.razor"
                                                        OrderStatus.Delivered

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(101, "Đã giao");
                    __builder3.CloseElement();
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n\r\n                                ");
                __builder2.OpenElement(103, "div");
                __builder2.AddAttribute(104, "class", "form-label-group mt-3");
                __builder2.AddMarkupContent(105, "<label class=\"control-lable\">Ghi chú</label>\r\n                                    ");
                __builder2.OpenElement(106, "input");
                __builder2.AddAttribute(107, "class", "form-control");
                __builder2.AddAttribute(108, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 60 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Orders\OrderDialog.razor"
                                                  order.Notes

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(109, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => order.Notes = __value, order.Notes));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n                                    <span asp-validation-for=\"Note\" class=\"text-danger\"></span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\r\n\r\n                                ");
                __builder2.OpenElement(112, "div");
                __builder2.AddAttribute(113, "class", "form-label-group mt-4");
                __builder2.OpenElement(114, "button");
                __builder2.AddAttribute(115, "type", "submit");
                __builder2.AddAttribute(116, "class", "btn btn-info");
                __builder2.AddAttribute(117, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Orders\OrderDialog.razor"
                                                                                           () => toastService.ShowSuccess("Lưu thành công!")

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(118, "Lưu");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\r\n                                    ");
                __builder2.OpenElement(120, "input");
                __builder2.AddAttribute(121, "type", "button");
                __builder2.AddAttribute(122, "class", "btn btn-primary");
                __builder2.AddAttribute(123, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Orders\OrderDialog.razor"
                                                                                            Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(124, "value", "Thoát");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 77 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Orders\OrderDialog.razor"
       
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment env { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Share.Interfaces.IOrderSvc _orderService { get; set; }
    }
}
namespace __Blazor.Server.Pages.Orders.OrderDialog
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
