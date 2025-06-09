using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Identity.Client;
using Microsoft.VisualBasic;

namespace MyShop.TagHelpers;

public class CurrentDateTimeTagHelper : TagHelper
{
    public string DateFormat { get; set; }
    public string OutputTag { get; set; } = "span";
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = OutputTag;
        output.TagMode = TagMode.StartTagAndEndTag;

        var currentTime = DateTime.Now;
        var formattedTime = string.Empty;
        if (string.IsNullOrEmpty(DateFormat))
        {
            formattedTime = currentTime.ToString("dd-MM-yyyy HH:mm:ss");
        }
        else
        {
            try
            {
                formattedTime = currentTime.ToString(DateFormat);
            }
            catch (Exception)
            {
                formattedTime = $"{currentTime.ToString("dd-MM-yyyy HH:mm:ss")} (Błędny format: {DateFormat})";
            }
        }
        output.Content.SetHtmlContent(formattedTime);
    }
}
