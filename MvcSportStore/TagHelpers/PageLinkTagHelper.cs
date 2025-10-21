using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MvcSportStore.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("page-link",Attributes="id")]
    public class PageLinkTagHelper : TagHelper
    {
        public int Id { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = null;
            string content = @"<span style='float:left;width:50px'>";
            content += $@"<a class='btn border border-secondary m-1' href='/Home/Index/{Id}'>{Id}</a>";
            content += @"</span>";

            output.Content.SetHtmlContent(content);
        }

        
    }
}
