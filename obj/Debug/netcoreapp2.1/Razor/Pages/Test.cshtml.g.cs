#pragma checksum "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa6284aaf3ca6a3cd2a2fc8fc355a3fb5bb4cc58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkk_AC.Pages.Pages_Test), @"mvc.1.0.razor-page", @"/Pages/Test.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Test.cshtml", typeof(tbkk_AC.Pages.Pages_Test), null)]
namespace tbkk_AC.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa6284aaf3ca6a3cd2a2fc8fc355a3fb5bb4cc58", @"/Pages/Test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69d77135ec122947e94bf66dec5647f0745c94b6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Test : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Licenses/Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Licenses/Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Assets/Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Assets/Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Test.cshtml"
  
    ViewData["Title"] = "Test";

#line default
#line hidden
            BeginContext(79, 1655, true);
            WriteLiteral(@"
<div id=""content-wrapper"">
    <div class=""container-fluid"">
        <!-- Breadcrumbs-->
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item"">
                <a href=""index.html"">Asset Control</a>
            </li>
            <li class=""breadcrumb-item active"">Managment</li>
            <li class=""breadcrumb-item active"">Expired</li>
        </ol>
        <!-- DataTables Example -->

        <div class=""card mb-3"">
            <div class=""card-header"">
                <div class=""dataTable_length"">
                    <i class=""fas fa-table"">Expired</i>
                </div>
            </div>
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""3"">
                        <thead>
                            <tr>
                                <th>
                                    ID
                                </th>
          ");
            WriteLiteral(@"                      <th>
                                    Name
                                </th>
                                <th>
                                    StartDate
                                </th>
                                <th>
                                    ExpireDate
                                </th>
                                <th>
                                    Status
                                </th>
                                <th>Actions</th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 49 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Test.cshtml"
                             foreach (var item in Model.License)
                            {
                                if (item.Status.Equals("Using"))
                                {
                                    if (item.ExpireDate < DateTime.Now.AddMonths(+1) || item.ExpireDate < DateTime.Now)
                                    {

#line default
#line hidden
            BeginContext(2092, 144, true);
            WriteLiteral("                                        <tr>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(2237, 44, false);
#line 57 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Test.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.LicenseID));

#line default
#line hidden
            EndContext();
            BeginContext(2281, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(2433, 46, false);
#line 60 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Test.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.LicenseName));

#line default
#line hidden
            EndContext();
            BeginContext(2479, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(2631, 44, false);
#line 63 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Test.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(2675, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(2827, 45, false);
#line 66 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Test.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.ExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(2872, 105, true);
            WriteLiteral("\r\n                                            </td>\r\n\r\n                                            <td>\r\n");
            EndContext();
#line 70 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Test.cshtml"
                                                 if (item.ExpireDate < DateTime.Now.AddMonths(+1)&&item.ExpireDate > DateTime.Now)
                                                {

#line default
#line hidden
            BeginContext(3160, 224, true);
            WriteLiteral("                                                    <h4>\r\n                                                        <span class=\"badge badge-warning\">Expiring</span>\r\n                                                    </h4>\r\n");
            EndContext();
#line 75 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Test.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
            BeginContext(3540, 222, true);
            WriteLiteral("                                                    <h4>\r\n                                                        <span class=\"badge badge-danger\">Expired</span>\r\n                                                    </h4>\r\n");
            EndContext();
#line 81 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Test.cshtml"
                                                }

#line default
#line hidden
            BeginContext(3813, 163, true);
            WriteLiteral("                                            </td>\r\n                                            <td width=\"100px\">\r\n                                                ");
            EndContext();
            BeginContext(3976, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c8f5093473440debc45a6ce197ed4f5", async() => {
                BeginContext(4037, 4, true);
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
#line 84 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Test.cshtml"
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
            BeginContext(4045, 52, true);
            WriteLiteral(" |\r\n                                                ");
            EndContext();
            BeginContext(4097, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2eed23b8ead24ab98f4859f535f1d7b3", async() => {
                BeginContext(4160, 6, true);
                WriteLiteral("Delete");
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
#line 85 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Test.cshtml"
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
            BeginContext(4170, 100, true);
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
            EndContext();
#line 88 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Test.cshtml"
                                    }
                                }
                            }

#line default
#line hidden
            BeginContext(4375, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 91 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Test.cshtml"
                             foreach (var item in Model.Asset)
                            {
                                if (item.Status.Equals("Using"))
                                {
                                    if (item.ExpireDate < DateTime.Now.AddMonths(+1) || item.ExpireDate < DateTime.Now)
                                    {

#line default
#line hidden
            BeginContext(4731, 144, true);
            WriteLiteral("                                        <tr>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(4876, 42, false);
#line 99 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Test.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.AssetID));

#line default
#line hidden
            EndContext();
            BeginContext(4918, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(5070, 44, false);
#line 102 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Test.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.AssetName));

#line default
#line hidden
            EndContext();
            BeginContext(5114, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(5266, 46, false);
#line 105 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Test.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.InstallDate));

#line default
#line hidden
            EndContext();
            BeginContext(5312, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(5464, 45, false);
#line 108 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Test.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.ExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(5509, 103, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n");
            EndContext();
#line 111 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Test.cshtml"
                                                 if (item.ExpireDate < DateTime.Now.AddMonths(+1)&&item.ExpireDate > DateTime.Now)
                                                {

#line default
#line hidden
            BeginContext(5795, 224, true);
            WriteLiteral("                                                    <h4>\r\n                                                        <span class=\"badge badge-warning\">Expiring</span>\r\n                                                    </h4>\r\n");
            EndContext();
#line 116 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Test.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
            BeginContext(6175, 222, true);
            WriteLiteral("                                                    <h4>\r\n                                                        <span class=\"badge badge-danger\">Expired</span>\r\n                                                    </h4>\r\n");
            EndContext();
#line 122 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Test.cshtml"
                                                }

#line default
#line hidden
            BeginContext(6448, 163, true);
            WriteLiteral("                                            </td>\r\n                                            <td width=\"100px\">\r\n                                                ");
            EndContext();
            BeginContext(6611, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eba483baef0246938c16afa7fed743ae", async() => {
                BeginContext(6668, 4, true);
                WriteLiteral("Edit");
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
#line 125 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Test.cshtml"
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
            BeginContext(6676, 52, true);
            WriteLiteral(" |\r\n                                                ");
            EndContext();
            BeginContext(6728, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "934c209097f94898b97c74ac0bef21c2", async() => {
                BeginContext(6787, 6, true);
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
#line 126 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Test.cshtml"
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
            BeginContext(6797, 100, true);
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
            EndContext();
#line 129 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Test.cshtml"
                                    }
                                }
                            }

#line default
#line hidden
            BeginContext(7002, 136, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tbkk_AC.Pages.TestModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.TestModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.TestModel>)PageContext?.ViewData;
        public tbkk_AC.Pages.TestModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
