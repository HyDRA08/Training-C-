#pragma checksum "E:\Training\MVCAssignment\MVCAssignment\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92b89e4b7bf810736b0c867fee095778e21e468d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\Training\MVCAssignment\MVCAssignment\Views\_ViewImports.cshtml"
using MVCAssignment;

#line default
#line hidden
#line 2 "E:\Training\MVCAssignment\MVCAssignment\Views\_ViewImports.cshtml"
using MVCAssignment.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92b89e4b7bf810736b0c867fee095778e21e468d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efe0a222b7409bad15aaf8a573f943780952e203", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVCAssignment.Models.ViewModel.ProductsViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(70, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Training\MVCAssignment\MVCAssignment\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(117, 83, true);
            WriteLiteral("\r\n\r\n<div class=\"limiter\">\r\n    <ul style=\"color:aliceblue;\">\r\n        <li id=\"nav\">");
            EndContext();
            BeginContext(200, 27, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a159fc2f5cf24e6eaebf56521a808af5", async() => {
                BeginContext(220, 3, true);
                WriteLiteral("ADD");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(227, 668, true);
            WriteLiteral(@"</li>
    </ul>
    <div class=""container-table100"">
        <div class=""wrap-table100"">
            <div class=""table100"">
                <table>
                    <thead>
                        <tr class=""table100-head"">
                            <th class=""column1"">Product #</th>
                            <th class=""column2"">Product Name</th>
                            <th class=""column3"">Product Description</th>
                            <th class=""column4"">Price</th>
                            <th></th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 27 "E:\Training\MVCAssignment\MVCAssignment\Views\Home\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(976, 86, true);
            WriteLiteral("                            <tr>\r\n                                <td class=\"column1\">");
            EndContext();
            BeginContext(1063, 38, false);
#line 30 "E:\Training\MVCAssignment\MVCAssignment\Views\Home\Index.cshtml"
                                               Write(Html.DisplayFor(x => item.ProductCode));

#line default
#line hidden
            EndContext();
            BeginContext(1101, 59, true);
            WriteLiteral("</td>\r\n                                <td class=\"column2\">");
            EndContext();
            BeginContext(1161, 39, false);
#line 31 "E:\Training\MVCAssignment\MVCAssignment\Views\Home\Index.cshtml"
                                               Write(Html.DisplayFor(x => item.ProdcuctName));

#line default
#line hidden
            EndContext();
            BeginContext(1200, 59, true);
            WriteLiteral("</td>\r\n                                <td class=\"column3\">");
            EndContext();
            BeginContext(1260, 38, false);
#line 32 "E:\Training\MVCAssignment\MVCAssignment\Views\Home\Index.cshtml"
                                               Write(Html.DisplayFor(x => item.ProductDesc));

#line default
#line hidden
            EndContext();
            BeginContext(1298, 60, true);
            WriteLiteral("</td>\r\n                                <td class=\"column4\">$");
            EndContext();
            BeginContext(1359, 39, false);
#line 33 "E:\Training\MVCAssignment\MVCAssignment\Views\Home\Index.cshtml"
                                                Write(Html.DisplayFor(x => item.ProductPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1398, 81, true);
            WriteLiteral("</td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1480, 60, false);
#line 35 "E:\Training\MVCAssignment\MVCAssignment\Views\Home\Index.cshtml"
                               Write(Html.ActionLink("Edit", "Edit", new { id = item.ProductId }));

#line default
#line hidden
            EndContext();
            BeginContext(1540, 40, true);
            WriteLiteral(" |\r\n                                    ");
            EndContext();
            BeginContext(1581, 64, false);
#line 36 "E:\Training\MVCAssignment\MVCAssignment\Views\Home\Index.cshtml"
                               Write(Html.ActionLink("Delete", "Delete", new { id = item.ProductId }));

#line default
#line hidden
            EndContext();
            BeginContext(1645, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 39 "E:\Training\MVCAssignment\MVCAssignment\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1748, 110, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVCAssignment.Models.ViewModel.ProductsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
