#pragma checksum "/Volumes/External Drive/Dropbox/dev/git/SortingAlgorithms/Views/Sort/Sort.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f3e49daa5a35a8339057eaed2f227fab4e51fea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sort_Sort), @"mvc.1.0.view", @"/Views/Sort/Sort.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sort/Sort.cshtml", typeof(AspNetCore.Views_Sort_Sort))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f3e49daa5a35a8339057eaed2f227fab4e51fea", @"/Views/Sort/Sort.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"458eb8d3abbcc848c0f29ebdbae721e99aef26f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Sort_Sort : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SortController>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(83, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "/Volumes/External Drive/Dropbox/dev/git/SortingAlgorithms/Views/Sort/Sort.cshtml"
  
    ViewData["Title"] = "Sorting Algorithm";

#line default
#line hidden
            BeginContext(139, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(144, 17, false);
#line 8 "/Volumes/External Drive/Dropbox/dev/git/SortingAlgorithms/Views/Sort/Sort.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(161, 102, true);
            WriteLiteral("</h2>\r\n\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            ");
            EndContext();
            BeginContext(264, 47, false);
#line 13 "/Volumes/External Drive/Dropbox/dev/git/SortingAlgorithms/Views/Sort/Sort.cshtml"
       Write(await Html.PartialAsync("_SortSelector", Model));

#line default
#line hidden
            EndContext();
            BeginContext(311, 187, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <div class=\"panel panel-success\">\r\n                <div class=\"panel-heading\">Results of the ");
            EndContext();
            BeginContext(499, 16, false);
#line 20 "/Volumes/External Drive/Dropbox/dev/git/SortingAlgorithms/Views/Sort/Sort.cshtml"
                                                     Write(ViewBag.SortType);

#line default
#line hidden
            EndContext();
            BeginContext(515, 236, true);
            WriteLiteral("</div>\r\n                <div class=\"panel-body\">\r\n                    <div style=\"display: block; float: right; text-align: left; width: 50%;\">\r\n                        <p><b>Additional Details</b></p>\r\n                        <p></p>\r\n");
            EndContext();
            BeginContext(1079, 133, true);
            WriteLiteral("\r\n                    </div>\r\n                    <dl>\r\n                        <dt>Before Sorting</dt>\r\n                        <dd>");
            EndContext();
            BeginContext(1213, 23, false);
#line 33 "/Volumes/External Drive/Dropbox/dev/git/SortingAlgorithms/Views/Sort/Sort.cshtml"
                       Write(ViewBag.OriginalNumbers);

#line default
#line hidden
            EndContext();
            BeginContext(1236, 124, true);
            WriteLiteral("</dd>\r\n                        <dd>&nbsp;</dd>\r\n                        <dt>After Sorting</dt>\r\n                        <dd>");
            EndContext();
            BeginContext(1361, 21, false);
#line 36 "/Volumes/External Drive/Dropbox/dev/git/SortingAlgorithms/Views/Sort/Sort.cshtml"
                       Write(ViewBag.SortedNumbers);

#line default
#line hidden
            EndContext();
            BeginContext(1382, 143, true);
            WriteLiteral("</dd>\r\n                        <dd>&nbsp;</dd>\r\n                        <dt>Below is every step of the sort:</dt>\r\n                        <dd>");
            EndContext();
            BeginContext(1526, 76, false);
#line 39 "/Volumes/External Drive/Dropbox/dev/git/SortingAlgorithms/Views/Sort/Sort.cshtml"
                       Write(Html.Raw(ViewBag.EachIteration.Replace(System.Environment.NewLine, "<br/>")));

#line default
#line hidden
            EndContext();
            BeginContext(1602, 114, true);
            WriteLiteral("</dd>\r\n                    </dl>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SortController> Html { get; private set; }
    }
}
#pragma warning restore 1591
