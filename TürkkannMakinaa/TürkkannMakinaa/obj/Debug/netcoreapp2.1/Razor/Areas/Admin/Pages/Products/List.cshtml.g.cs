#pragma checksum "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\Products\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e38f914d6192565239e6fd9b5a4c51a731de94b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Pages_Products_List), @"mvc.1.0.razor-page", @"/Areas/Admin/Pages/Products/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Admin/Pages/Products/List.cshtml", typeof(AspNetCore.Areas_Admin_Pages_Products_List), null)]
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
#line 5 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\_ViewImports.cshtml"
using TürkkannMakinaa.Areas.Admin.Page.Categories;

#line default
#line hidden
#line 6 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\_ViewImports.cshtml"
using TürkkannMakinaa.Areas.Admin.Page.Products;

#line default
#line hidden
#line 7 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\_ViewImports.cshtml"
using TürkkannMakinaa.Areas.Admin.Page.Employee;

#line default
#line hidden
#line 8 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\_ViewImports.cshtml"
using NonFactors.Mvc.Grid;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e38f914d6192565239e6fd9b5a4c51a731de94b6", @"/Areas/Admin/Pages/Products/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fded1a3bd1ab100a6e2d46ed9e6960206e8db780", @"/Areas/Admin/Pages/_ViewImports.cshtml")]
    public class Areas_Admin_Pages_Products_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "file", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "AddPhotos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/img/svg_icon/close.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:20px; text-decoration:none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(75, 27, true);
            WriteLiteral("<div style=\"\"></div>\r\n<div>");
            EndContext();
            BeginContext(103, 19, false);
