#pragma checksum "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04056873209706974f963dd1e4934474ed13911e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkk_AC.Pages.Licenses.Pages_Licenses_Index), @"mvc.1.0.razor-page", @"/Pages/Licenses/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Licenses/Index.cshtml", typeof(tbkk_AC.Pages.Licenses.Pages_Licenses_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04056873209706974f963dd1e4934474ed13911e", @"/Pages/Licenses/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69d77135ec122947e94bf66dec5647f0745c94b6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Licenses_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(92, 671, true);
            WriteLiteral(@"
<div id=""content-wrapper"">
    <div class=""container-fluid"">
        <!-- Breadcrumbs-->
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item"">
                <a href=""index.html"">Asset Control</a>
            </li>
            <li class=""breadcrumb-item active"">Managment</li>
            <li class=""breadcrumb-item active"">License</li>
        </ol>
        <!-- DataTables Example -->

        <div class=""card mb-3"">
            <div class=""card-header"">
                <div class=""dataTable_length"">
                    <i class=""fas fa-table"">License</i>
                    <div style=""float: right"">
                        ");
            EndContext();
            BeginContext(763, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ef48777fe334e8589143e77d665bf2c", async() => {
                BeginContext(784, 61, true);
                WriteLiteral("<button type=\"button\" class=\"btn btn-primary\">Create</button>");
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
            BeginContext(849, 299, true);
            WriteLiteral(@"

                        <button class=""btn btn-info"" type=""button"" data-toggle=""collapse"" data-target=""#multiCollapseExample2"" aria-expanded=""false"" aria-controls=""multiCollapseExample2"">Import data</button>
                    </div>
                </div>

            </div>
            ");
            EndContext();
            BeginContext(1148, 885, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b42854e2cbb4fcbb3190ece382c7fa8", async() => {
                BeginContext(1198, 828, true);
                WriteLiteral(@"
                <div class=""collapse multi-collapse"" id=""multiCollapseExample2"" style=""margin-top:1%;margin-left:auto"">
                    <div class=""card card-body"" style=""margin-left:70%"">
                        <div class=""input-group"">
                            <div class=""custom-file"">
                                <input type=""file"" class=""custom-file-input"" id=""fUpload"" name=""Excel"">
                                <label class=""custom-file-label"" for=""fUpload""></label>
                            </div>
                            <div class=""input-group-append"">
                                <input class=""btn btn-outline-info"" value=""Upload"" type=""submit"" />
                            </div>
                        </div>
                    </div>
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2033, 330, true);
            WriteLiteral(@"
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""3"">
                        <thead>
                            <tr>
                                <th>
                                    ");
            EndContext();
            BeginContext(2364, 58, false);
#line 53 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.License[0].LicenseName));

#line default
#line hidden
            EndContext();
            BeginContext(2422, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(2538, 60, false);
#line 56 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.License[0].SoftewareName));

#line default
#line hidden
            EndContext();
            BeginContext(2598, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(2714, 57, false);
#line 59 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.License[0].ExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(2771, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(2887, 55, false);
#line 62 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.License[0].PONumber));

#line default
#line hidden
            EndContext();
            BeginContext(2942, 565, true);
            WriteLiteral(@"
                                </th>  
                                <th>
                                    Supplier
                                </th>
                                <th>
                                    Department
                                </th>
                                <th>
                                    Company
                                </th>
                                <th>Actions</th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 77 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Index.cshtml"
                             foreach (var item in Model.License)
                            {
                                if (item.Status.Equals("Using"))
                                {

#line default
#line hidden
            BeginContext(3705, 132, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(3838, 46, false);
#line 83 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.LicenseName));

#line default
#line hidden
            EndContext();
            BeginContext(3884, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(4024, 48, false);
#line 86 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.SoftewareName));

#line default
#line hidden
            EndContext();
            BeginContext(4072, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(4212, 45, false);
#line 89 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.ExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(4257, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(4397, 43, false);
#line 92 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.PONumber));

#line default
#line hidden
            EndContext();
            BeginContext(4440, 137, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        \r\n                                        <td>\r\n");
            EndContext();
#line 96 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Index.cshtml"
                                             foreach (var item1 in Model.Supplier)
                                            {
                                                if (item.Supplier_SupplierID == item1.SupplierID)
                                                {
                                                    

#line default
#line hidden
            BeginContext(4911, 48, false);
#line 100 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item1.SupplierName));

#line default
#line hidden
            EndContext();
#line 100 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Index.cshtml"
                                                                                                     
                                                }
                                            }

#line default
#line hidden
            BeginContext(5059, 95, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n");
            EndContext();
#line 106 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Index.cshtml"
                                             foreach (var item1 in Model.Department)
                                            {
                                                if (item.Department_DepartmentID == item1.DepartmentID)
                                                {
                                                    

#line default
#line hidden
            BeginContext(5496, 50, false);
#line 110 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item1.DepartmentName));

#line default
#line hidden
            EndContext();
#line 110 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Index.cshtml"
                                                                                                       
                                                }
                                            }

#line default
#line hidden
            BeginContext(5646, 93, true);
            WriteLiteral("                                        </td>\r\n                                        <td>\r\n");
            EndContext();
#line 115 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Index.cshtml"
                                             foreach (var item1 in Model.Company)
                                            {
                                                if (item.Company_CompanyID == item1.CompanyID)
                                                {
                                                    

#line default
#line hidden
            BeginContext(6069, 47, false);
#line 119 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item1.CompanyName));

#line default
#line hidden
            EndContext();
#line 119 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Index.cshtml"
                                                                                                    
                                                }
                                            }

#line default
#line hidden
            BeginContext(6216, 153, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td width=\"100px\">\r\n                                            ");
            EndContext();
            BeginContext(6369, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c838799b0559415887678829a9595108", async() => {
                BeginContext(6424, 7, true);
                WriteLiteral("Details");
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
#line 125 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Index.cshtml"
                                                                      WriteLiteral(item.LicenseID);

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
            BeginContext(6435, 48, true);
            WriteLiteral(" |\r\n                                            ");
            EndContext();
            BeginContext(6483, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31ed636d898c4c98b3190d0b920e075b", async() => {
                BeginContext(6535, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 126 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Index.cshtml"
                                                                   WriteLiteral(item.LicenseID);

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
            BeginContext(6543, 48, true);
            WriteLiteral(" |\r\n                                            ");
            EndContext();
            BeginContext(6591, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5e7fed93fc3469c8e0235036aa3cf14", async() => {
                BeginContext(6645, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 127 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Index.cshtml"
                                                                     WriteLiteral(item.LicenseID);

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
            BeginContext(6655, 92, true);
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 130 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Licenses\Index.cshtml"
                                }
                            }

#line default
#line hidden
            BeginContext(6813, 136, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tbkk_AC.Pages.Licenses.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.Licenses.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.Licenses.IndexModel>)PageContext?.ViewData;
        public tbkk_AC.Pages.Licenses.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
