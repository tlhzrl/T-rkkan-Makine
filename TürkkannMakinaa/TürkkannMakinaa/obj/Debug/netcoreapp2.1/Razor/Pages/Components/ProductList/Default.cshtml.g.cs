#pragma checksum "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Pages\Components\ProductList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f96f725a11f1b4f61ca490e4558d924534bcf37b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Components_ProductList_Default), @"mvc.1.0.view", @"/Pages/Components/ProductList/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Components/ProductList/Default.cshtml", typeof(AspNetCore.Pages_Components_ProductList_Default))]
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
#line 1 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Pages\Components\ProductList\Default.cshtml"
using TürkkannMakinaa.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f96f725a11f1b4f61ca490e4558d924534bcf37b", @"/Pages/Components/ProductList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85009b9ff499b478fa0810f3fcf1b8e1cb2c27bb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Components_ProductList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductByCategoryVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(60, 43, true);
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <br />\r\n\r\n");
            EndContext();
#line 9 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Pages\Components\ProductList\Default.cshtml"
     if (!string.IsNullOrEmpty(Model.CategoryName))
    {

#line default
#line hidden
            BeginContext(163, 151, true);
            WriteLiteral("        <div class=\"row\" style=\"float:left;\">\r\n\r\n            <span>\r\n                <a>\r\n                    Toplam : <span class=\"badge badge-light\">");
            EndContext();
            BeginContext(315, 19, false);
#line 15 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Pages\Components\ProductList\Default.cshtml"
                                                        Write(Model.ProductCounts);

#line default
#line hidden
            EndContext();
            BeginContext(334, 85, true);
            WriteLiteral(" ürün mevcuttur !</span>\r\n                </a>\r\n            </span>\r\n        </div>\r\n");
            EndContext();
            BeginContext(421, 32, true);
            WriteLiteral("        <br />\r\n        <br />\r\n");
            EndContext();
#line 22 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Pages\Components\ProductList\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(460, 29, true);
            WriteLiteral("\r\n\r\n\r\n    <div class=\"row\">\r\n");
            EndContext();
#line 27 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Pages\Components\ProductList\Default.cshtml"
         foreach (var item in Model.Products)
        {

#line default
#line hidden
            BeginContext(547, 168, true);
            WriteLiteral("            <div class=\"col-sm-12 col-md-3\">\r\n                <div class=\"thumbnail\" style=\"height:350px !important\">\r\n                    <img style=\"max-height:100px\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 715, "\"", 759, 2);
            WriteAttributeValue("", 721, "data:image/jpeg;base64,", 721, 23, true);
#line 31 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Pages\Components\ProductList\Default.cshtml"
WriteAttributeValue("", 744, item.MainPhoto, 744, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(760, 84, true);
            WriteLiteral(" alt=\"...\">\r\n                    <div class=\"caption\">\r\n                        <h3>");
            EndContext();
            BeginContext(845, 9, false);
#line 33 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Pages\Components\ProductList\Default.cshtml"
                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(854, 64, true);
            WriteLiteral("</h3>\r\n                        <p>\r\n                            ");
            EndContext();
            BeginContext(919, 10, false);
#line 35 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Pages\Components\ProductList\Default.cshtml"
                       Write(item.Notes);

#line default
#line hidden
            EndContext();
            BeginContext(929, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(993, 98, true);
            WriteLiteral("                        </p>\r\n                        <p style=\"position:absolute; bottom:20px\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1091, "\"", 1129, 2);
            WriteAttributeValue("", 1098, "/Product/ProductDetail/", 1098, 23, true);
#line 39 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Pages\Components\ProductList\Default.cshtml"
WriteAttributeValue("", 1121, item.Id, 1121, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1130, 132, true);
            WriteLiteral(" class=\"btn btn-primary\" role=\"button\">Ürün Detayı</a></p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 43 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Pages\Components\ProductList\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(1273, 66, true);
            WriteLiteral("        <div class=\"clearfix\"></div>\r\n\r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductByCategoryVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
