using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using TurkkanMakineTagHelpers.Enums;

namespace TurkkanMakineTagHelpers.Mvc.TagHelpers
{
    [HtmlTargetElement("currency-selector", Attributes = "model-for")]
    public class CurrencyTagHelper:TagHelper
    {
        public ModelExpression ModelFor{ get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.Add("class", "form-control");
            output.TagName = "select";

            string selected = this.ModelFor.Model as string;

            var currencyList = Enum.GetValues(typeof(CurrencyEnum));

            foreach (int currencyItem in currencyList)
            {
                output.Content.AppendHtml($"<option>{((CurrencyEnum)currencyItem).ToString()}</option>");
            }

            output.Attributes.SetAttribute("Name", this.ModelFor.Name);
            output.Attributes.SetAttribute("Id", this.ModelFor.Name);
            
            base.Process(context, output);
        }
    }
}
