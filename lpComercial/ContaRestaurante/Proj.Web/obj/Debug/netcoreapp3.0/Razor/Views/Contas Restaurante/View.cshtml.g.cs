#pragma checksum "/Users/aldrinjr/ulbra/lpComercial/ContaRestaurante/Proj.Web/Views/Contas Restaurante/View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39a78ddf8482f9221fc746b6ee6f4f0653025a44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contas_Restaurante_View), @"mvc.1.0.view", @"/Views/Contas Restaurante/View.cshtml")]
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
#line 1 "/Users/aldrinjr/ulbra/lpComercial/ContaRestaurante/Proj.Web/Views/_ViewImports.cshtml"
using ContaRestaurante;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/aldrinjr/ulbra/lpComercial/ContaRestaurante/Proj.Web/Views/_ViewImports.cshtml"
using ContaRestaurante.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39a78ddf8482f9221fc746b6ee6f4f0653025a44", @"/Views/Contas Restaurante/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ffab0c3120dd2d6e5d2b57166ff7bca16c73737", @"/Views/_ViewImports.cshtml")]
    public class Views_Contas_Restaurante_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<restaurante.domain.Consumo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2 class=""text-center"">Contas de Luz</h2>

<div class=""form-group col-12 col-sm-8 col-md-6 mx-auto"">
    <div class=""editor-label"">
        restaurante
    </div>
    <div class=""editor-field"">
        <select class=""form-control"" name=""restaurante.id"" required>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39a78ddf8482f9221fc746b6ee6f4f0653025a443693", async() => {
                WriteLiteral("Selecione o restaurante");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 12 "/Users/aldrinjr/ulbra/lpComercial/ContaRestaurante/Proj.Web/Views/Contas Restaurante/View.cshtml"
             foreach(var restaurante in ViewBag.Imoveis)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39a78ddf8482f9221fc746b6ee6f4f0653025a445448", async() => {
#nullable restore
#line 14 "/Users/aldrinjr/ulbra/lpComercial/ContaRestaurante/Proj.Web/Views/Contas Restaurante/View.cshtml"
                                                                                                 Write(restaurante.identificacao);

#line default
#line hidden
#nullable disable
                WriteLiteral(" | ");
#nullable restore
#line 14 "/Users/aldrinjr/ulbra/lpComercial/ContaRestaurante/Proj.Web/Views/Contas Restaurante/View.cshtml"
                                                                                                                              Write(restaurante.cidade);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "/Users/aldrinjr/ulbra/lpComercial/ContaRestaurante/Proj.Web/Views/Contas Restaurante/View.cshtml"
                   WriteLiteral(restaurante.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 14 "/Users/aldrinjr/ulbra/lpComercial/ContaRestaurante/Proj.Web/Views/Contas Restaurante/View.cshtml"
AddHtmlAttributeValue("", 499, @restaurante.id == Model.restaurante.id, 499, 42, false);

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
            WriteLiteral("\n");
#nullable restore
#line 15 "/Users/aldrinjr/ulbra/lpComercial/ContaRestaurante/Proj.Web/Views/Contas Restaurante/View.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </select>   \n    </div>\n</div>\n\n<div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\n    <div class=\"editor-label\">\n        Data Pagamento\n    </div>\n    <div class=\"editor-field\">\n        ");
#nullable restore
#line 25 "/Users/aldrinjr/ulbra/lpComercial/ContaRestaurante/Proj.Web/Views/Contas Restaurante/View.cshtml"
   Write(Html.EditorFor(model => model.data, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <small class=\"form-text text-muted\">");
#nullable restore
#line 26 "/Users/aldrinjr/ulbra/lpComercial/ContaRestaurante/Proj.Web/Views/Contas Restaurante/View.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.data));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\n    </div>\n</div>\n\n<div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\n    <div class=\"editor-label\">\n        Valor a pagar\n    </div>\n    <div class=\"editor-field\">\n        ");
#nullable restore
#line 35 "/Users/aldrinjr/ulbra/lpComercial/ContaRestaurante/Proj.Web/Views/Contas Restaurante/View.cshtml"
   Write(Html.EditorFor(model => model.valor, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <small class=\"form-text text-muted\">");
#nullable restore
#line 36 "/Users/aldrinjr/ulbra/lpComercial/ContaRestaurante/Proj.Web/Views/Contas Restaurante/View.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\n    </div>\n</div>\n\n<div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\n    <div class=\"editor-label\">\n        Data Pagamento\n    </div>\n    <div class=\"editor-field\">\n        ");
#nullable restore
#line 45 "/Users/aldrinjr/ulbra/lpComercial/ContaRestaurante/Proj.Web/Views/Contas Restaurante/View.cshtml"
   Write(Html.EditorFor(model => model.data, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <small class=\"form-text text-muted\">");
#nullable restore
#line 46 "/Users/aldrinjr/ulbra/lpComercial/ContaRestaurante/Proj.Web/Views/Contas Restaurante/View.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.data));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\n    </div>\n</div>\n\n<div class=\"d-block text-center\">\n    <button type=\"submit\" class=\"btn btn-primary d-block my-4 mx-auto\">Atualizar</button>\n\n    ");
#nullable restore
#line 53 "/Users/aldrinjr/ulbra/lpComercial/ContaRestaurante/Proj.Web/Views/Contas Restaurante/View.cshtml"
Write(Html.ActionLink("Voltar para listagem", "Index", null, null, new { @class = "mt-2 d-block" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div> -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<restaurante.domain.Consumo> Html { get; private set; }
    }
}
#pragma warning restore 1591