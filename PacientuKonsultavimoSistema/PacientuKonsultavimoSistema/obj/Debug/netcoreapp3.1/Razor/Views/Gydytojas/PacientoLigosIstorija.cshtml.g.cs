#pragma checksum "C:\Users\augus\Desktop\Galutinis\Pacientu-Konsultavimo-Sistema-master\PacientuKonsultavimoSistema\PacientuKonsultavimoSistema\Views\Gydytojas\PacientoLigosIstorija.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b595efd0020bd6f4f39ae496c95f9d7b6956d925"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gydytojas_PacientoLigosIstorija), @"mvc.1.0.view", @"/Views/Gydytojas/PacientoLigosIstorija.cshtml")]
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
#line 1 "C:\Users\augus\Desktop\Galutinis\Pacientu-Konsultavimo-Sistema-master\PacientuKonsultavimoSistema\PacientuKonsultavimoSistema\Views\_ViewImports.cshtml"
using PacientuKonsultavimoSistema;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\augus\Desktop\Galutinis\Pacientu-Konsultavimo-Sistema-master\PacientuKonsultavimoSistema\PacientuKonsultavimoSistema\Views\_ViewImports.cshtml"
using PacientuKonsultavimoSistema.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\augus\Desktop\Galutinis\Pacientu-Konsultavimo-Sistema-master\PacientuKonsultavimoSistema\PacientuKonsultavimoSistema\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\augus\Desktop\Galutinis\Pacientu-Konsultavimo-Sistema-master\PacientuKonsultavimoSistema\PacientuKonsultavimoSistema\Views\_ViewImports.cshtml"
using PacientuKonsultavimoSistema.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b595efd0020bd6f4f39ae496c95f9d7b6956d925", @"/Views/Gydytojas/PacientoLigosIstorija.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afddc0514edc333e27502fc98ad2006b131c30f4", @"/Views/_ViewImports.cshtml")]
    public class Views_Gydytojas_PacientoLigosIstorija : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LigosIstorija>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/homepage.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PacientoLigosIstorija", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LigosIstorija", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Gydytojas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\augus\Desktop\Galutinis\Pacientu-Konsultavimo-Sistema-master\PacientuKonsultavimoSistema\PacientuKonsultavimoSistema\Views\Gydytojas\PacientoLigosIstorija.cshtml"
  
    ViewBag.Title = "Mano grafikas";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b595efd0020bd6f4f39ae496c95f9d7b6956d9258248", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b595efd0020bd6f4f39ae496c95f9d7b6956d9258628", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b595efd0020bd6f4f39ae496c95f9d7b6956d9259806", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b595efd0020bd6f4f39ae496c95f9d7b6956d92510984", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <style>
        .tableFixHead {
            overflow-y: auto;
            height: 60vh;
            width: 100%;
        }
            .tableFixHead thead th {
                position: sticky;
                top: 0;
            }

        table {
            border-collapse: collapse;
            width: 100%;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b595efd0020bd6f4f39ae496c95f9d7b6956d92513224", async() => {
                WriteLiteral("\r\n    <div class=\"row justify-content-center\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b595efd0020bd6f4f39ae496c95f9d7b6956d92513541", async() => {
                    WriteLiteral("\r\n            <div>\r\n                <input type=\"date\" name=\"data\"");
                    BeginWriteAttribute("value", " value=\"", 995, "\"", 1003, 0);
                    EndWriteAttribute();
                    WriteLiteral(" class=\"form-control\">\r\n                <input type=\"submit\" value=\"Ieškoti\" class=\"btn btn-info\" />\r\n            </div>\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        <div class=""col-md-12"">
            <div class=""card"">
                <header class=""card-header"">
                    <h4 class=""card-title mt-2"">Paciento Ligos Istorija</h4>
                </header>
                <table class=""table table-striped border"">
                    <tr class=""table-info"">
                    <tr><th style=""background-color:#CEECF5"">Vardas: </th><th>");
#nullable restore
#line 47 "C:\Users\augus\Desktop\Galutinis\Pacientu-Konsultavimo-Sistema-master\PacientuKonsultavimoSistema\PacientuKonsultavimoSistema\Views\Gydytojas\PacientoLigosIstorija.cshtml"
                                                                         Write(ViewBag.Vardas);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th></tr>\r\n                    <tr><th style=\"background-color:#CEECF5\">Pavardė: </th><th>");
#nullable restore
#line 48 "C:\Users\augus\Desktop\Galutinis\Pacientu-Konsultavimo-Sistema-master\PacientuKonsultavimoSistema\PacientuKonsultavimoSistema\Views\Gydytojas\PacientoLigosIstorija.cshtml"
                                                                          Write(ViewBag.Pavarde);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th></tr>\r\n                    <tr><th style=\"background-color:#CEECF5\">Gimimo metai: </th><th>");
#nullable restore
#line 49 "C:\Users\augus\Desktop\Galutinis\Pacientu-Konsultavimo-Sistema-master\PacientuKonsultavimoSistema\PacientuKonsultavimoSistema\Views\Gydytojas\PacientoLigosIstorija.cshtml"
                                                                               Write(ViewBag.Metai);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th></tr>\r\n                    <tr><th style=\"background-color:#CEECF5\">Lytis: </th><th>");
#nullable restore
#line 50 "C:\Users\augus\Desktop\Galutinis\Pacientu-Konsultavimo-Sistema-master\PacientuKonsultavimoSistema\PacientuKonsultavimoSistema\Views\Gydytojas\PacientoLigosIstorija.cshtml"
                                                                        Write(ViewBag.Lytis);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th></tr>\r\n                    <tr>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b595efd0020bd6f4f39ae496c95f9d7b6956d92518027", async() => {
                    WriteLiteral("\r\n                            <button type=\"submit\" class=\"nav-link btn btn-primary\">Pridėti</button>\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "C:\Users\augus\Desktop\Galutinis\Pacientu-Konsultavimo-Sistema-master\PacientuKonsultavimoSistema\PacientuKonsultavimoSistema\Views\Gydytojas\PacientoLigosIstorija.cshtml"
                                                                         WriteLiteral(ViewBag.Id2);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </tr>\r\n                </table>\r\n                <div class=\"tableFixHead\">\r\n                    <table class=\"table table-striped border\">\r\n                        </tr>\r\n");
#nullable restore
#line 60 "C:\Users\augus\Desktop\Galutinis\Pacientu-Konsultavimo-Sistema-master\PacientuKonsultavimoSistema\PacientuKonsultavimoSistema\Views\Gydytojas\PacientoLigosIstorija.cshtml"
                         foreach (LigosIstorija i in Model)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                            <tr><th style=\"background-color:#CEECF5\">Gydytojo vardas: </th><th>");
