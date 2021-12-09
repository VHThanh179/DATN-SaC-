#pragma checksum "D:\DATN\Project\SaCBackpack\Server\Pages\Customers\CustomerDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8615afb10f34b7d086c6ffd385b4c4e89b2d6d80"
// <auto-generated/>
#pragma warning disable 1591
namespace Server.Pages.Customers
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
#line 12 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DATN\Project\SaCBackpack\Server\Pages\Customers\CustomerDialog.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DATN\Project\SaCBackpack\Server\Pages\Customers\CustomerDialog.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DATN\Project\SaCBackpack\Server\Pages\Customers\CustomerDialog.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/customerdialog/{id}")]
    public partial class CustomerDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-xl-8 mx-auto");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card card-signin flex-row shadow-lg card-signup");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-body");
            __builder.AddMarkupContent(10, "<h2 class=\"card-title text-center font-weight-bold text-uppercase\">Thông tin khách hàng</h2>\r\n                    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-md-12");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(13);
            __builder.AddAttribute(14, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "D:\DATN\Project\SaCBackpack\Server\Pages\Customers\CustomerDialog.razor"
                                          customer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(16, "input");
                __builder2.AddAttribute(17, "type", "hidden");
                __builder2.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "D:\DATN\Project\SaCBackpack\Server\Pages\Customers\CustomerDialog.razor"
                                                        customer.CustomerId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => customer.CustomerId = __value, customer.CustomerId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n                            ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group row");
                __builder2.AddMarkupContent(23, "<label class=\"control-label col-5\">Họ và tên</label>\r\n                                ");
                __builder2.OpenElement(24, "span");
                __builder2.AddAttribute(25, "class", "font-weight-bold col-7");
                __builder2.AddContent(26, 
#nullable restore
#line 20 "D:\DATN\Project\SaCBackpack\Server\Pages\Customers\CustomerDialog.razor"
                                                                      customer.FullName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n                            ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group row");
                __builder2.AddMarkupContent(30, "<label class=\"control-label col-5\">Ngày sinh</label>\r\n                                ");
                __builder2.OpenElement(31, "span");
                __builder2.AddAttribute(32, "class", "font-weight-bold col-7");
                __builder2.AddContent(33, 
#nullable restore
#line 24 "D:\DATN\Project\SaCBackpack\Server\Pages\Customers\CustomerDialog.razor"
                                                                      customer.DoB.Date.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n                            ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "form-group row");
                __builder2.AddMarkupContent(37, "<label class=\"control-label col-5\">Số điện thoại</label>\r\n                                ");
                __builder2.OpenElement(38, "span");
                __builder2.AddAttribute(39, "class", "font-weight-bold col-7");
                __builder2.AddContent(40, 
#nullable restore
#line 28 "D:\DATN\Project\SaCBackpack\Server\Pages\Customers\CustomerDialog.razor"
                                                                      customer.PhoneNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                            ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-group row");
                __builder2.AddMarkupContent(44, "<label class=\"control-label col-5\">Email</label>\r\n                                ");
                __builder2.OpenElement(45, "span");
                __builder2.AddAttribute(46, "class", "font-weight-bold col-7");
                __builder2.AddContent(47, 
#nullable restore
#line 32 "D:\DATN\Project\SaCBackpack\Server\Pages\Customers\CustomerDialog.razor"
                                                                      customer.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                            ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "form-group row");
                __builder2.AddMarkupContent(51, "<label class=\"control-label col-5\">Địa chỉ</label>\r\n                                ");
                __builder2.OpenElement(52, "span");
                __builder2.AddAttribute(53, "class", "font-weight-bold col-7");
                __builder2.AddContent(54, 
#nullable restore
#line 36 "D:\DATN\Project\SaCBackpack\Server\Pages\Customers\CustomerDialog.razor"
                                                                      customer.Address

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                            ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group row");
                __builder2.AddMarkupContent(58, "<label class=\"control-label col-5\">Trạng thái</label>");
#nullable restore
#line 40 "D:\DATN\Project\SaCBackpack\Server\Pages\Customers\CustomerDialog.razor"
                                 if (customer.Status)
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(59, "<span class=\"font-weight-bold col-7\">Đang hoạt động</span>");
#nullable restore
#line 43 "D:\DATN\Project\SaCBackpack\Server\Pages\Customers\CustomerDialog.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(60, "<span class=\"font-weight-bold col-7\">Dừng hoạt động</span>");
#nullable restore
#line 47 "D:\DATN\Project\SaCBackpack\Server\Pages\Customers\CustomerDialog.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n                            ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "form-group row");
                __builder2.AddMarkupContent(64, "<label class=\"control-label col-5\">Ngày tạo</label>\r\n                                ");
                __builder2.OpenElement(65, "span");
                __builder2.AddAttribute(66, "class", "font-weight-bold col-7");
                __builder2.AddContent(67, 
#nullable restore
#line 51 "D:\DATN\Project\SaCBackpack\Server\Pages\Customers\CustomerDialog.razor"
                                                                      customer.CreatedDate.Date.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                            ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "form-group");
                __builder2.OpenElement(71, "input");
                __builder2.AddAttribute(72, "type", "button");
                __builder2.AddAttribute(73, "class", "btn btn-primary");
                __builder2.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "D:\DATN\Project\SaCBackpack\Server\Pages\Customers\CustomerDialog.razor"
                                                                                        Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(75, "value", "Thoát");
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
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "D:\DATN\Project\SaCBackpack\Server\Pages\Customers\CustomerDialog.razor"
       
    [Parameter]
    public string id { get; set; }

    private Share.Models.Customer customer { get; set; }

    protected override void OnInitialized()
    {
        customer = _customerSvc.GetCustomer(int.Parse(id));
    }

    //private void SubmitForm()
    //{
    //    _toastParameters = new ToastParameters();
    //    customer.Status = bool.Parse(status);
    //    int ret = _customerSvc.EditCustomer(customer.CustomerId, customer);
    //    if (ret != 0)
    //    {
    //        _toastParameters.Add(nameof(Notification.Title), "Chỉnh sửa khách hàng thành công!");
    //        _toastParameters.Add(nameof(Notification.IsSuccess), true);
    //        toastService.ShowToast<Notification>(_toastParameters);
    //    }
    //    else
    //    {
    //        _toastParameters.Add(nameof(Notification.Title), "Chỉnh sửa khách hàng thất bại!");
    //        _toastParameters.Add(nameof(Notification.IsSuccess), false);
    //        toastService.ShowToast<Notification>(_toastParameters);
    //    }
    //    navigation.NavigateTo("customerlist");
    //}

    private void Cancel()
    {
        navigation.NavigateTo("customerlist", true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Share.Interfaces.ICustomerSvc _customerSvc { get; set; }
    }
}
#pragma warning restore 1591
