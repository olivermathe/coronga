#pragma checksum "/home/razor1911/ulbra/lpComercial/TarefasController/Views/Tarefa/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c2be9e792cfa30bea504b0a2dd1c564ca911e96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tarefa_Index), @"mvc.1.0.view", @"/Views/Tarefa/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tarefa/Index.cshtml", typeof(AspNetCore.Views_Tarefa_Index))]
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
#line 1 "/home/razor1911/ulbra/lpComercial/TarefasController/Views/_ViewImports.cshtml"
using TarefasController;

#line default
#line hidden
#line 2 "/home/razor1911/ulbra/lpComercial/TarefasController/Views/_ViewImports.cshtml"
using TarefasController.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c2be9e792cfa30bea504b0a2dd1c564ca911e96", @"/Views/Tarefa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e8b6bb33ad375226450ee01e0069224cbf29ac4", @"/Views/_ViewImports.cshtml")]
    public class Views_Tarefa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TarefasController.Models.Tarefa>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 495, true);
            WriteLiteral(@"<!-- model do razor tem que receber a view do app pleople-->
</br></br>
<a href=""Tarefa/Create"" class=""btn btn-primary"">Nova tarefa</a> <!--usou o esquema do botao do bootstrap-->
</br></br>
<div class=""container"">
    <table class=""table"">
        <thead>
            <tr>
                <th>Id</th>
                <th>tarefaNome</th>
                <th>dataLimite</th>
                <th>percentConcluido</th>
                <th></th>
            </tr>
            </tr>
        </thead>
");
            EndContext();
#line 18 "/home/razor1911/ulbra/lpComercial/TarefasController/Views/Tarefa/Index.cshtml"
         foreach(var item in Model)
        { 

#line default
#line hidden
            BeginContext(595, 37, true);
            WriteLiteral("            <tr>\n                <td>");
            EndContext();
            BeginContext(633, 7, false);
#line 21 "/home/razor1911/ulbra/lpComercial/TarefasController/Views/Tarefa/Index.cshtml"
               Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(640, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(667, 15, false);
#line 22 "/home/razor1911/ulbra/lpComercial/TarefasController/Views/Tarefa/Index.cshtml"
               Write(item.tarefaNome);

#line default
#line hidden
            EndContext();
            BeginContext(682, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(709, 15, false);
#line 23 "/home/razor1911/ulbra/lpComercial/TarefasController/Views/Tarefa/Index.cshtml"
               Write(item.dataLimite);

#line default
#line hidden
            EndContext();
            BeginContext(724, 51, true);
            WriteLiteral("</td>\n                <td><a class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", "\n                         href=\"", 775, "\"", 829, 2);
            WriteAttributeValue("", 807, "Tarefa/Delete/", 807, 14, true);
#line 25 "/home/razor1911/ulbra/lpComercial/TarefasController/Views/Tarefa/Index.cshtml"
WriteAttributeValue("", 821, item.id, 821, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(830, 65, true);
            WriteLiteral(">Deletar</a> </td>\n                <td><a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", "\n                         href=\"", 895, "\"", 947, 2);
            WriteAttributeValue("", 927, "Tarefa/Edit/", 927, 12, true);
#line 27 "/home/razor1911/ulbra/lpComercial/TarefasController/Views/Tarefa/Index.cshtml"
WriteAttributeValue("", 939, item.id, 939, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(948, 36, true);
            WriteLiteral(">Editar</a> </td>\n            </tr>\n");
            EndContext();
#line 29 "/home/razor1911/ulbra/lpComercial/TarefasController/Views/Tarefa/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(994, 19, true);
            WriteLiteral("    </table>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TarefasController.Models.Tarefa>> Html { get; private set; }
    }
}
#pragma warning restore 1591