#pragma checksum "C:\Users\muham\OneDrive\Masaüstü\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\Products\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8b965bd492edc8df37805cd009f2ffa1f5a4bb8"
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
#line 5 "C:\Users\muham\OneDrive\Masaüstü\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\_ViewImports.cshtml"
using TürkkannMakinaa.Areas.Admin.Page.Categories;

#line default
#line hidden
#line 6 "C:\Users\muham\OneDrive\Masaüstü\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\_ViewImports.cshtml"
using TürkkannMakinaa.Areas.Admin.Page.Products;

#line default
#line hidden
#line 7 "C:\Users\muham\OneDrive\Masaüstü\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\_ViewImports.cshtml"
using TürkkannMakinaa.Areas.Admin.Page.Employee;

#line default
#line hidden
#line 8 "C:\Users\muham\OneDrive\Masaüstü\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\_ViewImports.cshtml"
using NonFactors.Mvc.Grid;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8b965bd492edc8df37805cd009f2ffa1f5a4bb8", @"/Areas/Admin/Pages/Products/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fded1a3bd1ab100a6e2d46ed9e6960206e8db780", @"/Areas/Admin/Pages/_ViewImports.cshtml")]
    public class Areas_Admin_Pages_Products_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "file", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "AddPhotos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(75, 27, true);
            WriteLiteral("<div style=\"\"></div>\r\n<div>");
            EndContext();
            BeginContext(103, 19, false);
#line 6 "C:\Users\muham\OneDrive\Masaüstü\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\Products\List.cshtml"
Write(TempData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(122, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            BeginContext(134, 1427, false);
#line 8 "C:\Users\muham\OneDrive\Masaüstü\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\Products\List.cshtml"
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
        .Encoded(false).RenderedAs(model => $"<a class='btn btn-info' href='/Product/Detail/{model.Id}'>Detay</a>").Sortable(false).Filterable(false);

        columns.Add(model => model.MainPhoto).Titled("Action")
                    .Encoded(false).RenderedAs(model => $"<a class='btn btn-primary' href='#AddPhotoModal_{model.Id}' data-toggle='modal'>Fotograf Ekle</a>").Sortable(false).Filterable(false);

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
            BeginContext(1562, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 38 "C:\Users\muham\OneDrive\Masaüstü\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\Products\List.cshtml"
 foreach (var item in Model.ProductList)
{

#line default
#line hidden
            BeginContext(1613, 8, true);
            WriteLiteral("    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1621, "\"", 1648, 2);
            WriteAttributeValue("", 1626, "AddPhotoModal_", 1626, 14, true);
#line 40 "C:\Users\muham\OneDrive\Masaüstü\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\Products\List.cshtml"
WriteAttributeValue("", 1640, item.Id, 1640, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1649, 327, true);
            WriteLiteral(@" class=""modal fade"" role=""dialog"">

        <div class=""modal-dialog"">

            Modal content
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                    <h4 class=""modal-title"">");
            EndContext();
            BeginContext(1977, 9, false);
#line 48 "C:\Users\muham\OneDrive\Masaüstü\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\Products\List.cshtml"
                                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1986, 114, true);
            WriteLiteral(" - Fotoğrafları</h4>\r\n                </div>\r\n                <div class=\"modal-body\">\r\n\r\n\r\n\r\n                    ");
            EndContext();
            BeginContext(2100, 778, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bc588040d2e4aa0a15b57a255c10610", async() => {
                BeginContext(2150, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 56 "C:\Users\muham\OneDrive\Masaüstü\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\Products\List.cshtml"
                          
                            Model.SelectedProductId = item.Id;
                        

#line default
#line hidden
                BeginContext(2273, 61, true);
                WriteLiteral("\r\n                        <div>\r\n                            ");
                EndContext();
                BeginContext(2334, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7d5118c418084c7b97c9adb0cb886c29", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 61 "C:\Users\muham\OneDrive\Masaüstü\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\Products\List.cshtml"
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
                BeginContext(2385, 78, true);
                WriteLiteral("\r\n                            &nbsp;&nbsp;&nbsp;\r\n                            ");
                EndContext();
                BeginContext(2463, 29, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4a43ca9363f4c4fb8d9a10e2eb60c3c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2492, 114, true);
                WriteLiteral("\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            ");
                EndContext();
                BeginContext(2606, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7200096b944c4f03bb7921eef2a2c23d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("multiple", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#line 67 "C:\Users\muham\OneDrive\Masaüstü\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\Products\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.files);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2671, 60, true);
                WriteLiteral("\r\n                        </div>\r\n\r\n                        ");
                EndContext();
                BeginContext(2731, 116, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "027a6ea88b344219bb95b8b400aa1c5f", async() => {
                    BeginContext(2806, 32, true);
                    WriteLiteral("<i class=\"fa fa-save\">Kaydet</i>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2847, 24, true);
                WriteLiteral("\r\n\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2878, 80, true);
            WriteLiteral("\r\n\r\n                </div>\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 80 "C:\Users\muham\OneDrive\Masaüstü\TürkkannMakinaa\TürkkannMakinaa\Areas\Admin\Pages\Products\List.cshtml"
}

#line default
#line hidden
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
