#pragma checksum "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Views\Posts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb6086a4f71da2d7c8149393d51fe053bf5dfe0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_Index), @"mvc.1.0.view", @"/Views/Posts/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Posts/Index.cshtml", typeof(AspNetCore.Views_Posts_Index))]
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
#line 1 "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Views\_ViewImports.cshtml"
using uit_project_framework;

#line default
#line hidden
#line 4 "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Views\Posts\Index.cshtml"
using uit_project_framework.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb6086a4f71da2d7c8149393d51fe053bf5dfe0e", @"/Views/Posts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b2dc8f72df46c8de15d8ec60f1267bb11c9e5e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<uit_project_framework.Models.Post>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ps-btn ps-btn--sm ps-post__morelink"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Views\Posts\Index.cshtml"
                                        

    ViewData["Title"] = "post";
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
            BeginContext(190, 252, true);
            WriteLiteral("\r\n<div class=\"page-wrap\">\r\n    <div class=\"ps-section--page-reverse\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-9 col-md-9 col-sm-12 col-xs-12 \">\r\n                    <div class=\"pt-80 pb-80\">\r\n");
            EndContext();
#line 17 "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Views\Posts\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(523, 242, true);
            WriteLiteral("                            <div class=\"ps-blog-listing\">\r\n                                <div class=\"ps-post\">\r\n                                    <div class=\"ps-post__thumbnail\"><a class=\"ps-post__overlay\" href=\"blog-detail.html\"></a><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 765, "\"", 812, 1);
#line 21 "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Views\Posts\Index.cshtml"
WriteAttributeValue("", 771, Html.DisplayFor(modelItem => item.Image), 771, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(813, 199, true);
            WriteLiteral(" alt=\"\" height=\"825\" width=\"440\"></div>\r\n                                    <div class=\"ps-post__header\">\r\n                                        <a class=\"ps-post__title\" href=\"blog-detail.html\"> ");
            EndContext();
            BeginContext(1013, 40, false);
#line 23 "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Views\Posts\Index.cshtml"
                                                                                      Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1053, 163, true);
            WriteLiteral("</a>\r\n                                        <div class=\"ps-post__meta\">\r\n                                            <span><i class=\"fa fa-calendar-check-o\"></i>");
            EndContext();
            BeginContext(1217, 44, false);
#line 25 "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Views\Posts\Index.cshtml"
                                                                                   Write(Html.DisplayFor(modelItem => item.CreatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(1261, 260, true);
            WriteLiteral(@"</span>

                                            
                                        </div>
                                    </div>
                                    <div class=""ps-post__content"">
                                        <p>");
            EndContext();
            BeginContext(1522, 42, false);
#line 31 "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Views\Posts\Index.cshtml"
                                      Write(Html.DisplayFor(modelItem => item.Content));

#line default
#line hidden
            EndContext();
            BeginContext(1564, 160, true);
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <footer class=\"ps-post__footer\">\r\n                                        ");
            EndContext();
            BeginContext(1724, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "501e3956962540e39cdbcbe45e04ebdc", async() => {
                BeginContext(1820, 9, true);
                WriteLiteral("Read more");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 34 "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Views\Posts\Index.cshtml"
                                                                                                              WriteLiteral(item.PostId);

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
            BeginContext(1833, 125, true);
            WriteLiteral("\r\n                                    </footer>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 38 "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Views\Posts\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1985, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(2711, 108, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<uit_project_framework.Models.Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
