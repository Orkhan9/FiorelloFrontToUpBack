#pragma checksum "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Areas\AdminF\Views\Users\ChangeRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb9402cdb8fe6b1efe45b373bdbfc2114a1be67e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminF_Views_Users_ChangeRole), @"mvc.1.0.view", @"/Areas/AdminF/Views/Users/ChangeRole.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AdminF/Views/Users/ChangeRole.cshtml", typeof(AspNetCore.Areas_AdminF_Views_Users_ChangeRole))]
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
#line 1 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Areas\AdminF\Views\_ViewImports.cshtml"
using FrontToUp.Models;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Areas\AdminF\Views\_ViewImports.cshtml"
using FrontToUp.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb9402cdb8fe6b1efe45b373bdbfc2114a1be67e", @"/Areas/AdminF/Views/Users/ChangeRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bb73b7844e802fb2115de52558301efd7ae90ff", @"/Areas/AdminF/Views/_ViewImports.cshtml")]
    public class Areas_AdminF_Views_Users_ChangeRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Areas\AdminF\Views\Users\ChangeRole.cshtml"
  
    ViewData["Title"] = "ChangeRole";

#line default
#line hidden
            BeginContext(61, 294, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12 d-flex align-items-stretch"">
        <div class=""row"">
            <div class=""col-md-12 grid-margin stretch-card"">
                <div class=""card"">
                    <div class=""card-body"">
                        <h4 class=""card-title"">");
            EndContext();
            BeginContext(356, 14, false);
#line 12 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Areas\AdminF\Views\Users\ChangeRole.cshtml"
                                          Write(Model.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(370, 64, true);
            WriteLiteral("</h4>\r\n                        <p>\r\n                            ");
            EndContext();
            BeginContext(435, 11, false);
#line 14 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Areas\AdminF\Views\Users\ChangeRole.cshtml"
                       Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(446, 89, true);
            WriteLiteral("\r\n                        </p>\r\n                        <p>\r\n                            ");
            EndContext();
            BeginContext(536, 14, false);
#line 17 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Areas\AdminF\Views\Users\ChangeRole.cshtml"
                       Write(Model.Username);

#line default
#line hidden
            EndContext();
            BeginContext(550, 170, true);
            WriteLiteral("\r\n                        </p>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"row mt-3\">\r\n    ");
            EndContext();
            BeginContext(720, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "610d58a171f147a28d5e420277b9a3ed", async() => {
                BeginContext(763, 7, true);
                WriteLiteral("Go back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(774, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(780, 458, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ab2f3b6b951478f9caabff8151bfe3c", async() => {
                BeginContext(800, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 29 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Areas\AdminF\Views\Users\ChangeRole.cshtml"
         foreach (string item in Model.Roles)
        {
            if (item == Model.Role)
            {

#line default
#line hidden
                BeginContext(912, 55, true);
                WriteLiteral("                <input type=\"radio\" name=\"Role\" checked");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 967, "\"", 980, 1);
#line 33 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Areas\AdminF\Views\Users\ChangeRole.cshtml"
WriteAttributeValue("", 975, item, 975, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(981, 2, true);
                WriteLiteral("/>");
                EndContext();
                BeginContext(984, 4, false);
#line 33 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Areas\AdminF\Views\Users\ChangeRole.cshtml"
                                                                  Write(item);

#line default
#line hidden
                EndContext();
#line 33 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Areas\AdminF\Views\Users\ChangeRole.cshtml"
                                                                            
            }
            else
            {

#line default
#line hidden
                BeginContext(1038, 47, true);
                WriteLiteral("                <input type=\"radio\" name=\"Role\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1085, "\"", 1098, 1);
#line 37 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Areas\AdminF\Views\Users\ChangeRole.cshtml"
WriteAttributeValue("", 1093, item, 1093, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1099, 2, true);
                WriteLiteral("/>");
                EndContext();
                BeginContext(1102, 4, false);
#line 37 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Areas\AdminF\Views\Users\ChangeRole.cshtml"
                                                          Write(item);

#line default
#line hidden
                EndContext();
#line 37 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Areas\AdminF\Views\Users\ChangeRole.cshtml"
                                                                    
            }

        }

#line default
#line hidden
                BeginContext(1136, 95, true);
                WriteLiteral("        \r\n        <button type=\"submit\" class=\"btn btn-primary ml-2\">Change Role</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1238, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
