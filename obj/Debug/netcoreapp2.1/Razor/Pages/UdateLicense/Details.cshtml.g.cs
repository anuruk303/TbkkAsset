#pragma checksum "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef9231f672d0975dc303cb8df7e7d5ccc5b9c4d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkk_AC.Pages.UdateLicense.Pages_UdateLicense_Details), @"mvc.1.0.razor-page", @"/Pages/UdateLicense/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/UdateLicense/Details.cshtml", typeof(tbkk_AC.Pages.UdateLicense.Pages_UdateLicense_Details), null)]
namespace tbkk_AC.Pages.UdateLicense
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef9231f672d0975dc303cb8df7e7d5ccc5b9c4d3", @"/Pages/UdateLicense/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69d77135ec122947e94bf66dec5647f0745c94b6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_UdateLicense_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Licenses/Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(147, 892, true);
            WriteLiteral(@"
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-9"">
                <h2>License Detail</h2>
                <div class="" col-md-12 col-lg-12 "">
                    <div class=""card "" style=""margin-top:1%"">
                        <div class=""card-header"" style=""font-weight:bold;color:darkblue;"">
                            Detail
                        </div>
                        <div class=""card-body"">
                            <table class=""table table-user-information"" style=""margin-top:-24%"">
                                <tbody>
                                    <tr>
                                        <div class=""card-body"">
                                            <div class=""row"">
                                                <div class=""col"">
                                                    <td>");
            EndContext();
            BeginContext(1040, 62, false);
#line 25 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Update_License.LicenseName));

#line default
#line hidden
            EndContext();
            BeginContext(1102, 66, true);
            WriteLiteral(" :</td>\r\n                                                    <td> ");
            EndContext();
            BeginContext(1169, 58, false);
#line 26 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                    Write(Html.DisplayFor(model => model.Update_License.LicenseName));

#line default
#line hidden
            EndContext();
            BeginContext(1227, 186, true);
            WriteLiteral("</td>\r\n                                                </div>\r\n                                                <div class=\"col\">\r\n                                                    <td>");
            EndContext();
            BeginContext(1414, 64, false);
#line 29 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Update_License.SoftewareName));

#line default
#line hidden
            EndContext();
            BeginContext(1478, 65, true);
            WriteLiteral(" :</td>\r\n                                                    <td>");
            EndContext();
            BeginContext(1544, 60, false);
#line 30 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.Update_License.SoftewareName));

#line default
#line hidden
            EndContext();
            BeginContext(1604, 499, true);
            WriteLiteral(@"</td>
                                                </div>
                                            </div>
                                        </div>
                                    </tr>
                                    <tr>
                                        <div class=""card-body"">
                                            <div class=""row"">
                                                <div class=""col"">
                                                    <td>");
            EndContext();
            BeginContext(2104, 62, false);
#line 39 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Update_License.Attachfiles));

#line default
#line hidden
            EndContext();
            BeginContext(2166, 66, true);
            WriteLiteral(" :</td>\r\n                                                    <td> ");
            EndContext();
            BeginContext(2233, 58, false);
#line 40 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                    Write(Html.DisplayFor(model => model.Update_License.Attachfiles));

#line default
#line hidden
            EndContext();
            BeginContext(2291, 186, true);
            WriteLiteral("</td>\r\n                                                </div>\r\n                                                <div class=\"col\">\r\n                                                    <td>");
            EndContext();
            BeginContext(2478, 59, false);
#line 43 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Update_License.PONumber));

#line default
#line hidden
            EndContext();
            BeginContext(2537, 65, true);
            WriteLiteral(" :</td>\r\n                                                    <td>");
            EndContext();
            BeginContext(2603, 55, false);
#line 44 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.Update_License.PONumber));

#line default
#line hidden
            EndContext();
            BeginContext(2658, 501, true);
            WriteLiteral(@"</td>

                                                </div>
                                            </div>
                                        </div>
                                    </tr>
                                    <tr>
                                        <div class=""card-body"">
                                            <div class=""row"">
                                                <div class=""col"">
                                                    <td>");
            EndContext();
            BeginContext(3160, 68, false);
#line 54 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Update_License.License_LicenseID));

#line default
#line hidden
            EndContext();
            BeginContext(3228, 65, true);
            WriteLiteral(" :</td>\r\n                                                    <td>");
            EndContext();
            BeginContext(3294, 64, false);
#line 55 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.Update_License.License_LicenseID));

#line default
#line hidden
            EndContext();
            BeginContext(3358, 2206, true);
            WriteLiteral(@"</td>
                                                </div>
                                                <div class=""col"">
                                                    <td></td>
                                                    <td></td>
                                                </div>
                                            </div>
                                        </div>
                                    </tr>
                                    <tr>
                                        <div class=""card-body"">
                                            <div class=""row"">
                                                <div class=""col"">
                                                    <td></td>
                                                    <td></td>

                                                </div>
                                                <div class=""col"">
                                                    <td></td>
                  ");
            WriteLiteral(@"                                  <td></td>
                                                </div>
                                            </div>
                                        </div>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>

                    <div class=""card "" style=""margin-top:-4%"">
                        <div class=""card-header"" style=""font-weight:bold;color:darkblue;"">
                            Model
                        </div>
                        <div class=""card-body"">
                            <table class=""table table-user-information"" style=""margin-top:-16%;margin-bottom:2%"">
                                <tbody>
                                    <tr>
                                        <div class=""card-body"">
                                            <div class=""row"">
                                        ");
            WriteLiteral("        <div class=\"col\">\r\n                                                    <td>Supplier :</td>\r\n                                                    <td>\r\n");
            EndContext();
#line 97 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                         foreach (var item in Model.Supplier)
                                                        {
                                                            if (Model.Update_License.Supplier_SupplierID == item.SupplierID)
                                                            {
                                                                

#line default
#line hidden
            BeginContext(5972, 47, false);
#line 101 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                           Write(Html.DisplayFor(modelItem => item.SupplierName));

#line default
#line hidden
            EndContext();
#line 101 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                                                                                
                                                            }
                                                        }

#line default
#line hidden
            BeginContext(6143, 312, true);
            WriteLiteral(@"                                                    </td>
                                                </div>
                                                <div class=""col"">
                                                    <td>Company :</td>
                                                    <td>
");
            EndContext();
#line 109 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                         foreach (var item in Model.Company)
                                                        {
                                                            if (Model.Update_License.Company_CompanyID == item.CompanyID)
                                                            {
                                                                

#line default
#line hidden
            BeginContext(6859, 46, false);
#line 113 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                           Write(Html.DisplayFor(modelItem => item.CompanyName));

#line default
#line hidden
            EndContext();
#line 113 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                                                                               
                                                            }
                                                        }

#line default
#line hidden
            BeginContext(7029, 628, true);
            WriteLiteral(@"                                                    </td>
                                                </div>
                                            </div>
                                        </div>
                                    </tr>
                                    <tr>
                                        <div class=""card-body"">
                                            <div class=""row"">
                                                <div class=""col"">
                                                    <td>Department :</td>
                                                    <td>
");
            EndContext();
#line 127 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                         foreach (var item in Model.Department)
                                                        {
                                                            if (Model.Update_License.Department_DepartmentID == item.DepartmentID)
                                                            {
                                                                

#line default
#line hidden
            BeginContext(8073, 49, false);
#line 131 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                           Write(Html.DisplayFor(modelItem => item.DepartmentName));

#line default
#line hidden
            EndContext();
#line 131 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                                                                                  
                                                            }
                                                        }

#line default
#line hidden
            BeginContext(8246, 2183, true);
            WriteLiteral(@"                                                    </td>
                                                </div>
                                                <div class=""col"">
                                                    <td></td>
                                                    <td></td>
                                                </div>
                                            </div>
                                        </div>
                                    </tr>
                                    <tr>
                                        <div class=""card-body"">
                                            <div class=""row"">
                                                <div class=""col"">
                                                    <td></td>
                                                    <td></td>

                                                </div>
                                                <div class=""col"">
                             ");
            WriteLiteral(@"                       <td></td>
                                                    <td></td>
                                                </div>
                                            </div>
                                        </div>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>

                    <div class=""card "" style=""margin-top:-4%"">
                        <div class=""card-header"" style=""font-weight:bold;color:darkblue;"">
                            Date
                        </div>
                        <div class=""card-body"">
                            <table class=""table table-user-information"" style=""margin-top:-16%;margin-bottom:-3%"">
                                <tbody>
                                    <tr>
                                        <div class=""card-body"">
                                            <div cl");
            WriteLiteral("ass=\"row\">\r\n                                                <div class=\"col\">\r\n                                                    <td>");
            EndContext();
            BeginContext(10430, 60, false);
#line 174 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Update_License.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(10490, 65, true);
            WriteLiteral(" :</td>\r\n                                                    <td>");
            EndContext();
            BeginContext(10556, 56, false);
#line 175 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.Update_License.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(10612, 188, true);
            WriteLiteral("</td>\r\n\r\n                                                </div>\r\n                                                <div class=\"col\">\r\n                                                    <td>");
            EndContext();
            BeginContext(10801, 63, false);
#line 179 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Update_License.PurchaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(10864, 65, true);
            WriteLiteral(" :</td>\r\n                                                    <td>");
            EndContext();
            BeginContext(10930, 59, false);
#line 180 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.Update_License.PurchaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(10989, 501, true);
            WriteLiteral(@"</td>

                                                </div>
                                            </div>
                                        </div>
                                    </tr>
                                    <tr>
                                        <div class=""card-body"">
                                            <div class=""row"">
                                                <div class=""col"">
                                                    <td>");
            EndContext();
            BeginContext(11491, 61, false);
#line 190 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Update_License.ExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(11552, 65, true);
            WriteLiteral(" :</td>\r\n                                                    <td>");
            EndContext();
            BeginContext(11618, 57, false);
#line 191 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.Update_License.ExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(11675, 2131, true);
            WriteLiteral(@"</td>

                                                </div>
                                                <div class=""col"">
                                                    <td></td>
                                                    <td></td>
                                                </div>
                                            </div>
                                        </div>
                                    </tr>
                                    <tr>
                                        <div class=""card-body"">
                                            <div class=""row"">
                                                <div class=""col"">
                                                    <td></td>
                                                    <td></td>

                                                </div>
                                                <div class=""col"">
                                                    <td></td>
                ");
            WriteLiteral(@"                                    <td></td>
                                                </div>
                                            </div>
                                        </div>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                    <div class=""card "" style=""margin-top:-0%"">
                        <div class=""card-header"" style=""font-weight:bold;color:darkblue;"">
                            More
                        </div>
                        <div class=""card-body"">
                            <table class=""table table-user-information"" style=""margin-top:-12%;margin-bottom:-3%"">
                                <tbody>
                                    <tr>
                                        <div class=""card-body"">
                                            <div class=""row"">
                                        ");
            WriteLiteral("        <div class=\"col\">\r\n                                                    <td>");
            EndContext();
            BeginContext(13807, 57, false);
#line 231 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Update_License.Status));

#line default
#line hidden
            EndContext();
            BeginContext(13864, 65, true);
            WriteLiteral(" :</td>\r\n                                                    <td>");
            EndContext();
            BeginContext(13930, 53, false);
#line 232 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.Update_License.Status));

#line default
#line hidden
            EndContext();
            BeginContext(13983, 186, true);
            WriteLiteral("</td>\r\n                                                </div>\r\n                                                <div class=\"col\">\r\n                                                    <td>");
            EndContext();
            BeginContext(14170, 55, false);
#line 235 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Update_License.Note));

#line default
#line hidden
            EndContext();
            BeginContext(14225, 292, true);
            WriteLiteral(@" :</td>
                                                    <td>
                                                        <div class=""form-group"">
                                                            <textarea class=""form-control"" id=""exampleFormControlTextarea3"" rows=""5"" cols='20'>");
            EndContext();
            BeginContext(14518, 51, false);
#line 238 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                                                                                                          Write(Html.DisplayFor(model => model.Update_License.Note));

#line default
#line hidden
            EndContext();
            BeginContext(14569, 2087, true);
            WriteLiteral(@"</textarea>
                                                        </div>
                                                    </td>

                                                </div>
                                            </div>
                                        </div>
                                    </tr>
                                    <tr>
                                        <div class=""card-body"">
                                            <div class=""row"">
                                                <div class=""col"">
                                                    <td></td>
                                                    <td></td>

                                                </div>
                                                <div class=""col"">
                                                    <td></td>
                                                    <td></td>
                                                </div>
                 ");
            WriteLiteral(@"                           </div>
                                        </div>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                    <div class=""card "" style=""margin-top:0%"">
                        <div class=""card-header"" style=""font-weight:bold;color:darkblue;"">
                            Update
                        </div>
                        <div class=""card-body"">
                            <table class=""table table-user-information"" style=""margin-top:-10%;margin-bottom:-3%"">
                                <tbody>
                                    <tr>
                                        <div class=""card-body"">
                                            <div class=""row"">
                                                <div class=""col"">
                                                    <td>Employee :</td>
                   ");
            WriteLiteral("                                 <td>\r\n");
            EndContext();
#line 278 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                         foreach (var item in Model.Employee)
                                                        {
                                                            if (Model.Update_License.Employee == item.EmployeeID)
                                                            {
                                                                

#line default
#line hidden
            BeginContext(17053, 44, false);
#line 282 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
#line 282 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                                                                             
                                                            }
                                                        }

#line default
#line hidden
            BeginContext(17221, 238, true);
            WriteLiteral("                                                    </td>\r\n                                                </div>\r\n                                                <div class=\"col\">\r\n                                                    <td>");
            EndContext();
            BeginContext(17460, 55, false);
#line 288 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Update_License.Date));

#line default
#line hidden
            EndContext();
            BeginContext(17515, 65, true);
            WriteLiteral(" :</td>\r\n                                                    <td>");
            EndContext();
            BeginContext(17581, 51, false);
#line 289 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.Update_License.Date));

#line default
#line hidden
            EndContext();
            BeginContext(17632, 1250, true);
            WriteLiteral(@"</td>

                                                </div>
                                            </div>
                                        </div>
                                    </tr>
                                    <tr>
                                        <div class=""card-body"">
                                            <div class=""row"">
                                                <div class=""col"">
                                                    <td></td>
                                                    <td></td>

                                                </div>
                                                <div class=""col"">
                                                    <td></td>
                                                    <td></td>
                                                </div>
                                            </div>
                                        </div>
                                    </tr>
   ");
            WriteLiteral("                             </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(18882, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "796de838dd974e528892ebbf56e8ed93", async() => {
                BeginContext(18971, 12, true);
                WriteLiteral("Back to List");
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
#line 319 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\UdateLicense\Details.cshtml"
                                                WriteLiteral(Model.Update_License.License_LicenseID);

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
            BeginContext(18987, 34, true);
            WriteLiteral("\r\n        </div>\r\n        </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tbkk_AC.Pages.UdateLicense.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.UdateLicense.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.UdateLicense.DetailsModel>)PageContext?.ViewData;
        public tbkk_AC.Pages.UdateLicense.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
