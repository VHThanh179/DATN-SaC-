// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Server.Pages.Products
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
#line 17 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\DATN\Project\SaCBackpack\Server\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DATN\Project\SaCBackpack\Server\Pages\Products\ProductList.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DATN\Project\SaCBackpack\Server\Pages\Products\ProductList.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "D:\DATN\Project\SaCBackpack\Server\Pages\Products\ProductList.razor"
       
    //[Parameter]
    public string SearchString { get; set; }
    public string SearchCategory { get; set; }
    public string SearchStatus { get; set; }
    int ids = 0;

    public List<Product> products { get; set; }

    //protected override void OnParametersSet()
    //{
    //    if (!string.IsNullOrEmpty(SearchString))
    //    {
    //        products = _productSvc.GetAllProduct().Where(x => x.ProductName.ToUpper().Contains(SearchString.ToUpper())).ToList();
    //    }
    //    else
    //    {
    //        products = _productSvc.GetAllProduct();
    //    }
    //}

    protected void SearchInfo(ChangeEventArgs args)
    {
        SearchString = args.Value.ToString();
        if (!string.IsNullOrEmpty(SearchString))
        {
            products = _productSvc.GetAllProduct().Where(x => x.ProductName.ToUpper().Contains(SearchString.ToUpper())
            || x.Price.ToString().Contains(SearchString)).ToList();
        }
        else
        {
            products = _productSvc.GetAllProduct();
        }
    }

    protected void SearchProductStatus(ChangeEventArgs args)
    {
        SearchStatus = args.Value.ToString();
        if (!string.IsNullOrEmpty(SearchStatus))
        {
            products = _productSvc.GetAllProduct().Where(x => x.Status.ToString() == SearchStatus).ToList();
        }
        else
        {
            products = _productSvc.GetAllProduct();
        }
    }

    protected void SearchProductCategory(ChangeEventArgs args)
    {
        SearchCategory = args.Value.ToString();
        if (!string.IsNullOrEmpty(SearchCategory))
        {
            products = _productSvc.GetAllProduct().Where(x => x.Category.ToString() == SearchCategory).ToList();
        }
        else
        {
            products = _productSvc.GetAllProduct();
        }
    }

    protected void ProductSorting(string SortColumn)
    {
        products = _productSvc.GetAllProduct();
        if (ids == 0)
        {
            ids = 1;

            switch (SortColumn)
            {
                case "ProductName":
                    products = products.OrderBy(x => x.ProductName).ToList();
                    break;
                case "Price":
                    products = products.OrderBy(x => x.Price).ToList();
                    break;
                case "Category":
                    products = products.OrderBy(x => x.Category).ToList();
                    break;
            }
        }
        else
        {
            ids = 0;

            switch (SortColumn)
            {
                case "ProductName":
                    products = products.OrderByDescending(x => x.ProductName).ToList();
                    break;
                case "Price":
                    products = products.OrderByDescending(x => x.Price).ToList();
                    break;
                case "Category":
                    products = products.OrderByDescending(x => x.Category).ToList();
                    break;
            }
        }
    }

    protected override void OnInitialized()
    {
        products = _productSvc.GetAllProduct();
    }

    void ShowModalProduct(int prodId)
    {
        var parameters = new ModalParameters();
        parameters.Add(nameof(ProductDialog.id), prodId.ToString());
        string title;
        if (prodId == 0)
        {
            title = "Thêm sản phẩm";
        }
        else { title = "Cập nhật sản phẩm"; }
        modal.Show<ProductDialog>(title, parameters);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService modal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Share.Interfaces.IProductSvc _productSvc { get; set; }
    }
}
#pragma warning restore 1591