#line 6 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\Products\List.cshtml"
Write(TempData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(122, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            BeginContext(134, 1696, false);
#line 8 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\Products\List.cshtml"
Write(Html

    .Grid(Model.ProductList)
    .Build(columns =>
    {
        columns.Add(model => model.UnitPrice).Titled("Fiyatı");
        columns.Add(model => model.Name).Titled("Kategori Adı");

        columns.Add(model => model.Currency).Titled("Para Birimi");
        columns.Add(model => model.MainPhoto).Titled("Fotoğrafı")
        .Encoded(false).RenderedAs(model => "<img style='max-height:76px;min-height:75px;max-width:51px;min-width:50px' src='data:image/jpeg;base64," + model.MainPhoto + "'/>").Sortable(false).Filterable(false);
        columns.Add(model => model.MainPhoto).Titled("Action")
        .Encoded(false).RenderedAs(model => $"<a class='btn btn-warning' href='/Admin/Products/Delete/{model.Id}'>Sil</a>").Sortable(false).Filterable(false);

        columns.Add(model => model.MainPhoto).Titled("Action")
                    .Encoded(false).RenderedAs(model => $"<a class='btn btn-primary' href='#AddPhotoModal_{model.Id}' data-toggle='modal'>Fotograf Ekle</a>").Sortable(false).Filterable(false);
        columns.Add(model => model.MainPhoto).Titled("Action")
                    .Encoded(false).RenderedAs(model => $"<a class='btn btn-primary' href='#EditPhotoModal_{model.Id}' data-toggle='modal'>Fotograf Güncelle</a>").Sortable(false).Filterable(false);
        columns.Add(model => model.MainPhoto).Titled("Action")
                    .Encoded(false).RenderedAs(model => $"<a class='btn btn-primary' href='/Admin/Products/Edit/{model.Id}' data-toggle='modal'>Ürün Güncelle</a>").Sortable(false).Filterable(false);

    })
    .Empty("No data found")
    .Filterable()
    .Sortable()
    .Pageable(pager => { pager.PagesToDisplay = 10; })


);

#line default
#line hidden
            EndContext();
            BeginContext(1831, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 39 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\Products\List.cshtml"
 foreach (var item in Model.ProductList)
{

#line default
#line hidden
            BeginContext(1882, 8, true);
            WriteLiteral("    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1890, "\"", 1917, 2);
            WriteAttributeValue("", 1895, "AddPhotoModal_", 1895, 14, true);
#line 41 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\Products\List.cshtml"
WriteAttributeValue("", 1909, item.Id, 1909, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1918, 327, true);
            WriteLiteral(@" class=""modal fade"" role=""dialog"">

        <div class=""modal-dialog"">

            Modal content
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                    <h4 class=""modal-title"">");
            EndContext();
            BeginContext(2246, 9, false);
#line 49 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\Products\List.cshtml"
                                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2255, 114, true);
            WriteLiteral(" - Fotoğrafları</h4>\r\n                </div>\r\n                <div class=\"modal-body\">\r\n\r\n\r\n\r\n                    ");
            EndContext();
            BeginContext(2369, 721, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d07b5e47fcb41ff807ce3630174bc96", async() => {
                BeginContext(2419, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 57 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\Products\List.cshtml"
                          
                            Model.SelectedProductId = item.Id;
                        

#line default
#line hidden
                BeginContext(2542, 61, true);
                WriteLiteral("\r\n                        <div>\r\n                            ");
                EndContext();
                BeginContext(2603, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "89d9da1948ed4128b0d47d03c2b84ac0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 62 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\Products\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SelectedProductId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2654, 164, true);
                WriteLiteral("\r\n                            &nbsp;&nbsp;&nbsp;\r\n\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            ");
                EndContext();
                BeginContext(2818, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c2c9ad50d4224f7986d2e1ecd3d27ae1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("multiple", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#line 68 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\Products\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.files);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2883, 60, true);
                WriteLiteral("\r\n                        </div>\r\n\r\n                        ");
                EndContext();
                BeginContext(2943, 116, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9fc3c3ef5cf413bafabbf13dc2fd338", async() => {
                    BeginContext(3018, 32, true);
                    WriteLiteral("<i class=\"fa fa-save\">Kaydet</i>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3059, 24, true);
                WriteLiteral("\r\n\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3090, 80, true);
            WriteLiteral("\r\n\r\n                </div>\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 81 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\Products\List.cshtml"
}

#line default
#line hidden
            BeginContext(3173, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
            EndContext();
#line 86 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\Products\List.cshtml"
 foreach (var item in Model.ProductList)
{

#line default
#line hidden
            BeginContext(3226, 8, true);
            WriteLiteral("    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3234, "\"", 3262, 2);
            WriteAttributeValue("", 3239, "EditPhotoModal_", 3239, 15, true);
#line 88 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\Products\List.cshtml"
WriteAttributeValue("", 3254, item.Id, 3254, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3263, 327, true);
            WriteLiteral(@" class=""modal fade"" role=""dialog"">

        <div class=""modal-dialog"">

            Modal content
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                    <h4 class=""modal-title"">");
            EndContext();
            BeginContext(3591, 9, false);
#line 96 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\Products\List.cshtml"
                                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3600, 119, true);
            WriteLiteral(" - Fotoğrafları</h4>\r\n                </div>\r\n                <div class=\"modal-body\">\r\n\r\n\r\n                    <div>\r\n");
            EndContext();
#line 102 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\Products\List.cshtml"
                         foreach (var photo_item in item.Photos)
                        {

#line default
#line hidden
            BeginContext(3812, 33, true);
            WriteLiteral("                            <span");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3845, "\"", 3868, 2);
            WriteAttributeValue("", 3850, "img_", 3850, 4, true);
#line 104 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\Products\List.cshtml"
WriteAttributeValue("", 3854, photo_item.Id, 3854, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3869, 93, true);
            WriteLiteral(">\r\n                                <img style=\"width:100px;height:100px; margin-bottom:20px;\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3962, "\"", 3987, 1);
#line 105 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\Products\List.cshtml"
WriteAttributeValue("", 3968, photo_item.FileUrl, 3968, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3988, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
            BeginContext(4055, 34, true);
            WriteLiteral("                                <a");
            EndContext();
            BeginWriteAttribute("onclick", "  onclick=\"", 4089, "\"", 4124, 3);
            WriteAttributeValue("", 4100, "Delete(\'", 4100, 8, true);
#line 107 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\Products\List.cshtml"
WriteAttributeValue("", 4108, photo_item.Id, 4108, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 4122, "\')", 4122, 2, true);
            EndWriteAttribute();
            BeginContext(4125, 29, true);
            WriteLiteral(" href=\"javascript:void(0);\"> ");
            EndContext();
            BeginContext(4154, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b01b2b654c8344adb2a82caae143f60c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4240, 44, true);
            WriteLiteral(" </a>\r\n                            </span>\r\n");
            EndContext();
#line 109 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\Products\List.cshtml"

                        }

#line default
#line hidden
            BeginContext(4313, 52, true);
            WriteLiteral("                    </div>\r\n\r\n\r\n                    ");
            EndContext();
            BeginContext(4365, 721, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2a2ee813c654b10809b2cdb98e49f59", async() => {
                BeginContext(4415, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 116 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\Products\List.cshtml"
                          
                            Model.SelectedProductId = item.Id;
                        

#line default
#line hidden
                BeginContext(4538, 61, true);
                WriteLiteral("\r\n                        <div>\r\n                            ");
                EndContext();
                BeginContext(4599, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9e4767e660fc49f5a17ca00e5fcf2f77", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 121 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\Products\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SelectedProductId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4650, 164, true);
                WriteLiteral("\r\n                            &nbsp;&nbsp;&nbsp;\r\n\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            ");
                EndContext();
                BeginContext(4814, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "97ef9928671449f890f8e84baf1e8e5b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("multiple", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#line 127 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\Products\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.files);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4879, 60, true);
                WriteLiteral("\r\n                        </div>\r\n\r\n                        ");
                EndContext();
                BeginContext(4939, 116, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f4471d7eb75471bb9e9c29f5d9ea02a", async() => {
                    BeginContext(5014, 32, true);
                    WriteLiteral("<i class=\"fa fa-save\">Kaydet</i>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5055, 24, true);
                WriteLiteral("\r\n\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5086, 80, true);
            WriteLiteral("\r\n\r\n                </div>\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 140 "C:\Users\muham\OneDrive\Masaüstü\program\TürkkannMakinaa\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\Products\List.cshtml"
}

#line default
#line hidden
            BeginContext(5169, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(5189, 524, true);
                WriteLiteral(@"

    <script>
        function Delete(photo_id) {

            $.ajax({
                url: '/Product/DeletePhoto/' + photo_id,
                method: 'GET',
                success: function (response) {
                    alert(response);
                    $('#img_' + photo_id).fadeOut();

                },
                error: function (err) {
                    console.log(err);
                }
            })
            //ajax
            //alert(photo_id);
        }
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TürkkannMakinaa.Areas.Admin.Pages.Products.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TürkkannMakinaa.Areas.Admin.Pages.Products.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TürkkannMakinaa.Areas.Admin.Pages.Products.ListModel>)PageContext?.ViewData;
        public TürkkannMakinaa.Areas.Admin.Pages.Products.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
