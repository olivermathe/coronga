#pragma checksum "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9dc7a584618cd55b7e36c7f5fbad92cc08bcc10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ContaLuz_Create), @"mvc.1.0.view", @"/Views/ContaLuz/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ContaLuz/Create.cshtml", typeof(AspNetCore.Views_ContaLuz_Create))]
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
#line 1 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/_ViewImports.cshtml"
using Proj.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9dc7a584618cd55b7e36c7f5fbad92cc08bcc10", @"/Views/ContaLuz/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e9cc475dedf69725ad704917a7b52ecccd00cef", @"/Views/_ViewImports.cshtml")]
    public class Views_ContaLuz_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Proj.Domain.Entities.ContaLuz>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 45, true);
            WriteLiteral("\n<h2 class=\"text-center\">Contas de Luz</h2>\n\n");
            EndContext();
#line 5 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(115, 28, false);
#line 7 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Create.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(154, 33, false);
#line 9 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Create.cshtml"
   Write(Html.HiddenFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(189, 278, true);
            WriteLiteral(@"        <div class=""form-group col-12 col-sm-8 col-md-6 mx-auto"">
            <div class=""editor-label"">
                Imovel
            </div>
            <div class=""editor-field"">
                <select class=""form-control"" name=""imovel.id"" required>
                    ");
            EndContext();
            BeginContext(467, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9dc7a584618cd55b7e36c7f5fbad92cc08bcc104541", async() => {
                BeginContext(502, 18, true);
                WriteLiteral("Selecione o Imovel");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(529, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 18 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Create.cshtml"
                     foreach(var imovel in ViewBag.Imoveis)
                    {

#line default
#line hidden
            BeginContext(612, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(636, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9dc7a584618cd55b7e36c7f5fbad92cc08bcc106880", async() => {
                BeginContext(664, 20, false);
#line 20 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Create.cshtml"
                                              Write(imovel.identificacao);

#line default
#line hidden
                EndContext();
                BeginContext(684, 3, true);
                WriteLiteral(" | ");
                EndContext();
                BeginContext(688, 13, false);
#line 20 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Create.cshtml"
                                                                      Write(imovel.cidade);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 20 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Create.cshtml"
                           WriteLiteral(imovel.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(710, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 21 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Create.cshtml"
                    }

#line default
#line hidden
            BeginContext(733, 63, true);
            WriteLiteral("                </select>   \n            </div>\n        </div>\n");
            EndContext();
            BeginContext(797, 208, true);
            WriteLiteral("        <div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\n            <div class=\"editor-label\">\n                Data Leitura\n            </div>\n            <div class=\"editor-field\">\n                ");
            EndContext();
            BeginContext(1006, 99, false);
#line 31 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Create.cshtml"
           Write(Html.EditorFor(model => model.dataLeitura, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
            EndContext();
            BeginContext(1105, 53, true);
            WriteLiteral("\n                <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(1159, 53, false);
#line 32 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Create.cshtml"
                                               Write(Html.ValidationMessageFor(model => model.dataLeitura));

#line default
#line hidden
            EndContext();
            BeginContext(1212, 43, true);
            WriteLiteral("</small>\n            </div>\n        </div>\n");
            EndContext();
            BeginContext(1256, 204, true);
            WriteLiteral("        <div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\n            <div class=\"editor-label\">\n                KW Gasto\n            </div>\n            <div class=\"editor-field\">\n                ");
            EndContext();
            BeginContext(1461, 95, false);
#line 41 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Create.cshtml"
           Write(Html.EditorFor(model => model.kwGasto, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
            EndContext();
            BeginContext(1556, 53, true);
            WriteLiteral("\n                <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(1610, 49, false);
#line 42 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Create.cshtml"
                                               Write(Html.ValidationMessageFor(model => model.kwGasto));

#line default
#line hidden
            EndContext();
            BeginContext(1659, 43, true);
            WriteLiteral("</small>\n            </div>\n        </div>\n");
            EndContext();
            BeginContext(1703, 209, true);
            WriteLiteral("        <div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\n            <div class=\"editor-label\">\n                Valor a pagar\n            </div>\n            <div class=\"editor-field\">\n                ");
            EndContext();
            BeginContext(1913, 99, false);
#line 51 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Create.cshtml"
           Write(Html.EditorFor(model => model.valorAPagar, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
            EndContext();
            BeginContext(2012, 53, true);
            WriteLiteral("\n                <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(2066, 53, false);
#line 52 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Create.cshtml"
                                               Write(Html.ValidationMessageFor(model => model.valorAPagar));

#line default
#line hidden
            EndContext();
            BeginContext(2119, 43, true);
            WriteLiteral("</small>\n            </div>\n        </div>\n");
            EndContext();
            BeginContext(2163, 210, true);
            WriteLiteral("        <div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\n            <div class=\"editor-label\">\n                Data Pagamento\n            </div>\n            <div class=\"editor-field\">\n                ");
            EndContext();
            BeginContext(2374, 101, false);
#line 61 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Create.cshtml"
           Write(Html.EditorFor(model => model.dataPagamento, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
            EndContext();
            BeginContext(2475, 53, true);
            WriteLiteral("\n                <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(2529, 55, false);
#line 62 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Create.cshtml"
                                               Write(Html.ValidationMessageFor(model => model.dataPagamento));

#line default
#line hidden
            EndContext();
            BeginContext(2584, 43, true);
            WriteLiteral("</small>\n            </div>\n        </div>\n");
            EndContext();
            BeginContext(2628, 212, true);
            WriteLiteral("        <div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\n            <div class=\"editor-label\">\n                Média de Consumo\n            </div>\n            <div class=\"editor-field\">\n                ");
            EndContext();
            BeginContext(2841, 100, false);
#line 71 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Create.cshtml"
           Write(Html.EditorFor(model => model.mediaConsumo, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
            EndContext();
            BeginContext(2941, 53, true);
            WriteLiteral("\n                <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(2995, 54, false);
#line 72 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Create.cshtml"
                                               Write(Html.ValidationMessageFor(model => model.mediaConsumo));

#line default
#line hidden
            EndContext();
            BeginContext(3049, 43, true);
            WriteLiteral("</small>\n            </div>\n        </div>\n");
            EndContext();
            BeginContext(3093, 153, true);
            WriteLiteral("        <div class=\"d-block text-center\">\n            <button type=\"submit\" class=\"btn btn-primary d-block my-4 mx-auto\">Adicionar</button>\n\n            ");
            EndContext();
            BeginContext(3247, 93, false);
#line 79 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Create.cshtml"
       Write(Html.ActionLink("Voltar para listagem", "Index", null, null, new { @class = "mt-2 d-block" }));

#line default
#line hidden
            EndContext();
            BeginContext(3340, 16, true);
            WriteLiteral("\n        </div>\n");
            EndContext();
#line 81 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Create.cshtml"
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Proj.Domain.Entities.ContaLuz> Html { get; private set; }
    }
}
#pragma warning restore 1591
