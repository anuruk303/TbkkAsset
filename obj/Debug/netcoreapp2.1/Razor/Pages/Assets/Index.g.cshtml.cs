#pragma checksum "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84cd07bb72fafd9b78c39bb4dcce05e84a4a2e3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkk_AC.Pages.Assets.Pages_Assets_Index), @"mvc.1.0.razor-page", @"/Pages/Assets/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Assets/Index.cshtml", typeof(tbkk_AC.Pages.Assets.Pages_Assets_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84cd07bb72fafd9b78c39bb4dcce05e84a4a2e3a", @"/Pages/Assets/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69d77135ec122947e94bf66dec5647f0745c94b6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Assets_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(45, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(84, 25, true);
            WriteLiteral("\n<h2>Index</h2>\n\n<p>\n    ");
            EndContext();
            BeginContext(109, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e53dbb0631cb48debb80868d795490f9", async() => {
                BeginContext(130, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(144, 86, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(231, 54, false);
#line 17 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].AssetName));

#line default
#line hidden
            EndContext();
            BeginContext(285, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(338, 57, false);
#line 20 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].SerailNumber));

#line default
#line hidden
            EndContext();
            BeginContext(395, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(448, 52, false);
#line 23 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].MACAddr));

#line default
#line hidden
            EndContext();
            BeginContext(500, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(553, 56, false);
#line 26 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].InstallDate));

#line default
#line hidden
            EndContext();
            BeginContext(609, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(662, 57, false);
#line 29 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].PurchaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(719, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(772, 55, false);
#line 32 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].ExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(827, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(880, 53, false);
#line 35 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].PONumber));

#line default
#line hidden
            EndContext();
            BeginContext(933, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(986, 50, false);
#line 38 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].Price));

#line default
#line hidden
            EndContext();
            BeginContext(1036, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1089, 53, false);
#line 41 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].Warranty));

#line default
#line hidden
            EndContext();
            BeginContext(1142, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1195, 49, false);
#line 44 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].Type));

#line default
#line hidden
            EndContext();
            BeginContext(1244, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1297, 49, false);
#line 47 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].Note));

#line default
#line hidden
            EndContext();
            BeginContext(1346, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1399, 51, false);
#line 50 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].Status));

#line default
#line hidden
            EndContext();
            BeginContext(1450, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1503, 50, false);
#line 53 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].Image));

#line default
#line hidden
            EndContext();
            BeginContext(1553, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1606, 62, false);
#line 56 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].Company_CompanyID));

#line default
#line hidden
            EndContext();
            BeginContext(1668, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1721, 64, false);
#line 59 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].Location_LocationID));

#line default
#line hidden
            EndContext();
            BeginContext(1785, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1838, 68, false);
#line 62 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].Department_DepartmentID));

#line default
#line hidden
            EndContext();
            BeginContext(1906, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1959, 53, false);
#line 65 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].Supplier));

#line default
#line hidden
            EndContext();
            BeginContext(2012, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(2065, 64, false);
#line 68 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].Employee_EmployeeID));

#line default
#line hidden
            EndContext();
            BeginContext(2129, 80, true);
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 74 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
 foreach (var item in Model.Asset) {

#line default
#line hidden
            BeginContext(2246, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(2293, 44, false);
#line 77 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AssetName));

#line default
#line hidden
            EndContext();
            BeginContext(2337, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2390, 47, false);
#line 80 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SerailNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2437, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2490, 42, false);
#line 83 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MACAddr));

#line default
#line hidden
            EndContext();
            BeginContext(2532, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2585, 46, false);
#line 86 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.InstallDate));

#line default
#line hidden
            EndContext();
            BeginContext(2631, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2684, 47, false);
#line 89 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PurchaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(2731, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2784, 45, false);
#line 92 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(2829, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2882, 43, false);
#line 95 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PONumber));

#line default
#line hidden
            EndContext();
            BeginContext(2925, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2978, 40, false);
#line 98 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(3018, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(3071, 43, false);
#line 101 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Warranty));

#line default
#line hidden
            EndContext();
            BeginContext(3114, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(3167, 39, false);
#line 104 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
            EndContext();
            BeginContext(3206, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(3259, 39, false);
#line 107 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Note));

#line default
#line hidden
            EndContext();
            BeginContext(3298, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(3351, 41, false);
#line 110 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(3392, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(3445, 40, false);
#line 113 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Image));

#line default
#line hidden
            EndContext();
            BeginContext(3485, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(3538, 52, false);
#line 116 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Company_CompanyID));

#line default
#line hidden
            EndContext();
            BeginContext(3590, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(3643, 54, false);
#line 119 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Location_LocationID));

#line default
#line hidden
            EndContext();
            BeginContext(3697, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(3750, 58, false);
#line 122 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Department_DepartmentID));

#line default
#line hidden
            EndContext();
            BeginContext(3808, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(3861, 51, false);
#line 125 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Supplier.Address));

#line default
#line hidden
            EndContext();
            BeginContext(3912, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(3965, 54, false);
#line 128 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Employee_EmployeeID));

#line default
#line hidden
            EndContext();
            BeginContext(4019, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(4071, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c62f96f8ac5749ec91b78c5f35230748", async() => {
                BeginContext(4121, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 131 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
                                       WriteLiteral(item.AssetID);

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
            BeginContext(4129, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(4148, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf2e7b5f6af74eaca98016ae04d8cea2", async() => {
                BeginContext(4201, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 132 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
                                          WriteLiteral(item.AssetID);

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
            BeginContext(4212, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(4231, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d241d3692c444c5ab30ec0110bb44c4", async() => {
                BeginContext(4283, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 133 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
                                         WriteLiteral(item.AssetID);

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
            BeginContext(4293, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 136 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Assets\Index.cshtml"
}

#line default
#line hidden
            BeginContext(4328, 22, true);
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tbkk_AC.Pages.Assets.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.Assets.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.Assets.IndexModel>)PageContext?.ViewData;
        public tbkk_AC.Pages.Assets.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
