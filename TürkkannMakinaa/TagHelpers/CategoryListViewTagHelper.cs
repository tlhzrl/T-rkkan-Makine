using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TürkkannMakinaa.Entities;

namespace TürkkannMakinaa.TagHelpers
{
    [HtmlTargetElement("app-category-list-view")]
    public class CategoryListViewTagHelper : TagHelper
    {
        private readonly ApplicationDbContext _db;

        public CategoryListViewTagHelper(ApplicationDbContext db )
        {
            _db = db;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var categoryList = _db.Category.ToList();

            output.TagName = "li";
            output.Content.AppendHtml($"<a href='/Product/Product/00'> Ürünler <i class='ti-angle-down'></i></a>");

            var ul = new TagBuilder("ul");
            ul.AddCssClass("submenu");

            foreach (var CategoryItem in categoryList)
            {
                var li = new TagBuilder("li");
                li.InnerHtml.AppendHtml($"<a href='/Product/Product/{CategoryItem.Id}'>{CategoryItem.CategoryName}</a>");

                ul.InnerHtml.AppendHtml(li);
            }

            output.Content.AppendHtml(ul);


            base.Process(context, output);

        }
    }
}
