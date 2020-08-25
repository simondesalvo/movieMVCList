#pragma checksum "/Users/simon/Documents/GrandCircus/movieMVCLists/movieregistration/Views/Home/Display.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74079ffc661290abe42288f521184e002000350d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Display), @"mvc.1.0.view", @"/Views/Home/Display.cshtml")]
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
#line 1 "/Users/simon/Documents/GrandCircus/movieMVCLists/movieregistration/Views/_ViewImports.cshtml"
using movieregistration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/simon/Documents/GrandCircus/movieMVCLists/movieregistration/Views/_ViewImports.cshtml"
using movieregistration.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/simon/Documents/GrandCircus/movieMVCLists/movieregistration/Views/Home/Display.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/simon/Documents/GrandCircus/movieMVCLists/movieregistration/Views/Home/Display.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74079ffc661290abe42288f521184e002000350d", @"/Views/Home/Display.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ed7c5ccd4abd76e441c19fc47c4842bd985dc6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Display : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/simon/Documents/GrandCircus/movieMVCLists/movieregistration/Views/Home/Display.cshtml"
  
    ViewData["Title"] = "Movie Registration Display";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 9 "/Users/simon/Documents/GrandCircus/movieMVCLists/movieregistration/Views/Home/Display.cshtml"
  List<Movie> movieList = new List<Movie>(); 

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/simon/Documents/GrandCircus/movieMVCLists/movieregistration/Views/Home/Display.cshtml"
  string movieListJSON = Context.Session.GetString("MovieListSession");
    if (movieListJSON != "EmptySession")
    {
        movieList = JsonSerializer.Deserialize<List<Movie>>(movieListJSON);
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/simon/Documents/GrandCircus/movieMVCLists/movieregistration/Views/Home/Display.cshtml"
 foreach (var movies in movieList)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/Users/simon/Documents/GrandCircus/movieMVCLists/movieregistration/Views/Home/Display.cshtml"
Write(movies.Title);

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/Users/simon/Documents/GrandCircus/movieMVCLists/movieregistration/Views/Home/Display.cshtml"
                 ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 20 "/Users/simon/Documents/GrandCircus/movieMVCLists/movieregistration/Views/Home/Display.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<a href=\"Registration\" class=\"btn btn-success\">Add More Movies to a List</a>\r\n<a href=\"EndSession\" class=\"btn btn-danger\">Remove Movie List</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591