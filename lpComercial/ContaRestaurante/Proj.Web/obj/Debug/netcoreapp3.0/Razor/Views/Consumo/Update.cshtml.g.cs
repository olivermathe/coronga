#pragma checksum "/Users/aldrinjr/ulbra/lpComercial/ContaRestaurante/Proj.Web/Views/Consumo/Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36c5a8a370bb2c46c34719e4ff2be7ac1d5a51f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consumo_Update), @"mvc.1.0.view", @"/Views/Consumo/Update.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36c5a8a370bb2c46c34719e4ff2be7ac1d5a51f5", @"/Views/Consumo/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ffab0c3120dd2d6e5d2b57166ff7bca16c73737", @"/Views/_ViewImports.cshtml")]
    public class Views_Consumo_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Proj.Domain.Entities.Consumo>
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
            WriteLiteral("\n<h2 class=\"text-center\">Consumos do Restaurante</h2>\n\n");
#nullable restore
#line 5 "/Users/aldrinjr/ulbra/lpComercial/ContaRestaurante/Proj.Web/Views/Consumo/Update.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/aldrinjr/ulbra/lpComercial/ContaRestaurante/Proj.Web/Views/Consumo/Update.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/aldrinjr/ulbra/lpComercial/ContaRestaurante/Proj.Web/Views/Consumo/Update.cshtml"
   Write(Html.HiddenFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""form-group col-12 col-sm-8 col-md-6 mx-auto"">
            <div class=""editor-label"">
                Restaurante
            </div>
            <div class=""editor-field"">
                <select class=""form-control"" name=""restaurante.id"" required>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36c5a8a370bb2c46c34719e4ff2be7ac1d5a51f54350", async() => {
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
#line 18 "/Users/aldrinjr/ulbra/lpComercial/ContaRestaurante/Proj.Web/Views/Consumo/Update.cshtml"
                     foreach(var Restaurante in ViewBag.Restaurante)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36c5a8a370bb2c46c34719e4ff2be7ac1d5a51f56124", async() => {
#nullable restore
#line 20 "/Users/aldrinjr/ulbra/lpComercial/ContaRestaurante/Proj.Web/Views/Consumo/Update.cshtml"
                                                                                                         Write(Restaurante.id);

#line default
#line hidden
#nullable disable
                WriteLiteral(" | ");
#nullable restore
#line 20 "/Users/aldrinjr/ulbra/lpComercial/ContaRestaurante/Proj.Web/Views/Consumo/Update.cshtml"
                                                                                                                           Write(Restaurante.cidade);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "/Users/aldrinjr/ulbra/lpComercial/ContaRestaurante/Proj.Web/Views/Consumo/Update.cshtml"
                           WriteLiteral(Restaurante.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 20 "/Users/aldrinjr/ulbra/lpComercial/ContaRestaurante/Proj.Web/Views/Consumo/Update.cshtml"
AddHtmlAttributeValue("", 702, @Restaurante.id == Model.restaurante.id, 702, 42, false);

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
#line 21 "/Users/aldrinjr/ulbra/lpComercial/ContaRestaurante/Proj.Web/Views/Consumo/Update.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </select>   \n            </div>\n        </div>\n");
            WriteLiteral("        <div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\n            <div class=\"editor-label\">\n                Data \n            </div>\n            <div class=\"editor-field\">\n                ");
#nullable restore
#line 31 "/Users/aldrinjr/ulbra/lpComercial/ContaRestaurante/Proj.Web/Views/Consumo/Update.cshtml"
           Write(Html.EditorFor(model => model.data, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <small class=\"form-text text-muted\">");
#nullable restore
#line 32 "/Users/aldrinjr/ulbra/lpComercial/ContaRestaurante/Proj.Web/Views/Consumo/Update.cshtml"
                                               Write(Html.ValidationMessageFor(model => model.data));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\n            </div>\n        </div>\n");
            WriteLiteral("        <div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\n            <div class=\"editor-label\">\n                Valor a pagar\n            </div>\n            <div class=\"editor-field\">\n                ");
#nullable restore
#line 41 "/Users/aldrinjr/ulbra/lpComercial/ContaRestaurante/Proj.Web/Views/Consumo/Update.cshtml"
           Write(Html.EditorFor(model => model.valor, new { htmlAttributes = new { @class = "form-control"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <small class=\"form-text text-muted\">");
#nullable restore
#line 42 "/Users/aldrinjr/ulbra/lpComercial/ContaRestaurante/Proj.Web/Views/Consumo/Update.cshtml"
                                               Write(Html.ValidationMessageFor(model => model.valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\n            </div>\n        </div>\n");
            WriteLiteral("        <div class=\"d-block text-center\">\n            <button type=\"submit\" class=\"btn btn-primary d-block my-4 mx-auto\">Atualizar</button>\n\n            ");
#nullable restore
#line 49 "/Users/aldrinjr/ulbra/lpComercial/ContaRestaurante/Proj.Web/Views/Consumo/Update.cshtml"
       Write(Html.ActionLink("Voltar para listagem", "Index", null, null, new { @class = "mt-2 d-block" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n");
#nullable restore
#line 51 "/Users/aldrinjr/ulbra/lpComercial/ContaRestaurante/Proj.Web/Views/Consumo/Update.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Proj.Domain.Entities.Consumo> Html { get; private set; }
    }
}
#pragma warning restore 1591
