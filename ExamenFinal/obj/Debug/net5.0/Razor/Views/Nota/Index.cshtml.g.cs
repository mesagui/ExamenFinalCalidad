#pragma checksum "D:\U\Calidad y Pruebas de Software\Examen\Examen Final\ExamenFinal\ExamenFinal\Views\Nota\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b4ab80c07b54356ca47d887c04995083190a7a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Nota_Index), @"mvc.1.0.view", @"/Views/Nota/Index.cshtml")]
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
#line 1 "D:\U\Calidad y Pruebas de Software\Examen\Examen Final\ExamenFinal\ExamenFinal\Views\_ViewImports.cshtml"
using ExamenFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\U\Calidad y Pruebas de Software\Examen\Examen Final\ExamenFinal\ExamenFinal\Views\Nota\Index.cshtml"
using ExamenFinal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b4ab80c07b54356ca47d887c04995083190a7a7", @"/Views/Nota/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2dfc294bf8d6131f460c8b716bd6e5797132710", @"/Views/_ViewImports.cshtml")]
    public class Views_Nota_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NotaIndex>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Crear", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<br />\r\n<div class=\"row\">\r\n    <div class=\"col-2 bg-light\">\r\n       \r\n        <h4>Categorias</h4>\r\n        \r\n");
#nullable restore
#line 10 "D:\U\Calidad y Pruebas de Software\Examen\Examen Final\ExamenFinal\ExamenFinal\Views\Nota\Index.cshtml"
         foreach (var tag in (List<Tag>) ViewBag.Tags)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <a class=\"text-secondary\"");
            BeginWriteAttribute("href", " href=\"", 282, "\"", 331, 1);
