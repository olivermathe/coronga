#pragma checksum "/home/razor1911/ulbra/lpComercial/TarefaMVC/Views/Tarefas/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88772623aa85c560fe52b87062d70e1de0b528c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tarefas_Edit), @"mvc.1.0.view", @"/Views/Tarefas/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tarefas/Edit.cshtml", typeof(AspNetCore.Views_Tarefas_Edit))]
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
#line 1 "/home/razor1911/ulbra/lpComercial/TarefaMVC/Views/_ViewImports.cshtml"
using TarefaMVC;

#line default
#line hidden
#line 2 "/home/razor1911/ulbra/lpComercial/TarefaMVC/Views/_ViewImports.cshtml"
using TarefaMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88772623aa85c560fe52b87062d70e1de0b528c3", @"/Views/Tarefas/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79f25bb0c3ad6dab19428c12b6fb2fe7dcc6203c", @"/Views/_ViewImports.cshtml")]
    public class Views_Tarefas_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppTarefa.Models.Tarefa>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 35, true);
            WriteLiteral("\n<div class=\"form-horizontal\">\n    ");
            EndContext();
            BeginContext(66, 1035, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88772623aa85c560fe52b87062d70e1de0b528c33934", async() => {
                BeginContext(100, 146, true);
                WriteLiteral("\n        <div class=\"form-group\">\n            <label>Id</label>\n            <input  class=\"form-control\"\n                    type=\"text\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", "\n                    value=\"", 246, "\"", 283, 1);
#line 9 "/home/razor1911/ulbra/lpComercial/TarefaMVC/Views/Tarefas/Edit.cshtml"
WriteAttributeValue("", 274, Model.id, 274, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(284, 172, true);
                WriteLiteral("/>\n        </div>\n    \n        <div class=\"form-group\">\n            <label>Nome</label>\n            <input  class=\"form-control\"\n                    type=\"text\" name=\"name\"");
                EndContext();
                BeginWriteAttribute("value", "\n                    value=\"", 456, "\"", 495, 1);
#line 16 "/home/razor1911/ulbra/lpComercial/TarefaMVC/Views/Tarefas/Edit.cshtml"
WriteAttributeValue("", 484, Model.name, 484, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(496, 188, true);
                WriteLiteral("/>\n        </div>\n        \n        <div class=\"form-group\">\n            <label>dataLimite</label>\n            <input  class=\"form-control\"\n                    type=\"text\" name=\"dataLimite\"");
                EndContext();
                BeginWriteAttribute("value", "\n                        value=\"", 684, "\"", 733, 1);
#line 23 "/home/razor1911/ulbra/lpComercial/TarefaMVC/Views/Tarefas/Edit.cshtml"
WriteAttributeValue("", 716, Model.dataLimite, 716, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(734, 193, true);
                WriteLiteral("/>\n        </div>\n\n         <div class=\"form-group\">\n            <label>percentConcluido</label>\n            <input  class=\"form-control\"\n                    type=\"text\" name=\"percentConcluido\"");
                EndContext();
                BeginWriteAttribute("value", "\n                        value=\"", 927, "\"", 982, 1);
#line 30 "/home/razor1911/ulbra/lpComercial/TarefaMVC/Views/Tarefas/Edit.cshtml"
WriteAttributeValue("", 959, Model.percentConcluido, 959, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(983, 111, true);
                WriteLiteral("/>\n        </div>\n\n        <input  class=\"btn btn-primary\" \n                type=\"submit\" value=\"Salvar\"/>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1101, 7, true);
            WriteLiteral("\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppTarefa.Models.Tarefa> Html { get; private set; }
    }
}
#pragma warning restore 1591
