#pragma checksum "C:\dre\projects\EMF\Views\Verses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8639067c8bbf39d7989940cc44aec6c5df9b4110"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Verses_Index), @"mvc.1.0.view", @"/Views/Verses/Index.cshtml")]
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
#line 1 "C:\dre\projects\EMF\Views\_ViewImports.cshtml"
using EMF;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\dre\projects\EMF\Views\_ViewImports.cshtml"
using EMF.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8639067c8bbf39d7989940cc44aec6c5df9b4110", @"/Views/Verses/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e12c156dcdbed6113de527842e61443c1d13779", @"/Views/_ViewImports.cshtml")]
    public class Views_Verses_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EMF.Models.Rootobject>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/klove.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\dre\projects\EMF\Views\Verses\Index.cshtml"
  
    ViewData["Title"] = "KLove Verse of the Day";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8639067c8bbf39d7989940cc44aec6c5df9b41103571", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div>\r\n    <h4>Verses for ");
#nullable restore
#line 11 "C:\dre\projects\EMF\Views\Verses\Index.cshtml"
              Write(ViewData["verseDate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
    <hr />
    <br />

    <table class=""table table-striped table-bordered"" id=""assets-data-table"">
        <thead>
            <tr>
                <th style=""display:none"">
                    ID
                </th>
                <th>
                    Verse
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody>

");
#nullable restore
#line 29 "C:\dre\projects\EMF\Views\Verses\Index.cshtml"
             foreach (var item in Model.Verses)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td style=\"display:none\">\r\n                        ");
#nullable restore
#line 33 "C:\dre\projects\EMF\Views\Verses\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 36 "C:\dre\projects\EMF\Views\Verses\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.VerseText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a href=\'#\'");
            BeginWriteAttribute("onclick", " onclick=\'", 979, "\'", 1035, 5);
            WriteAttributeValue("", 989, "saveToFavorites(`", 989, 17, true);
#nullable restore
#line 39 "C:\dre\projects\EMF\Views\Verses\Index.cshtml"
WriteAttributeValue("", 1006, item.Id, 1006, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1014, "`,`", 1014, 3, true);
#nullable restore
#line 39 "C:\dre\projects\EMF\Views\Verses\Index.cshtml"
WriteAttributeValue("", 1017, item.VerseText, 1017, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1032, "`);", 1032, 3, true);
            EndWriteAttribute();
            WriteLiteral(">Save to Favorites</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 42 "C:\dre\projects\EMF\Views\Verses\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n        <script type=\"text/javascript\">\r\n            $(document).ready(function () {\r\n\r\n                // $(\'#assets-data-table\').DataTable();\r\n\r\n            });\r\n        </script>\r\n    ");
            }
            );
            WriteLiteral(@"


    <script type=""text/javascript"">

        function saveToFavorites(id, vt) {

            $.ajax('/Favorites/SaveToFavorites',
                {
                    data: { id: id, verse: vt },
                    dataType: 'json', // type of response data
                    // timeout: 5000,     // timeout milliseconds
                    success: function (data, status, xhr) {
                        if (data) {
                            $.confirm({
                                title: 'Success',
                                content: 'Saved to your favorites',
                                type: 'green',
                                typeAnimated: true,
                                buttons: {
                                    close: function () {
                                    }
                                }
                            });
                        }
                        else {
                            $.confirm({
              ");
            WriteLiteral(@"                  title: 'Alert',
                                content: 'This verse is already in your favorites',
                                type: 'red',
                                typeAnimated: true,
                                buttons: {
                                    close: function () {
                                    }
                                }
                            });
                        }
                    },
                    error: function (jqXhr, textStatus, errorMessage) { // error callback
                        $.confirm({
                            title: 'Error',
                            content: errorMessage,
                            type: 'red',
                            typeAnimated: true,
                            buttons: {
                                close: function () {
                                }
                            }
                        });
                    }
                }");
            WriteLiteral(");\r\n\r\n        }\r\n\r\n\r\n    </script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EMF.Models.Rootobject> Html { get; private set; }
    }
}
#pragma warning restore 1591
