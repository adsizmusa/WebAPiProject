#pragma checksum "E:\My interview\Aen Software\Projects\AenWebProject\DevExtremeClient\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40d82c9853d11cb1165f3747014c753fdd550730"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DevExtremeClient.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace DevExtremeClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\My interview\Aen Software\Projects\AenWebProject\DevExtremeClient\Pages\_ViewImports.cshtml"
using DevExtremeClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\My interview\Aen Software\Projects\AenWebProject\DevExtremeClient\Pages\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\My interview\Aen Software\Projects\AenWebProject\DevExtremeClient\Pages\Index.cshtml"
using BussinessDTO.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\My interview\Aen Software\Projects\AenWebProject\DevExtremeClient\Pages\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40d82c9853d11cb1165f3747014c753fdd550730", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24a581d47b49d009001f6828e2dacad5e0dc07f8", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "E:\My interview\Aen Software\Projects\AenWebProject\DevExtremeClient\Pages\Index.cshtml"
  
    var order = new OrderDTO();


#line default
#line hidden
#nullable disable
            WriteLiteral("<h2 class=\"content-block\">Home</h2>\r\n\r\n\r\n");
#nullable restore
#line 13 "E:\My interview\Aen Software\Projects\AenWebProject\DevExtremeClient\Pages\Index.cshtml"
Write(Html.DevExtreme().Popup()
         .ID("order-popup")
         .OnShown("loadGrid")
        .ShowTitle(true)

   .FullScreen(true)
    .Title("Add Order")
    .ContentTemplate(new TemplateName("popup-template"))
);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 24 "E:\My interview\Aen Software\Projects\AenWebProject\DevExtremeClient\Pages\Index.cshtml"
 using (Html.DevExtreme().NamedTemplate("popup-template"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p style=\"float:right\">\r\n        ");
#nullable restore
#line 27 "E:\My interview\Aen Software\Projects\AenWebProject\DevExtremeClient\Pages\Index.cshtml"
    Write(Html.DevExtreme().Button()
            .Text("Add Order")
                   .Type(ButtonType.Success)
                        .StylingMode(ButtonStylingMode.Contained)
            .OnClick("add_order")
        );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 34 "E:\My interview\Aen Software\Projects\AenWebProject\DevExtremeClient\Pages\Index.cshtml"
Write(Html.DevExtreme().ScrollView()
        .Width("100%")
        .Height("100%")
        .Content(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("\r\n             ");
#nullable restore
#line 38 "E:\My interview\Aen Software\Projects\AenWebProject\DevExtremeClient\Pages\Index.cshtml"
         Write(Html.DevExtreme().Form<OrderDTO>()
                    .ID("orderForm")
                    .ColCount(4)
                    .FormData(order)
                    .LabelLocation(FormLabelLocation.Top)
                    .ReadOnly(false)
                    .ShowColonAfterLabel(true)
                          .Items(items =>
                          {
                              items.AddSimpleFor(s => s.FinalAmount);
                              items.AddSimpleFor(s => s.Amount);
                              items.AddSimpleFor(s => s.GeneralAmount);
                              items.AddSimpleFor(s => s.OrderStatus);
                              items.AddSimpleFor(s => s.PaymentStatus);
                              items.AddSimpleFor(s => s.ShippingAmount);
                              items.AddSimpleFor(s => s.Status);
                              items.AddSimpleFor(s => s.TaxAmount);


                          })
        );

#line default
#line hidden
#nullable disable
    WriteLiteral("\r\n\r\n");
#nullable restore
#line 60 "E:\My interview\Aen Software\Projects\AenWebProject\DevExtremeClient\Pages\Index.cshtml"
Write(Html.DevExtreme().DataGrid<OrderItemDTO>()
            .ID("orderItemGrid")
    .ElementAttr(new { @class = "dx-card wide-card" })
    .DataSource(order.OrderItems)
    .ShowBorders(false)

    .FocusedRowIndex(0)
    .ColumnAutoWidth(true)
    
    .ColumnHidingEnabled(true)
    .Columns(columns => {
        columns.AddFor(m => m.Price);
        columns.AddFor(m => m.Quantity);
        columns.AddFor(m => m.Discount);
        columns.AddFor(m => m.Tax);
        columns.AddFor(m => m.Status);
    })


);

#line default
#line hidden
#nullable disable
    WriteLiteral("\r\n\r\n\r\n<div style=\"height:50px\">\r\n\r\n</div>\r\n        ");
    PopWriter();
}
))
    );

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "E:\My interview\Aen Software\Projects\AenWebProject\DevExtremeClient\Pages\Index.cshtml"
     


}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 91 "E:\My interview\Aen Software\Projects\AenWebProject\DevExtremeClient\Pages\Index.cshtml"
Write(Html.DevExtreme().Button()
                    .ElementAttr("class", "button-info pull-right")
                    .Text("Add Order")
                    .OnClick(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("\r\n                        function showInfo(data) {\r\n                            var popup = $(\"#order-popup\").dxPopup(\"instance\");\r\n\r\n                            popup.show();\r\n                        }\r\n                    ");
    PopWriter();
}
))
                );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 102 "E:\My interview\Aen Software\Projects\AenWebProject\DevExtremeClient\Pages\Index.cshtml"
