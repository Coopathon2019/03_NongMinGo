#pragma checksum "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\_MyProductThumbnail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a52018c097dcd862cae58922ec48bf18fe836ecd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_NongMinGo_Views_Shared__MyProductThumbnail), @"mvc.1.0.view", @"/Areas/NongMinGo/Views/Shared/_MyProductThumbnail.cshtml")]
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
#nullable restore
#line 1 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\_ViewImports.cshtml"
using SimplCommerce.Module.Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a52018c097dcd862cae58922ec48bf18fe836ecd", @"/Areas/NongMinGo/Views/Shared/_MyProductThumbnail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9d0c0ec1d4e2cd2b667a8d34e400704aff8147b", @"/Areas/NongMinGo/Views/_ViewImports.cshtml")]
    public class Areas_NongMinGo_Views_Shared__MyProductThumbnail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimplCommerce.Module.Catalog.Areas.Catalog.ViewModels.ProductThumbnail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success mt-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card mb-4\">\r\n    <input type=\"hidden\" id=\"productId\"");
            BeginWriteAttribute("value", " value=\"", 145, "\"", 162, 1);
#nullable restore
#line 4 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\_MyProductThumbnail.cshtml"
WriteAttributeValue("", 153, Model.Id, 153, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <img");
            BeginWriteAttribute("alt", " alt=\"", 184, "\"", 201, 1);
#nullable restore
#line 5 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\_MyProductThumbnail.cshtml"
WriteAttributeValue("", 190, Model.Name, 190, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 223, "\"", 248, 1);
#nullable restore
#line 5 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\_MyProductThumbnail.cshtml"
WriteAttributeValue("", 229, Model.ThumbnailUrl, 229, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title product-name\">");
#nullable restore
#line 7 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\_MyProductThumbnail.cshtml"
                                               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-text product-price\">\r\n");
#nullable restore
#line 9 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\_MyProductThumbnail.cshtml"
                     if (Model.IsCallForPricing)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\_MyProductThumbnail.cshtml"
                   Write(Localizer["Call for pricing"]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\_MyProductThumbnail.cshtml"
                                                      
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\_MyProductThumbnail.cshtml"
                   Write(Model.CalculatedProductPrice.PriceString);

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\_MyProductThumbnail.cshtml"
                                                                 
                        if (Model.CalculatedProductPrice.PercentOfSaving > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"product-price-saving\">-");
#nullable restore
#line 18 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\_MyProductThumbnail.cshtml"
                                                            Write(Model.CalculatedProductPrice.PercentOfSaving);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n                            <br />\r\n                            <span class=\"product-price-regular\">");
#nullable restore
#line 20 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\_MyProductThumbnail.cshtml"
                                                           Write(Model.CalculatedProductPrice.OldPriceString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 21 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\_MyProductThumbnail.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </p>
                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""card"">
                            <div class=""card-header"" id=""cardBrandHeader"">
                                <h5 class=""mb-0"">
                                    ");
#nullable restore
#line 29 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\_MyProductThumbnail.cshtml"
                               Write(Localizer["ProductManagementDetail"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </h5>\r\n                            </div>\r\n                            <div class=\"show\">\r\n                                <div class=\"card-body\"");
            BeginWriteAttribute("style", " style=\'", 1635, "\'", 1721, 2);
            WriteAttributeValue("", 1643, "background-color:", 1643, 17, true);
#nullable restore
#line 33 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\_MyProductThumbnail.cshtml"
WriteAttributeValue(" ", 1660, Model.IsPublished ? "lightgreen" : "lightgoldenrodyellow", 1661, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 34 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\_MyProductThumbnail.cshtml"
                                Write(Model.IsPublished ? Localizer["This product is already been published"] : Localizer["This product is not yet been published"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <br />\r\n                                    ");
#nullable restore
#line 36 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\_MyProductThumbnail.cshtml"
                               Write(Localizer["Reviews"]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\_MyProductThumbnail.cshtml"
                                                    Write(Localizer["Count"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 36 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\_MyProductThumbnail.cshtml"
                                                                          Write(Model.ReviewsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <br />\r\n                                    ");
#nullable restore
#line 38 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\_MyProductThumbnail.cshtml"
                               Write(Localizer["Stock"]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\_MyProductThumbnail.cshtml"
                                                  Write(Localizer["Quantity"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 38 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\_MyProductThumbnail.cshtml"
                                                                           Write(Model.StockQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <br />\r\n                                    ");
#nullable restore
#line 40 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\_MyProductThumbnail.cshtml"
                               Write(Localizer["IsAllowToOrder"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 40 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\_MyProductThumbnail.cshtml"
                                                               Write(Model.IsAllowToOrder ? "Yes" : "No");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-md-12"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a52018c097dcd862cae58922ec48bf18fe836ecd14494", async() => {
#nullable restore
#line 48 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\_MyProductThumbnail.cshtml"
                                                                                Write(Localizer["User View"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("<i class=\"czi-arrow-right\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2642, "~/", 2642, 2, true);
#nullable restore
#line 48 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\_MyProductThumbnail.cshtml"
AddHtmlAttributeValue("", 2644, Model.Slug, 2644, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <a class=\"btn btn-outline-warning mt-1\"");
            BeginWriteAttribute("href", " href=\"", 2780, "\"", 2818, 2);
            WriteAttributeValue("", 2787, "/admin#!/product/edit/", 2787, 22, true);
#nullable restore
#line 49 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\_MyProductThumbnail.cshtml"
WriteAttributeValue("", 2809, Model.Id, 2809, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 49 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\_MyProductThumbnail.cshtml"
                                                                                                  Write(Localizer["Edit View"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("<i class=\"czi-arrow-right\"></i></a>\r\n                        <a class=\"btn btn-outline-secondary mt-1\" href=\"/admin#!/stocks\">");
#nullable restore
#line 50 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\_MyProductThumbnail.cshtml"
                                                                                    Write(Localizer["Stock"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ( ");
#nullable restore
#line 50 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\_MyProductThumbnail.cshtml"
                                                                                                          Write(Model.StockQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" )<i class=\"czi-arrow-right\"></i></a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration AppSetting { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimplCommerce.Module.Catalog.Areas.Catalog.ViewModels.ProductThumbnail> Html { get; private set; }
    }
}
#pragma warning restore 1591
