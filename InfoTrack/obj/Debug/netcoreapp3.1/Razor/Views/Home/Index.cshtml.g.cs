#pragma checksum "C:\Users\mattreynolds\source\repos\InfoTrack\InfoTrack\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2d643688d006a186c14555601603b6c3ec60864"
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
#line 1 "C:\Users\mattreynolds\source\repos\InfoTrack\InfoTrack\Views\_ViewImports.cshtml"
using InfoTrack;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mattreynolds\source\repos\InfoTrack\InfoTrack\Views\_ViewImports.cshtml"
using InfoTrack.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2d643688d006a186c14555601603b6c3ec60864", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdeb6d7649b7ce8503e5118a8ca59f12ebcf0bca", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\mattreynolds\source\repos\InfoTrack\InfoTrack\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <div class=""container"">
        <div class=""form-group"">
            <div class=""row"">
                <div class=""col-sm-6"">
                    <label class=""form-label"" for=""keywords"">Keywords</label>
                    <input type=""text"" id=""keywords"" data-bind=""value: keywords"" class=""form-control"" />
                </div>
                <div class=""col-sm-6"">
                    <label class=""form-label"" for=""uri"">URL</label>
                    <input type=""text"" id=""uri"" data-bind=""value: uri"" class=""form-control"" />
                </div>
            </div>
        </div>
        <div class=""form-group"">
            <div class=""row"">
                <div class=""align-items-center col-sm-12"">
                    <button class=""btn btn-primary btn-lg"" data-bind=""click: search, disable: searching() || (!uri() || !keywords()) "">
                        <span>Search</span>
                        <span data-bind=");
            WriteLiteral(@"""visible: searching"" class=""spinner-border spinner-border-sm"" role=""status"" aria-hidden=""true""></span>
                    </button>
                </div>
            </div>
        </div>
        <div class=""form-group"">
            <div class=""row"">
                <div class=""align-items-center col-sm-12"">
                    <label class=""form-label"" data-bind=""visible: results"">Indexed Positions</label>
                    <div data-bind=""text: results""></div>
                </div>
            </div>
        </div>
    </div>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
