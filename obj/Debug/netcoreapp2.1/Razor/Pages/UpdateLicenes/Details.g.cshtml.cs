#pragma checksum "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e217fcca1d1dfb6cce9b6259a12090229b2d6d21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkk_AC.Pages.UpdateLicenes.Pages_UpdateLicenes_Details), @"mvc.1.0.razor-page", @"/Pages/UpdateLicenes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/UpdateLicenes/Details.cshtml", typeof(tbkk_AC.Pages.UpdateLicenes.Pages_UpdateLicenes_Details), null)]
namespace tbkk_AC.Pages.UpdateLicenes
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e217fcca1d1dfb6cce9b6259a12090229b2d6d21", @"/Pages/UpdateLicenes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69d77135ec122947e94bf66dec5647f0745c94b6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_UpdateLicenes_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(101, 128, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Update_License</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(230, 55, false);
#line 15 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_License.Date));

#line default
#line hidden
            EndContext();
            BeginContext(285, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(329, 51, false);
#line 18 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Update_License.Date));

#line default
#line hidden
            EndContext();
            BeginContext(380, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(424, 62, false);
#line 21 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_License.LicenseName));

#line default
#line hidden
            EndContext();
            BeginContext(486, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(530, 58, false);
#line 24 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Update_License.LicenseName));

#line default
#line hidden
            EndContext();
            BeginContext(588, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(632, 64, false);
#line 27 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_License.SoftewareName));

#line default
#line hidden
            EndContext();
            BeginContext(696, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(740, 60, false);
#line 30 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Update_License.SoftewareName));

#line default
#line hidden
            EndContext();
            BeginContext(800, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(844, 63, false);
#line 33 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_License.PurchaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(907, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(951, 59, false);
#line 36 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Update_License.PurchaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(1010, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1054, 60, false);
#line 39 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_License.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(1114, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1158, 56, false);
#line 42 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Update_License.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(1214, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1258, 61, false);
#line 45 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_License.ExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1319, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1363, 57, false);
#line 48 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Update_License.ExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1420, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1464, 59, false);
#line 51 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_License.PONumber));

#line default
#line hidden
            EndContext();
            BeginContext(1523, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1567, 55, false);
#line 54 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Update_License.PONumber));

#line default
#line hidden
            EndContext();
            BeginContext(1622, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1666, 62, false);
#line 57 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_License.Attachfiles));

#line default
#line hidden
            EndContext();
            BeginContext(1728, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1772, 58, false);
#line 60 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Update_License.Attachfiles));

#line default
#line hidden
            EndContext();
            BeginContext(1830, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1874, 55, false);
#line 63 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_License.Note));

#line default
#line hidden
            EndContext();
            BeginContext(1929, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1973, 51, false);
#line 66 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Update_License.Note));

#line default
#line hidden
            EndContext();
            BeginContext(2024, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2068, 57, false);
#line 69 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_License.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2125, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2169, 53, false);
#line 72 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Update_License.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2222, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2266, 59, false);
#line 75 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_License.Employee));

#line default
#line hidden
            EndContext();
            BeginContext(2325, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2369, 55, false);
#line 78 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Update_License.Employee));

#line default
#line hidden
            EndContext();
            BeginContext(2424, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2468, 64, false);
#line 81 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_License.Model_ModelID));

#line default
#line hidden
            EndContext();
            BeginContext(2532, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2576, 60, false);
#line 84 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Update_License.Model_ModelID));

#line default
#line hidden
            EndContext();
            BeginContext(2636, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2680, 70, false);
#line 87 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_License.Supplier_SupplierID));

#line default
#line hidden
            EndContext();
            BeginContext(2750, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2794, 66, false);
#line 90 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Update_License.Supplier_SupplierID));

#line default
#line hidden
            EndContext();
            BeginContext(2860, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2904, 74, false);
#line 93 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_License.Department_DepartmentID));

#line default
#line hidden
            EndContext();
            BeginContext(2978, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3022, 70, false);
#line 96 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Update_License.Department_DepartmentID));

#line default
#line hidden
            EndContext();
            BeginContext(3092, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3136, 68, false);
#line 99 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_License.Company_CompanyID));

#line default
#line hidden
            EndContext();
            BeginContext(3204, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3248, 64, false);
#line 102 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Update_License.Company_CompanyID));

#line default
#line hidden
            EndContext();
            BeginContext(3312, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3356, 68, false);
#line 105 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_License.License_LicenseID));

#line default
#line hidden
            EndContext();
            BeginContext(3424, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3468, 64, false);
#line 108 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Update_License.License_LicenseID));

#line default
#line hidden
            EndContext();
            BeginContext(3532, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3579, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef3f4ecf662a4d4a84d2bd81cdee5970", async() => {
                BeginContext(3653, 4, true);
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
#line 113 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UpdateLicenes\Details.cshtml"
                           WriteLiteral(Model.Update_License.UpdateLicenseID);

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
            BeginContext(3661, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3669, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12072f4e9a754983aab1c765aa4832a4", async() => {
                BeginContext(3691, 12, true);
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
            BeginContext(3707, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tbkk_AC.Pages.UpdateLicenes.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.UpdateLicenes.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.UpdateLicenes.DetailsModel>)PageContext?.ViewData;
        public tbkk_AC.Pages.UpdateLicenes.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
