#pragma checksum "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2264f94fa69bdf9bafe5560eb60ea73746a60a6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post__Post), @"mvc.1.0.view", @"/Views/Post/_Post.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2264f94fa69bdf9bafe5560eb60ea73746a60a6a", @"/Views/Post/_Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f8f19e3310f52f2995b1ca717e63201847c6b92", @"/Views/_ViewImports.cshtml")]
    public class Views_Post__Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
 if (ViewBag.List != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <br />
    <br />
    <div class=""col-12"">
        <table class=""table table-bordered"" style=""margin-top: 15px"">
            <caption style=""caption-side: top; color:black""><b>Last 10 Pull Requests</b></caption>
            <thead>
                <tr>
                    <th>Number</th>
                    <th>Title</th>
                    <th>Author</th>
                    <th>State</th>
                    <th>Created At</th>
                    <th>Closed At</th>
                    <th>Duration</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 21 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
                 foreach (var data in ViewBag.List)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 757, "\"", 773, 1);
#nullable restore
#line 24 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
WriteAttributeValue("", 764, data.Url, 764, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">");
#nullable restore
#line 24 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
                                                           Write(data.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                        <td>");
#nullable restore
#line 25 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
                       Write(data.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 890, "\"", 913, 1);
#nullable restore
#line 26 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
WriteAttributeValue("", 897, data.Author.Url, 897, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">");
#nullable restore
#line 26 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
                                                                  Write(data.Author.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                        <td>");
#nullable restore
#line 27 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
                       Write(data.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 28 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
                       Write(data.CreatedAt.ToLocalTime().ToString("dd.MM.yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n");
#nullable restore
#line 30 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
                             if (data.ClosedAt != ViewBag.nullTime)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
                           Write(data.ClosedAt.ToLocalTime().ToString("dd.MM.yyyy HH:mm"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
                                                                                         
                            }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("---");
#nullable restore
#line 36 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
                                                
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 40 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
                             if (data.ClosedAt != ViewBag.nullTime)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
                                 if ((data.ClosedAt - data.CreatedAt).Days != 0)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
                                Write((data.ClosedAt - data.CreatedAt).Days);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Days ");
#nullable restore
#line 44 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
                                                                                                ;
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
                                 if ((data.ClosedAt - data.CreatedAt).Hours != 0)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
                                Write((data.ClosedAt - data.CreatedAt).Hours);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Hours ");
#nullable restore
#line 48 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
                                                                                                  ;
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
                                 if ((data.ClosedAt - data.CreatedAt).Minutes != 0)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
                                Write((data.ClosedAt - data.CreatedAt).Minutes);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Minutes ");
#nullable restore
#line 52 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
                                                                                                      ;
                                }
                                else if ((data.ClosedAt - data.CreatedAt).Seconds != 0)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
                                Write((data.ClosedAt - data.CreatedAt).Seconds);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Seconds ");
#nullable restore
#line 56 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
                                                                                                      ;
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
                                 
                            }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("---");
#nullable restore
#line 61 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
                                                
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 65 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n");
#nullable restore
#line 70 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-4\">\r\n    <br />\r\n    <br />\r\n    <h4>\r\n        There is no pull request.\r\n    </h4>\r\n</div>\r\n");
#nullable restore
#line 80 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 82 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
  
    var Dictionary = (Dictionary<string, int>)ViewData["dictionary"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<br />
<div class=""col-6"">
    <table class=""table table-bordered"" style=""margin-top: 15px"">
        <caption style=""caption-side: top; color:black""><b>Top 10 Contributors</b></caption>
        <thead>
            <tr>
                <th>Name</th>
                <th>Commits</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 97 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
             foreach (var item in Dictionary.OrderByDescending(i => i.Value).Take(10))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 100 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
                   Write(item.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 101 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
                   Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 103 "C:\Users\leven\source\repos\leventyil\GitAnalytic\GitAnalytic\Views\Post\_Post.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
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
