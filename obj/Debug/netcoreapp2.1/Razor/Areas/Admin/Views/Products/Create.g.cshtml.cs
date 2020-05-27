#pragma checksum "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Areas\Admin\Views\Products\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e03d4aaa0e7b96b510fdd3f61f82493dd84209e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Products_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/Products/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Products/Create.cshtml", typeof(AspNetCore.Areas_Admin_Views_Products_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e03d4aaa0e7b96b510fdd3f61f82493dd84209e7", @"/Areas/Admin/Views/Products/Create.cshtml")]
    public class Areas_Admin_Views_Products_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<uit_project_framework.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Areas\Admin\Views\Products\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(136, 2399, true);
            WriteLiteral(@"
<h2>Create</h2>

<h4>Product</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""ProductName"" class=""control-label""></label>
                <input asp-for=""ProductName"" class=""form-control"" />
                <span asp-validation-for=""ProductName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Image"" class=""control-label""></label>
                <input asp-for=""Image"" class=""form-control"" />
                <span asp-validation-for=""Image"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Unit"" class=""control-label""></label>
                <input asp-for=""Unit"" class=""form-control"" />
                <span asp-validation-for=""Unit"" class=""text-danger""></span>
      ");
            WriteLiteral(@"      </div>
            <div class=""form-group"">
                <label asp-for=""Price"" class=""control-label""></label>
                <input asp-for=""Price"" class=""form-control"" />
                <span asp-validation-for=""Price"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CategoryID"" class=""control-label""></label>
                <input asp-for=""CategoryID"" class=""form-control"" />
                <span asp-validation-for=""CategoryID"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CreatedAt"" class=""control-label""></label>
                <input asp-for=""CreatedAt"" class=""form-control"" />
                <span asp-validation-for=""CreatedAt"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""UpdatedAt"" class=""control-label""></label>
                <input asp-for=""UpdatedAt"" class=""form-co");
            WriteLiteral(@"ntrol"" />
                <span asp-validation-for=""UpdatedAt"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-default"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<uit_project_framework.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
