#pragma checksum "D:\software engineering\вту софтуерно инженерство\1-ви курс\2-ри семестър\Уеб програмиране с .NET\Упражнения\PicturesShop mvc web asp net\PicturesShop\PicturesShop\Views\Admin\FindOrderById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39903a2f20280a7d70007fb0d7945c07a3b8151d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_FindOrderById), @"mvc.1.0.view", @"/Views/Admin/FindOrderById.cshtml")]
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
#nullable restore
#line 1 "D:\software engineering\вту софтуерно инженерство\1-ви курс\2-ри семестър\Уеб програмиране с .NET\Упражнения\PicturesShop mvc web asp net\PicturesShop\PicturesShop\Views\_ViewImports.cshtml"
using PicturesShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\software engineering\вту софтуерно инженерство\1-ви курс\2-ри семестър\Уеб програмиране с .NET\Упражнения\PicturesShop mvc web asp net\PicturesShop\PicturesShop\Views\_ViewImports.cshtml"
using PicturesShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39903a2f20280a7d70007fb0d7945c07a3b8151d", @"/Views/Admin/FindOrderById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"451189177e7713211cc6d71f1e21549ef78eb7c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_FindOrderById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PicturesShop.Models.PictureController.EditPicture>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\software engineering\вту софтуерно инженерство\1-ви курс\2-ри семестър\Уеб програмиране с .NET\Упражнения\PicturesShop mvc web asp net\PicturesShop\PicturesShop\Views\Admin\FindOrderById.cshtml"
  
    ViewData["ActivePage"] = "FindOrderById";
    ViewData["ActiveTab"] = "Orders";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"mt-3 mr-3 ml-3\">\r\n    <h4>Find order by Id</h4>\r\n    <hr>\r\n    <label for=\"id\">Order Id</label>\r\n    <input type=\"number\" id=\"id\" class=\"form-control\">\r\n    <button class=\"btn btn-primary mt-3\" onclick=\"findOrder()\">Find order</button>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PicturesShop.Models.PictureController.EditPicture> Html { get; private set; }
    }
}
#pragma warning restore 1591
