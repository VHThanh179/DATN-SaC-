#pragma checksum "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "667b132eb9f4bf6555ad59bd01a3b8e8c626e12f"
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
#line 12 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\_Imports.razor"
using Share.Models;

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
#line 2 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
using Share.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
using Share.Helpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cart")]
    public partial class CartLayout : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .my-custom-scrollbar {\r\n        position: relative;\r\n        height: 400px;\r\n        overflow: auto;\r\n    }\r\n\r\n    .table-wrapper-scroll-y {\r\n        display: block;\r\n    }\r\n\r\n    .payment-info {\r\n        background: blue;\r\n        padding: 10px;\r\n        border-radius: 6px;\r\n        color: #fff;\r\n        font-weight: bold\r\n    }\r\n\r\n    .product-details {\r\n        padding: 10px\r\n    }\r\n\r\n    body {\r\n        background: #eee\r\n    }\r\n\r\n    .cart {\r\n        background: #fff\r\n    }\r\n\r\n    .p-about {\r\n        font-size: 12px\r\n    }\r\n\r\n    .table-shadow {\r\n        -webkit-box-shadow: 5px 5px 15px -2px rgba(0, 0, 0, 0.42);\r\n        box-shadow: 5px 5px 15px -2px rgba(0, 0, 0, 0.42)\r\n    }\r\n\r\n    .type {\r\n        font-weight: 400;\r\n        font-size: 10px\r\n    }\r\n\r\n    label.radio {\r\n        cursor: pointer\r\n    }\r\n\r\n        label.radio input {\r\n            position: absolute;\r\n            top: 0;\r\n            left: 0;\r\n            visibility: hidden;\r\n            pointer-events: none\r\n        }\r\n\r\n        label.radio span {\r\n            padding: 1px 12px;\r\n            border: 2px solid #ada9a9;\r\n            display: inline-block;\r\n            color: #8f37aa;\r\n            border-radius: 3px;\r\n            text-transform: uppercase;\r\n            font-size: 11px;\r\n            font-weight: 300\r\n        }\r\n\r\n        label.radio input:checked + span {\r\n            border-color: #fff;\r\n            background-color: blue;\r\n            color: #fff\r\n        }\r\n\r\n    .credit-inputs {\r\n        background: rgb(102, 102, 221);\r\n        color: #fff !important;\r\n        border-color: rgb(102, 102, 221)\r\n    }\r\n\r\n        .credit-inputs::placeholder {\r\n            color: #fff;\r\n            font-size: 13px\r\n        }\r\n\r\n    .credit-card-label {\r\n        font-size: 9px;\r\n        font-weight: 300\r\n    }\r\n\r\n    .form-control.credit-inputs:focus {\r\n        background: rgb(102, 102, 221);\r\n        border: rgb(102, 102, 221)\r\n    }\r\n\r\n    .line {\r\n        border-bottom: 1px solid rgb(102, 102, 221)\r\n    }\r\n\r\n    .information span {\r\n        font-size: 12px;\r\n        font-weight: 500\r\n    }\r\n\r\n    .information {\r\n        margin-bottom: 5px\r\n    }\r\n\r\n    .items {\r\n        -webkit-box-shadow: 5px 5px 4px -1px rgba(0, 0, 0, 0.25);\r\n        box-shadow: 5px 5px 4px -1px rgba(0, 0, 0, 0.08)\r\n    }\r\n\r\n    .spec {\r\n        font-size: 11px\r\n    }\r\n\r\n    .button:focus {\r\n        outline: none;\r\n    }\r\n</style>\r\n");
            __builder.OpenComponent<BlazorAnimate.Animate>(1);
            __builder.AddAttribute(2, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 133 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
                    Animations.FadeUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 133 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
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
                __builder2.AddAttribute(10, "class", "col-md-12");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "product-details mr-2");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "d-flex justify-content-between");
                __builder2.AddMarkupContent(15, "<a href=\"/\" class=\"d-flex flex-row align-items-center\"><i class=\"fa fa-long-arrow-left\"></i><span class=\"ml-2\">Tiếp tục mua sắm</span></a>\r\n                        ");
                __builder2.OpenElement(16, "a");
                __builder2.AddAttribute(17, "style", "cursor:pointer");
                __builder2.AddAttribute(18, "class", "d-flex flex-row align-items-end");
                __builder2.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 140 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
                                                                                                    ChangeDisplay

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(20, "<span class=\"ml-2\">Mã khuyến mãi</span>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n                    <hr>\r\n                    ");
                __builder2.AddMarkupContent(22, "<h6 class=\"mb-0\">Giỏ hàng</h6>\r\n                    ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "table-wrapper-scroll-y my-custom-scrollbar");
                __builder2.OpenElement(25, "table");
                __builder2.AddAttribute(26, "class", "table table-responsive mb-0");
                __builder2.OpenElement(27, "tbody");
#nullable restore
#line 147 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
                                 foreach (var item in orderCart.ListViewCart)
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(28, "tr");
                __builder2.AddAttribute(29, "class");
                __builder2.OpenElement(30, "th");
                __builder2.AddAttribute(31, "scope", "row");
                __builder2.AddAttribute(32, "width", "300px");
                __builder2.OpenElement(33, "img");
                __builder2.AddAttribute(34, "class", "rounded");
                __builder2.AddAttribute(35, "src", 
#nullable restore
#line 151 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
                                                                        imgUrl + item.product.Image

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(36, "width", "40");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                                            ");
                __builder2.OpenElement(38, "span");
                __builder2.AddAttribute(39, "class", "ml-2");
                __builder2.OpenElement(40, "span");
                __builder2.AddAttribute(41, "class", "font-weight-bold");
                __builder2.AddContent(42, 
#nullable restore
#line 152 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
                                                                                               item.product.ProductName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                                            ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "ml-2");
                __builder2.OpenElement(46, "span");
                __builder2.AddAttribute(47, "class", "spec badge bg-dark");
                __builder2.AddContent(48, 
#nullable restore
#line 153 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
                                                                                                item.product.Category.DisplayName()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n                                        ");
                __builder2.OpenElement(50, "th");
                __builder2.AddAttribute(51, "class", "text-center");
                __builder2.OpenElement(52, "span");
                __builder2.OpenElement(53, "i");
                __builder2.AddAttribute(54, "class", "fa fa-minus");
                __builder2.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 157 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
                                                                                   () => MinusQuantityAndUpdateCart(item)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(56, "   ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n                                            ");
                __builder2.OpenElement(58, "span");
                __builder2.AddAttribute(59, "class");
                __builder2.AddContent(60, 
#nullable restore
#line 158 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
                                                            item.Quantity

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(61, "   ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n                                            ");
                __builder2.OpenElement(63, "span");
                __builder2.OpenElement(64, "i");
                __builder2.AddAttribute(65, "class", "fa fa-plus");
                __builder2.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 159 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
                                                                                  () => PlusQuantityAndUpdateCart(item)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n                                        ");
                __builder2.OpenElement(68, "th");
                __builder2.AddAttribute(69, "class", "text-center");
                __builder2.AddAttribute(70, "width", "100px");
                __builder2.OpenElement(71, "span");
                __builder2.AddAttribute(72, "class", "font-weight-bold");
                __builder2.AddContent(73, 
#nullable restore
#line 161 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
                                                                                                              string.Format("{0:#,0}", item.Price)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(74, "đ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n                                        ");
                __builder2.OpenElement(76, "th");
                __builder2.AddAttribute(77, "class", "text-center");
                __builder2.AddAttribute(78, "width", "30px");
                __builder2.OpenElement(79, "i");
                __builder2.AddAttribute(80, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 162 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
                                                                                          () => DeleteCart(item)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(81, "class", "fa fa-trash-o ml-3 text-black-50 ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 164 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n                            ");
                __builder2.OpenElement(83, "tfoot");
                __builder2.OpenElement(84, "tr");
                __builder2.AddAttribute(85, "class");
                __builder2.AddMarkupContent(86, "<th scope=\"row\" width=\"300px\">Tổng cộng:</th>\r\n                                    <th class=\"text-center\"></th>\r\n                                    ");
                __builder2.OpenElement(87, "th");
                __builder2.AddAttribute(88, "class", "text-center");
                __builder2.AddAttribute(89, "width", "200px");
                __builder2.AddContent(90, 
#nullable restore
#line 171 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
                                                                            string.Format("{0:#,0}", @orderCart.Total)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(91, "đ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n                                    <th class=\"text-center\" width=\"30px\"></th>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n        ");
                __builder2.OpenElement(94, "div");
                __builder2.AddAttribute(95, "class", "row");
                __builder2.OpenElement(96, "div");
                __builder2.AddAttribute(97, "class", "col-6");
                __builder2.OpenElement(98, "span");
                __builder2.AddMarkupContent(99, "&nbsp; Bạn đã thêm ");
                __builder2.AddContent(100, 
#nullable restore
#line 209 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
                                          orderCart.ListViewCart.Count

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(101, " sản phẩm vào giỏ hàng");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n            ");
                __builder2.OpenElement(103, "div");
                __builder2.AddAttribute(104, "class", "col-6 text-end");
                __builder2.OpenElement(105, "button");
                __builder2.AddAttribute(106, "class", "btn btn-primary btn-block");
                __builder2.AddAttribute(107, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 212 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
                                                                      () => modal.Show<Checkout>("Thanh Toán")

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(108, "type", "button");
                __builder2.AddMarkupContent(109, "<span>Tiếp theo<i class=\"fa fa-long-arrow-right ml-1\"></i></span>");
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
#line 221 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\CartLayout.razor"
       
    private string emailAddress;
    public Cart orderCart;
    private double totalCost = 0;
    protected string imgUrl = "";
    protected string temp = "";
    public string vouchercode;
    public Voucher voucher = new Voucher();
    public List<Voucher> voucherlist;

    protected override void OnInitialized()
    {
        emailAddress = sessionStorage.GetItem<string>("Email");
        var cart = sessionStorage.GetItem<string>("cart");
        if (cart == null)
        {
            orderCart = new Share.Models.ViewModels.Cart();
        }
        else
        {
            orderCart = JsonConvert.DeserializeObject<Cart>(cart);
        }
        imgUrl = config.GetSection("API")["ImgUrl"].ToString();
    }

    protected override async Task OnInitializedAsync()
    {
        var apiUrl = config.GetSection("API")["APIUrl"].ToString();
        voucherlist = new List<Voucher>();

        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            client.BaseAddress = new Uri(apiUrl);
            using (var response = await client.GetAsync("Voucher"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                voucherlist = JsonConvert.DeserializeObject<List<Voucher>>(apiResponse);
            }
        }
    }

    private void PlusQuantity(CartItem item)
    {
        item.Quantity++;
    }
    private void MinusQuantity(CartItem item)
    {
        if (item.Quantity > 0)
        {
            item.Quantity--;
        }
    }

    private void PlusQuantityAndUpdateCart(CartItem item)
    {
        PlusQuantity(item);
        UpdateCart(item);
    }

    private void MinusQuantityAndUpdateCart(CartItem item)
    {
        MinusQuantity(item);
        UpdateCart(item);
    }

    private void UpdateCart(CartItem item)
    {
        double discount;
        if (voucher.VoucherCode != null)
        {
            if (voucher.CategoryDiscount == CategoryDiscount.Percent)
            {
                discount = voucher.Value / 100;
                item.Price = item.Quantity * item.product.Price;
                orderCart.Total = Calculate(orderCart.ListViewCart) - (Calculate(orderCart.ListViewCart) * (float)discount);
                sessionStorage.SetItem("cart", JsonConvert.SerializeObject(orderCart));
            }
            else
            {
                discount = voucher.Value;
                item.Price = item.Quantity * item.product.Price;
                orderCart.Total = Calculate(orderCart.ListViewCart) - (float)discount;
                sessionStorage.SetItem("cart", JsonConvert.SerializeObject(orderCart));
            }
        }
        else
        {
            item.Price = item.Quantity * item.product.Price;
            orderCart.Total = Calculate(orderCart.ListViewCart);
            sessionStorage.SetItem("cart", JsonConvert.SerializeObject(orderCart));
        }
    }

    private void DeleteCart(CartItem item)
    {
        orderCart.ListViewCart.Remove(item);
        orderCart.Total = Calculate(orderCart.ListViewCart);
        sessionStorage.SetItem("cart", JsonConvert.SerializeObject(orderCart));
    }

    private async Task OrderCart()
    {
        var apiUrl = config.GetSection("API")["APIUrl"].ToString();
        imgUrl = config.GetSection("API")["ImgUrl"].ToString();
        var accessToken = sessionStorage.GetItem<string>("AccessToken");
        var khachhangid = sessionStorage.GetItem<int>("khachhangId");

        orderCart.CustomerId = khachhangid;

        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            StringContent content = new StringContent(JsonConvert.SerializeObject(orderCart), System.Text.Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            HttpResponseMessage response = await client.PostAsync(apiUrl + "Cart", content);

            if (response.StatusCode == HttpStatusCode.OK)
            {

            }
            else
            {
                sessionStorage.RemoveItem("cart");
                await JSRuntime.InvokeAsync<object>("clearCart", "");
                NavigationManager.NavigateTo("/history");
            }
        }
    }

    private float Calculate(List<CartItem> listCart)
    {
        float total = 0;
        if (listCart != null)
        {
            for (int i = 0; i < listCart.Count; i++)
            {
                total += listCart[i].Price;
            }
        }
        return total;
    }

    private bool flag = false;
    private void ChangeDisplay()
    {
        if (!flag)
            flag = true;
        else
            flag = false;
    }

    private void CheckVoucher(Cart cart)
    {
        foreach (var item in voucherlist)
        {
            if (vouchercode == item.VoucherCode)
            {
                if (item.Status == true)
                {
                    voucher = item;
                    UpdateCart(cart.ListViewCart.FirstOrDefault());
                }
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService modal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
