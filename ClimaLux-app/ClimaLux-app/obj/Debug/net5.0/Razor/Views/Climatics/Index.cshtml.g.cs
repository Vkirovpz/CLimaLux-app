#pragma checksum "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2153331274e8bbcf096bd8c61ae4ec7c5e31e0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Climatics_Index), @"mvc.1.0.view", @"/Views/Climatics/Index.cshtml")]
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
#line 1 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\_ViewImports.cshtml"
using ClimaLux_app;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\_ViewImports.cshtml"
using ClimaLux_app.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\_ViewImports.cshtml"
using ClimaLux_app.Models.Climatics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\_ViewImports.cshtml"
using ClimaLux_Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2153331274e8bbcf096bd8c61ae4ec7c5e31e0a", @"/Views/Climatics/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5be273c33f759be74d9b19dd69b998c67624e202", @"/Views/_ViewImports.cshtml")]
    public class Views_Climatics_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Climatic>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-white float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Index.cshtml"
  
    ViewData["Title"] = "All climas";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div>
    <img src=""https://cdn5.focus.bg/bazar/0c/original/0c842720d2b539af3a9b71da8766d90d.jpg"" alt=""ClimaLuxLogo"">
</div>
<div class=""row banner-blocks-container banner-block-34213"">
    <div class=""col-sm-12 col-sm-4 col-md-4"">
        <div class=""banner-item is_a_link"">
            <div class=""banner-image"">
                <img src=""https://eclima.bg/image/cache/catalog/design/Icons/Free_Delivery_icons-50x50.png"" alt=""Безплатна доставка"">
            </div>
            <div class=""banner-info"">
                <div class=""banner-title"">Безплатна доставка</div>
                <div class=""banner-description"">Всички климатици се доставят безплатно</div>
            </div>
        </div>
    </div>
    <div class=""col-sm-12 col-sm-4 col-md-4"">
        <div class=""banner-item "">
            <div class=""banner-image"">
                <img src=""https://eclima.bg/image/cache/catalog/design/Icons/zashto_eclima-50x50.png"" alt=""Защо Клима Лукс"">
            </div>
            <div class=""banne");
            WriteLiteral(@"r-info"">
                <div class=""banner-title"">Защо Клима Лукс</div>
                <div class=""banner-description"">Сигурност, качество и професионализъм</div>
            </div>
        </div>
    </div>
    <div class=""col-sm-12 col-sm-4 col-md-4"">
        <div class=""banner-item "">
            <div class=""banner-image"">
                <img src=""https://eclima.bg/image/cache/catalog/design/Icons/0_procenta_lihva-50x50.png"" alt=""0% лихва"">
            </div>
            <div class=""banner-info"">
                <div class=""banner-title"">0% лихва</div>
                <div class=""banner-description"">Изплащане без оскъпяване</div>
            </div>
        </div>
    </div>
</div>

<div class=""row"">
");
#nullable restore
#line 46 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-md-4 col-xs-6 border-primary mb-3"">
            <div class=""card mb-3"" style=""max-width: 540px;"">
                <div class=""row g-0"">
                    <div class=""col-md-12"">
                        <div class=""card-header text-white bg-info"">
                            <p class=""card-text"">
                                <h5 class=""card-title"">
                                    ");
#nullable restore
#line 55 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Index.cshtml"
                               Write(item.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 56 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Index.cshtml"
                                     if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2153331274e8bbcf096bd8c61ae4ec7c5e31e0a8682", async() => {
                WriteLiteral("<i class=\"bi bi-pencil-square\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Index.cshtml"
                                                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 59 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </h5>\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 2852, "\"", 2872, 1);
#nullable restore
#line 65 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Index.cshtml"
WriteAttributeValue("", 2858, item.ImageUrl, 2858, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\"");
            BeginWriteAttribute("alt", " alt=\"", 2886, "\"", 2903, 1);
#nullable restore
#line 65 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Index.cshtml"
WriteAttributeValue("", 2892, item.Model, 2892, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        <div class=\"card-body\">\r\n                            <p class=\"card-text\">");
#nullable restore
#line 69 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Index.cshtml"
                                            Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><b>Cinema: </b></p>\r\n                            <p class=\"card-text\"><b>Category: </b>");
#nullable restore
#line 71 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Index.cshtml"
                                                             Write(item.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-12\">\r\n                        <div class=\"card-footer \">\r\n                            <p class=\"card-text\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2153331274e8bbcf096bd8c61ae4ec7c5e31e0a13505", async() => {
                WriteLiteral("\r\n                                    <i class=\"bi bi-eye-fill\"></i> Show Details\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Index.cshtml"
                                                                                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 87 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Climatic>> Html { get; private set; }
    }
}
#pragma warning restore 1591
