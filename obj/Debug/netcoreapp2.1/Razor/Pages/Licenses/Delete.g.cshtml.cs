#pragma checksum "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f70ffacdc6b5e76078eb6da892002dd8b30dd392"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkk_AC.Pages.Licenses.Pages_Licenses_Delete), @"mvc.1.0.razor-page", @"/Pages/Licenses/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Licenses/Delete.cshtml", typeof(tbkk_AC.Pages.Licenses.Pages_Licenses_Delete), null)]
namespace tbkk_AC.Pages.Licenses
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f70ffacdc6b5e76078eb6da892002dd8b30dd392", @"/Pages/Licenses/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69d77135ec122947e94bf66dec5647f0745c94b6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Licenses_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(88, 159, true);
            WriteLiteral("\n<h2>Delete</h2>\n\n<h3>Are you sure you want to delete this?</h3>\n<div>\n    <h4>License</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(248, 55, false);
#line 16 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.License.LicenseName));

#line default
#line hidden
            EndContext();
            BeginContext(303, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(344, 51, false);
#line 19 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.License.LicenseName));

#line default
#line hidden
            EndContext();
            BeginContext(395, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(436, 57, false);
#line 22 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.License.SoftewareName));

#line default
#line hidden
            EndContext();
            BeginContext(493, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(534, 53, false);
#line 25 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.License.SoftewareName));

#line default
#line hidden
            EndContext();
            BeginContext(587, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(628, 56, false);
#line 28 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.License.PurchaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(684, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(725, 52, false);
#line 31 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.License.PurchaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(777, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(818, 53, false);
#line 34 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.License.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(871, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(912, 49, false);
#line 37 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.License.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(961, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1002, 54, false);
#line 40 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.License.ExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1056, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1097, 50, false);
#line 43 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.License.ExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1147, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1188, 52, false);
#line 46 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.License.PONumber));

#line default
#line hidden
            EndContext();
            BeginContext(1240, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1281, 48, false);
#line 49 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.License.PONumber));

#line default
#line hidden
            EndContext();
            BeginContext(1329, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1370, 55, false);
#line 52 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.License.Attachfiles));

#line default
#line hidden
            EndContext();
            BeginContext(1425, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1466, 51, false);
#line 55 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.License.Attachfiles));

#line default
#line hidden
            EndContext();
            BeginContext(1517, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1558, 48, false);
#line 58 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.License.Note));

#line default
#line hidden
            EndContext();
            BeginContext(1606, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1647, 44, false);
#line 61 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.License.Note));

#line default
#line hidden
            EndContext();
            BeginContext(1691, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1732, 50, false);
#line 64 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.License.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1782, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1823, 46, false);
#line 67 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.License.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1869, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1910, 57, false);
#line 70 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.License.Model_ModelID));

#line default
#line hidden
            EndContext();
            BeginContext(1967, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2008, 53, false);
#line 73 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.License.Model_ModelID));

#line default
#line hidden
            EndContext();
            BeginContext(2061, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(2102, 63, false);
#line 76 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.License.Supplier_SupplierID));

#line default
#line hidden
            EndContext();
            BeginContext(2165, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2206, 59, false);
#line 79 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.License.Supplier_SupplierID));

#line default
#line hidden
            EndContext();
            BeginContext(2265, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(2306, 67, false);
#line 82 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.License.Department_DepartmentID));

#line default
#line hidden
            EndContext();
            BeginContext(2373, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2414, 63, false);
#line 85 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.License.Department_DepartmentID));

#line default
#line hidden
            EndContext();
            BeginContext(2477, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(2518, 61, false);
#line 88 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.License.Company_CompanyID));

#line default
#line hidden
            EndContext();
            BeginContext(2579, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2620, 57, false);
#line 91 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Delete.cshtml"
       Write(Html.DisplayFor(model => model.License.Company_CompanyID));

#line default
#line hidden
            EndContext();
            BeginContext(2677, 34, true);
            WriteLiteral("\n        </dd>\n    </dl>\n    \n    ");
            EndContext();
            BeginContext(2711, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6441f53de7b64d718a33e10c2498c908", async() => {
                BeginContext(2731, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(2740, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "81aa05cb5902446286c567cc5dc806b1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 96 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.License.LicenseID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2791, 82, true);
                WriteLiteral("\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\n        ");
                EndContext();
                BeginContext(2873, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee6b432c38144a10a5c640877d4e77c5", async() => {
                    BeginContext(2895, 12, true);
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
                BeginContext(2911, 5, true);
                WriteLiteral("\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2923, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tbkk_AC.Pages.Licenses.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.Licenses.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.Licenses.DeleteModel>)PageContext?.ViewData;
        public tbkk_AC.Pages.Licenses.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
