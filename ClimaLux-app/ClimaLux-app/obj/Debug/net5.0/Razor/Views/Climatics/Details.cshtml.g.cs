#pragma checksum "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0abe42ed81acf04fd396930959908181f395f17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Climatics_Details), @"mvc.1.0.view", @"/Views/Climatics/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0abe42ed81acf04fd396930959908181f395f17", @"/Views/Climatics/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5be273c33f759be74d9b19dd69b998c67624e202", @"/Views/_ViewImports.cshtml")]
    public class Views_Climatics_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Climatic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Details.cshtml"
  
    ViewData["Title"] = "Детайли за продукта";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"my-4\">\r\n    ");
#nullable restore
#line 8 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Details.cshtml"
Write(Model.Brand.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 8 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Details.cshtml"
                 Write(Model.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h1>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-8\">\r\n        <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 217, "\"", 238, 1);
#nullable restore
#line 13 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Details.cshtml"
WriteAttributeValue("", 223, Model.ImageUrl, 223, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 239, "\"", 245, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n\r\n    <div class=\"col-md-4\">\r\n        <h3 class=\"my-3\">Характеристики</h3>\r\n        <ul>\r\n            <li>Производител: ");
#nullable restore
#line 19 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Details.cshtml"
                         Write(Model.Brand.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>Модел: ");
#nullable restore
#line 20 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Details.cshtml"
                  Write(Model.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>Категория: ");
#nullable restore
#line 21 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Details.cshtml"
                      Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>Произход: ");
#nullable restore
#line 22 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Details.cshtml"
                     Write(Model.Origin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>Хладилен агент: ");
#nullable restore
#line 23 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Details.cshtml"
                           Write(Model.CoolAgent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>Ниво шум вътрешно тяло: ");
#nullable restore
#line 24 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Details.cshtml"
                                   Write(Model.NoiseLevelInside);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>Ниво шум външно тяло: ");
#nullable restore
#line 25 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Details.cshtml"
                                 Write(Model.NoiseLevelOutside);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>Консумирана мощност на охлаждане(kW): ");
#nullable restore
#line 26 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Details.cshtml"
                                                 Write(Model.CoolingKWPower);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>Консумирана мощност на отопление(kW): ");
#nullable restore
#line 27 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Details.cshtml"
                                                 Write(Model.HeatingKWPower);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>Мощност: ");
#nullable restore
#line 28 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Details.cshtml"
                    Write(Model.BtuPower.Power);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>Енергиен клас охлаждане: ");
#nullable restore
#line 29 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Details.cshtml"
                                    Write(Model.EnergyClassCooling.CoolClass);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>Енергиен клас отопление: ");
#nullable restore
#line 30 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Details.cshtml"
                                    Write(Model.EnergyClassHeating.HeatClass);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>Размер помещение: ");
#nullable restore
#line 31 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Details.cshtml"
                             Write(Model.RoomSize.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>Гаранция: ");
#nullable restore
#line 32 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Details.cshtml"
                     Write(Model.Waranty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>Price: ");
#nullable restore
#line 33 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Details.cshtml"
                  Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        </ul>\r\n\r\n        <h3 class=\"my-3\">Описание</h3>\r\n        <p>");
#nullable restore
#line 37 "C:\Users\Valentin\Desktop\c#\ClimaLux-app\CLimaLux-app\ClimaLux-app\ClimaLux-app\Views\Climatics\Details.cshtml"
      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        <h3 class=\"my-3\">Поръчай този продукт</h3>\r\n        <p>Тел: +35900007 </p>\r\n        <p>Facebook: <a href=\"https://www.facebook.com/klimaticipazardjik\">Clima Lux</a></p>\r\n\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Climatic> Html { get; private set; }
    }
}
#pragma warning restore 1591
