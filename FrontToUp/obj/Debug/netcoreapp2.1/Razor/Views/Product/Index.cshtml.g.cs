#pragma checksum "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d99ce9b21032fcc786f79489134d1085488e8d8a"
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
#line 1 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\_ViewImports.cshtml"
using FrontToUp.Models;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\_ViewImports.cshtml"
using FrontToUp.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d99ce9b21032fcc786f79489134d1085488e8d8a", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bb73b7844e802fb2115de52558301efd7ae90ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(70, 110, true);
            WriteLiteral("\r\n<section id=\"products\">\r\n    <div class=\"container\">\r\n        \r\n        <div class=\"row\" id=\"productList\">\r\n");
            EndContext();
            BeginContext(230, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(243, 41, false);
#line 11 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Product\Index.cshtml"
       Write(await Component.InvokeAsync("Products",8));

#line default
#line hidden
            EndContext();
            BeginContext(284, 64, true);
            WriteLiteral("\r\n        </div>\r\n        <input type=\"hidden\" id=\"ProductCount\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 348, "\"", 377, 1);
#line 13 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Product\Index.cshtml"
WriteAttributeValue("", 356, ViewBag.ProductCount, 356, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(378, 188, true);
            WriteLiteral(" />\r\n        <div class=\"row mt-3 mb-3 justify-content-center\">\r\n            <button class=\"btn btn-success\" id=\"loadMore\">Load more...</button>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591