#nullable restore
#line 63 "C:\Users\augus\Desktop\Galutinis\Pacientu-Konsultavimo-Sistema-master\PacientuKonsultavimoSistema\PacientuKonsultavimoSistema\Views\Gydytojas\PacientoLigosIstorija.cshtml"
                                                                                          Write(i.GydVardas);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th></tr>\r\n                            <tr><th style=\"background-color:#CEECF5\">Gydytojo pavardė: </th><th>");
#nullable restore
#line 64 "C:\Users\augus\Desktop\Galutinis\Pacientu-Konsultavimo-Sistema-master\PacientuKonsultavimoSistema\PacientuKonsultavimoSistema\Views\Gydytojas\PacientoLigosIstorija.cshtml"
                                                                                           Write(i.GydPavarde);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th></tr>\r\n                            <tr><th style=\"background-color:#CEECF5\">Data: </th><th>");
#nullable restore
#line 65 "C:\Users\augus\Desktop\Galutinis\Pacientu-Konsultavimo-Sistema-master\PacientuKonsultavimoSistema\PacientuKonsultavimoSistema\Views\Gydytojas\PacientoLigosIstorija.cshtml"
                                                                               Write(i.Data);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th></tr>\r\n                            <tr><th style=\"background-color:#CEECF5\">Liga: </th><th>");
#nullable restore
#line 66 "C:\Users\augus\Desktop\Galutinis\Pacientu-Konsultavimo-Sistema-master\PacientuKonsultavimoSistema\PacientuKonsultavimoSistema\Views\Gydytojas\PacientoLigosIstorija.cshtml"
                                                                               Write(i.Liga);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th></tr>\r\n                            <tr><th colspan=\"2\" style=\"background-color:#CEECF5\">Aprašymas:</th></tr\">\r\n                            <tr><th colspan=\"2\">");
#nullable restore
#line 68 "C:\Users\augus\Desktop\Galutinis\Pacientu-Konsultavimo-Sistema-master\PacientuKonsultavimoSistema\PacientuKonsultavimoSistema\Views\Gydytojas\PacientoLigosIstorija.cshtml"
                                           Write(i.LigosAprasas);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th></tr>\r\n                            </tr>\r\n");
#nullable restore
#line 70 "C:\Users\augus\Desktop\Galutinis\Pacientu-Konsultavimo-Sistema-master\PacientuKonsultavimoSistema\PacientuKonsultavimoSistema\Views\Gydytojas\PacientoLigosIstorija.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </table>\r\n                </div>\r\n                <!-- card-body end .// -->\r\n            </div> <!-- card.// -->\r\n        </div> <!-- col.//-->\r\n    </div> <!-- row.//-->\r\n    <!--container end.//-->\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LigosIstorija>> Html { get; private set; }
    }
}
#pragma warning restore 1591
