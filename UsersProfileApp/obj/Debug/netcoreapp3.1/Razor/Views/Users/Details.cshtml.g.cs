#pragma checksum "C:\Kannan\Interview\UsersProfileApp\UsersProfileApp\Views\Users\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fadf0f286aabf9dcfcb995766c01a204897b15c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(UsersProfileApp.Pages.Users.Views_Users_Details), @"mvc.1.0.view", @"/Views/Users/Details.cshtml")]
namespace UsersProfileApp.Pages.Users
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
#line 1 "C:\Kannan\Interview\UsersProfileApp\UsersProfileApp\Views\_ViewImports.cshtml"
using UsersProfileApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fadf0f286aabf9dcfcb995766c01a204897b15c6", @"/Views/Users/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9bb9502129035caa504b298a9920b8c8564f2cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UsersProfileApp.ViewModels.UsersViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Kannan\Interview\UsersProfileApp\UsersProfileApp\Views\Users\Details.cshtml"
   ViewData["Title"] = "Users"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Users</h1>\n");
#nullable restore
#line 6 "C:\Kannan\Interview\UsersProfileApp\UsersProfileApp\Views\Users\Details.cshtml"
 using (Html.BeginForm("Create", "Users", FormMethod.Post))
{


#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Kannan\Interview\UsersProfileApp\UsersProfileApp\Views\Users\Details.cshtml"
Write(Html.LabelFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Kannan\Interview\UsersProfileApp\UsersProfileApp\Views\Users\Details.cshtml"
                                    Write(Html.EditorFor(model => model.FirstName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Kannan\Interview\UsersProfileApp\UsersProfileApp\Views\Users\Details.cshtml"
                                                                                                                                        Write(Html.ValidationMessageFor(model => model.FirstName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Kannan\Interview\UsersProfileApp\UsersProfileApp\Views\Users\Details.cshtml"
           Write(Html.ValidationMessageFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Kannan\Interview\UsersProfileApp\UsersProfileApp\Views\Users\Details.cshtml"
                           Write(Html.LabelFor(model => model.LastName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Kannan\Interview\UsersProfileApp\UsersProfileApp\Views\Users\Details.cshtml"
                                                                   Write(Html.EditorFor(model => model.LastName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Kannan\Interview\UsersProfileApp\UsersProfileApp\Views\Users\Details.cshtml"
                                                                                                                                                                      Write(Html.ValidationMessageFor(model => model.LastName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <input type=\"submit\" value=\"Submit\" />\n");
            WriteLiteral(@"                                                                <div class=""panel-body"">
                                                                    <table id=""assets-data-table"" class=""table table-striped table-bordered"" style=""width:100%"">
                                                                        <thead>
                                                                            <tr>
                                                                                <th>First name</th>
                                                                                <th>Last name</th>
                                                                            </tr>
                                                                        </thead>
                                                                        <tbody>
");
#nullable restore
#line 24 "C:\Kannan\Interview\UsersProfileApp\UsersProfileApp\Views\Users\Details.cshtml"
                                                                             foreach (var user in ViewBag.Users)
                                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                                <tr>\n                                                                                    <td>");
#nullable restore
#line 27 "C:\Kannan\Interview\UsersProfileApp\UsersProfileApp\Views\Users\Details.cshtml"
                                                                                   Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                                    <td>");
#nullable restore
#line 28 "C:\Kannan\Interview\UsersProfileApp\UsersProfileApp\Views\Users\Details.cshtml"
                                                                                   Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                                </tr>\n");
#nullable restore
#line 30 "C:\Kannan\Interview\UsersProfileApp\UsersProfileApp\Views\Users\Details.cshtml"

                                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                        </tbody>\n                                                                    </table>\n                                                                </div>");
#nullable restore
#line 34 "C:\Kannan\Interview\UsersProfileApp\UsersProfileApp\Views\Users\Details.cshtml"
                                                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 37 "C:\Kannan\Interview\UsersProfileApp\UsersProfileApp\Views\Users\Details.cshtml"
 if (ViewBag.Message != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("< script type = \"text/javascript\" >\n\n    window.onload = function() {\n    alert(\"");
#nullable restore
#line 41 "C:\Kannan\Interview\UsersProfileApp\UsersProfileApp\Views\Users\Details.cshtml"
      Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\n    };\n    </ script >");
#nullable restore
#line 43 "C:\Kannan\Interview\UsersProfileApp\UsersProfileApp\Views\Users\Details.cshtml"
               }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UsersProfileApp.ViewModels.UsersViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
