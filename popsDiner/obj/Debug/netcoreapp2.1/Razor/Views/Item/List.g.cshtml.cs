#pragma checksum "C:\Users\patel\OneDrive\Desktop\popsDiner\popsDiner\Views\Item\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3391096cf372e7dfa16330cd53710438eb5b0d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_List), @"mvc.1.0.view", @"/Views/Item/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Item/List.cshtml", typeof(AspNetCore.Views_Item_List))]
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
#line 1 "C:\Users\patel\OneDrive\Desktop\popsDiner\popsDiner\Views\_ViewImports.cshtml"
using popsDiner.Models;

#line default
#line hidden
#line 2 "C:\Users\patel\OneDrive\Desktop\popsDiner\popsDiner\Views\_ViewImports.cshtml"
using popsDiner.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3391096cf372e7dfa16330cd53710438eb5b0d5", @"/Views/Item/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"970c2464b334b9df4f68878ae669cafcf089643b", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ItemsListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 23, false);
#line 2 "C:\Users\patel\OneDrive\Desktop\popsDiner\popsDiner\Views\Item\List.cshtml"
Write(ViewBag.CurrentCategory);

#line default
#line hidden
            EndContext();
            BeginContext(51, 8, true);
            WriteLiteral("\r\n\r\n<h1>");
            EndContext();
            BeginContext(60, 21, false);
#line 4 "C:\Users\patel\OneDrive\Desktop\popsDiner\popsDiner\Views\Item\List.cshtml"
Write(Model.CurrentCategory);

#line default
#line hidden
            EndContext();
            BeginContext(81, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
#line 5 "C:\Users\patel\OneDrive\Desktop\popsDiner\popsDiner\Views\Item\List.cshtml"
 foreach (var item in Model.Items)
{
    

#line default
#line hidden
            BeginContext(288, 95, true);
            WriteLiteral("    <div class=\"col-sm-4 col-lg-4 col-md-4\">\r\n        <div class=\"thumbnail\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 383, "\"", 412, 1);
#line 15 "C:\Users\patel\OneDrive\Desktop\popsDiner\popsDiner\Views\Item\List.cshtml"
WriteAttributeValue("", 389, item.ImageThumbnailUrl, 389, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(413, 84, true);
            WriteLiteral(" alt=\"\">\r\n            <div class=\"caption\">\r\n                <h3 class=\"pull-right\">");
            EndContext();
            BeginContext(498, 24, false);
#line 17 "C:\Users\patel\OneDrive\Desktop\popsDiner\popsDiner\Views\Item\List.cshtml"
                                  Write(item.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(522, 52, true);
            WriteLiteral("</h3>\r\n                <h3>\r\n                    <a>");
            EndContext();
            BeginContext(575, 9, false);
#line 19 "C:\Users\patel\OneDrive\Desktop\popsDiner\popsDiner\Views\Item\List.cshtml"
                  Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(584, 48, true);
            WriteLiteral("</a>\r\n                </h3>\r\n                <p>");
            EndContext();
            BeginContext(633, 21, false);
#line 21 "C:\Users\patel\OneDrive\Desktop\popsDiner\popsDiner\Views\Item\List.cshtml"
              Write(item.shortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(654, 54, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 25 "C:\Users\patel\OneDrive\Desktop\popsDiner\popsDiner\Views\Item\List.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ItemsListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
