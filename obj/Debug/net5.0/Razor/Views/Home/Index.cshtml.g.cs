#pragma checksum "D:\Mario USMP\ciclo VI\programacion I\pc03a\pc3b\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ffefde26d4587fddaf0b31404d814225269a369"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Mario USMP\ciclo VI\programacion I\pc03a\pc3b\Views\_ViewImports.cshtml"
using pc3b;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Mario USMP\ciclo VI\programacion I\pc03a\pc3b\Views\_ViewImports.cshtml"
using pc3b.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ffefde26d4587fddaf0b31404d814225269a369", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e9eeb96c962072ff73fab6478e1c6550222902a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Producto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Mario USMP\ciclo VI\programacion I\pc03a\pc3b\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <h1 class=\"display-4\">Lista de productos a la venta</h1>\r\n    \r\n\r\n");
#nullable restore
#line 11 "D:\Mario USMP\ciclo VI\programacion I\pc03a\pc3b\Views\Home\Index.cshtml"
     if (Model.Count == 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>No hay ningun producto.</p>\r\n");
#nullable restore
#line 13 "D:\Mario USMP\ciclo VI\programacion I\pc03a\pc3b\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n    //? esta al lado de un objeto significa q tiene q estar lleno para mostrar\r\n");
#nullable restore
#line 16 "D:\Mario USMP\ciclo VI\programacion I\pc03a\pc3b\Views\Home\Index.cshtml"
     foreach (var Producto in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <p>Nombre del producto: ");
#nullable restore
#line 17 "D:\Mario USMP\ciclo VI\programacion I\pc03a\pc3b\Views\Home\Index.cshtml"
                         Write(Producto.NameP);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <img class=\"img-responsive\" width=\"190\" height=\"200\"");
            BeginWriteAttribute("src", " src=\"", 458, "\"", 484, 2);
            WriteAttributeValue("", 464, "/img/", 464, 5, true);
#nullable restore
#line 18 "D:\Mario USMP\ciclo VI\programacion I\pc03a\pc3b\Views\Home\Index.cshtml"
WriteAttributeValue("", 469, Producto.Image, 469, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", "\r\n                                        alt=\"", 485, "\"", 547, 1);
#nullable restore
#line 19 "D:\Mario USMP\ciclo VI\programacion I\pc03a\pc3b\Views\Home\Index.cshtml"
WriteAttributeValue("", 532, Producto.Image, 532, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
            WriteLiteral("      <p>Descripcion: ");
#nullable restore
#line 22 "D:\Mario USMP\ciclo VI\programacion I\pc03a\pc3b\Views\Home\Index.cshtml"
                 Write(Producto.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n      <p>Precio: $");
#nullable restore
#line 23 "D:\Mario USMP\ciclo VI\programacion I\pc03a\pc3b\Views\Home\Index.cshtml"
             Write(Producto.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n      <p>Celular: ");
#nullable restore
#line 24 "D:\Mario USMP\ciclo VI\programacion I\pc03a\pc3b\Views\Home\Index.cshtml"
             Write(Producto.cell);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n      <p>Lugar de compra: ");
#nullable restore
#line 25 "D:\Mario USMP\ciclo VI\programacion I\pc03a\pc3b\Views\Home\Index.cshtml"
                     Write(Producto.Place);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n      <p>Nombre del Comprador: ");
#nullable restore
#line 26 "D:\Mario USMP\ciclo VI\programacion I\pc03a\pc3b\Views\Home\Index.cshtml"
                          Write(Producto.NameC);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n      <p>Categoria: ");
#nullable restore
#line 27 "D:\Mario USMP\ciclo VI\programacion I\pc03a\pc3b\Views\Home\Index.cshtml"
               Write(Producto.Categoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 28 "D:\Mario USMP\ciclo VI\programacion I\pc03a\pc3b\Views\Home\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Producto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
