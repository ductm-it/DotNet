#pragma checksum "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Views\Posts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f490bf44b09b536b1df9ab62710c22086ff0997b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_Details), @"mvc.1.0.view", @"/Views/Posts/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Posts/Details.cshtml", typeof(AspNetCore.Views_Posts_Details))]
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
#line 2 "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Views\_ViewImports.cshtml"
using uit_project_framework.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f490bf44b09b536b1df9ab62710c22086ff0997b", @"/Views/Posts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b2dc8f72df46c8de15d8ec60f1267bb11c9e5e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<uit_project_framework.Models.Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Views\Posts\Details.cshtml"
  
Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
            BeginContext(96, 355, true);
            WriteLiteral(@"
<div class=""ps-section--page-reverse"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-9 col-md-9 col-sm-12 col-xs-12 "">
                <div class=""ps-blog-detail pt-80 pb-80"">
                    <div class=""ps-post"">
                        <div class=""ps-post__thumbnail"">
                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 451, "\"", 494, 1);
#line 15 "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Views\Posts\Details.cshtml"
WriteAttributeValue("", 457, Html.DisplayFor(model=> model.Image), 457, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(495, 127, true);
            WriteLiteral(" alt=\"\"></div>\r\n                        <div class=\"ps-post__header\">\r\n                            <div class=\"ps-post__title\">");
            EndContext();
            BeginContext(623, 36, false);
#line 17 "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Views\Posts\Details.cshtml"
                                                   Write(Html.DisplayFor(model=> model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(659, 217, true);
            WriteLiteral("</div>\r\n                            <div class=\"ps-post__meta\">\r\n                                <span>\r\n                                    <i class=\"fa fa-calendar-check-o\"></i>\r\n                                    ");
            EndContext();
            BeginContext(877, 40, false);
#line 21 "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Views\Posts\Details.cshtml"
                               Write(Html.DisplayFor(model=> model.CreatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(917, 199, true);
            WriteLiteral("\r\n                                </span>\r\n\r\n\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"ps-post__content\">\r\n                            ");
            EndContext();
            BeginContext(1117, 39, false);
#line 28 "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Views\Posts\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Content));

#line default
#line hidden
            EndContext();
            BeginContext(1156, 233, true);
            WriteLiteral("\r\n                        </div>\r\n                        \r\n                    </div>\r\n                    \r\n                    \r\n                   \r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<uit_project_framework.Models.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591