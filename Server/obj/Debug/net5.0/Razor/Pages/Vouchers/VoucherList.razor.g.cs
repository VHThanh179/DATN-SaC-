#pragma checksum "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec5a117774a71375189b1638a367d2a4aa8fa6a7"
// <auto-generated/>
#pragma warning disable 1591
namespace Server.Pages.Vouchers
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
#line 2 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
using Share.Helpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/voucherlist")]
    public partial class VoucherList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"font-weight-bold text-center\">Danh sách giảm giá</h1>");
#nullable restore
#line 7 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
 if (vouchers == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading ...</em></p>");
#nullable restore
#line 10 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "text-right");
            __builder.AddMarkupContent(4, "<a style=\"text-decoration:none;\" href=\"/voucherdialog/0\"><button type=\"button\" class=\"btn btn-success btn-circle btn-md\"><i class=\"fa fa-plus\" style=\"color:white;font-size:20px;\"></i></button></a>\r\n    <br>\r\n    <br>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class");
            __builder.OpenElement(7, "select");
            __builder.AddAttribute(8, "value", 
#nullable restore
#line 20 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
                        SearchCategory

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
                                                   SearchVoucherCategory

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(10, "option");
            __builder.AddAttribute(11, "value");
            __builder.AddMarkupContent(12, "Chọn thể lọai");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "option");
            __builder.AddAttribute(15, "value", 
#nullable restore
#line 22 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
                            CategoryDiscount.Percent

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(16, "Phần trăm");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "option");
            __builder.AddAttribute(19, "value", 
#nullable restore
#line 23 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
                            CategoryDiscount.Cash

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(20, "Tiền mặt");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "select");
            __builder.AddAttribute(23, "value", 
#nullable restore
#line 25 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
                        SearchStatus

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
                                                 SearchVoucherStatus

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(25, "option");
            __builder.AddAttribute(26, "value");
            __builder.AddMarkupContent(27, "Chọn trạng thái");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.OpenElement(29, "option");
            __builder.AddAttribute(30, "value", "True");
            __builder.AddMarkupContent(31, "Còn hiệu lực");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenElement(33, "option");
            __builder.AddAttribute(34, "value", "False");
            __builder.AddMarkupContent(35, "Hết hiệu lực");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "type", "text");
            __builder.AddAttribute(39, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
                                                               SearchInfo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "placeholder", "Nhập thông tin tìm kiếm...");
            __builder.AddAttribute(41, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
                                        SearchString

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchString = __value, SearchString));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "class", "btn btn-outline-primary");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
                                                          OnInitialized

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(47, "Danh sách");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n    <br>\r\n    <br>");
            __builder.CloseElement();
            __builder.OpenElement(49, "table");
            __builder.AddAttribute(50, "class", "table table-hover text-center");
            __builder.OpenElement(51, "thead");
            __builder.AddAttribute(52, "class", "thead-dark");
            __builder.OpenElement(53, "tr");
            __builder.OpenElement(54, "th");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
                                ()=>VoucherSorting("VoucherCode")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(56, "Mã voucher");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.OpenElement(58, "th");
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
                                ()=>VoucherSorting("StartDate")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(60, "Ngày hiệu lực");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.OpenElement(62, "th");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
                                ()=>VoucherSorting("EndDate")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(64, "Ngày kết thúc");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.OpenElement(66, "th");
            __builder.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
                                ()=>VoucherSorting("Status")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(68, "Trạng thái");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                ");
            __builder.OpenElement(70, "th");
            __builder.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
                                ()=>VoucherSorting("VoucherQuantity")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(72, "Số lượng");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.OpenElement(74, "th");
            __builder.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
                                ()=>VoucherSorting("CategoryDiscount")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(76, "Loại giảm giá");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                ");
            __builder.OpenElement(78, "th");
            __builder.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
                                ()=>VoucherSorting("Value")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(80, "Giá trị");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                <th></th>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n        ");
            __builder.OpenElement(83, "tbody");
