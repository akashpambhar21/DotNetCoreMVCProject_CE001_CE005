#pragma checksum "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be230c143951fc64bdd62b06598985d9b06a2583"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Details), @"mvc.1.0.view", @"/Views/Movie/Details.cshtml")]
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
#line 1 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\_ViewImports.cshtml"
using MovieTicketBooking.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\_ViewImports.cshtml"
using MovieTicketBooking.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be230c143951fc64bdd62b06598985d9b06a2583", @"/Views/Movie/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"633685069679b088cf0348c63f836defdc8b025d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Movie_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Booking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark text-decoration-none mx-2 my-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-3 w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 25rem; width: 17rem"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card rounded-3 text-decoration-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
  
    string posterPath = "~/images/" + (Model.PosterPath ?? "default-poster.jpg");

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container d-flex justify-content-between align-items-center my-1\">\n    <button onclick=\"history.back()\" class=\"btn btn-dark text-decoration-none my-2\">Back</button>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be230c143951fc64bdd62b06598985d9b06a25836798", async() => {
                WriteLiteral("Book Now");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 9 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                                                     WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n<div class=\"container-fluid bg-dark\">\n    <div class=\"container p-3\">\n        <div class=\"row\">\n            <div class=\"col-4\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "be230c143951fc64bdd62b06598985d9b06a25839441", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
              WriteLiteral(posterPath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 16 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n            <div class=\"col-8 d-flex align-items-center\">\n                <div id=\"details\">\n                    <h1 class=\"text-light mb-3\">\n                        ");
#nullable restore
#line 21 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                   Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <span class=\"text-muted\">(");
#nullable restore
#line 22 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                                             Write(ViewBag.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</span>\n                    </h1>\n                    <h6 class=\"my-3\">\n                        <span class=\"text-light\">");
#nullable restore
#line 25 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                                            Write(ViewBag.Runtime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" • </span>\n                        <span class=\"text-light\">");
#nullable restore
#line 26 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                                            Write(ViewBag.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" •</span>\n                        <span class=\"text-light\">");
#nullable restore
#line 27 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                                            Write(ViewBag.Released);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                    </h6>\n                    <h5>\n");
#nullable restore
#line 30 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                         foreach (var language in ViewBag.Languages)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"badge bg-light text-dark my-3 me-2\">");
#nullable restore
#line 32 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                                                                        Write(language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 33 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </h5>\n                    <h4 class=\"text-primary\">Ratings</h4>\n                    <div class=\"row my-3 text-light\">\n");
#nullable restore
#line 37 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                         foreach (var rating in ViewBag.Ratings)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-4 d-flex flex-column\">\n                                <h5>");
#nullable restore
#line 40 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                               Write(rating.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                                <p class=\"text-muted\">");
#nullable restore
#line 41 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                                                 Write(rating.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            </div>\n");
#nullable restore
#line 43 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n                    <h4 class=\"text-primary\">Cast & Crew</h4>\n                    <div class=\"row text-light my-3\">\n");
#nullable restore
#line 47 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                         foreach (var actor in ViewBag.Actors)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-4 d-flex flex-column\">\n                                <h5>");
#nullable restore
#line 50 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                               Write(actor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                                <p class=\"text-muted\">Actor</p>\n                            </div>\n");
#nullable restore
#line 53 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-4 d-flex flex-column\">\n                            <h5>");
#nullable restore
#line 55 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                           Write(ViewBag.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                            <p class=\"text-muted\">Director</p>\n                        </div>\n");
#nullable restore
#line 58 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                         foreach (var writer in ViewBag.Writers)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-4 d-flex flex-column\">\n                                <h5>");
#nullable restore
#line 61 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                               Write(writer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                                <p class=\"text-muted\">Writer</p>\n                            </div>\n");
#nullable restore
#line 64 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n<div class=\"container my-3\">\n    <h4><span class=\"badge bg-dark text-white\">About the Movie</span></h4>\n    <p id=\"desc\">");
#nullable restore
#line 74 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
            Write(ViewBag.Plot);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n</div>\n\n");
#nullable restore
#line 77 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
 if (ViewBag.SimilarMovies.Count != 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container my-3\">\n        <h4><span class=\"badge bg-dark text-white\">You might also like</span></h4>\n        <div class=\"d-flex\" style=\"overflow-x:auto;flex-wrap:nowrap\">\n");
#nullable restore
#line 82 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
             foreach (var movie in ViewBag.SimilarMovies)
            {
                string poster = "~/images/" + (movie.PosterPath ?? "default-poster.jpg");

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"my-2 me-2\" style=\"flex:0 0 auto\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be230c143951fc64bdd62b06598985d9b06a258320076", async() => {
                WriteLiteral("\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "be230c143951fc64bdd62b06598985d9b06a258320354", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                      WriteLiteral(poster);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#nullable restore
#line 87 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        <div class=\"text-dark text-center my-2\">\n                            ");
#nullable restore
#line 89 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                       Write(movie.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </div>\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
                                              WriteLiteral(movie.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n");
#nullable restore
#line 93 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n");
#nullable restore
#line 96 "C:\Users\Akash\Desktop\WAD Project\core\MovieTicketBooking\MovieTicketBooking\Views\Movie\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
