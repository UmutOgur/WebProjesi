#pragma checksum "C:\Users\BTAkademi\source\repos\CoreSeminerWeb\CoreSeminerWeb\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56a2141950c3e02daf648d083ff343fbf2dc3aac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
#line 1 "C:\Users\BTAkademi\source\repos\CoreSeminerWeb\CoreSeminerWeb\Views\_ViewImports.cshtml"
using CoreSeminerWeb;

#line default
#line hidden
#line 2 "C:\Users\BTAkademi\source\repos\CoreSeminerWeb\CoreSeminerWeb\Views\_ViewImports.cshtml"
using CoreSeminerWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56a2141950c3e02daf648d083ff343fbf2dc3aac", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae6df54dd1d67428d268052dd60b681b718a5b58", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagingModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::CoreSeminerWeb.PagingTagHelper __CoreSeminerWeb_PagingTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\BTAkademi\source\repos\CoreSeminerWeb\CoreSeminerWeb\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int currentPage = (int)ViewData["id"];

#line default
#line hidden
            BeginContext(107, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(110, 24, false);
#line 8 "C:\Users\BTAkademi\source\repos\CoreSeminerWeb\CoreSeminerWeb\Views\Product\Index.cshtml"
Write(Html.BoldText("Urunler"));

#line default
#line hidden
            EndContext();
            BeginContext(134, 13, true);
            WriteLiteral("\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(147, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3643c2466864a96b4b8e22a15f292a8", async() => {
                BeginContext(170, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(184, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(277, 62, false);
#line 17 "C:\Users\BTAkademi\source\repos\CoreSeminerWeb\CoreSeminerWeb\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.prodList.First().ProductId));

#line default
#line hidden
            EndContext();
            BeginContext(339, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(395, 64, false);
#line 20 "C:\Users\BTAkademi\source\repos\CoreSeminerWeb\CoreSeminerWeb\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.prodList.First().ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(459, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(515, 68, false);
#line 23 "C:\Users\BTAkademi\source\repos\CoreSeminerWeb\CoreSeminerWeb\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.prodList.First().QuantityPerUnit));

#line default
#line hidden
            EndContext();
            BeginContext(583, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(639, 62, false);
#line 26 "C:\Users\BTAkademi\source\repos\CoreSeminerWeb\CoreSeminerWeb\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.prodList.First().UnitPrice));

#line default
#line hidden
            EndContext();
            BeginContext(701, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(757, 65, false);
#line 29 "C:\Users\BTAkademi\source\repos\CoreSeminerWeb\CoreSeminerWeb\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.prodList.First().UnitsInStock));

#line default
#line hidden
            EndContext();
            BeginContext(822, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(878, 65, false);
#line 32 "C:\Users\BTAkademi\source\repos\CoreSeminerWeb\CoreSeminerWeb\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.prodList.First().UnitsOnOrder));

#line default
#line hidden
            EndContext();
            BeginContext(943, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(999, 65, false);
#line 35 "C:\Users\BTAkademi\source\repos\CoreSeminerWeb\CoreSeminerWeb\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.prodList.First().ReorderLevel));

#line default
#line hidden
            EndContext();
            BeginContext(1064, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1120, 65, false);
#line 38 "C:\Users\BTAkademi\source\repos\CoreSeminerWeb\CoreSeminerWeb\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.prodList.First().Discontinued));

#line default
#line hidden
            EndContext();
            BeginContext(1185, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 44 "C:\Users\BTAkademi\source\repos\CoreSeminerWeb\CoreSeminerWeb\Views\Product\Index.cshtml"
         foreach (var item in Model.prodList)
        {

#line default
#line hidden
            BeginContext(1329, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1390, 44, false);
#line 48 "C:\Users\BTAkademi\source\repos\CoreSeminerWeb\CoreSeminerWeb\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductId));

#line default
#line hidden
            EndContext();
            BeginContext(1434, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1502, 46, false);
#line 51 "C:\Users\BTAkademi\source\repos\CoreSeminerWeb\CoreSeminerWeb\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(1548, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1616, 50, false);
#line 54 "C:\Users\BTAkademi\source\repos\CoreSeminerWeb\CoreSeminerWeb\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.QuantityPerUnit));

#line default
#line hidden
            EndContext();
            BeginContext(1666, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1734, 44, false);
#line 57 "C:\Users\BTAkademi\source\repos\CoreSeminerWeb\CoreSeminerWeb\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.UnitPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1778, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1846, 47, false);
#line 60 "C:\Users\BTAkademi\source\repos\CoreSeminerWeb\CoreSeminerWeb\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.UnitsInStock));

#line default
#line hidden
            EndContext();
            BeginContext(1893, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1961, 47, false);
#line 63 "C:\Users\BTAkademi\source\repos\CoreSeminerWeb\CoreSeminerWeb\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.UnitsOnOrder));

#line default
#line hidden
            EndContext();
            BeginContext(2008, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2076, 47, false);
#line 66 "C:\Users\BTAkademi\source\repos\CoreSeminerWeb\CoreSeminerWeb\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ReorderLevel));

#line default
#line hidden
            EndContext();
            BeginContext(2123, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2191, 47, false);
#line 69 "C:\Users\BTAkademi\source\repos\CoreSeminerWeb\CoreSeminerWeb\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Discontinued));

#line default
#line hidden
            EndContext();
            BeginContext(2238, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2306, 58, false);
#line 72 "C:\Users\BTAkademi\source\repos\CoreSeminerWeb\CoreSeminerWeb\Views\Product\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id=item.ProductId }));

#line default
#line hidden
            EndContext();
            BeginContext(2364, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2389, 66, false);
#line 73 "C:\Users\BTAkademi\source\repos\CoreSeminerWeb\CoreSeminerWeb\Views\Product\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item.ProductId }));

#line default
#line hidden
            EndContext();
            BeginContext(2455, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2480, 64, false);
#line 74 "C:\Users\BTAkademi\source\repos\CoreSeminerWeb\CoreSeminerWeb\Views\Product\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.ProductId }));

#line default
#line hidden
            EndContext();
            BeginContext(2544, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 77 "C:\Users\BTAkademi\source\repos\CoreSeminerWeb\CoreSeminerWeb\Views\Product\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2599, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
            BeginContext(2623, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("paging", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f1286f51c594a94aea9d09eac82004a", async() => {
            }
            );
            __CoreSeminerWeb_PagingTagHelper = CreateTagHelper<global::CoreSeminerWeb.PagingTagHelper>();
            __tagHelperExecutionContext.Add(__CoreSeminerWeb_PagingTagHelper);
#line 80 "C:\Users\BTAkademi\source\repos\CoreSeminerWeb\CoreSeminerWeb\Views\Product\Index.cshtml"
__CoreSeminerWeb_PagingTagHelper.PageCount = Model.PageCount;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("for-pagecount", __CoreSeminerWeb_PagingTagHelper.PageCount, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 80 "C:\Users\BTAkademi\source\repos\CoreSeminerWeb\CoreSeminerWeb\Views\Product\Index.cshtml"
__CoreSeminerWeb_PagingTagHelper.PageNumber = currentPage;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("for-pagenumber", __CoreSeminerWeb_PagingTagHelper.PageNumber, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2701, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3002, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagingModel> Html { get; private set; }
    }
}
#pragma warning restore 1591