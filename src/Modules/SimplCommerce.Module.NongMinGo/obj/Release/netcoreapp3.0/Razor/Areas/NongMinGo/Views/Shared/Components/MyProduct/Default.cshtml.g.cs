#pragma checksum "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\Components\MyProduct\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80ade6684c4825a9b539eae394609a2c815ca1bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_NongMinGo_Views_Shared_Components_MyProduct_Default), @"mvc.1.0.view", @"/Areas/NongMinGo/Views/Shared/Components/MyProduct/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80ade6684c4825a9b539eae394609a2c815ca1bf", @"/Areas/NongMinGo/Views/Shared/Components/MyProduct/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9d0c0ec1d4e2cd2b667a8d34e400704aff8147b", @"/Areas/NongMinGo/Views/_ViewImports.cshtml")]
    public class Areas_NongMinGo_Views_Shared_Components_MyProduct_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimplCommerce.Module.Catalog.Areas.Catalog.ViewModels.ProductsByBrand>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_MyProductThumbnail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style type=""text/css"">
    .page-header {
        padding-bottom: 9px;
        margin: 20px 0 30px;
        border-bottom: 1px solid #eeeeee;
        color: black;
    }

        .page-header small {
            color: lightgray;
        }
</style>


<div class=""page-header"">
    <div class=""row"">
        <div class=""col-xs-6 col-md-4"">
            <h3>
                ");
#nullable restore
#line 22 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\Components\MyProduct\Default.cshtml"
           Write(Localizer["My Agricultural Product"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <small> ");
#nullable restore
#line 22 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\Components\MyProduct\Default.cshtml"
                                                         Write(Localizer["all your agricultural products"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n            </h3>\r\n        </div>\r\n        <div class=\"col-xs-6 col-md-6\">\r\n");
            WriteLiteral("\r\n            <div class=\"line-it-button\" data-lang=\"zh_Hant\" data-type=\"share-a\" data-ver=\"3\" data-url=\"https://www.nongmingo.com/ui/");
#nullable restore
#line 37 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\Components\MyProduct\Default.cshtml"
                                                                                                                                Write(Model.BrandId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" data-color=""default"" data-size=""small"" data-count=""false"" style=""display: none;""></div>
            <script src=""https://d.line-scdn.net/r/web/social-plugin/js/thirdparty/loader.min.js"" async=""async"" defer=""defer""></script>

            <div class=""fb-share-button"" data-href=""https://www.nongmingo.com/ui/");
#nullable restore
#line 40 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\Components\MyProduct\Default.cshtml"
                                                                             Write(Model.BrandId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-layout=\"button\" data-size=\"small\">\r\n                <a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 1697, "\"", 1824, 3);
            WriteAttributeValue("", 1704, "https://www.facebook.com/sharer/sharer.php?u=https%3A%2F%2Fwww.nongmingo.com%2Fui%2F", 1704, 84, true);
#nullable restore
#line 41 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\Components\MyProduct\Default.cshtml"
WriteAttributeValue("", 1788, Model.BrandId, 1788, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1804, "&amp;src=sdkpreparse", 1804, 20, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"fb-xfbml-parse-ignore\">分享</a>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-xs-6 col-md-2\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80ade6684c4825a9b539eae394609a2c815ca1bf8680", async() => {
#nullable restore
#line 45 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\Components\MyProduct\Default.cshtml"
                                                                  Write(Localizer["go to management hall"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("<i class=\"czi-arrow-right\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
    </div>

<div class=""row"">

    <div class=""col-xs-6 col-md-4"">
        <div class=""card mb-4"">
            <a href=""/admin#!/product-create"">
                <img alt=""addnewoneicon.png"" class=""card-img-top"" src=""/public/images/products/addnewoneicon.png"">
                <div class=""card-body"">
                    <h5 class=""card-title product-name"">");
#nullable restore
#line 57 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\Components\MyProduct\Default.cshtml"
                                                   Write(Localizer["Create your new product"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                </div>\r\n            </a>\r\n        </div>\r\n    </div>\r\n\r\n");
#nullable restore
#line 63 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\Components\MyProduct\Default.cshtml"
     foreach (var product in Model.Products)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-xs-6 col-md-4\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "80ade6684c4825a9b539eae394609a2c815ca1bf11475", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 66 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\Components\MyProduct\Default.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = product;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 68 "D:\CodingWork\Projects\NongMinGoProject\SimplCommerce\src\Modules\SimplCommerce.Module.NongMinGo\Areas\NongMinGo\Views\Shared\Components\MyProduct\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration AppSetting { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimplCommerce.Module.Catalog.Areas.Catalog.ViewModels.ProductsByBrand> Html { get; private set; }
    }
}
#pragma warning restore 1591