#nullable restore
#line 13 "D:\U\Calidad y Pruebas de Software\Examen\Examen Final\ExamenFinal\ExamenFinal\Views\Nota\Index.cshtml"
WriteAttributeValue("", 289, Url.Action("Index", new{TagId=tag.TagId}), 289, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 13 "D:\U\Calidad y Pruebas de Software\Examen\Examen Final\ExamenFinal\ExamenFinal\Views\Nota\Index.cshtml"
                                                                                       Write(tag.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </li>\r\n");
#nullable restore
#line 15 "D:\U\Calidad y Pruebas de Software\Examen\Examen Final\ExamenFinal\ExamenFinal\Views\Nota\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n        <li>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 418, "\"", 467, 1);
#nullable restore
#line 18 "D:\U\Calidad y Pruebas de Software\Examen\Examen Final\ExamenFinal\ExamenFinal\Views\Nota\Index.cshtml"
WriteAttributeValue("", 425, Url.Action("Index", new{Compartida=true}), 425, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Compartidas</a>\r\n        </li>\r\n    </div>\r\n    <div class=\"col-10\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b4ab80c07b54356ca47d887c04995083190a7a76733", async() => {
                WriteLiteral("\r\n            ");
#nullable restore
#line 23 "D:\U\Calidad y Pruebas de Software\Examen\Examen Final\ExamenFinal\ExamenFinal\Views\Nota\Index.cshtml"
       Write(Html.HiddenFor(model => model.TagId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 24 "D:\U\Calidad y Pruebas de Software\Examen\Examen Final\ExamenFinal\ExamenFinal\Views\Nota\Index.cshtml"
       Write(Html.HiddenFor(model => model.Compartida));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div class=\"row\">\r\n                \r\n               <div class=\"col-8\">\r\n                    ");
#nullable restore
#line 28 "D:\U\Calidad y Pruebas de Software\Examen\Examen Final\ExamenFinal\ExamenFinal\Views\Nota\Index.cshtml"
               Write(Html.TextBoxFor(model => model.BuscarTexto, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
                
               <div class=""col-2"">
                   <button type=""submit"" class=""btn btn-outline-secondary""> <i class=""fas fa-search""></i> Buscar</button>
               </div>
                
                <div class=""col-2"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b4ab80c07b54356ca47d887c04995083190a7a78319", async() => {
                    WriteLiteral(" <i class=\"far fa-sticky-note\"></i> Nuevo");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n            <br />\r\n            <a class=\"btn btn-outline-primary\"");
                BeginWriteAttribute("href", " href=\"", 1426, "\"", 1453, 1);
#nullable restore
#line 41 "D:\U\Calidad y Pruebas de Software\Examen\Examen Final\ExamenFinal\ExamenFinal\Views\Nota\Index.cshtml"
WriteAttributeValue("", 1433, Url.Action("Index"), 1433, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> <i class=\"fas fa-list\"></i> Listar</a>\r\n            <br />\r\n            <br />\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 22 "D:\U\Calidad y Pruebas de Software\Examen\Examen Final\ExamenFinal\ExamenFinal\Views\Nota\Index.cshtml"
AddHtmlAttributeValue("", 561, Url.Action("Index"), 561, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        \r\n\r\n");
#nullable restore
#line 47 "D:\U\Calidad y Pruebas de Software\Examen\Examen Final\ExamenFinal\ExamenFinal\Views\Nota\Index.cshtml"
         foreach (var nota in Model.Notas)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 51 "D:\U\Calidad y Pruebas de Software\Examen\Examen Final\ExamenFinal\ExamenFinal\Views\Nota\Index.cshtml"
                                      Write(nota.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 51 "D:\U\Calidad y Pruebas de Software\Examen\Examen Final\ExamenFinal\ExamenFinal\Views\Nota\Index.cshtml"
                                                    Write(nota.FechaModificacion >= nota.Fecha ? "(Modificado: " + nota.FechaModificacion.ToShortDateString() + ")" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 52 "D:\U\Calidad y Pruebas de Software\Examen\Examen Final\ExamenFinal\ExamenFinal\Views\Nota\Index.cshtml"
                                     Write(@nota.Contenido.Length > 50 ? nota.Contenido.Substring(0, 47) + "..." : nota.Contenido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <div class=\"row\">\r\n                        <a class=\"btn btn-outline-info m-2\"");
            BeginWriteAttribute("href", " href=\"", 2103, "\"", 2155, 1);
#nullable restore
#line 54 "D:\U\Calidad y Pruebas de Software\Examen\Examen Final\ExamenFinal\ExamenFinal\Views\Nota\Index.cshtml"
WriteAttributeValue("", 2110, Url.Action("Editar", new {id = nota.NotaId}), 2110, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <i class=\"far fa-edit\"></i> Editar</a>\r\n                        <a class=\"btn btn-outline-danger m-2\"");
            BeginWriteAttribute("href", " href=\"", 2259, "\"", 2313, 1);
#nullable restore
#line 55 "D:\U\Calidad y Pruebas de Software\Examen\Examen Final\ExamenFinal\ExamenFinal\Views\Nota\Index.cshtml"
WriteAttributeValue("", 2266, Url.Action("Eliminar", new {id = nota.NotaId}), 2266, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <i class=\"far fa-trash-alt\"></i> Eliminar</a>\r\n                        <a class=\"btn btn-outline-success m-2\"");
            BeginWriteAttribute("href", " href=\"", 2425, "\"", 2480, 1);
#nullable restore
#line 56 "D:\U\Calidad y Pruebas de Software\Examen\Examen Final\ExamenFinal\ExamenFinal\Views\Nota\Index.cshtml"
WriteAttributeValue("", 2432, Url.Action("Compartir", new {id = nota.NotaId}), 2432, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fas fa-share-alt-square\"></i> Compartir</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <br />\r\n");
#nullable restore
#line 61 "D:\U\Calidad y Pruebas de Software\Examen\Examen Final\ExamenFinal\ExamenFinal\Views\Nota\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NotaIndex> Html { get; private set; }
    }
}
#pragma warning restore 1591