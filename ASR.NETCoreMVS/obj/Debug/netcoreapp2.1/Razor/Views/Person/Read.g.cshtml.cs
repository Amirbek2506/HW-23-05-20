#pragma checksum "D:\projects\HW-23-05-20\ASR.NETCoreMVS\ASR.NETCoreMVS\Views\Person\Read.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "027a3f92eceea06bc0aa12de2cc11ba81bfc38c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Read), @"mvc.1.0.view", @"/Views/Person/Read.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Person/Read.cshtml", typeof(AspNetCore.Views_Person_Read))]
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
#line 1 "D:\projects\HW-23-05-20\ASR.NETCoreMVS\ASR.NETCoreMVS\Views\_ViewImports.cshtml"
using ASR.NETCoreMVS;

#line default
#line hidden
#line 2 "D:\projects\HW-23-05-20\ASR.NETCoreMVS\ASR.NETCoreMVS\Views\_ViewImports.cshtml"
using ASR.NETCoreMVS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"027a3f92eceea06bc0aa12de2cc11ba81bfc38c2", @"/Views/Person/Read.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e8a7747124f228477a47790d0b98ef68e1ff54e", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_Read : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70b4bf7a1cbc4b0994c9d7710040345e", async() => {
                BeginContext(31, 61, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n");
                EndContext();
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
            EndContext();
            BeginContext(99, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(101, 845, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "759e898ae18a41df9c5c5a5227e259c1", async() => {
                BeginContext(107, 440, true);
                WriteLiteral(@"
    <div>
        <text class=""text-info"">Таблица Person</text>
        <table class=""table table-bordered table-hover table-striped"">
            <thead>
                <tr>
                    <th scope=""col"">Id</th>
                    <th scope=""col"">Фамилия</th>
                    <th scope=""col"">Имя</th>
                    <th scope=""col"">Очество</th>
                </tr>
            </thead>
            <tbody>
");
                EndContext();
#line 19 "D:\projects\HW-23-05-20\ASR.NETCoreMVS\ASR.NETCoreMVS\Views\Person\Read.cshtml"
                 foreach (var person in Model)
                {

#line default
#line hidden
                BeginContext(614, 54, true);
                WriteLiteral("                    <tr>\r\n                        <td>");
                EndContext();
                BeginContext(669, 9, false);
#line 22 "D:\projects\HW-23-05-20\ASR.NETCoreMVS\ASR.NETCoreMVS\Views\Person\Read.cshtml"
                       Write(person.Id);

#line default
#line hidden
                EndContext();
                BeginContext(678, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(714, 15, false);
#line 23 "D:\projects\HW-23-05-20\ASR.NETCoreMVS\ASR.NETCoreMVS\Views\Person\Read.cshtml"
                       Write(person.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(729, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(765, 16, false);
#line 24 "D:\projects\HW-23-05-20\ASR.NETCoreMVS\ASR.NETCoreMVS\Views\Person\Read.cshtml"
                       Write(person.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(781, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(817, 17, false);
#line 25 "D:\projects\HW-23-05-20\ASR.NETCoreMVS\ASR.NETCoreMVS\Views\Person\Read.cshtml"
                       Write(person.MiddleName);

#line default
#line hidden
                EndContext();
                BeginContext(834, 34, true);
                WriteLiteral("</td>\r\n                    </tr>\r\n");
                EndContext();
#line 27 "D:\projects\HW-23-05-20\ASR.NETCoreMVS\ASR.NETCoreMVS\Views\Person\Read.cshtml"
                }

#line default
#line hidden
                BeginContext(887, 52, true);
                WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(946, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
