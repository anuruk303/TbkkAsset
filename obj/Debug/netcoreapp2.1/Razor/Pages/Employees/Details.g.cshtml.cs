#pragma checksum "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Employees\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "042374845b18cce5fb67b984004ba06fb7f74f23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkk_AC.Pages.Employees.Pages_Employees_Details), @"mvc.1.0.razor-page", @"/Pages/Employees/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Employees/Details.cshtml", typeof(tbkk_AC.Pages.Employees.Pages_Employees_Details), null)]
namespace tbkk_AC.Pages.Employees
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"042374845b18cce5fb67b984004ba06fb7f74f23", @"/Pages/Employees/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69d77135ec122947e94bf66dec5647f0745c94b6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Employees_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("220px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Employees\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(97, 320, true);
            WriteLiteral(@"<div class=""container"">
    <div class=""row"">
        <div class=""col-md-9"">
            <h2>Employee Detail</h2>
            <div class="" col-md-12 col-lg-12 "">
                <table class=""table table-user-information"">
                    <tbody>
                        <tr>
                            <td>");
            EndContext();
            BeginContext(418, 54, false);
#line 15 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Employees\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Employee.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(472, 42, true);
            WriteLiteral(" :</td>\r\n                            <td> ");
            EndContext();
            BeginContext(515, 50, false);
#line 16 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Employees\Details.cshtml"
                            Write(Html.DisplayFor(model => model.Employee.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(565, 100, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(666, 53, false);
#line 19 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Employees\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Employee.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(719, 41, true);
            WriteLiteral(" :</td>\r\n                            <td>");
            EndContext();
            BeginContext(761, 49, false);
#line 20 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Employees\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Employee.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(810, 100, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(911, 51, false);
#line 23 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Employees\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Employee.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(962, 41, true);
            WriteLiteral(" :</td>\r\n                            <td>");
            EndContext();
            BeginContext(1004, 47, false);
#line 24 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Employees\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Employee.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(1051, 102, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n\r\n                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1154, 50, false);
#line 28 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Employees\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Employee.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1204, 41, true);
            WriteLiteral(" :</td>\r\n                            <td>");
            EndContext();
            BeginContext(1246, 46, false);
#line 29 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Employees\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Employee.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1292, 100, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1393, 49, false);
#line 32 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Employees\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Employee.Call));

#line default
#line hidden
            EndContext();
            BeginContext(1442, 41, true);
            WriteLiteral(" :</td>\r\n                            <td>");
            EndContext();
            BeginContext(1484, 45, false);
#line 33 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Employees\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Employee.Call));

#line default
#line hidden
            EndContext();
            BeginContext(1529, 100, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1630, 49, false);
#line 36 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Employees\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Employee.Line));

#line default
#line hidden
            EndContext();
            BeginContext(1679, 41, true);
            WriteLiteral(" :</td>\r\n                            <td>");
            EndContext();
            BeginContext(1721, 45, false);
#line 37 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Employees\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Employee.Line));

#line default
#line hidden
            EndContext();
            BeginContext(1766, 100, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1867, 49, false);
#line 40 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Employees\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Employee.Addr));

#line default
#line hidden
            EndContext();
            BeginContext(1916, 41, true);
            WriteLiteral(" :</td>\r\n                            <td>");
            EndContext();
            BeginContext(1958, 45, false);
#line 41 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Employees\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Employee.Addr));

#line default
#line hidden
            EndContext();
            BeginContext(2003, 100, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(2104, 49, false);
#line 44 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Employees\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Employee.Date));

#line default
#line hidden
            EndContext();
            BeginContext(2153, 41, true);
            WriteLiteral(" :</td>\r\n                            <td>");
            EndContext();
            BeginContext(2195, 45, false);
#line 45 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Employees\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Employee.Date));

#line default
#line hidden
            EndContext();
            BeginContext(2240, 100, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(2341, 51, false);
#line 48 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Employees\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Employee.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2392, 41, true);
            WriteLiteral(" :</td>\r\n                            <td>");
            EndContext();
            BeginContext(2434, 47, false);
#line 49 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Employees\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Employee.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2481, 100, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(2582, 52, false);
#line 52 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Employees\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Employee.Company));

#line default
#line hidden
            EndContext();
            BeginContext(2634, 41, true);
            WriteLiteral(" :</td>\r\n                            <td>");
            EndContext();
            BeginContext(2676, 60, false);
#line 53 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Employees\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Employee.Company.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(2736, 100, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(2837, 55, false);
#line 56 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Employees\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Employee.Department));

#line default
#line hidden
            EndContext();
            BeginContext(2892, 41, true);
            WriteLiteral(" :</td>\r\n                            <td>");
            EndContext();
            BeginContext(2934, 66, false);
#line 57 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Employees\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Employee.Department.DepartmentName));

#line default
#line hidden
            EndContext();
            BeginContext(3000, 100, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(3101, 53, false);
#line 60 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Employees\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Employee.Location));

#line default
#line hidden
            EndContext();
            BeginContext(3154, 41, true);
            WriteLiteral(" :</td>\r\n                            <td>");
            EndContext();
            BeginContext(3196, 62, false);
#line 61 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Employees\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Employee.Location.LocationName));

#line default
#line hidden
            EndContext();
            BeginContext(3258, 100, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(3359, 57, false);
#line 64 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Employees\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Employee.EmployeeType));

#line default
#line hidden
            EndContext();
            BeginContext(3416, 41, true);
            WriteLiteral(" :</td>\r\n                            <td>");
            EndContext();
            BeginContext(3458, 70, false);
#line 65 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Employees\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Employee.EmployeeType.EmployeeTypeName));

#line default
#line hidden
            EndContext();
            BeginContext(3528, 100, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(3629, 53, false);
#line 68 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Employees\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Employee.Position));

#line default
#line hidden
            EndContext();
            BeginContext(3682, 41, true);
            WriteLiteral(" :</td>\r\n                            <td>");
            EndContext();
            BeginContext(3724, 62, false);
#line 69 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Employees\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Employee.Position.PositionName));

#line default
#line hidden
            EndContext();
            BeginContext(3786, 290, true);
            WriteLiteral(@"</td>
                        </tr>
                        

                    </tbody>
                </table>
            </div>
        </div>
        <div class=""col-md-3"">
            <h2></h2>
            <div class=""col-md-3 col-lg-3 "" align=""center"">
                ");
            EndContext();
            BeginContext(4076, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "110431026393437d9d214d590d2b12f1", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4086, "~/uploads/", 4086, 10, true);
#line 80 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Employees\Details.cshtml"
AddHtmlAttributeValue("", 4096, Html.DisplayFor(model => model.Employee.Image), 4096, 47, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4176, 75, true);
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(4251, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c63ce4aa7d040f08ee4712b019a04da", async() => {
                BeginContext(4314, 4, true);
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
#line 88 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Employees\Details.cshtml"
                               WriteLiteral(Model.Employee.EmployeeID);

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
            BeginContext(4322, 12, true);
            WriteLiteral(" |\r\n        ");
            EndContext();
            BeginContext(4334, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a4fc39ae2b84c74b9601f6ece2d5c1f", async() => {
                BeginContext(4356, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4372, 2153, true);
            WriteLiteral(@"
    </div>
    <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
        <li class=""nav-item"">
            <a class=""nav-link active"" id=""home-tab"" data-toggle=""tab"" href=""#home"" role=""tab"" aria-controls=""home"" aria-selected=""true"">Join</a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" id=""profile-tab"" data-toggle=""tab"" href=""#profile"" role=""tab"" aria-controls=""profile"" aria-selected=""false"">History Update</a>
        </li>
    </ul>
    <div class=""tab-content"" id=""myTabContent"">
        <div class=""tab-pane fade show active"" id=""home"" role=""tabpanel"" aria-labelledby=""home-tab"">
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""3"">
                        <thead>
                            <tr>
                                <th>
                                    Name
                                </th>
                   ");
            WriteLiteral(@"             <th>
                                    Time
                                </th>

                                <th>
                                    User
                                </th>
                                <th>
                                    date
                                </th>

                                <th>
                                    Edit
                                </th>
                                <th>
                                    Details
                                </th>
                                <th>
                                    Delete
                                </th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                            </tr>

                        </tbody>
                    </table>
                </div>
            </div>
        </div>
        <div class=""tab");
            WriteLiteral("-pane fade\" id=\"profile\" role=\"tabpanel\" aria-labelledby=\"profile-tab\">\r\n\r\n        </div>\r\n\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tbkk_AC.Pages.Employees.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.Employees.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.Employees.DetailsModel>)PageContext?.ViewData;
        public tbkk_AC.Pages.Employees.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
