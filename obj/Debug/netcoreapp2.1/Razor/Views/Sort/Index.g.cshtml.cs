#pragma checksum "/Volumes/External Drive/Dropbox/dev/git/SortingAlgorithms/Views/Sort/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b40532795c8830c01658b278df20fab59a918b52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sort_Index), @"mvc.1.0.view", @"/Views/Sort/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sort/Index.cshtml", typeof(AspNetCore.Views_Sort_Index))]
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
#line 1 "/Volumes/External Drive/Dropbox/dev/git/SortingAlgorithms/Views/_ViewImports.cshtml"
using SortingAlgorithms;

#line default
#line hidden
#line 2 "/Volumes/External Drive/Dropbox/dev/git/SortingAlgorithms/Views/_ViewImports.cshtml"
using SortingAlgorithms.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b40532795c8830c01658b278df20fab59a918b52", @"/Views/Sort/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"458eb8d3abbcc848c0f29ebdbae721e99aef26f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Sort_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SortModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Volumes/External Drive/Dropbox/dev/git/SortingAlgorithms/Views/Sort/Index.cshtml"
  
    ViewData["Title"] = "Sorting Algorithm";

#line default
#line hidden
            BeginContext(73, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(78, 17, false);
#line 6 "/Volumes/External Drive/Dropbox/dev/git/SortingAlgorithms/Views/Sort/Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(95, 102, true);
            WriteLiteral("</h2>\r\n\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            ");
            EndContext();
            BeginContext(198, 47, false);
#line 11 "/Volumes/External Drive/Dropbox/dev/git/SortingAlgorithms/Views/Sort/Index.cshtml"
       Write(await Html.PartialAsync("_SortSelector", Model));

#line default
#line hidden
            EndContext();
            BeginContext(245, 38, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SortModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
