#pragma checksum "/Users/aldrinjr/ulbra/lpComercial/TarefasArnaldo/Views/TarefasArnaldo/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8457a0f3acfee4b9807f4c53ae88b5937af0431a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TarefasArnaldo_Edit), @"mvc.1.0.view", @"/Views/TarefasArnaldo/Edit.cshtml")]
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
#line 1 "/Users/aldrinjr/ulbra/lpComercial/TarefasArnaldo/Views/_ViewImports.cshtml"
using TarefasArnaldo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/aldrinjr/ulbra/lpComercial/TarefasArnaldo/Views/_ViewImports.cshtml"
using TarefasArnaldo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8457a0f3acfee4b9807f4c53ae88b5937af0431a", @"/Views/TarefasArnaldo/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"617a795ba7ab97f52085ef987b1a29a9f2bc6cfa", @"/Views/_ViewImports.cshtml")]
    public class Views_TarefasArnaldo_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TarefasArnaldo.Models.Task>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"form-horizontal\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8457a0f3acfee4b9807f4c53ae88b5937af0431a3883", async() => {
                WriteLiteral("\n\n        <div class=\"form-group\">\n            \n            <label>Id</label>\n            <input  class=\"form-control\"\n                    type=\"text\" name=\"id\"");
                BeginWriteAttribute("value", "\n                    value=\"", 263, "\"", 300, 1);
#nullable restore
#line 11 "/Users/aldrinjr/ulbra/lpComercial/TarefasArnaldo/Views/TarefasArnaldo/Edit.cshtml"
WriteAttributeValue("", 291, Model.id, 291, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\n        </div>\n    \n        <div class=\"form-group\">\n            <label>Nome Tarefa</label>\n            <input  class=\"form-control\"\n                    type=\"text\" name=\"name\"");
                BeginWriteAttribute("value", "\n                    value=\"", 480, "\"", 519, 1);
#nullable restore
#line 18 "/Users/aldrinjr/ulbra/lpComercial/TarefasArnaldo/Views/TarefasArnaldo/Edit.cshtml"
WriteAttributeValue("", 508, Model.name, 508, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\n        </div>\n        \n        <div class=\"form-group\">\n            <label>Data Limite</label>\n            <input  class=\"form-control\"\n                    type=\"text\" name=\"date\"");
                BeginWriteAttribute("value", "\n                        value=\"", 703, "\"", 746, 1);
#nullable restore
#line 25 "/Users/aldrinjr/ulbra/lpComercial/TarefasArnaldo/Views/TarefasArnaldo/Edit.cshtml"
WriteAttributeValue("", 735, Model.date, 735, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\n        </div>\n\n           <div class=\"form-group\">\n            <label>Percentual Concluido</label>\n            <input  class=\"form-control\"\n                    type=\"text\" name=\"percentComplete\"");
                BeginWriteAttribute("value", "\n                        value=\"", 945, "\"", 999, 1);
#nullable restore
#line 32 "/Users/aldrinjr/ulbra/lpComercial/TarefasArnaldo/Views/TarefasArnaldo/Edit.cshtml"
WriteAttributeValue("", 977, Model.percentComplete, 977, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\n        </div>\n\n        <input  class=\"btn btn-primary\" \n                type=\"submit\" value=\"Salvar\"/>\n    ");
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
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TarefasArnaldo.Models.Task> Html { get; private set; }
    }
}
#pragma warning restore 1591
