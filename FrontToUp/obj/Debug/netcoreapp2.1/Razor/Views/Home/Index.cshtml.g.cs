#pragma checksum "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23a4ee767802f680038aa9785cacf9d3de880b46"
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
#line 1 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\_ViewImports.cshtml"
using FrontToUp.Models;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\_ViewImports.cshtml"
using FrontToUp.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23a4ee767802f680038aa9785cacf9d3de880b46", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bb73b7844e802fb2115de52558301efd7ae90ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(56, 150, true);
            WriteLiteral("\r\n<!-- MAIN START -->\r\n\r\n    <main>\r\n\r\n        <!-- SLIDER START -->\r\n\r\n        <section id=\"slider\">\r\n            <div class=\"owl-carousel slider\">\r\n");
            EndContext();
#line 14 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                 foreach (SliderImage item in Model.SliderImages)
                {

#line default
#line hidden
            BeginContext(292, 26, true);
            WriteLiteral("                    <div> ");
            EndContext();
            BeginContext(318, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5194c2f1c89641d3938d3bb44d288f5b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 328, "~/img/", 328, 6, true);
#line 16 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 334, item.ImageName, 334, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(358, 9, true);
            WriteLiteral(" </div>\r\n");
            EndContext();
#line 17 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(386, 237, true);
            WriteLiteral("            </div>\r\n            <div class=\"container context pl-lg-5 ml-lg-3\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-lg-5\">\r\n                        <div class=\"text\">\r\n                            <h1> ");
            EndContext();
            BeginContext(624, 22, false);
#line 23 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                            Write(Model.SliderText.Title);

#line default
#line hidden
            EndContext();
            BeginContext(646, 113, true);
            WriteLiteral(" </h1>\r\n                            <p class=\"text-black-50 d-none d-sm-block\">\r\n                                ");
            EndContext();
            BeginContext(760, 28, false);
#line 25 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                           Write(Model.SliderText.Description);

#line default
#line hidden
            EndContext();
            BeginContext(788, 139, true);
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                        <div class=\"img\">\r\n                            ");
            EndContext();
            BeginContext(927, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "887df5be0cca4601822745422d8a8849", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 937, "~/img/", 937, 6, true);
#line 29 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 943, Model.SliderText.Image, 943, 23, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(975, 808, true);
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
        </section>

        <!-- SLIDER END -->
        <!-- PRODUCTS START -->

        <section id=""products"">
            <div class=""container"">
                <div class=""row pt-5"">
                    <div class=""col-12 d-flex justify-content-between"">
                        <ul class=""category-mobile d-md-none list-unstyled"">
                            <li>
                                <a href="""" class=""categories mr-2"">Categories</a>
                                <i class=""fas fa-caret-down""></i>
                                <ul class=""category list-unstyled"" style=""display: none;"">
                                    <li><a href="""" data-id=""all"">All</a></li>
");
            EndContext();
