#pragma checksum "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9eae71083dd13923a076758281ce0230511379b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkk_AC.Pages.Assets.Pages_Assets_Details), @"mvc.1.0.razor-page", @"/Pages/Assets/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Assets/Details.cshtml", typeof(tbkk_AC.Pages.Assets.Pages_Assets_Details), null)]
namespace tbkk_AC.Pages.Assets
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\_ViewImports.cshtml"
using tbkk_AC;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9eae71083dd13923a076758281ce0230511379b", @"/Pages/Assets/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69d77135ec122947e94bf66dec5647f0745c94b6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Assets_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(94, 119, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Asset</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(214, 51, false);
#line 15 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.AssetName));

#line default
#line hidden
            EndContext();
            BeginContext(265, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(309, 47, false);
#line 18 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Asset.AssetName));

#line default
#line hidden
            EndContext();
            BeginContext(356, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(400, 54, false);
#line 21 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.SerailNumber));

#line default
#line hidden
            EndContext();
            BeginContext(454, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(498, 50, false);
#line 24 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Asset.SerailNumber));

#line default
#line hidden
            EndContext();
            BeginContext(548, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(592, 49, false);
#line 27 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.MACAddr));

#line default
#line hidden
            EndContext();
            BeginContext(641, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(685, 45, false);
#line 30 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Asset.MACAddr));

#line default
#line hidden
            EndContext();
            BeginContext(730, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(774, 53, false);
#line 33 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.InstallDate));

#line default
#line hidden
            EndContext();
            BeginContext(827, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(871, 49, false);
#line 36 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Asset.InstallDate));

#line default
#line hidden
            EndContext();
            BeginContext(920, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(964, 54, false);
#line 39 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.PurchaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(1018, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1062, 50, false);
#line 42 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Asset.PurchaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(1112, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1156, 52, false);
#line 45 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.ExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1208, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1252, 48, false);
#line 48 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Asset.ExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1300, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1344, 50, false);
#line 51 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.PONumber));

#line default
#line hidden
            EndContext();
            BeginContext(1394, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1438, 46, false);
#line 54 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Asset.PONumber));

#line default
#line hidden
            EndContext();
            BeginContext(1484, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1528, 47, false);
#line 57 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1575, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1619, 43, false);
#line 60 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Asset.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1662, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1706, 50, false);
#line 63 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.Warranty));

#line default
#line hidden
            EndContext();
            BeginContext(1756, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1800, 46, false);
#line 66 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Asset.Warranty));

#line default
#line hidden
            EndContext();
            BeginContext(1846, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1890, 46, false);
#line 69 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.Type));

#line default
#line hidden
            EndContext();
            BeginContext(1936, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1980, 42, false);
#line 72 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Asset.Type));

#line default
#line hidden
            EndContext();
            BeginContext(2022, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2066, 46, false);
#line 75 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.Note));

#line default
#line hidden
            EndContext();
            BeginContext(2112, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2156, 42, false);
#line 78 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Asset.Note));

#line default
#line hidden
            EndContext();
            BeginContext(2198, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2242, 48, false);
#line 81 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2290, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2334, 44, false);
#line 84 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Asset.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2378, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2422, 47, false);
#line 87 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.Image));

#line default
#line hidden
            EndContext();
            BeginContext(2469, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2513, 43, false);
#line 90 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Asset.Image));

#line default
#line hidden
            EndContext();
            BeginContext(2556, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2600, 59, false);
#line 93 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.Company_CompanyID));

#line default
#line hidden
            EndContext();
            BeginContext(2659, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2703, 55, false);
#line 96 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Asset.Company_CompanyID));

#line default
#line hidden
            EndContext();
            BeginContext(2758, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2802, 61, false);
#line 99 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.Location_LocationID));

#line default
#line hidden
            EndContext();
            BeginContext(2863, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2907, 57, false);
#line 102 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Asset.Location_LocationID));

#line default
#line hidden
            EndContext();
            BeginContext(2964, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3008, 65, false);
#line 105 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.Department_DepartmentID));

#line default
#line hidden
            EndContext();
            BeginContext(3073, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3117, 61, false);
#line 108 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Asset.Department_DepartmentID));

#line default
#line hidden
            EndContext();
            BeginContext(3178, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3222, 61, false);
#line 111 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.Supplier_SupplierID));

#line default
#line hidden
            EndContext();
            BeginContext(3283, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3327, 57, false);
#line 114 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Asset.Supplier_SupplierID));

#line default
#line hidden
            EndContext();
            BeginContext(3384, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3428, 55, false);
#line 117 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.Model_ModelID));

#line default
#line hidden
            EndContext();
            BeginContext(3483, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3527, 51, false);
#line 120 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Asset.Model_ModelID));

#line default
#line hidden
            EndContext();
            BeginContext(3578, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3625, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80fe1d680f2041ed93e1cb9b9edebd28", async() => {
                BeginContext(3682, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 125 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Details.cshtml"
                           WriteLiteral(Model.Asset.AssetID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3690, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3698, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e9409fa3f784cb599becba0d5f96e18", async() => {
                BeginContext(3720, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3736, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tbkk_AC.Pages.Assets.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.Assets.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.Assets.DetailsModel>)PageContext?.ViewData;
        public tbkk_AC.Pages.Assets.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