#nullable restore
#line 52 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
             foreach (var item in vouchers)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(84, "tr");
            __builder.OpenElement(85, "td");
            __builder.AddContent(86, 
#nullable restore
#line 55 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
                         item.VoucherCode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                    ");
            __builder.OpenElement(88, "td");
            __builder.AddContent(89, 
#nullable restore
#line 56 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
                         item.StartDate.Date.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                    ");
            __builder.OpenElement(91, "td");
            __builder.AddContent(92, 
#nullable restore
#line 57 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
                         item.EndDate.Date.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                    ");
            __builder.OpenElement(94, "td");
#nullable restore
#line 59 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
                         if (item.Status)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(95, "<span>Còn hiệu lực</span>");
#nullable restore
#line 62 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(96, "<span>Hết hiệu lực</span>");
#nullable restore
#line 66 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n                    ");
            __builder.OpenElement(98, "td");
            __builder.AddContent(99, 
#nullable restore
#line 68 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
                         item.VoucherQuantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n                    ");
            __builder.OpenElement(101, "td");
            __builder.AddContent(102, 
#nullable restore
#line 69 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
                         item.CategoryDiscount.DisplayName()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n                    ");
            __builder.OpenElement(104, "td");
            __builder.AddContent(105, 
#nullable restore
#line 70 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
                         item.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                    ");
            __builder.OpenElement(107, "td");
            __builder.OpenElement(108, "a");
            __builder.AddAttribute(109, "class", "btn btn-info");
            __builder.AddAttribute(110, "href", "/voucherdialog/" + (
#nullable restore
#line 72 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
                                                                      item.VoucherId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(111, "Sửa");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 75 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 78 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Vouchers\VoucherList.razor"
       
    //[Parameter]
    public string SearchString { get; set; }
    public string SearchCategory { get; set; }
    public string SearchStatus { get; set; }
    int ids = 0;
    public List<Voucher> vouchers;

    protected void SearchInfo(ChangeEventArgs args)
    {
        SearchString = args.Value.ToString();
        if (!string.IsNullOrEmpty(SearchString))
        {
            vouchers = _voucherSvc.GetAllVoucher().Where(x => x.VoucherCode.ToUpper().Contains(SearchString.ToUpper())
            || x.StartDate.ToString().Contains(SearchString) || x.EndDate.ToString().Contains(SearchString)
            || x.VoucherQuantity.ToString().Contains(SearchString) || x.Value.ToString().Contains(SearchString)).ToList();
        }
        else
        {
            vouchers = _voucherSvc.GetAllVoucher();
        }
    }

    protected void SearchVoucherCategory(ChangeEventArgs args)
    {
        SearchCategory = args.Value.ToString();
        if (!string.IsNullOrEmpty(SearchCategory))
        {
            vouchers = _voucherSvc.GetAllVoucher().Where(x => x.CategoryDiscount.ToString() == SearchCategory).ToList();
        }
        else
        {
            vouchers = _voucherSvc.GetAllVoucher();
        }
    }

    protected void SearchVoucherStatus(ChangeEventArgs args)
    {
        SearchStatus = args.Value.ToString();
        if (!string.IsNullOrEmpty(SearchStatus))
        {
            vouchers = _voucherSvc.GetAllVoucher().Where(x => x.Status.ToString() == SearchStatus).ToList();
        }
        else
        {
            vouchers = _voucherSvc.GetAllVoucher();
        }
    }

    protected void VoucherSorting(string SortColumn)
    {
        vouchers = _voucherSvc.GetAllVoucher();
        if (ids == 0)
        {
            ids = 1;
            switch (SortColumn)
            {
                case "VoucherCode":
                    vouchers = vouchers.OrderBy(x => x.VoucherCode).ToList();
                    break;
                case "StartDate":
                    vouchers = vouchers.OrderBy(x => x.StartDate).ToList();
                    break;
                case "EndDate":
                    vouchers = vouchers.OrderBy(x => x.EndDate).ToList();
                    break;
                case "Status":
                    vouchers = vouchers.OrderBy(x => x.Status).ToList();
                    break;
                case "VoucherQuantity":
                    vouchers = vouchers.OrderBy(x => x.VoucherQuantity).ToList();
                    break;
                case "CategoryDiscount":
                    vouchers = vouchers.OrderBy(x => x.CategoryDiscount).ToList();
                    break;
                case "Value":
                    vouchers = vouchers.OrderBy(x => x.Value).ToList();
                    break;
            }
        }
        else
        {
            ids = 0;

            switch (SortColumn)
            {
                case "VoucherCode":
                    vouchers = vouchers.OrderByDescending(x => x.VoucherCode).ToList();
                    break;
                case "StartDate":
                    vouchers = vouchers.OrderByDescending(x => x.StartDate).ToList();
                    break;
                case "EndDate":
                    vouchers = vouchers.OrderByDescending(x => x.EndDate).ToList();
                    break;
                case "Status":
                    vouchers = vouchers.OrderByDescending(x => x.Status).ToList();
                    break;
                case "VoucherQuantity":
                    vouchers = vouchers.OrderByDescending(x => x.VoucherQuantity).ToList();
                    break;
                case "CategoryDiscount":
                    vouchers = vouchers.OrderByDescending(x => x.CategoryDiscount).ToList();
                    break;
                case "Value":
                    vouchers = vouchers.OrderByDescending(x => x.Value).ToList();
                    break;
            }
        }
    }

    protected override void OnInitialized()
    {
        vouchers = _voucherSvc.GetAllVoucher();
    }
    //protected override void OnParametersSet()
    //{
    //    if (!string.IsNullOrEmpty(SearchString))
    //    {
    //        vouchers = _voucherSvc.GetAllVoucher().Where(x => x.VoucherCode.ToUpper().Contains(SearchString.ToUpper())).ToList();
    //    }
    //    else
    //    {
    //        vouchers = _voucherSvc.GetAllVoucher();
    //    }
    //}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Share.Interfaces.IVoucherSvc _voucherSvc { get; set; }
    }
}
#pragma warning restore 1591