#line 49 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                                     foreach (Category item in Model.Categories)
                                    {

#line default
#line hidden
            BeginContext(1904, 64, true);
            WriteLiteral("                                        <li><a href=\"\" data-id=\"");
            EndContext();
            BeginContext(1969, 19, false);
#line 51 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                                                           Write(item.Name.ToLower());

#line default
#line hidden
            EndContext();
            BeginContext(1988, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(1991, 19, false);
#line 51 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                                                                                 Write(item.Name.ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(2010, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 52 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2060, 256, true);
            WriteLiteral(@"
                                </ul>
                            </li>
                        </ul>
                        <ul class=""category d-none d-md-flex list-unstyled"">
                            <li><a href="""" data-id=""all"">All</a></li>
");
            EndContext();
#line 59 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                             foreach (Category item in Model.Categories)
                            {

#line default
#line hidden
            BeginContext(2421, 56, true);
            WriteLiteral("                                <li><a href=\"\" data-id=\"");
            EndContext();
            BeginContext(2478, 19, false);
#line 61 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                                                   Write(item.Name.ToLower());

#line default
#line hidden
            EndContext();
            BeginContext(2497, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(2500, 19, false);
#line 61 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                                                                         Write(item.Name.ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(2519, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 62 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(2561, 426, true);
            WriteLiteral(@"
                        </ul>
                        <ul class=""list-unstyled"">
                            <li>
                                <a href="""" class=""mr-2"">Filter</a>
                                <i class=""fas fa-caret-down""></i>
                            </li>
                        </ul>
                    </div>
                </div>
                <div class=""row"">
                   ");
            EndContext();
            BeginContext(2988, 39, false);
#line 74 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
              Write(await Component.InvokeAsync("Products"));

#line default
#line hidden
            EndContext();
            BeginContext(3027, 368, true);
            WriteLiteral(@"

                </div>
            </div>
        </section>

        <!-- PRODUCTS END -->


        <!-- ABOUT START -->

        <section id=""about"">
            <div class=""container py-5"">
                <div class=""row py-5"">
                    <div class=""col-lg-6"">
                        <div class=""img"">
                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3395, "\"", 3427, 2);
            WriteAttributeValue("", 3401, "img/", 3401, 4, true);
#line 90 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
WriteAttributeValue("", 3405, Model.Valentine.Image, 3405, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3428, 58, true);
            WriteLiteral(" class=\"img-fluid\" alt=\"\">\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3486, "\"", 3514, 1);
#line 91 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
WriteAttributeValue("", 3493, Model.Valentine.Link, 3493, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3515, 517, true);
            WriteLiteral(@">
                                <div class=""player position-absolute rounded-circle d-flex align-items-center justify-content-center"">
                                    <i class=""fas fa-play fa-lg""></i>
                                </div>
                            </a>
                            
                        </div>
                    </div>
                    <div class=""col-lg-6"">
                        <div class=""about-text mt-5 mt-lg-0 px-lg-5"">
                            ");
            EndContext();
            BeginContext(4033, 31, false);
#line 101 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                       Write(Html.Raw(Model.Valentine.Title));

#line default
#line hidden
            EndContext();
            BeginContext(4064, 79, true);
            WriteLiteral("\r\n                            <p class=\"py-3\">\r\n                               ");
            EndContext();
            BeginContext(4144, 27, false);
#line 103 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                          Write(Model.Valentine.Description);

#line default
#line hidden
            EndContext();
            BeginContext(4171, 124, true);
            WriteLiteral("\r\n                            </p>\r\n                            <ul class=\"list-unstyled\">\r\n                                ");
            EndContext();
            BeginContext(4296, 35, false);
#line 106 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                           Write(Html.Raw(Model.Valentine.HeartList));

#line default
#line hidden
            EndContext();
            BeginContext(4331, 479, true);
            WriteLiteral(@"
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </section>

        <!-- ABOUT END -->


        <!-- EXPERTS START -->

        <section id=""experts"">
            <div class=""container"">
                <div class=""row py-5"">
                    <div class=""offset-lg-3 col-lg-6"">
                        <div class=""section-title"">
                            <h1>");
            EndContext();
            BeginContext(4811, 22, false);
#line 124 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                           Write(Model.ExpertText.Title);

#line default
#line hidden
            EndContext();
            BeginContext(4833, 94, true);
            WriteLiteral("</h1>\r\n                            <p class=\"text-black-50\">\r\n                                ");
            EndContext();
            BeginContext(4928, 21, false);
#line 126 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                           Write(Model.ExpertText.Text);

#line default
#line hidden
            EndContext();
            BeginContext(4949, 160, true);
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"row pb-5\">\r\n");
            EndContext();
#line 132 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                     foreach (ExpertImage item in Model.ExpertImages)
                    {

#line default
#line hidden
            BeginContext(5203, 204, true);
            WriteLiteral("                        <div class=\"col-md-6 col-lg-3\">\r\n                            <div class=\"item text-center\">\r\n                                <div class=\"img\">\r\n                                    ");
            EndContext();
            BeginContext(5407, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cc1d78b308444a3095d2c3de5b10e05a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5417, "~/img/", 5417, 6, true);
#line 137 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 5423, item.ImageName, 5423, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5480, 139, true);
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"text mt-3\">\r\n                                    <h6>");
            EndContext();
            BeginContext(5620, 9, false);
#line 140 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(5629, 68, true);
            WriteLiteral("</h6>\r\n                                    <p class=\"text-black-50\">");
            EndContext();
            BeginContext(5698, 15, false);
#line 141 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                                                        Write(item.Profession);

#line default
#line hidden
            EndContext();
            BeginContext(5713, 114, true);
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 145 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(5850, 163, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </section>\r\n\r\n        <!-- EXPERTS END -->\r\n        <!-- SUBSCRIBE START -->\r\n\r\n        <section id=\"subscribe\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 6013, "\"", 6102, 6);
            WriteAttributeValue("", 6021, "background:", 6021, 11, true);
            WriteAttributeValue(" ", 6032, "url(../img/", 6033, 12, true);
#line 153 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
WriteAttributeValue("", 6044, Model.Subscribe.ImageName, 6044, 26, false);

#line default
#line hidden
            WriteAttributeValue("", 6070, ");", 6070, 2, true);
            WriteAttributeValue(" ", 6072, "background-attachment:", 6073, 23, true);
            WriteAttributeValue(" ", 6095, "fixed;", 6096, 7, true);
            EndWriteAttribute();
            BeginContext(6103, 223, true);
            WriteLiteral(">\r\n            <div class=\"container py-5\">\r\n                <div class=\"row py-5\">\r\n                    <div class=\"col-12\">\r\n                        <div class=\"content text-center py-5\">\r\n                            <h3>");
            EndContext();
            BeginContext(6327, 21, false);
#line 158 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                           Write(Model.Subscribe.Title);

#line default
#line hidden
            EndContext();
            BeginContext(6348, 812, true);
            WriteLiteral(@"</h3>
                            <div class=""form-group d-flex justify-content-center flex-wrap mt-5"">
                                <input type=""email"" placeholder=""Email Address"" class=""form-control-lg rounded-0"">
                                <button class=""btn btn-danger btn-lg rounded-0 px-5 mt-3 mt-sm-0"">Subscribe</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>

        <!-- SUBSCRIBE END -->
        <!-- BLOG START -->

        <section id=""blog"">
            <div class=""container"">
                <div class=""row py-5"">
                    <div class=""offset-lg-3 col-lg-6"">
                        <div class=""section-title"">
                            <h1>");
            EndContext();
            BeginContext(7161, 20, false);
#line 177 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                           Write(Model.BlogText.Title);

#line default
#line hidden
            EndContext();
            BeginContext(7181, 94, true);
            WriteLiteral("</h1>\r\n                            <p class=\"text-black-50\">\r\n                                ");
            EndContext();
            BeginContext(7276, 19, false);
#line 179 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                           Write(Model.BlogText.Text);

#line default
#line hidden
            EndContext();
            BeginContext(7295, 160, true);
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"row pb-5\">\r\n");
            EndContext();
#line 185 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                     foreach (BlogImage item in Model.BlogImages)
                    {

#line default
#line hidden
            BeginContext(7545, 210, true);
            WriteLiteral("                        <div class=\"col-md-6 col-lg-4\">\r\n                            <div class=\"item\">\r\n                                <div class=\"img position-relative\">\r\n                                    ");
            EndContext();
            BeginContext(7755, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "92041c3dd52941a9bfbc9467447f05d5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7765, "~/img/", 7765, 6, true);
#line 190 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 7771, item.ImageName, 7771, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7813, 366, true);
            WriteLiteral(@"
                                    <div class=""date rounded bg-light position-absolute py-1 px-2"">
                                        <span>29.12.2019</span>
                                    </div>
                                </div>
                                <div class=""text mt-3 text-center px-5"">
                                    <h5>");
            EndContext();
            BeginContext(8180, 10, false);
#line 196 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                                   Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(8190, 110, true);
            WriteLiteral("</h5>\r\n                                    <p class=\"text-black-50\">\r\n                                        ");
            EndContext();
            BeginContext(8301, 9, false);
#line 198 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                                   Write(item.Text);

#line default
#line hidden
            EndContext();
            BeginContext(8310, 152, true);
            WriteLiteral("\r\n                                    </p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 203 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(8485, 366, true);
            WriteLiteral(@"

                </div>
            </div>
        </section>

        <!-- BLOG END -->
        <!-- SAY START -->

        <section id=""say"">
            <div class=""container"">
                <div class=""row py-5 justify-content-center"">
                    <div class=""col-md-8 col-xl-6"">
                        <div class=""owl-carousel say"">

");
            EndContext();
#line 219 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                             foreach (Say item in Model.Says)
                            {

#line default
#line hidden
            BeginContext(8945, 189, true);
            WriteLiteral("                                <div class=\"item text-center\">\r\n                                    <div class=\"img d-flex justify-content-center\">\r\n                                        ");
            EndContext();
            BeginContext(9134, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9577940c4c0d4346b1ea1f98c92ec8cb", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9144, "~/img/", 9144, 6, true);
#line 223 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 9150, item.ImageName, 9150, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9174, 212, true);
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"text text-muted pt-3 pb-5\">\r\n                                        <i>\r\n                                            ");
            EndContext();
            BeginContext(9387, 9, false);
#line 227 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                                       Write(item.Text);

#line default
#line hidden
            EndContext();
            BeginContext(9396, 194, true);
            WriteLiteral("\r\n                                        </i>\r\n                                    </div>\r\n                                    <div class=\"author\">\r\n                                        <h6>");
            EndContext();
            BeginContext(9591, 9, false);
#line 231 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(9600, 72, true);
            WriteLiteral("</h6>\r\n                                        <p class=\"text-black-50\">");
            EndContext();
            BeginContext(9673, 15, false);
#line 232 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                                                            Write(item.Profession);

#line default
#line hidden
            EndContext();
            BeginContext(9688, 90, true);
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n");
            EndContext();
#line 235 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(9809, 276, true);
            WriteLiteral(@"

                        </div>
                    </div>
                </div>
            </div>
        </section>

        <!-- SAY END -->
        <!-- INSTAGRAM START -->

        <section id=""instagram"">
            <div class=""owl-carousel instagram"">
");
            EndContext();
#line 249 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
                 foreach (Instagram item in Model.Instagrams)
                {

#line default
#line hidden
            BeginContext(10167, 25, true);
            WriteLiteral("                    <div>");
            EndContext();
            BeginContext(10192, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "01a99d28da314781b4998042352fe3b0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 10202, "~/img/", 10202, 6, true);
#line 251 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 10208, item.ImageName, 10208, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10250, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 252 "C:\Users\User\Desktop\my projects\ASP\FrontToUp\FrontToUp\Views\Home\Index.cshtml"

                }

#line default
#line hidden
            BeginContext(10279, 221, true);
            WriteLiteral("            </div>\r\n            <div class=\"hastag bg-light text-muted py-2 px-3\">\r\n                #FIORELLO\r\n            </div>\r\n        </section>\r\n\r\n        <!-- INSTAGRAM END -->\r\n\r\n    </main>\r\n\r\n<!-- MAIN END -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
