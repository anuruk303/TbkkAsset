#pragma checksum "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc69ab07f6b51050badd102cb2de37078b54dab2"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc69ab07f6b51050badd102cb2de37078b54dab2", @"/Pages/Networks/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69d77135ec122947e94bf66dec5647f0745c94b6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Networks_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            BeginContext(49, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(90, 355, true);
            WriteLiteral(@"    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-9"">
                <h2>Network Detail</h2>
                <div class="" col-md-12 col-lg-12 "">
                    <table class=""table table-user-information"">
                        <tbody>
                            <tr>
                                <td>");
            EndContext();
            BeginContext(446, 55, false);
#line 15 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.Network.NetworkName));

#line default
#line hidden
            EndContext();
            BeginContext(501, 46, true);
            WriteLiteral(" :</td>\r\n                                <td> ");
            EndContext();
            BeginContext(548, 51, false);
#line 16 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                                Write(Html.DisplayFor(model => model.Network.NetworkName));

#line default
#line hidden
            EndContext();
            BeginContext(599, 112, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(712, 50, false);
#line 19 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.Network.IpAddr));

#line default
#line hidden
            EndContext();
            BeginContext(762, 45, true);
            WriteLiteral(" :</td>\r\n                                <td>");
            EndContext();
            BeginContext(808, 46, false);
#line 20 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                               Write(Html.DisplayFor(model => model.Network.IpAddr));

#line default
#line hidden
            EndContext();
            BeginContext(854, 112, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(967, 52, false);
#line 23 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.Network.Password));

#line default
#line hidden
            EndContext();
            BeginContext(1019, 45, true);
            WriteLiteral(" :</td>\r\n                                <td>");
            EndContext();
            BeginContext(1065, 48, false);
#line 24 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                               Write(Html.DisplayFor(model => model.Network.Password));

#line default
#line hidden
            EndContext();
            BeginContext(1113, 148, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n\r\n                            <tr>\r\n                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(1262, 50, false);
#line 29 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.Network.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1312, 45, true);
            WriteLiteral(" :</td>\r\n                                <td>");
            EndContext();
            BeginContext(1358, 46, false);
#line 30 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                               Write(Html.DisplayFor(model => model.Network.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1404, 112, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(1517, 48, false);
#line 33 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.Network.Note));

#line default
#line hidden
            EndContext();
            BeginContext(1565, 232, true);
            WriteLiteral(" :</td>\r\n                                <td>\r\n                                    <div class=\"form-group\">\r\n                                        <textarea class=\"form-control\" id=\"exampleFormControlTextarea3\" rows=\"5\" cols=\'20\'>");
            EndContext();
            BeginContext(1798, 44, false);
#line 36 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
                                                                                                                      Write(Html.DisplayFor(model => model.Network.Note));

#line default
#line hidden
            EndContext();
            BeginContext(1842, 288, true);
            WriteLiteral(@"</textarea>
                                    </div>
                                </td>
                            </tr>

                        </tbody>
                    </table>
                </div>
            </div>

        </div>

        <div>
            ");
            EndContext();
            BeginContext(2130, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c14b5c5216bd45f0b2b14bda180a2726", async() => {
                BeginContext(2191, 4, true);
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
#line 49 "C:\Users\Anuruk\Desktop\tbkk-asset-master\Pages\Networks\Details.cshtml"
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
            BeginContext(2199, 16, true);
            WriteLiteral(" |\r\n            ");
            EndContext();
            BeginContext(2215, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "723f13a193a64ed1aad62b5bf023aacf", async() => {
                BeginContext(2237, 12, true);
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
            BeginContext(2253, 2360, true);
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
                                ");
            WriteLiteral(@"        Name
                                    </th>
                                    <th>
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
                    ");
            WriteLiteral(@"            </tr>

                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            <div class=""tab-pane fade"" id=""profile"" role=""tabpanel"" aria-labelledby=""profile-tab"">

            </div>

        </div>
       ");
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
