#pragma checksum "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Home\_Repo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae1aca65a793e1618e4d818d9a0627b8bd10da19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__Repo), @"mvc.1.0.view", @"/Views/Home/_Repo.cshtml")]
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
#line 1 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\_ViewImports.cshtml"
using GitAnalytic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\_ViewImports.cshtml"
using GitAnalytic.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae1aca65a793e1618e4d818d9a0627b8bd10da19", @"/Views/Home/_Repo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f8f19e3310f52f2995b1ca717e63201847c6b92", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__Repo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("https://localhost:5003/home"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("getGrid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Home\_Repo.cshtml"
 if (ViewBag.ResponseStatus != false)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae1aca65a793e1618e4d818d9a0627b8bd10da194837", async() => {
                WriteLiteral("\r\n            <label><b>Repository Name</b></label>\r\n            <br />\r\n            ");
#nullable restore
#line 7 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Home\_Repo.cshtml"
       Write(Html.DropDownList("Repo", (IEnumerable<SelectListItem>)ViewBag.repoNames, new { @id = "Selection", @class = "form-control", @onchange = "document.cookie = 'repoCookie = ' + this.selectedIndex + '; path=/;' + 'expires= Fri, 31 Dec 9999 23:59:59 GMT'" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <br />\r\n            <a class=\"btn btn-primary\" href=\"#\" id=\"getData\">Get Git Analytics</a>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral(@"    <script>
        function readCookie(name) {
            var nameEQ = name + ""="";
            var ca = document.cookie.split(';');
            for (var i = 0; i < ca.length; i++) {
                var c = ca[i];
                while (c.charAt(0) == ' ') c = c.substring(1, c.length);
                if (c.indexOf(nameEQ) == 0) return c.substring(nameEQ.length, c.length);
            }
            return null;
        }
        window.onload = function () { document.getElementById(""Selection"").selectedIndex = readCookie(""repoCookie""); }
    </script>
    <script>
    $('#getData').click(function (e) {

                e.preventDefault();
                var select = $(""#Selection option:selected"").val();
                var select2 = $(""#Organization option:selected"").val();

                $.ajax({
                    url: '");
#nullable restore
#line 34 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Home\_Repo.cshtml"
                     Write(Url.Action("Post", "Post"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                    type: ""POST"",
                    data: { 'Repo': select, 'User': select2 },
                    dataType: ""text"",
                    success: function (result) {
                        $(""#postDiv"").html(result);
                    },
                    error: function (xhr, status) {
                        alert(status);
                    }
                });
            });
    </script>
");
#nullable restore
#line 47 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Home\_Repo.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-4\">\r\n    <br />\r\n    <h3 style=\"color:red\">Error: Not authorized.\r\n        <br />\r\n        Please enter a valid token.</h3>\r\n</div>\r\n");
#nullable restore
#line 56 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Home\_Repo.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
