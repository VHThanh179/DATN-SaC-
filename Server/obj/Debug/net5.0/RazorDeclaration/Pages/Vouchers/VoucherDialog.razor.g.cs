// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Server.Pages.Vouchers
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
#line 2 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherDialog.razor"
using Share.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/voucherdialog/{id}")]
    public partial class VoucherDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "D:\DATN\Project\SaCBackpack\Server\Pages\Vouchers\VoucherDialog.razor"
       
    [Parameter]
    public string id { get; set; }
    private Share.Models.Voucher voucher { get; set; }
    private string Tilte = "";
    protected override void OnInitialized()
    {
        if (string.IsNullOrWhiteSpace(id) || id == "0")
        {
            Tilte = "Thêm mã giảm giá";
            voucher = new Share.Models.Voucher();
        }
        else
        {
            Tilte = "Sửa mã giảm giá";
            voucher = _voucherService.GetVoucher(int.Parse(id));
        }
    }
    private void SubmitForm()
    {
        if (voucher.VoucherId == 0)
        {
            _voucherService.AddVoucher(voucher);
        }
        else
        {
            _voucherService.EditVoucher(voucher.VoucherId, voucher);
        }
        navigation.NavigateTo("VoucherList");
    }
    private void Cancel()
    {
        navigation.NavigateTo("VoucherList", true);

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Share.Interfaces.IVoucherSvc _voucherService { get; set; }
    }
}
#pragma warning restore 1591
