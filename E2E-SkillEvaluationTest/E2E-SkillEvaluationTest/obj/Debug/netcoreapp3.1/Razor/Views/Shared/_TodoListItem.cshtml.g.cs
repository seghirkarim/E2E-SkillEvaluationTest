#pragma checksum "C:\Users\Karim\Desktop\E2E-SkillEvaluationTest\E2E-SkillEvaluationTest\E2E-SkillEvaluationTest\Views\Shared\_TodoListItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "669e7579e019337b104e9960779ab163da143906"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TodoListItem), @"mvc.1.0.view", @"/Views/Shared/_TodoListItem.cshtml")]
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
#line 1 "C:\Users\Karim\Desktop\E2E-SkillEvaluationTest\E2E-SkillEvaluationTest\E2E-SkillEvaluationTest\Views\_ViewImports.cshtml"
using E2E_SkillEvaluationTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Karim\Desktop\E2E-SkillEvaluationTest\E2E-SkillEvaluationTest\E2E-SkillEvaluationTest\Views\_ViewImports.cshtml"
using E2E_SkillEvaluationTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"669e7579e019337b104e9960779ab163da143906", @"/Views/Shared/_TodoListItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28eebb7825012af9e65886c9a8567df119000036", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TodoListItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Todo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<tr>\r\n    <th scope=\"row\">");
#nullable restore
#line 4 "C:\Users\Karim\Desktop\E2E-SkillEvaluationTest\E2E-SkillEvaluationTest\E2E-SkillEvaluationTest\Views\Shared\_TodoListItem.cshtml"
               Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    <td>\r\n        ");
#nullable restore
#line 6 "C:\Users\Karim\Desktop\E2E-SkillEvaluationTest\E2E-SkillEvaluationTest\E2E-SkillEvaluationTest\Views\Shared\_TodoListItem.cshtml"
   Write(Html.ActionLink(Model.Title, "Details", "Todo", new { id = Model.Id }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n");
#nullable restore
#line 9 "C:\Users\Karim\Desktop\E2E-SkillEvaluationTest\E2E-SkillEvaluationTest\E2E-SkillEvaluationTest\Views\Shared\_TodoListItem.cshtml"
         if (Model.Completed)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"badge badge-success\">Finished</span>\r\n");
#nullable restore
#line 12 "C:\Users\Karim\Desktop\E2E-SkillEvaluationTest\E2E-SkillEvaluationTest\E2E-SkillEvaluationTest\Views\Shared\_TodoListItem.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button type=\"button\" class=\"btn btn-warning markFinished\"");
            BeginWriteAttribute("value", " value=", 386, "", 402, 1);
#nullable restore
#line 15 "C:\Users\Karim\Desktop\E2E-SkillEvaluationTest\E2E-SkillEvaluationTest\E2E-SkillEvaluationTest\Views\Shared\_TodoListItem.cshtml"
WriteAttributeValue("", 393, Model.Id, 393, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Mark as finished</button>\r\n");
#nullable restore
#line 16 "C:\Users\Karim\Desktop\E2E-SkillEvaluationTest\E2E-SkillEvaluationTest\E2E-SkillEvaluationTest\Views\Shared\_TodoListItem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 19 "C:\Users\Karim\Desktop\E2E-SkillEvaluationTest\E2E-SkillEvaluationTest\E2E-SkillEvaluationTest\Views\Shared\_TodoListItem.cshtml"
   Write(Html.ActionLink("Edit", "Edit", "Todo", new { id = Model.Id }, new { @class = "btn btn-primary", @style = "color:white", @role = "button" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        <button type=\"button\" class=\"btn btn-danger delete\"");
            BeginWriteAttribute("value", " value=", 693, "", 709, 1);
#nullable restore
#line 22 "C:\Users\Karim\Desktop\E2E-SkillEvaluationTest\E2E-SkillEvaluationTest\E2E-SkillEvaluationTest\Views\Shared\_TodoListItem.cshtml"
WriteAttributeValue("", 700, Model.Id, 700, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</button>\r\n    </td>\r\n</tr>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Todo> Html { get; private set; }
    }
}
#pragma warning restore 1591
