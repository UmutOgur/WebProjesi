using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreSeminerWeb
{
    public static class BoldTextHtmlHelper
    {
        public static IHtmlContent BoldText(this IHtmlHelper content, string text)
        {
            return new HtmlString($"<strong style=\"color:red\">{text}</strong>");
        }
    }
}
