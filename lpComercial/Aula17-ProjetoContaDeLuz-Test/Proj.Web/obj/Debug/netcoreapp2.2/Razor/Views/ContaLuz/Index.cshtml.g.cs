#pragma checksum "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b88b15aaad89457e8365583c2d80a35fc8208c02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ContaLuz_Index), @"mvc.1.0.view", @"/Views/ContaLuz/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ContaLuz/Index.cshtml", typeof(AspNetCore.Views_ContaLuz_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b88b15aaad89457e8365583c2d80a35fc8208c02", @"/Views/ContaLuz/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e9cc475dedf69725ad704917a7b52ecccd00cef", @"/Views/_ViewImports.cshtml")]
    public class Views_ContaLuz_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Proj.Domain.Entities.ContaLuz>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ContaLuz", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "View", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary mx-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 79, true);
            WriteLiteral("\n<h2 class=\"text-center\">Contas de Luz</h2>\n<p class=\"d-block text-right\">\n    ");
            EndContext();
            BeginContext(130, 100, false);
#line 5 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Index.cshtml"
Write(Html.ActionLink("Adicionar Conta de Luz", "Create", new {}, new { @class = "btn btn-outline-info" }));

#line default
#line hidden
            EndContext();
            BeginContext(230, 362, true);
            WriteLiteral(@"
</p>
<table class=""table table-bordered table-striped"">
    <thead class=""thead-dark"">
        <tr>
            <th>ID</th>
            <th>Data Leitura</th>
            <th>KW Gasto</th>
            <th>Valor a pagar</th>
            <th>Data Pagamento</th>
            <th>Média Consumo</th>
            <th>Ações</th>
        </tr>
    </thead>

    <tbody>
");
            EndContext();
#line 21 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(639, 37, true);
            WriteLiteral("            <tr>\n                <th>");
            EndContext();
            BeginContext(677, 7, false);
#line 24 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Index.cshtml"
               Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(684, 26, true);
            WriteLiteral("</th>\n                <td>");
            EndContext();
            BeginContext(711, 39, false);
#line 25 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Index.cshtml"
               Write(item.dataLeitura.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(750, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(777, 12, false);
#line 26 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Index.cshtml"
               Write(item.kwGasto);

#line default
#line hidden
            EndContext();
            BeginContext(789, 29, true);
            WriteLiteral("</td>\n                <td>R$ ");
            EndContext();
            BeginContext(819, 16, false);
#line 27 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Index.cshtml"
                  Write(item.valorAPagar);

#line default
#line hidden
            EndContext();
            BeginContext(835, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(862, 41, false);
#line 28 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Index.cshtml"
               Write(item.dataPagamento.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(903, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(930, 17, false);
#line 29 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Index.cshtml"
               Write(item.mediaConsumo);

#line default
#line hidden
            EndContext();
            BeginContext(947, 67, true);
            WriteLiteral("</td>\n                <td class=\"text-center\">\n                    ");
            EndContext();
            BeginContext(1014, 208, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b88b15aaad89457e8365583c2d80a35fc8208c029038", async() => {
                BeginContext(1192, 26, true);
                WriteLiteral("<i class=\"fas fa-eye\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 34 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Index.cshtml"
                          WriteLiteral(item.id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1222, 22, true);
            WriteLiteral("\n\n                    ");
            EndContext();
            BeginContext(1244, 216, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b88b15aaad89457e8365583c2d80a35fc8208c0211687", async() => {
                BeginContext(1429, 27, true);
                WriteLiteral("<i class=\"fas fa-edit\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 39 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Index.cshtml"
                          WriteLiteral(item.id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1460, 22, true);
            WriteLiteral("\n\n                    ");
            EndContext();
            BeginContext(1482, 215, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b88b15aaad89457e8365583c2d80a35fc8208c0214338", async() => {
                BeginContext(1661, 32, true);
                WriteLiteral("<i class=\"fas fa-trash-alt\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Index.cshtml"
                          WriteLiteral(item.id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1697, 41, true);
            WriteLiteral("\n                </td>\n            </tr>\n");
            EndContext();
#line 47 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1748, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 48 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Index.cshtml"
         if (!Model.Any())
        {

#line default
#line hidden
            BeginContext(1785, 82, true);
            WriteLiteral("            <td colspan=\"7\" class=\"text-center\"> Nenhum registro cadastrado </td>\n");
            EndContext();
#line 51 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1877, 23, true);
            WriteLiteral("    </tbody>\n</table>\n\n");
            EndContext();
#line 55 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Index.cshtml"
 if (Model.Any())
{

#line default
#line hidden
            BeginContext(1920, 455, true);
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-sm-6"">
            <div class=""card"">
                <h5 class=""card-header"">Menor Consumo</h5>
                <div class=""card-body"">
                    <div class=""form-group col-12"">
                        <div class=""editor-label"">
                            Data Leitura
                        </div>
                        <div class=""editor-field"">
                            <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2375, "\"", 2439, 1);
#line 67 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Index.cshtml"
WriteAttributeValue("", 2383, ViewBag.menorConsumo.dataLeitura.ToString("dd/MM/yyyy"), 2383, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2440, 360, true);
            WriteLiteral(@" class=""form-control"" disabled/>
                        </div>
                    </div>

                    <div class=""form-group col-12"">
                        <div class=""editor-label"">
                            KW Gasto
                        </div>
                        <div class=""editor-field"">
                            <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2800, "\"", 2837, 1);
#line 76 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Index.cshtml"
WriteAttributeValue("", 2808, ViewBag.menorConsumo.kwGasto, 2808, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2838, 365, true);
            WriteLiteral(@" class=""form-control"" disabled/>
                        </div>
                    </div>

                    <div class=""form-group col-12"">
                        <div class=""editor-label"">
                            Valor a pagar
                        </div>
                        <div class=""editor-field"">
                            <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3203, "\"", 3247, 2);
            WriteAttributeValue("", 3211, "R$", 3211, 2, true);
#line 85 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Index.cshtml"
WriteAttributeValue(" ", 3213, ViewBag.menorConsumo.valorAPagar, 3214, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3248, 366, true);
            WriteLiteral(@" class=""form-control"" disabled/>
                        </div>
                    </div>

                    <div class=""form-group col-12"">
                        <div class=""editor-label"">
                            Data Pagamento
                        </div>
                        <div class=""editor-field"">
                            <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3614, "\"", 3680, 1);
#line 94 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Index.cshtml"
WriteAttributeValue("", 3622, ViewBag.menorConsumo.dataPagamento.ToString("dd/MM/yyyy"), 3622, 58, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3681, 368, true);
            WriteLiteral(@" class=""form-control"" disabled/>
                        </div>
                    </div>

                    <div class=""form-group col-12"">
                        <div class=""editor-label"">
                            Média de Consumo
                        </div>
                        <div class=""editor-field"">
                            <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4049, "\"", 4091, 1);
#line 103 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Index.cshtml"
WriteAttributeValue("", 4057, ViewBag.menorConsumo.mediaConsumo, 4057, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4092, 581, true);
            WriteLiteral(@" class=""form-control"" disabled/>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-sm-6"">
            <div class=""card"">
                <h5 class=""card-header"">Maior Consumo</h5>
                <div class=""card-body"">
                    <div class=""form-group col-12"">
                        <div class=""editor-label"">
                            Data Leitura
                        </div>
                        <div class=""editor-field"">
                            <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4673, "\"", 4737, 1);
#line 118 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Index.cshtml"
WriteAttributeValue("", 4681, ViewBag.maiorConsumo.dataLeitura.ToString("dd/MM/yyyy"), 4681, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4738, 360, true);
            WriteLiteral(@" class=""form-control"" disabled/>
                        </div>
                    </div>

                    <div class=""form-group col-12"">
                        <div class=""editor-label"">
                            KW Gasto
                        </div>
                        <div class=""editor-field"">
                            <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5098, "\"", 5135, 1);
#line 127 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Index.cshtml"
WriteAttributeValue("", 5106, ViewBag.maiorConsumo.kwGasto, 5106, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5136, 365, true);
            WriteLiteral(@" class=""form-control"" disabled/>
                        </div>
                    </div>

                    <div class=""form-group col-12"">
                        <div class=""editor-label"">
                            Valor a pagar
                        </div>
                        <div class=""editor-field"">
                            <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5501, "\"", 5545, 2);
            WriteAttributeValue("", 5509, "R$", 5509, 2, true);
#line 136 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Index.cshtml"
WriteAttributeValue(" ", 5511, ViewBag.maiorConsumo.valorAPagar, 5512, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5546, 366, true);
            WriteLiteral(@" class=""form-control"" disabled/>
                        </div>
                    </div>

                    <div class=""form-group col-12"">
                        <div class=""editor-label"">
                            Data Pagamento
                        </div>
                        <div class=""editor-field"">
                            <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5912, "\"", 5978, 1);
#line 145 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Index.cshtml"
WriteAttributeValue("", 5920, ViewBag.maiorConsumo.dataPagamento.ToString("dd/MM/yyyy"), 5920, 58, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5979, 368, true);
            WriteLiteral(@" class=""form-control"" disabled/>
                        </div>
                    </div>

                    <div class=""form-group col-12"">
                        <div class=""editor-label"">
                            Média de Consumo
                        </div>
                        <div class=""editor-field"">
                            <input type=""text""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 6347, "\"", 6389, 1);
#line 154 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Index.cshtml"
WriteAttributeValue("", 6355, ViewBag.maiorConsumo.mediaConsumo, 6355, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6390, 159, true);
            WriteLiteral(" class=\"form-control\" disabled/>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n");
            EndContext();
#line 161 "/Users/aldrinjr/Downloads/LPC-2019-2-Canoas-master/Aula17-ProjetoContaDeLuz-Test/Proj.Web/Views/ContaLuz/Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Proj.Domain.Entities.ContaLuz>> Html { get; private set; }
    }
}
#pragma warning restore 1591