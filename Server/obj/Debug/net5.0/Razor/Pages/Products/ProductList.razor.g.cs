<<<<<<< HEAD
#pragma checksum "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Products\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53f382a8f2dbe568268330427bcba3cb0ae6bc70"
=======
#pragma checksum "D:\DATN\Project\SaCBackpack\Server\Pages\Products\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8531fdda5fcc02f2397f090950871c2564bde86b"
>>>>>>> Thanh-Module
// <auto-generated/>
#pragma warning disable 1591
namespace Server.Pages.Products
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\_Imports.razor"
using Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Products\ProductList.razor"
=======
#line 11 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DATN\Project\SaCBackpack\Server\Pages\Products\ProductList.razor"
>>>>>>> Thanh-Module
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Products\ProductList.razor"
using Share.Helpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/productlist")]
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"font-weight-bold text-center\">Danh sách sản phẩm</h1>");
#nullable restore
<<<<<<< HEAD
#line 9 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Products\ProductList.razor"
     if (products == null)
    {
=======
#line 9 "D:\DATN\Project\SaCBackpack\Server\Pages\Products\ProductList.razor"
 if (products == null)
{
>>>>>>> Thanh-Module

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading ...</em></p>");
#nullable restore
<<<<<<< HEAD
#line 12 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Products\ProductList.razor"
    }
    else
    {
=======
#line 12 "D:\DATN\Project\SaCBackpack\Server\Pages\Products\ProductList.razor"
}
else
{
>>>>>>> Thanh-Module

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "text-right");
            __builder.AddMarkupContent(4, "<a style=\"text-decoration:none;\" href=\"/productdialog/0\"><button type=\"button\" class=\"btn btn-success btn-circle btn-md\"><i class=\"fa fa-plus\" style=\"color:white;font-size:20px;\"></i></button></a>\r\n    <br>\r\n    <br>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
<<<<<<< HEAD
#line 20 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Products\ProductList.razor"
=======
#line 22 "D:\DATN\Project\SaCBackpack\Server\Pages\Products\ProductList.razor"
>>>>>>> Thanh-Module
                                   SearchString

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchString = __value, SearchString));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "class", "btn btn-outline-success");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
<<<<<<< HEAD
#line 21 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Products\ProductList.razor"
=======
#line 23 "D:\DATN\Project\SaCBackpack\Server\Pages\Products\ProductList.razor"
>>>>>>> Thanh-Module
                                                          OnParametersSet

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(15, "<i class=\"fa fa-search\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "btn btn-outline-primary");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
<<<<<<< HEAD
#line 22 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Products\ProductList.razor"
=======
#line 24 "D:\DATN\Project\SaCBackpack\Server\Pages\Products\ProductList.razor"
>>>>>>> Thanh-Module
                                                          OnInitialized

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(20, "Danh sách");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    <br>\r\n    <br>");
            __builder.CloseElement();
            __builder.OpenElement(22, "table");
            __builder.AddAttribute(23, "class", "table table-hover text-center");
            __builder.AddMarkupContent(24, @"<thead class=""thead-dark""><tr><th scope=""col"">Tên</th>
                <th scope=""col"">Giá</th>
                <th scope=""col"">Phân loại</th>
                <th scope=""col"" style=""width:20%"">Hình</th>
                <th scope=""col"">Trạng thái</th>
                <th scope=""col"" style=""width:30%"">Thông tin</th>
                <th scope=""col"">Hành động</th></tr></thead>
        ");
            __builder.OpenElement(25, "tbody");
#nullable restore
<<<<<<< HEAD
#line 41 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Products\ProductList.razor"
                 foreach (var item in products)
                {
=======
#line 43 "D:\DATN\Project\SaCBackpack\Server\Pages\Products\ProductList.razor"
             foreach (var item in products)
            {
>>>>>>> Thanh-Module

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "tr");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
<<<<<<< HEAD
#line 44 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Products\ProductList.razor"
                             item.ProductName
=======
#line 46 "D:\DATN\Project\SaCBackpack\Server\Pages\Products\ProductList.razor"
                         item.ProductName
>>>>>>> Thanh-Module

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
<<<<<<< HEAD
#line 45 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Products\ProductList.razor"
                             item.Price
=======
#line 47 "D:\DATN\Project\SaCBackpack\Server\Pages\Products\ProductList.razor"
                         item.Price
>>>>>>> Thanh-Module

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
<<<<<<< HEAD
#line 46 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Products\ProductList.razor"
                             item.Category.DisplayName()
=======
#line 48 "D:\DATN\Project\SaCBackpack\Server\Pages\Products\ProductList.razor"
                         item.Category.DisplayName()
>>>>>>> Thanh-Module

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "td");
            __builder.OpenElement(37, "img");
            __builder.AddAttribute(38, "src", "images/Product/" + (
#nullable restore
<<<<<<< HEAD
#line 47 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Products\ProductList.razor"
                                                      item.Image
=======
#line 49 "D:\DATN\Project\SaCBackpack\Server\Pages\Products\ProductList.razor"
                                                  item.Image
>>>>>>> Thanh-Module

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "style", "width:150px; height:150px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.OpenElement(41, "td");
#nullable restore
<<<<<<< HEAD
#line 49 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Products\ProductList.razor"
                             if (item.Status)
                            {
=======
#line 51 "D:\DATN\Project\SaCBackpack\Server\Pages\Products\ProductList.razor"
                         if (item.Status)
                        {
>>>>>>> Thanh-Module

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(42, "<span>Còn hàng</span>");
#nullable restore
<<<<<<< HEAD
#line 52 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Products\ProductList.razor"
                            }
                            else
                            {
=======
#line 54 "D:\DATN\Project\SaCBackpack\Server\Pages\Products\ProductList.razor"
                        }
                        else
                        {
>>>>>>> Thanh-Module

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(43, "<span>Hết hàng</span>");
#nullable restore
<<<<<<< HEAD
#line 56 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Products\ProductList.razor"
                            }
=======
#line 58 "D:\DATN\Project\SaCBackpack\Server\Pages\Products\ProductList.razor"
                        }
>>>>>>> Thanh-Module

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.OpenElement(45, "td");
            __builder.AddContent(46, 
#nullable restore
<<<<<<< HEAD
#line 58 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Products\ProductList.razor"
                             item.Description
=======
#line 60 "D:\DATN\Project\SaCBackpack\Server\Pages\Products\ProductList.razor"
                          (MarkupString)item.Description
>>>>>>> Thanh-Module

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.OpenElement(48, "td");
            __builder.OpenElement(49, "a");
            __builder.AddAttribute(50, "class", "btn btn-info");
            __builder.AddAttribute(51, "href", "/productdialog/" + (
#nullable restore
<<<<<<< HEAD
#line 60 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Products\ProductList.razor"
                                                                          item.ProductId
=======
#line 62 "D:\DATN\Project\SaCBackpack\Server\Pages\Products\ProductList.razor"
                                                                      item.ProductId
>>>>>>> Thanh-Module

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(52, "Sửa");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
<<<<<<< HEAD
#line 63 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Products\ProductList.razor"
                }
=======
#line 65 "D:\DATN\Project\SaCBackpack\Server\Pages\Products\ProductList.razor"
            }
>>>>>>> Thanh-Module

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
<<<<<<< HEAD
#line 66 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Products\ProductList.razor"
    }
=======
#line 68 "D:\DATN\Project\SaCBackpack\Server\Pages\Products\ProductList.razor"
}
>>>>>>> Thanh-Module

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
<<<<<<< HEAD
#line 69 "C:\Users\asus\OneDrive\Máy tính\DATN\Project\Server\Pages\Products\ProductList.razor"
=======
#line 70 "D:\DATN\Project\SaCBackpack\Server\Pages\Products\ProductList.razor"
>>>>>>> Thanh-Module
       
    [Parameter]
    public string SearchString { get; set; }

    public List<Product> products { get; set; }

    protected override void OnParametersSet()
    {
        if (!string.IsNullOrEmpty(SearchString))
        {
            products = _productSvc.GetAllProduct().Where(x => x.ProductName.ToUpper().Contains(SearchString.ToUpper())).ToList();
        }
        else
        {
            products = _productSvc.GetAllProduct();
        }
    }

    protected override void OnInitialized()
    {
        products = _productSvc.GetAllProduct();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Share.Interfaces.IProductSvc _productSvc { get; set; }
    }
}
#pragma warning restore 1591
