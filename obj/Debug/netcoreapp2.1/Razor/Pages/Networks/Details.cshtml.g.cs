#pragma checksum "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4884a32d9a2775c7378e47b55af5c17f98961fe3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkk_AC.Pages.Networks.Pages_Networks_Details), @"mvc.1.0.razor-page", @"/Pages/Networks/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Networks/Details.cshtml", typeof(tbkk_AC.Pages.Networks.Pages_Networks_Details), null)]
namespace tbkk_AC.Pages.Networks
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4884a32d9a2775c7378e47b55af5c17f98961fe3", @"/Pages/Networks/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69d77135ec122947e94bf66dec5647f0745c94b6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Networks_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Assets/Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../JoinNetwork_Assets/Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../JoinNetwork_Assets/Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../UpdateNetworks/Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(96, 840, true);
            WriteLiteral(@"<div class=""container"">
    <div class=""row"">
        <div class=""col-md-9"">
            <h2>Network Detail</h2>
            <div class="" col-md-12 col-lg-12 "">
                <div class=""card "" style=""margin-top:1%"">
                    <div class=""card-header"" style=""font-weight:bold;color:darkblue;"">
                        Detail
                    </div>
                    <div class=""card-body"">
                        <table class=""table table-user-information"" style=""margin-top:-21%;margin-bottom:-6%"">
                            <tbody>
                                <tr>
                                    <div class=""card-body"">
                                        <div class=""row"">
                                            <div class=""col"">
                                                <td>");
            EndContext();
            BeginContext(937, 53, false);
#line 23 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.Network.NetworkID));

#line default
#line hidden
            EndContext();
            BeginContext(990, 61, true);
            WriteLiteral(" :</td>\r\n                                                <td>");
            EndContext();
            BeginContext(1052, 49, false);
#line 24 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                                               Write(Html.DisplayFor(model => model.Network.NetworkID));

#line default
#line hidden
            EndContext();
            BeginContext(1101, 174, true);
            WriteLiteral("</td>\r\n                                            </div>\r\n                                            <div class=\"col\">\r\n                                                <td>");
            EndContext();
            BeginContext(1276, 55, false);
#line 27 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.Network.NetworkName));

#line default
#line hidden
            EndContext();
            BeginContext(1331, 61, true);
            WriteLiteral(" :</td>\r\n                                                <td>");
            EndContext();
            BeginContext(1393, 51, false);
#line 28 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                                               Write(Html.DisplayFor(model => model.Network.NetworkName));

#line default
#line hidden
            EndContext();
            BeginContext(1444, 463, true);
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
            BeginContext(1908, 50, false);
#line 37 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.Network.IpAddr));

#line default
#line hidden
            EndContext();
            BeginContext(1958, 61, true);
            WriteLiteral(" :</td>\r\n                                                <td>");
            EndContext();
            BeginContext(2020, 46, false);
#line 38 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                                               Write(Html.DisplayFor(model => model.Network.IpAddr));

#line default
#line hidden
            EndContext();
            BeginContext(2066, 176, true);
            WriteLiteral("</td>\r\n\r\n                                            </div>\r\n                                            <div class=\"col\">\r\n                                                <td>");
            EndContext();
            BeginContext(2243, 52, false);
#line 42 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.Network.Password));

#line default
#line hidden
            EndContext();
            BeginContext(2295, 61, true);
            WriteLiteral(" :</td>\r\n                                                <td>");
            EndContext();
            BeginContext(2357, 48, false);
#line 43 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                                               Write(Html.DisplayFor(model => model.Network.Password));

#line default
#line hidden
            EndContext();
            BeginContext(2405, 463, true);
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
            BeginContext(2869, 50, false);
#line 52 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.Network.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2919, 61, true);
            WriteLiteral(" :</td>\r\n                                                <td>");
            EndContext();
            BeginContext(2981, 46, false);
#line 53 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                                               Write(Html.DisplayFor(model => model.Network.Status));

#line default
#line hidden
            EndContext();
            BeginContext(3027, 176, true);
            WriteLiteral("</td>\r\n\r\n                                            </div>\r\n                                            <div class=\"col\">\r\n                                                <td>");
            EndContext();
            BeginContext(3204, 48, false);
#line 57 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.Network.Note));

#line default
#line hidden
            EndContext();
            BeginContext(3252, 280, true);
            WriteLiteral(@" :</td>
                                                <td>
                                                    <div class=""form-group"">
                                                        <textarea class=""form-control"" id=""exampleFormControlTextarea3"" rows=""5"" cols='20'>");
            EndContext();
            BeginContext(3533, 44, false);
#line 60 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                                                                                                                                      Write(Html.DisplayFor(model => model.Network.Note));

#line default
#line hidden
            EndContext();
            BeginContext(3577, 1281, true);
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
                                        </div>
                                    </d");
            WriteLiteral(@"iv>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div style=""margin-top:2%"">
        ");
            EndContext();
            BeginContext(4858, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d961d2212dba4514925a876873ec9133", async() => {
                BeginContext(4919, 4, true);
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
#line 90 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                               WriteLiteral(Model.Network.NetworkID);

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
            BeginContext(4927, 12, true);
            WriteLiteral(" |\r\n        ");
            EndContext();
            BeginContext(4939, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d59d725393e9499ba3f42d1459909930", async() => {
                BeginContext(4961, 12, true);
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
            BeginContext(4977, 1717, true);
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
                                    NetworkName
                                </th>
            ");
            WriteLiteral(@"                    <th>
                                    Asset
                                </th>

                                <th>
                                    Status
                                </th>
                                <th>
                                    Asset
                                </th>
                                <th>
                                    Edit
                                </th>
                                <th>
                                    Delete
                                </th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 130 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                             foreach (var item in Model.Join_Network_Asset)
                            {
                                if (Model.Network.NetworkID == item.Network_NetworkID)
                                {

#line default
#line hidden
            BeginContext(6925, 132, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(7058, 51, false);
#line 136 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.Network.NetworkName));

#line default
#line hidden
            EndContext();
            BeginContext(7109, 95, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n");
            EndContext();
#line 139 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                                             foreach (var item1 in Model.Asset)
                                            {
                                                if (item.Asset_AssetID == item1.AssetID)
                                                {
                                                    

#line default
#line hidden
            BeginContext(7526, 45, false);
#line 143 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                                               Write(Html.DisplayFor(modelItem => item1.AssetName));

#line default
#line hidden
            EndContext();
#line 143 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                                                                                                  
                                                }
                                            }

#line default
#line hidden
            BeginContext(7671, 137, true);
            WriteLiteral("                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(7809, 41, false);
#line 148 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(7850, 153, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td width=\"100px\">\r\n                                            ");
            EndContext();
            BeginContext(8003, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65730d2686da44c3a2be6575cbb1f549", async() => {
                BeginContext(8074, 7, true);
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
#line 151 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                                                                              WriteLiteral(item.Network_NetworkID);

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
            BeginContext(8085, 153, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td width=\"100px\">\r\n                                            ");
            EndContext();
            BeginContext(8238, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "702a8ae8bd394a45be7587d03c169dd9", async() => {
                BeginContext(8312, 4, true);
                WriteLiteral("Edit");
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
#line 154 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                                                                                       WriteLiteral(item.JoinNetAsID);

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
            BeginContext(8320, 153, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td width=\"100px\">\r\n                                            ");
            EndContext();
            BeginContext(8473, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2f4b77470eb480d8ecf5ca9492d535a", async() => {
                BeginContext(8549, 6, true);
                WriteLiteral("Delete");
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
#line 157 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                                                                                         WriteLiteral(item.JoinNetAsID);

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
            BeginContext(8559, 92, true);
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 160 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                                }
                            }

#line default
#line hidden
            BeginContext(8717, 1071, true);
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
        </div>
        <div class=""tab-pane fade"" id=""profile"" role=""tabpanel"" aria-labelledby=""profile-tab"">
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table class=""table table-bordered"" id=""dataTable1"" width=""100%"" cellspacing=""3"">
                        <thead>
                            <tr>
                                <th>
                                    NetworkName
                                </th>
                                <th>
                                    User
                                </th>

                                <th>
                                    UpdateDate
                                </th>
                                <th>
                                    Details
                                </th>
                            </tr>
                    ");
            WriteLiteral("    </thead>\r\n                        <tbody>\r\n");
            EndContext();
#line 189 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                             foreach (var item in Model.Update_Network)
                            {
                                if (Model.Network.NetworkID == item.Network_NetworkID)
                                {

#line default
#line hidden
            BeginContext(10015, 132, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(10148, 51, false);
#line 195 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.Network.NetworkName));

#line default
#line hidden
            EndContext();
            BeginContext(10199, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(10339, 45, false);
#line 198 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                                       Write(Html.DisplayFor(model => item.Employee_EmpID));

#line default
#line hidden
            EndContext();
            BeginContext(10384, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(10524, 39, false);
#line 201 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(10563, 153, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td width=\"100px\">\r\n                                            ");
            EndContext();
            BeginContext(10716, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70458ece9c4e443195b44c30c76326a7", async() => {
                BeginContext(10793, 7, true);
                WriteLiteral("Details");
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
#line 204 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                                                                                      WriteLiteral(item.NetworkUpdateID);

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
            BeginContext(10804, 94, true);
            WriteLiteral("\r\n                                        </td>\r\n\r\n                                    </tr>\r\n");
            EndContext();
#line 208 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                                }
                            }

#line default
#line hidden
            BeginContext(10964, 142, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tbkk_AC.Pages.Networks.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.Networks.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.Networks.DetailsModel>)PageContext?.ViewData;
        public tbkk_AC.Pages.Networks.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
