#pragma checksum "C:\Users\Karim\Desktop\E2E-SkillEvaluationTest\E2E-SkillEvaluationTest\E2E-SkillEvaluationTest\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00c1ba8c789c9ed5707c9b0b2dc0f55ffda26059"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00c1ba8c789c9ed5707c9b0b2dc0f55ffda26059", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28eebb7825012af9e65886c9a8567df119000036", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Todo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Karim\Desktop\E2E-SkillEvaluationTest\E2E-SkillEvaluationTest\E2E-SkillEvaluationTest\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1 class=""display-4"">My To-do list</h1>
<hr />
<table id=""dataTable"" class=""table table-striped"" style=""min-width:100%"">
    <thead>
        <tr>
            <th>ID</th>
            <th>Title</th>
            <th>Finished</th>
            <th></th>
            <th>");
#nullable restore
#line 14 "C:\Users\Karim\Desktop\E2E-SkillEvaluationTest\E2E-SkillEvaluationTest\E2E-SkillEvaluationTest\Views\Home\Index.cshtml"
           Write(Html.ActionLink("Add To-do", "Create", "Todo", new { @class = "btn btn-primary", @style = "color:white", @role = "button" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 18 "C:\Users\Karim\Desktop\E2E-SkillEvaluationTest\E2E-SkillEvaluationTest\E2E-SkillEvaluationTest\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {
            await Html.RenderPartialAsync("_TodoListItem", item);
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<script>
    var dataTable

    $(document).ready(function () {
        dataTable = $('#dataTable').DataTable({
            ""columnDefs"": [
                {
                    ""targets"": [3,4],
                    orderable: false
                },
            ]
        });
    });

    $('#dataTable tbody').on('click', '.markFinished', function () {
        var button = $(this);
        var Id = $(this).val();
        if (confirm(""This Todo will be marked as finished!"")) {
            $.ajax({
                url: ""/Todo/MarkFinished/"" + Id,
                type: ""Get""
            }).done(function () {
                button.replaceWith('<span class=""badge badge-success"">Finished</span>');
            }).fail(function () {
                alert(""Something Went Wrong."");
            });
        }
    });

    $('#dataTable tbody').on('click', '.delete', function () {
        var button = $(this);
        var Id = $(this).val();
        if (confirm(""");
            WriteLiteral(@"This Todo will be deleted!"")) {
            $.ajax({
                url: ""/Todo/Delete/"" + Id,
                type: ""Get""
            }).done(function () {
                var pageNumber = dataTable.page.info().page
                dataTable
                    .row($(button).parents(""tr""))
                    .remove()
                    .page(pageNumber)
                    .draw('page');
            }).fail(function () {
                alert(""Something Went Wrong."");
            });
        }
    });
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Todo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
