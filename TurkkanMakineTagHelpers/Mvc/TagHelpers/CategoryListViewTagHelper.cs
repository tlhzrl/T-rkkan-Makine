using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace TurkkanMakineTagHelpers.Mvc.TagHelpers
{
    [HtmlTargetElement("category-list-view", Attributes = "items")]
    public class CategoryListViewTagHelper: TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);
        }
    }
}
