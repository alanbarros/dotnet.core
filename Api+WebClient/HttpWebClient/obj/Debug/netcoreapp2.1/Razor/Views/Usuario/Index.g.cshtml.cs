#pragma checksum "/home/alan/Documentos/dotnet/DOTNET CORE/Api+WebClient/HttpWebClient/Views/Usuario/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f1bea3d9edd03a07a7e6797d9b28c1f9eaa5d34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Index), @"mvc.1.0.view", @"/Views/Usuario/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Index.cshtml", typeof(AspNetCore.Views_Usuario_Index))]
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
#line 1 "/home/alan/Documentos/dotnet/DOTNET CORE/Api+WebClient/HttpWebClient/Views/_ViewImports.cshtml"
using HttpWebClient;

#line default
#line hidden
#line 2 "/home/alan/Documentos/dotnet/DOTNET CORE/Api+WebClient/HttpWebClient/Views/_ViewImports.cshtml"
using HttpWebClient.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f1bea3d9edd03a07a7e6797d9b28c1f9eaa5d34", @"/Views/Usuario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8927d2066abd0a0f928b718b7926279e6b6193d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UsuarioAPI.Models.Usuario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(46, 37, true);
            WriteLiteral("\n<h1>Lista de usuarios</h1>\n\n<p>\n    ");
            EndContext();
            BeginContext(83, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53ef3d4877a9430287aef4547ec4d17c", async() => {
                BeginContext(106, 10, true);
                WriteLiteral("Criar Novo");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(120, 69, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>");
            EndContext();
            BeginContext(190, 38, false);
#line 11 "/home/alan/Documentos/dotnet/DOTNET CORE/Api+WebClient/HttpWebClient/Views/Usuario/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(228, 22, true);
            WriteLiteral("</th>\n            <th>");
            EndContext();
            BeginContext(251, 44, false);
#line 12 "/home/alan/Documentos/dotnet/DOTNET CORE/Api+WebClient/HttpWebClient/Views/Usuario/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
            EndContext();
            BeginContext(295, 22, true);
            WriteLiteral("</th>\n            <th>");
            EndContext();
            BeginContext(318, 44, false);
#line 13 "/home/alan/Documentos/dotnet/DOTNET CORE/Api+WebClient/HttpWebClient/Views/Usuario/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(362, 67, true);
            WriteLiteral("</th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 18 "/home/alan/Documentos/dotnet/DOTNET CORE/Api+WebClient/HttpWebClient/Views/Usuario/Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(476, 58, true);
            WriteLiteral("            <tr>\n                <td>\n                    ");
            EndContext();
            BeginContext(535, 37, false);
#line 22 "/home/alan/Documentos/dotnet/DOTNET CORE/Api+WebClient/HttpWebClient/Views/Usuario/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(572, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(637, 43, false);
#line 25 "/home/alan/Documentos/dotnet/DOTNET CORE/Api+WebClient/HttpWebClient/Views/Usuario/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Username));

#line default
#line hidden
            EndContext();
            BeginContext(680, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(745, 43, false);
#line 28 "/home/alan/Documentos/dotnet/DOTNET CORE/Api+WebClient/HttpWebClient/Views/Usuario/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
            EndContext();
            BeginContext(788, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(853, 66, false);
#line 31 "/home/alan/Documentos/dotnet/DOTNET CORE/Api+WebClient/HttpWebClient/Views/Usuario/Index.cshtml"
               Write(Html.ActionLink("Remover","Delete","Usuario", new { Id = item.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(919, 23, true);
            WriteLiteral(" |\n                    ");
            EndContext();
            BeginContext(943, 62, false);
#line 32 "/home/alan/Documentos/dotnet/DOTNET CORE/Api+WebClient/HttpWebClient/Views/Usuario/Index.cshtml"
               Write(Html.ActionLink("Editar","Edit","Usuario",new { Id = item.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(1005, 23, true);
            WriteLiteral(" |\n                    ");
            EndContext();
            BeginContext(1029, 68, false);
#line 33 "/home/alan/Documentos/dotnet/DOTNET CORE/Api+WebClient/HttpWebClient/Views/Usuario/Index.cshtml"
               Write(Html.ActionLink("Detalhes","Details","Usuario", new { Id = item.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(1097, 41, true);
            WriteLiteral("\n                </td>\n            </tr>\n");
            EndContext();
#line 36 "/home/alan/Documentos/dotnet/DOTNET CORE/Api+WebClient/HttpWebClient/Views/Usuario/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1148, 21, true);
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UsuarioAPI.Models.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
