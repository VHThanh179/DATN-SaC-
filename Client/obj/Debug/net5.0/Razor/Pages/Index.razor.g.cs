#pragma checksum "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57c68be512d79490cdbe4f3365689f5b2761c614"
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
#line 2 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
using Share.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(WebLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .carousel-inner img {\r\n        width: 100%;\r\n    }\r\n\r\n    .card {\r\n        background-color: #fff;\r\n        border: none;\r\n        border-radius: 10px;\r\n        width: auto;\r\n        box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);\r\n        margin-bottom: 20px;\r\n        height: 450px;\r\n    }\r\n\r\n        .card:hover {\r\n            border: solid;\r\n            border-color: black;\r\n            box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19)\r\n        }\r\n\r\n    .image-container {\r\n        position: relative;\r\n        text-align: center;\r\n    }\r\n\r\n    .product-detail-container {\r\n        position: relative;\r\n    }\r\n\r\n    .thumbnail-image {\r\n        border-radius: 10px !important;\r\n    }\r\n\r\n    .discount {\r\n        background-color: red;\r\n        padding-top: 1px;\r\n        padding-bottom: 1px;\r\n        padding-left: 4px;\r\n        padding-right: 4px;\r\n        border-radius: 6px;\r\n        color: #fff\r\n    }\r\n\r\n    .wishlist {\r\n        height: 25px;\r\n        width: 25px;\r\n        background-color: #eee;\r\n        display: flex;\r\n        justify-content: center;\r\n        align-items: center;\r\n        border-radius: 50%;\r\n        box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19)\r\n    }\r\n\r\n    .first {\r\n        position: absolute;\r\n        width: 100%;\r\n        padding: 9px\r\n    }\r\n\r\n    .dress-name {\r\n        font-weight: bold;\r\n        width: 100%;\r\n    }\r\n\r\n    .new-price {\r\n        font-size: 18px;\r\n        font-weight: bold;\r\n        color: red\r\n    }\r\n\r\n    .old-price {\r\n        font-weight: bold;\r\n        color: grey\r\n    }\r\n\r\n    .rating-number {\r\n        color: grey\r\n    }\r\n</style>\r\n<br>\r\n<br>\r\n<br>\r\n");
            __builder.OpenComponent<BlazorAnimate.Animate>(1);
            __builder.AddAttribute(2, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 103 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                    Animations.FadeUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 103 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                                                 TimeSpan.FromSeconds(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, @"<div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel""><div class=""carousel-inner""><div class=""carousel-item active""><img src=""/assets/img/banner1.jpg"" class=""d-block w-100"" alt=""Image1""></div>
            <div class=""carousel-item""><img src=""/assets/img/banner2.png"" class=""d-block w-100"" alt=""Image2""></div>
            <div class=""carousel-item""><img src=""/assets/img/banner3.png"" class=""d-block w-100"" alt=""Image3""></div></div>
        <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev""><span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span></a>
        <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next""><span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span></a></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenComponent<BlazorAnimate.Animate>(7);
            __builder.AddAttribute(8, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 128 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                    Animations.FadeUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 128 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                                                 TimeSpan.FromSeconds(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(11, "section");
                __builder2.AddAttribute(12, "id", "product");
                __builder2.AddAttribute(13, "class", "portfolio");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "container");
                __builder2.AddMarkupContent(16, "<div class=\"section-title\" data-aos=\"fade-up\"><h2>Sản phẩm</h2></div>\r\n\r\n            ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "row portfolio-container");
                __builder2.AddAttribute(19, "data-aos", "fade-up");
                __builder2.AddAttribute(20, "data-aos-delay", "200");
#nullable restore
#line 139 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                 foreach (var item in products)
                {
                    

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", " col-3 filter-app");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "card ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "image-container ");
                __builder2.AddMarkupContent(27, "<div class=\"first\"><div class=\"d-flex justify-content-between align-items-center\"><span class=\"wishlist\"><i class=\"fa fa-heart-o\"></i></span></div></div>");
#nullable restore
#line 163 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                                  
                                    temp = imgUrl + item.Image;
                                

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(28, "img");
                __builder2.AddAttribute(29, "src", 
#nullable restore
#line 166 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                                           temp

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(30, "class", "img-fluid rounded thumbnail-image");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                                ");
                __builder2.OpenElement(32, "a");
                __builder2.AddAttribute(33, "href", "/detail/" + (
#nullable restore
#line 167 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                                                  item.ProductId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "title", "More Details");
                __builder2.AddMarkupContent(35, "<i class=\"bx bx-link\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                            ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "product-detail-container p-2");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "d-flex justify-content-between align-items-center");
                __builder2.OpenElement(41, "h4");
                __builder2.AddAttribute(42, "class", "dress-name text-center");
                __builder2.AddContent(43, 
#nullable restore
#line 172 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                                                                        item.ProductName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                            ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "product-detail-container p-2");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "d-flex justify-content-between align-items-center pt-1");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "d-flex flex-column mb-2");
                __builder2.OpenElement(51, "span");
                __builder2.AddAttribute(52, "class", "new-price");
                __builder2.AddContent(53, 
#nullable restore
#line 178 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                                                                                                   string.Format("{0:#,0}", item.Price)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(54, " VNĐ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                                    ");
                __builder2.OpenElement(56, "button");
                __builder2.AddAttribute(57, "class", "btn btn-dark btn-sm text-right");
                __builder2.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 179 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                                                                                             () => AddCart(item.ProductId)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(59, "THÊM VÀO GIỎ HÀNG +");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 184 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(60, "\r\n");
            __builder.OpenComponent<BlazorAnimate.Animate>(61);
            __builder.AddAttribute(62, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 193 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                    Animations.FadeUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 193 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                                                 TimeSpan.FromSeconds(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(65, "<section id=\"services\" class=\"services section-bg\"><div class=\"container\"><div class=\"section-title\" data-aos=\"fade-up\"><h2>Dịch vụ</h2>\r\n                <p>Đến với dịch vụ của chúng tôi, quý khách sẽ được chọn những chiếc Balo & Phụ kiện chất lượng và mới nhất từ các nhà phân phối uy tín</p></div>\r\n\r\n            <div class=\"row\"><div class=\"col-md-6 col-lg-3 d-flex align-items-stretch mb-5 mb-lg-0\" data-aos=\"zoom-in\"><div class=\"icon-box icon-box-pink\"><div class=\"icon\"><i class=\"bx bxl-shopify\"></i></div>\r\n                        <h4 class=\"title\"><a href>Sản phẩm chất lượng</a></h4>\r\n                        <p class=\"description\">SaC Backpack - nơi mua sắm cặp balo, túi xách, phụ kiện lý tưởng của nhiều bạn trẻ, là sự lựa chọn hoàn hảo dành cho bạn. </p></div></div>\r\n\r\n                <div class=\"col-md-6 col-lg-3 d-flex align-items-stretch mb-5 mb-lg-0\" data-aos=\"zoom-in\" data-aos-delay=\"100\"><div class=\"icon-box icon-box-cyan\"><div class=\"icon\"><i class=\"bx bx-transfer-alt\"></i></div>\r\n                        <h4 class=\"title\"><a href>Giao hàng cực nhanh</a></h4>\r\n                        <p class=\"description\">Giao hàng trên toàn quốc cam kết đi hàng ngay khi nhận được đơn</p></div></div>\r\n\r\n                <div class=\"col-md-6 col-lg-3 d-flex align-items-stretch mb-5 mb-lg-0\" data-aos=\"zoom-in\" data-aos-delay=\"200\"><div class=\"icon-box icon-box-green\"><div class=\"icon\"><i class=\"bx bx-dollar\"></i></div>\r\n                        <h4 class=\"title\"><a href>Giá cả phải chăng</a></h4>\r\n                        <p class=\"description\">Đến với SaC Backpack bạn có thể thoải mái lựa chọn những chiếc Balo & phụ kiện với giá cực rẻ</p></div></div>\r\n\r\n                <div class=\"col-md-6 col-lg-3 d-flex align-items-stretch mb-5 mb-lg-0\" data-aos=\"zoom-in\" data-aos-delay=\"300\"><div class=\"icon-box icon-box-blue\"><div class=\"icon\"><i class=\"bx bxs-backpack\"></i></div>\r\n                        <h4 class=\"title\"><a href>Nhẹ nhàng thoải mái</a></h4>\r\n                        <p class=\"description\">Thiết kế chú trọng tới sự thoải mái và thời trang, sành điệu. </p></div></div></div></div></section>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(66, "\r\n");
            __builder.OpenComponent<BlazorAnimate.Animate>(67);
            __builder.AddAttribute(68, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 241 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                    Animations.FadeUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 241 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                                                 TimeSpan.FromSeconds(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "Delay", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 241 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
                                                                                 TimeSpan.FromSeconds(0.5)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(72, "<section id=\"contact\" class=\"contact section-bg\"><div class=\"container\"><div class=\"section-title\" data-aos=\"fade-up\"><h2>Liên hệ với chúng tôi</h2></div>\r\n\r\n            <div class=\"row\"><div class=\"col-lg-5 d-flex align-items-stretch\" data-aos=\"fade-right\"><div class=\"info\"><div class=\"address\"><i class=\"bi bi-geo-alt\"></i>\r\n                            <h4>Location:</h4>\r\n                            <p>A108 Adam Street, New York, NY 535022</p></div>\r\n\r\n                        <div class=\"email\"><i class=\"bi bi-envelope\"></i>\r\n                            <h4>Email:</h4>\r\n                            <p>info@example.com</p></div>\r\n\r\n                        <div class=\"phone\"><i class=\"bi bi-phone\"></i>\r\n                            <h4>Call:</h4>\r\n                            <p>+1 5589 55488 55s</p></div>\r\n\r\n                        <iframe src=\"https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d12097.433213460943!2d-74.0062269!3d40.7101282!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0xb89d1fe6bc499443!2sDowntown+Conference+Center!5e0!3m2!1smk!2sbg!4v1539943755621\" frameborder=\"0\" style=\"border:0; width: 100%; height: 290px;\" allowfullscreen></iframe></div></div>\r\n\r\n                <div class=\"col-lg-7 mt-5 mt-lg-0 d-flex align-items-stretch\" data-aos=\"fade-left\"><form action=\"forms/contact.php\" method=\"post\" role=\"form\" class=\"php-email-form\"><div class=\"row\"><div class=\"form-group col-md-6\"><label for=\"name\">Your Name</label>\r\n                                <input type=\"text\" name=\"name\" class=\"form-control\" id=\"name\" required></div>\r\n                            <div class=\"form-group col-md-6 mt-3 mt-md-0\"><label for=\"name\">Your Email</label>\r\n                                <input type=\"email\" class=\"form-control\" name=\"email\" id=\"email\" required></div></div>\r\n                        <div class=\"form-group mt-3\"><label for=\"name\">Subject</label>\r\n                            <input type=\"text\" class=\"form-control\" name=\"subject\" id=\"subject\" required></div>\r\n                        <div class=\"form-group mt-3\"><label for=\"name\">Message</label>\r\n                            <textarea class=\"form-control\" name=\"message\" rows=\"10\" required></textarea></div>\r\n                        <div class=\"my-3\"><div class=\"loading\">Loading</div>\r\n                            <div class=\"error-message\"></div>\r\n                            <div class=\"sent-message\">Your message has been sent. Thank you!</div></div>\r\n                        <div class=\"text-center\"><button type=\"submit\">Send Message</button></div></form></div></div></div></section>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
           
    protected async override Task OnAfterRenderAsync(bool fistRender)
    {
        if (fistRender)
        {
            await JSRuntime.InvokeAsync<object>("initializeCarousel");
            fistRender = false;
        }
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 313 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Client\Pages\Index.razor"
      

    public List<Product> products;
    protected string imgUrl = "";
    protected string temp = "";

    protected override async Task OnInitializedAsync()
    {
        var apiUrl = config.GetSection("API")["APIUrl"].ToString();
        imgUrl = config.GetSection("API")["ImgUrl"].ToString();

        products = new List<Product>();
        using (var client = new HttpClient())
        {
            //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            client.BaseAddress = new Uri(apiUrl);
            using (var response = await client.GetAsync("Product"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                products = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(apiResponse);
            }
        }
    }

    private void AddCart(int id)
    {
        //var cart = HttpContext.Session.GetString("cart");//get key cart
        var cart = sessionStorage.GetItem<string>("cart");//get key cart
        if (cart == null)
        {
            var product = products.Where(u => u.ProductId == id).FirstOrDefault();
            List<CartItem> listCart = new List<CartItem>()
    {
                    new CartItem
                    {
                        product = product,
                        Quantity = 1,
                        Price = product.Price
                    }
            };

            Cart orderCart = new Cart()
            {
                ListViewCart = listCart,
                Total = Calculate(listCart)
            };

            sessionStorage.SetItem("cart", JsonConvert.SerializeObject(orderCart));
            //HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(listCart));
        }
        else
        {
            var product = products.Where(u => u.ProductId == id).FirstOrDefault();
            Cart orderCart = JsonConvert.DeserializeObject<Cart>(cart);
            bool check = true;
            for (int i = 0; i < orderCart.ListViewCart.Count; i++)
            {
                if (orderCart.ListViewCart[i].product.ProductId == id)
                {
                    orderCart.ListViewCart[i].Quantity++;
                    orderCart.ListViewCart[i].Price = product.Price * orderCart.ListViewCart[i].Quantity;
                    check = false;
                }
            }

            if (check)
            {
                orderCart.ListViewCart.Add(new CartItem
                {
                    product = product,
                    Quantity = 1,
                    Price = product.Price * 1
                });
            }
            orderCart.Total = Calculate(orderCart.ListViewCart);
            sessionStorage.SetItem("cart", JsonConvert.SerializeObject(orderCart));

            //HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
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

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.JSInterop.IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISyncSessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
