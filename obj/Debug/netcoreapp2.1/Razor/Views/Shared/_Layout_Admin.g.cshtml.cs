#pragma checksum "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Views\Shared\_Layout_Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "726f57be079c9ab50abd9f61214c80af58b51095"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout_Admin), @"mvc.1.0.view", @"/Views/Shared/_Layout_Admin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout_Admin.cshtml", typeof(AspNetCore.Views_Shared__Layout_Admin))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"726f57be079c9ab50abd9f61214c80af58b51095", @"/Views/Shared/_Layout_Admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b2dc8f72df46c8de15d8ec60f1267bb11c9e5e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout_Admin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("theme-blush"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 54, true);
            WriteLiteral("<!doctype html>\r\n<html class=\"no-js \" lang=\"en\">\r\n\r\n\r\n");
            EndContext();
            BeginContext(54, 779, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62d8de27570b4aeb9318169fd7e1bee9", async() => {
                BeginContext(60, 766, true);
                WriteLiteral(@"
<meta charset=""utf-8"">
<meta http-equiv=""X-UA-Compatible"" content=""IE=Edge"">
<meta content=""width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no"" name=""viewport"">
<meta name=""description"" content=""Responsive Bootstrap 4 and web Application ui kit."">

<title>:: Aero Bootstrap4 Admin :: Product list</title>
<link rel=""icon"" href=""favicon.ico"" type=""image/x-icon"">
<!-- Favicon-->
<link rel=""stylesheet"" href=""/assets/plugins/bootstrap/css/bootstrap.min.css"">
<link rel=""stylesheet"" href=""/assets/plugins/footable-bootstrap/css/footable.bootstrap.min.css"">
<link rel=""stylesheet"" href=""/assets/plugins/footable-bootstrap/css/footable.standalone.min.css"">

<!-- Custom Css -->
<link rel=""stylesheet"" href=""/assets/css/style.min.css"">
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(833, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(837, 2662, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f63b783073a48bca4d8f9f5e3530a4c", async() => {
                BeginContext(863, 487, true);
                WriteLiteral(@"

<!-- Page Loader -->
<div class=""page-loader-wrapper"">
    <div class=""loader"">
        <div class=""m-t-30""><img class=""zmdi-hc-spin"" src=""/assets/images/loader.svg"" width=""48"" height=""48"" alt=""Aero""></div>
        <p>Please wait...</p>
    </div>
</div>

<!-- Overlay For Sidebars -->
<div class=""overlay""></div>

<!-- Main Search -->
<div id=""search"">
    <button id=""close"" type=""button"" class=""close btn btn-primary btn-icon btn-icon-mini btn-round"">x</button>
    ");
                EndContext();
                BeginContext(1350, 156, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dd11a1987a940f6a2008460e9b87ed1", async() => {
                    BeginContext(1356, 143, true);
                    WriteLiteral("\r\n        <input type=\"search\" value=\"\" placeholder=\"Search...\" />\r\n        <button type=\"submit\" class=\"btn btn-primary\">Search</button>\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1506, 1486, true);
                WriteLiteral(@"
</div>


<!-- Left Sidebar -->
<aside id=""leftsidebar"" class=""sidebar"">
    <div class=""navbar-brand"">
        <button class=""btn-menu ls-toggle-btn"" type=""button""><i class=""zmdi zmdi-menu""></i></button>
        <a href=""index.html""><img src=""/assets/images/logo.svg"" width=""25"" alt=""Aero""><span class=""m-l-10"">Aero</span></a>
    </div>
    <div class=""menu"">
        <ul class=""list"">
            <li>
                <div class=""user-info"">
                    <a class=""image"" href=""profile.html""><img src=""/assets/images/profile_av.jpg"" alt=""User""></a>
                    <div class=""detail"">
                        <h4>Michael</h4>
                        <small>Super Admin</small>                        
                    </div>
                </div>
            </li>
            <li><a href=""index.html""><i class=""zmdi zmdi-home""></i><span>Dashboard</span></a></li>
            <li><a href=""index.html""><i class=""zmdi zmdi-home""></i><span>Products</span></a></li>
            <li><a h");
                WriteLiteral(@"ref=""index.html""><i class=""zmdi zmdi-home""></i><span>Vouchers</span></a></li>
            <li><a href=""index.html""><i class=""zmdi zmdi-home""></i><span>Posts</span></a></li>
            <li><a href=""index.html""><i class=""zmdi zmdi-home""></i><span>Orders</span></a></li>
            <li><a href=""index.html""><i class=""zmdi zmdi-home""></i><span>Contact</span></a></li>
            
        </ul>
    </div>
</aside>



<section class=""content"">
        ");
                EndContext();
                BeginContext(2993, 12, false);
#line 76 "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Views\Shared\_Layout_Admin.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(3005, 487, true);
                WriteLiteral(@"
</section>
<!-- Jquery Core Js --> 
<script src=""/assets/bundles/libscripts.bundle.js""></script> <!-- Lib Scripts Plugin Js --> 
<script src=""/assets/bundles/vendorscripts.bundle.js""></script> <!-- Lib Scripts Plugin Js --> 

<script src=""/assets/bundles/footable.bundle.js""></script> <!-- Lib Scripts Plugin Js -->

<script src=""/assets/bundles/mainscripts.bundle.js""></script><!-- Custom Js -->
<script src=""/assets/js/pages/tables/footable.js""></script><!-- Custom Js --> 
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3499, 13, true);
            WriteLiteral("\r\n\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
