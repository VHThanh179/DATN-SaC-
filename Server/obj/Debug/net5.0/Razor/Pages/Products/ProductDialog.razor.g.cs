#pragma checksum "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23bb01bf77b9fb937ddfb52b0e56ddc42a964de3"
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
#line 2 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
using Syncfusion.Blazor.RichTextEditor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/productdialog/{id}")]
    public partial class ProductDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .my-custom-scrollbar {
        position: relative;
        height: 650px;
        overflow: auto;
    }

    .textEditorScroll {
        position: relative;
        height: 175px;
        overflow: auto;
    }

    .table-wrapper-scroll-y {
        display: block;
    }

    main {
        height: 650px;
    }
</style>
");
            __builder.OpenElement(1, "main");
            __builder.AddAttribute(2, "class", "row table-wrapper-scroll-y my-custom-scrollbar");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-10 m-auto");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 36 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                          product

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 36 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                                                   SubmitForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.OpenElement(11, "input");
                __builder2.AddAttribute(12, "type", "hidden");
                __builder2.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                                        product.ProductId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => product.ProductId = __value, product.ProductId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "row");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group col-6");
                __builder2.AddMarkupContent(20, "<label class=\"control-label\">Tên sản phẩm</label>\r\n                    ");
                __builder2.OpenElement(21, "input");
                __builder2.AddAttribute(22, "class", "form-control");
                __builder2.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                                  product.ProductName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => product.ProductName = __value, product.ProductName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n                    ");
                __Blazor.Server.Pages.Products.ProductDialog.TypeInference.CreateValidationMessage_0(__builder2, 26, 27, 
#nullable restore
#line 43 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                                              () => product.ProductName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n\r\n                ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group col-6");
                __builder2.AddMarkupContent(31, "<label class=\"control-label\">Giá</label>\r\n                    ");
                __builder2.OpenElement(32, "input");
                __builder2.AddAttribute(33, "class", "form-control");
                __builder2.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 48 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                                  product.Price

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => product.Price = __value, product.Price));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                    ");
                __Blazor.Server.Pages.Products.ProductDialog.TypeInference.CreateValidationMessage_1(__builder2, 37, 38, 
#nullable restore
#line 49 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                                              () => product.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n\r\n            ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "row");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-group col-6");
                __builder2.AddMarkupContent(44, "<label class=\"control-label\">Phân loại</label>\r\n                    ");
                __Blazor.Server.Pages.Products.ProductDialog.TypeInference.CreateInputSelect_2(__builder2, 45, 46, "form-control", 47, 
#nullable restore
#line 57 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                                               product.Category

#line default
#line hidden
#nullable disable
                , 48, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.Category = __value, product.Category)), 49, () => product.Category, 50, (__builder3) => {
                    __builder3.OpenElement(51, "option");
                    __builder3.AddAttribute(52, "value", 
#nullable restore
#line 58 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                                        Category.Backpack

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(53, "Ba lô");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(54, "\r\n                        ");
                    __builder3.OpenElement(55, "option");
                    __builder3.AddAttribute(56, "value", 
#nullable restore
#line 59 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                                        Category.Accessories

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(57, "Phụ kiện");
                    __builder3.CloseElement();
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "form-group col-6");
                __builder2.AddMarkupContent(61, "<label class=\"control-label\">Trạng thái</label>\r\n                    ");
                __builder2.OpenElement(62, "select");
                __builder2.AddAttribute(63, "class", "form-control");
                __builder2.AddAttribute(64, "required");
                __builder2.AddAttribute(65, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 64 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                                   status

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => status = __value, status));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(67, "option");
                __builder2.AddAttribute(68, "value");
                __builder2.AddMarkupContent(69, "Chọn trạng thái");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n                        ");
                __builder2.OpenElement(71, "option");
                __builder2.AddAttribute(72, "value", "true");
                __builder2.AddMarkupContent(73, "Còn hàng");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n                        ");
                __builder2.OpenElement(75, "option");
                __builder2.AddAttribute(76, "value", "false");
                __builder2.AddMarkupContent(77, "Hết hàng");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n\r\n            ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "row");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "form-group col-6");
                __builder2.AddMarkupContent(83, "<label class=\"control-label\">Chọn hình</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(84);
                __builder2.AddAttribute(85, "class", "form-control");
                __builder2.AddAttribute(86, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 75 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                                                              OnInputFileChange

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
#nullable restore
#line 76 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                     if (isOverSized)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(87, "<span class=\"text-danger\">Kích thước ảnh phải nhỏ hơn 1MB</span>");
#nullable restore
#line 79 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 81 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                 if (product.Image != null)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "form-group col-6");
                __builder2.OpenElement(90, "img");
                __builder2.AddAttribute(91, "src", "images/Product/" + (
#nullable restore
#line 84 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                                                  product.Image

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(92, "style", "height:100px");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 86 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n            ");
                __builder2.OpenElement(94, "div");
                __builder2.AddAttribute(95, "class", "row");
                __builder2.OpenElement(96, "div");
                __builder2.AddAttribute(97, "class", "form-group col-12");
                __builder2.AddMarkupContent(98, "<label class=\"control-label\">\r\n                        Thông tin mô tả\r\n                    </label>\r\n                    ");
                __builder2.OpenElement(99, "div");
                __builder2.AddAttribute(100, "class", "textEditorScroll table-wrapper-scroll-y");
                __builder2.OpenComponent<Syncfusion.Blazor.RichTextEditor.SfRichTextEditor>(101);
                __builder2.AddAttribute(102, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 94 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                                                       product.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(103, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.Description = __value, product.Description))));
                __builder2.AddAttribute(104, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => product.Description));
                __builder2.AddAttribute(105, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.RichTextEditor.RichTextEditorToolbarSettings>(106);
                    __builder3.AddAttribute(107, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Syncfusion.Blazor.RichTextEditor.ToolbarItemModel>>(
#nullable restore
#line 95 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                                                                  Toolbars

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(108, "\r\n                        ");
                __Blazor.Server.Pages.Products.ProductDialog.TypeInference.CreateValidationMessage_3(__builder2, 109, 110, 
#nullable restore
#line 97 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                                                  () => product.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\r\n            ");
                __builder2.OpenElement(112, "div");
                __builder2.AddAttribute(113, "class", "form-group text-center");
#nullable restore
#line 102 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                 if (id == "0")
                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(114, "<button type=\"submit\" class=\"btn btn-info\">Thêm</button>");
#nullable restore
#line 105 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(115, "button");
                __builder2.AddAttribute(116, "type", "submit");
                __builder2.AddAttribute(117, "class", "btn btn-info");
                __builder2.AddAttribute(118, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 108 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                                                                            () => toastService.ShowSuccess("Lưu thành công!")

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(119, "Cập nhật");
                __builder2.CloseElement();
#nullable restore
#line 109 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(120, "input");
                __builder2.AddAttribute(121, "type", "button");
                __builder2.AddAttribute(122, "class", "ml-2 btn btn-primary");
                __builder2.AddAttribute(123, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 110 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 119 "C:\Users\Navteiv\Desktop\DATN\DATN-SaC\Server\Pages\Products\ProductDialog.razor"
       
    [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }

    [Parameter]
    public string id { get; set; }

    private string status = null;
    public bool isOverSized { get; set; }

    private Product product { get; set; }
    IReadOnlyList<IBrowserFile> selectedFiles;

    public List<ToolbarItemModel> Toolbars = new List<ToolbarItemModel>()
{
        new ToolbarItemModel() { Command = ToolbarCommand.Bold },
        new ToolbarItemModel() { Command = ToolbarCommand.Italic },
        new ToolbarItemModel() { Command = ToolbarCommand.Underline },
        new ToolbarItemModel() { Command = ToolbarCommand.FontSize },
        new ToolbarItemModel() { Command = ToolbarCommand.FontColor },
        new ToolbarItemModel() { Command = ToolbarCommand.LowerCase },
        new ToolbarItemModel() { Command = ToolbarCommand.UpperCase },
        new ToolbarItemModel() { Command = ToolbarCommand.Alignments },
        new ToolbarItemModel() { Command = ToolbarCommand.CreateLink },
        new ToolbarItemModel() { Command = ToolbarCommand.Undo },
        new ToolbarItemModel() { Command = ToolbarCommand.Redo }
        };


    protected override void OnInitialized()
    {
        if (string.IsNullOrWhiteSpace(id) || id == "0")
        {
            product = new Product();
            product.Status = true;
        }
        else
        {
            product = _productSvc.GetProduct(int.Parse(id));
            if (product.Status == true)
            {
                status = "true";
            }
            else
            {
                status = "false";
            }
        }
    }

    private async void SubmitForm()
    {
        if (selectedFiles != null && selectedFiles.Count > 0)
        {
            var roothPath = $"{env.WebRootPath}\\images";
            if (!Directory.Exists(roothPath))
            {
                Directory.CreateDirectory(roothPath);
            }

            string dirPath = roothPath + @"\" + "Product";
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }

            var file = selectedFiles[0];
            if (file.Size < 1000000)
            {
                string filePath = dirPath + @"\" + file.Name;
                {
                    Stream stream = file.OpenReadStream(1000000);
                    FileStream fs = File.Create(filePath);
                    await stream.CopyToAsync(fs);
                    stream.Close();
                    fs.Close();
                }
                product.Image = file.Name;
                if (product.ProductId == 0)
                {
                    product.Status = bool.Parse(status);
                    _productSvc.AddProduct(product);
                }
                else
                {
                    product.Status = bool.Parse(status);
                    _productSvc.EditProduct(product.ProductId, product);
                }
                navigation.NavigateTo("productlist", true);
            }
            else
            {
                isOverSized = true;
            }
        }
    }
    private void Cancel()
    {
        //navigation.NavigateTo("productlist", true);
        ModalInstance.CloseAsync(ModalResult.Ok<Product>(product));
    }

    private void OnInputFileChange(InputFileChangeEventArgs e)
    {
        selectedFiles = e.GetMultipleFiles();
        this.StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService modal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment env { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Share.Interfaces.IProductSvc _productSvc { get; set; }
    }
}
namespace __Blazor.Server.Pages.Products.ProductDialog
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
