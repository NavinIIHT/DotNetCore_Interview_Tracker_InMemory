#pragma checksum "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\DeleteUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbc1c436e3517950ea55a398b50a343ba8b3554e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_DeleteUser), @"mvc.1.0.view", @"/Views/User/DeleteUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/DeleteUser.cshtml", typeof(AspNetCore.Views_User_DeleteUser))]
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
#line 1 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\_ViewImports.cshtml"
using InterviewTracker;

#line default
#line hidden
#line 2 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\_ViewImports.cshtml"
using InterviewTracker.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbc1c436e3517950ea55a398b50a343ba8b3554e", @"/Views/User/DeleteUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c65db002670eb00f1d552890840cda9fab809fae", @"/Views/_ViewImports.cshtml")]
    public class Views_User_DeleteUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InterviewTracker.Entities.ApplicationUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\DeleteUser.cshtml"
  
    ViewData["Title"] = "DeleteUser";

#line default
#line hidden
            BeginContext(96, 402, true);
            WriteLiteral(@"
<h3 class=""text-center text-uppercase"">Delete User Record</h3>
<div class=""card"" style=""width:50%; margin:auto;"">
    <div class=""card-header bg-danger text-white"">
        <h3>Are you sure you want to delete this?</h3>
    </div>
    <div class=""card-body"">
        <div class=""row"">
            <div class=""col-md-6"">
                <dl>
                    <dt>
                        ");
            EndContext();
            BeginContext(499, 45, false);
#line 16 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\DeleteUser.cshtml"
                   Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(544, 99, true);
            WriteLiteral("\r\n                    </dt>\r\n\r\n                    <dd class=\"col-md-10\">\r\n                        ");
            EndContext();
            BeginContext(644, 41, false);
#line 20 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\DeleteUser.cshtml"
                   Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(685, 180, true);
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                <dl>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(866, 44, false);
#line 27 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\DeleteUser.cshtml"
                   Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(910, 81, true);
            WriteLiteral("\r\n                    </dt>\r\n\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(992, 40, false);
#line 31 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\DeleteUser.cshtml"
                   Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1032, 223, true);
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6\">\r\n                <dl>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1256, 41, false);
#line 40 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\DeleteUser.cshtml"
                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1297, 81, true);
            WriteLiteral("\r\n                    </dt>\r\n\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1379, 37, false);
#line 44 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\DeleteUser.cshtml"
                   Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1416, 180, true);
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                <dl>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1597, 45, false);
#line 51 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\DeleteUser.cshtml"
                   Write(Html.DisplayNameFor(model => model.UserTypes));

#line default
#line hidden
            EndContext();
            BeginContext(1642, 81, true);
            WriteLiteral("\r\n                    </dt>\r\n\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(1724, 41, false);
#line 55 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\DeleteUser.cshtml"
                   Write(Html.DisplayFor(model => model.UserTypes));

#line default
#line hidden
            EndContext();
            BeginContext(1765, 223, true);
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6\">\r\n                <dl>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(1989, 40, false);
#line 64 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\DeleteUser.cshtml"
                   Write(Html.DisplayNameFor(model => model.Stat));

#line default
#line hidden
            EndContext();
            BeginContext(2029, 81, true);
            WriteLiteral("\r\n                    </dt>\r\n\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2111, 36, false);
#line 68 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\DeleteUser.cshtml"
                   Write(Html.DisplayFor(model => model.Stat));

#line default
#line hidden
            EndContext();
            BeginContext(2147, 180, true);
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                <dl>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(2328, 47, false);
#line 75 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\DeleteUser.cshtml"
                   Write(Html.DisplayNameFor(model => model.ReportingTo));

#line default
#line hidden
            EndContext();
            BeginContext(2375, 81, true);
            WriteLiteral("\r\n                    </dt>\r\n\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2457, 43, false);
#line 79 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\DeleteUser.cshtml"
                   Write(Html.DisplayFor(model => model.ReportingTo));

#line default
#line hidden
            EndContext();
            BeginContext(2500, 224, true);
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <dl>\r\n                    <dt>\r\n                        ");
            EndContext();
            BeginContext(2725, 48, false);
#line 88 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\DeleteUser.cshtml"
                   Write(Html.DisplayNameFor(model => model.MobileNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2773, 81, true);
            WriteLiteral("\r\n                    </dt>\r\n\r\n                    <dd>\r\n                        ");
            EndContext();
            BeginContext(2855, 44, false);
#line 92 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\DeleteUser.cshtml"
                   Write(Html.DisplayFor(model => model.MobileNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2899, 88, true);
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 97 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\DeleteUser.cshtml"
         using (Html.BeginForm())
        {
            

#line default
#line hidden
            BeginContext(3046, 23, false);
#line 99 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\DeleteUser.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(3071, 146, true);
            WriteLiteral("            <div class=\"form-actions no-color\">\r\n                <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n                ");
            EndContext();
            BeginContext(3218, 42, false);
#line 102 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\DeleteUser.cshtml"
           Write(Html.ActionLink("Back to List", "AllUser"));

#line default
#line hidden
            EndContext();
            BeginContext(3260, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 104 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\DeleteUser.cshtml"
        }

#line default
#line hidden
            BeginContext(3293, 19, true);
            WriteLiteral("    </div>\r\n</div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InterviewTracker.Entities.ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