Write(Html.DevExtreme().DataGrid<OrderDTO>()
        .ID("mainDataGrid")
    .ElementAttr(new { @class = "dx-card wide-card" })
    .DataSource(d => d.Mvc().Controller("Home").LoadAction("GetOrders").Key("Id"))
    .ShowBorders(false)
    .FilterRow(f => f.Visible(true))
    .FocusedRowEnabled(true)
    .FocusedRowIndex(0)
    .ColumnAutoWidth(true)

    .ColumnHidingEnabled(true)
    .Columns(columns => {
        columns.AddFor(m => m.Amount);
        columns.AddFor(m => m.FinalAmount);
        columns.AddFor(m => m.GeneralAmount);
        columns.AddFor(m => m.OrderStatus);
        columns.AddFor(m => m.TaxAmount);
    })
    .Paging(p => p.PageSize(10))
    .Pager(p => p
        .ShowPageSizeSelector(true)
        .AllowedPageSizes(new[] { 5, 10, 20 })
        .ShowInfo(true)
    )
);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script type=""text/javascript"">
    function add_order(e) {

    

        var order = $(""#orderForm"").dxForm(""instance"").option('formData');
        var orderItem = $(""#orderItemGrid"").dxDataGrid(""instance"").getDataSource().items();
        order.OrderItems = orderItem;

        $.post(""/Home/SaveOrder"", order, function (result) {

            if (result.IsSuccess) {

                var popup = $(""#order-popup"").dxPopup(""instance"");

                popup.hide();

                $(""#mainDataGrid"").dxDataGrid(""getDataSource"").reload();

            }
            else {
                DevExpress.ui.notify(result.Messegges);
            }

        });
     
    }

    function loadGrid() {
        $(""#orderItemGrid"").dxDataGrid({
            // ...
            editing: {
                allowUpdating: true,
                allowAdding: true,
                allowDeleting: true,
                mode: 'row' // 'batch' | 'cell' | 'form' | 'popup'
            },

        }");
            WriteLiteral(@");
    }
    function add_order_item(e) {
        loadGrid();
    }

    $(function () {

        var token = getCookie(""token"");
        if (token == null) {
            window.location.href =""/Login"";
        }
    });

    function getCookie(name) {
        const value = `; ${document.cookie}`;
        const parts = value.split(`; ${name}=`);
        if (parts.length === 2) return parts.pop().split(';').shift();
    }
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Index> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Index> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Index>)PageContext?.ViewData;
        public Pages_Index Model => ViewData.Model;
    }
}
#pragma warning restore 1591
