#pragma checksum "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Areas\Admin\Views\Vouchers\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b06436ee90fdd4fe38be6eb488b6696300b50f9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Vouchers_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/Vouchers/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Vouchers/Delete.cshtml", typeof(AspNetCore.Areas_Admin_Views_Vouchers_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b06436ee90fdd4fe38be6eb488b6696300b50f9d", @"/Areas/Admin/Views/Vouchers/Delete.cshtml")]
    public class Areas_Admin_Views_Vouchers_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<uit_project_framework.Models.Voucher>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Areas\Admin\Views\Vouchers\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout_Admin.cshtml";

#line default
#line hidden
            BeginContext(142, 168, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Voucher</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(311, 47, false);
#line 16 "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Areas\Admin\Views\Vouchers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VoucherCode));

#line default
#line hidden
            EndContext();
            BeginContext(358, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(402, 43, false);
#line 19 "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Areas\Admin\Views\Vouchers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VoucherCode));

#line default
#line hidden
            EndContext();
            BeginContext(445, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(489, 41, false);
#line 22 "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Areas\Admin\Views\Vouchers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Money));

#line default
#line hidden
            EndContext();
            BeginContext(530, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(574, 37, false);
#line 25 "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Areas\Admin\Views\Vouchers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Money));

#line default
#line hidden
            EndContext();
            BeginContext(611, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(655, 42, false);
#line 28 "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Areas\Admin\Views\Vouchers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(697, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(741, 38, false);
#line 31 "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Areas\Admin\Views\Vouchers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(779, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(823, 45, false);
#line 34 "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Areas\Admin\Views\Vouchers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(868, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(912, 41, false);
#line 37 "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Areas\Admin\Views\Vouchers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(953, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(997, 45, false);
#line 40 "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Areas\Admin\Views\Vouchers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(1042, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1086, 41, false);
#line 43 "C:\Users\Admin\uit\dotnet\uit-project-framework\uit-project-framework\Areas\Admin\Views\Vouchers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(1127, 262, true);
            WriteLiteral(@"
        </dd>
    </dl>
    
    <form asp-action=""Delete"">
        <input type=""hidden"" asp-for=""VoucherId"" />
        <input type=""submit"" value=""Delete"" class=""btn btn-default"" /> |
        <a asp-action=""Index"">Back to List</a>
    </form>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<uit_project_framework.Models.Voucher> Html { get; private set; }
    }
}
#pragma warning restore 1591
