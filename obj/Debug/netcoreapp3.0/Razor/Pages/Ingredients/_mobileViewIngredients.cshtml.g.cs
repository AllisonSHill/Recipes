#pragma checksum "C:\Users\Allison\Documents\GitHub\RazorPagesRecipe\Pages\Ingredients\_mobileViewIngredients.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6baf108072a26529873106f1c324e1975cf1d6bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPagesRecipe.Pages.Ingredients.Pages_Ingredients__mobileViewIngredients), @"mvc.1.0.razor-page", @"/Pages/Ingredients/_mobileViewIngredients.cshtml")]
namespace RazorPagesRecipe.Pages.Ingredients
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Allison\Documents\GitHub\RazorPagesRecipe\Pages\_ViewImports.cshtml"
using RazorPagesRecipe;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6baf108072a26529873106f1c324e1975cf1d6bd", @"/Pages/Ingredients/_mobileViewIngredients.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1785680adb6e21003be4201a659becea4b67ee5a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Ingredients__mobileViewIngredients : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<td>\r\n    ");
#nullable restore
#line 5 "C:\Users\Allison\Documents\GitHub\RazorPagesRecipe\Pages\Ingredients\_mobileViewIngredients.cshtml"
Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</td>\r\n<td>\r\n    <b>Amount/Serving:</b> ");
#nullable restore
#line 8 "C:\Users\Allison\Documents\GitHub\RazorPagesRecipe\Pages\Ingredients\_mobileViewIngredients.cshtml"
                      Write(Html.DisplayFor(model => model.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    <b>Instructions:</b> ");
#nullable restore
#line 9 "C:\Users\Allison\Documents\GitHub\RazorPagesRecipe\Pages\Ingredients\_mobileViewIngredients.cshtml"
                    Write(Html.DisplayFor(model => model.Instructions));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</td>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPagesRecipe.Models.Ingredient> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesRecipe.Models.Ingredient> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesRecipe.Models.Ingredient>)PageContext?.ViewData;
        public RazorPagesRecipe.Models.Ingredient Model => ViewData.Model;
    }
}
#pragma warning restore 1591