using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreSeminerWeb
{
    [HtmlTargetElement("paging")]
    public class PagingTagHelper : TagHelper
    {
        [HtmlAttributeName("for-pagenumber")]
        public int PageNumber { get; set; }
        [HtmlAttributeName("for-pagecount")]
        public int PageCount { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagMode = TagMode.StartTagAndEndTag;
            output.TagName = "paging";
            StringBuilder htmlBuilder = new StringBuilder();
            for (int index = 0; index < this.PageCount; index++)
            {
                if (this.PageNumber == index)
                {
                    htmlBuilder.AppendLine($"<a href = \"/Product/Index/{index}\" class=\"btn btn-success\">{index + 1}</a>");
                }
                else
                {
                    htmlBuilder.AppendLine($"<a href = \"/Product/Index/{index}\" class=\"btn btn-primary\">{index + 1}</a>");
                }
            }
            output.PreContent.SetHtmlContent(htmlBuilder.ToString());
        }
    }
}
