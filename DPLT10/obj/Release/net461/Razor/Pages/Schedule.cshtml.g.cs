#pragma checksum "C:\Users\ShivaThogiti\Documents\DPLT10\DPLT10\DPLT10\Pages\Schedule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcea5d930f3958ecee396d232d665406f4b1ec63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DPLT10.Pages.Pages_Schedule), @"mvc.1.0.razor-page", @"/Pages/Schedule.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Schedule.cshtml", typeof(DPLT10.Pages.Pages_Schedule), null)]
namespace DPLT10.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\ShivaThogiti\Documents\DPLT10\DPLT10\DPLT10\Pages\_ViewImports.cshtml"
using DPLT10;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcea5d930f3958ecee396d232d665406f4b1ec63", @"/Pages/Schedule.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2924263a7e156e5df01bceb63332bb11aad7c152", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Schedule : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/RiversideRomeos.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:50px;height:50px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Blasters.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Flickers.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Demons.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Raptors.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/TOPazc.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(162, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\ShivaThogiti\Documents\DPLT10\DPLT10\DPLT10\Pages\Schedule.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(191, 466, true);
            WriteLiteral(@"
<!DOCTYPE html>

<html>
<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">

<script>
    $(document).ready(function () {
        $(""#myInput"").on(""keyup"", function () {
            var value = $(this).val().toLowerCase();
            $(""#myTable tr"").filter(function () {
                $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
            });
        });
    });
</script>
");
            EndContext();
            BeginContext(657, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9126e02ea5d4212aa29cb771d4a7935", async() => {
                BeginContext(663, 87, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(757, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(759, 4430, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e48559b6827e4cb28b125b7998616f1c", async() => {
                BeginContext(766, 154, true);
                WriteLiteral("\r\n        <input class=\"form-control\" id=\"myInput\" type=\"text\" placeholder=\"Search..\">\r\n        <br>\r\n        <table>\r\n            <tbody id=\"myTable\" >\r\n");
                EndContext();
#line 34 "C:\Users\ShivaThogiti\Documents\DPLT10\DPLT10\DPLT10\Pages\Schedule.cshtml"
                 foreach (var Schedule in Model.Schedules)
                {

#line default
#line hidden
                BeginContext(999, 120, true);
                WriteLiteral("                    <tr>\r\n                        <td style=\"text-align:center\"><b style=\"color:white;font-size:large;\">");
                EndContext();
                BeginContext(1120, 14, false);
#line 37 "C:\Users\ShivaThogiti\Documents\DPLT10\DPLT10\DPLT10\Pages\Schedule.cshtml"
                                                                                         Write(Schedule.Match);

#line default
#line hidden
                EndContext();
                BeginContext(1134, 160, true);
                WriteLiteral(" </b></td>\r\n                   \r\n                        <td>&nbsp;&nbsp;\r\n                            <b style=\"color:white\">\r\n                                ");
                EndContext();
                BeginContext(1295, 13, false);
#line 41 "C:\Users\ShivaThogiti\Documents\DPLT10\DPLT10\DPLT10\Pages\Schedule.cshtml"
                           Write(Schedule.Date);

#line default
#line hidden
                EndContext();
                BeginContext(1308, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(1343, 13, false);
#line 42 "C:\Users\ShivaThogiti\Documents\DPLT10\DPLT10\DPLT10\Pages\Schedule.cshtml"
                           Write(Schedule.Time);

#line default
#line hidden
                EndContext();
                BeginContext(1356, 67, true);
                WriteLiteral("\r\n                            </b>\r\n                        </td>\r\n");
                EndContext();
#line 45 "C:\Users\ShivaThogiti\Documents\DPLT10\DPLT10\DPLT10\Pages\Schedule.cshtml"
                         if (@Schedule.Team1 == "RIVERSIDE ROMEOS")
                        {

#line default
#line hidden
                BeginContext(1519, 32, true);
                WriteLiteral("                            <td>");
                EndContext();
                BeginContext(1551, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "64b0425394c0401b8f1373e31fadf96c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1625, 72, true);
                WriteLiteral("<b style=\"color:dodgerblue;font-size:large;\">RIVERSIDE ROMEOS</b></td>\r\n");
                EndContext();
#line 48 "C:\Users\ShivaThogiti\Documents\DPLT10\DPLT10\DPLT10\Pages\Schedule.cshtml"
                        }
                        else if (@Schedule.Team1 == "MIAMISBURG BLASTERS")
                        {

#line default
#line hidden
                BeginContext(1827, 32, true);
                WriteLiteral("                            <td>");
                EndContext();
                BeginContext(1859, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1b32b16660744e46a97fe488ff94e053", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1926, 74, true);
                WriteLiteral("<b style=\"color:lawngreen;font-size:large;\">MIAMISBURG BLASTERS</b></td>\r\n");
                EndContext();
#line 52 "C:\Users\ShivaThogiti\Documents\DPLT10\DPLT10\DPLT10\Pages\Schedule.cshtml"
                        }
                        else if (@Schedule.Team1 == "FAIRBORN FLICKERS")
                        {

#line default
#line hidden
                BeginContext(2128, 32, true);
                WriteLiteral("                            <td>");
                EndContext();
                BeginContext(2160, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f31c4ee4124b4b219f51bbb2f97bf677", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2227, 66, true);
                WriteLiteral("<b style=\"color:red;font-size:large;\">FAIRBORN FLICKERS</b></td>\r\n");
                EndContext();
#line 56 "C:\Users\ShivaThogiti\Documents\DPLT10\DPLT10\DPLT10\Pages\Schedule.cshtml"
                        }
                        else if (@Schedule.Team1 == "DAYTON DEMONS")
                        {

#line default
#line hidden
                BeginContext(2417, 32, true);
                WriteLiteral("                            <td>");
                EndContext();
                BeginContext(2449, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b7e0ee4e79254a8180be21a5a311d999", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2514, 65, true);
                WriteLiteral("<b style=\"color:yellow;font-size:large;\">DAYTON DEMONS</b></td>\r\n");
                EndContext();
#line 60 "C:\Users\ShivaThogiti\Documents\DPLT10\DPLT10\DPLT10\Pages\Schedule.cshtml"
                        }
                        else if (@Schedule.Team1 == "BEAVERCREEK RAPTORS")
                        {

#line default
#line hidden
                BeginContext(2709, 32, true);
                WriteLiteral("                            <td>");
                EndContext();
                BeginContext(2741, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "18a47d0286d444798ae6ac66abce9266", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2807, 70, true);
                WriteLiteral("<b style=\"color:brown;font-size:large;\">BEAVERCREEK RAPTORS</b></td>\r\n");
                EndContext();
#line 64 "C:\Users\ShivaThogiti\Documents\DPLT10\DPLT10\DPLT10\Pages\Schedule.cshtml"
                        }
                        else if (@Schedule.Team1 == "CINCY TOPAZC")
                        {

#line default
#line hidden
                BeginContext(3000, 32, true);
                WriteLiteral("                            <td>");
                EndContext();
                BeginContext(3032, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3315d7f0eba04ac68f47467abd8810d8", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3097, 64, true);
                WriteLiteral("<b style=\"color:orange;font-size:large;\">CINCY TOPAZC</b></td>\r\n");
                EndContext();
#line 68 "C:\Users\ShivaThogiti\Documents\DPLT10\DPLT10\DPLT10\Pages\Schedule.cshtml"
                        }

#line default
#line hidden
                BeginContext(3188, 51, true);
                WriteLiteral("                        <td><b style=\"color:white\">");
                EndContext();
                BeginContext(3240, 11, false);
#line 69 "C:\Users\ShivaThogiti\Documents\DPLT10\DPLT10\DPLT10\Pages\Schedule.cshtml"
                                              Write(Schedule.vs);

#line default
#line hidden
                EndContext();
                BeginContext(3251, 11, true);
                WriteLiteral("</b></td>\r\n");
                EndContext();
#line 70 "C:\Users\ShivaThogiti\Documents\DPLT10\DPLT10\DPLT10\Pages\Schedule.cshtml"
                         if (@Schedule.Team2 == "RIVERSIDE ROMEOS")
                        {

#line default
#line hidden
                BeginContext(3358, 32, true);
                WriteLiteral("                            <td>");
                EndContext();
                BeginContext(3390, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "63018849ff924674bd6b22ef1c537390", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3464, 72, true);
                WriteLiteral("<b style=\"color:dodgerblue;font-size:large;\">RIVERSIDE ROMEOS</b></td>\r\n");
                EndContext();
#line 73 "C:\Users\ShivaThogiti\Documents\DPLT10\DPLT10\DPLT10\Pages\Schedule.cshtml"
                        }
                        else if (@Schedule.Team2 == "MIAMISBURG BLASTERS")
                        {

#line default
#line hidden
                BeginContext(3666, 32, true);
                WriteLiteral("                            <td>");
                EndContext();
                BeginContext(3698, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d94e3625b5ac43ea8561fae1bd47999e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3765, 74, true);
                WriteLiteral("<b style=\"color:lawngreen;font-size:large;\">MIAMISBURG BLASTERS</b></td>\r\n");
                EndContext();
#line 77 "C:\Users\ShivaThogiti\Documents\DPLT10\DPLT10\DPLT10\Pages\Schedule.cshtml"
                        }
                        else if (@Schedule.Team2 == "FAIRBORN FLICKERS")
                        {

#line default
#line hidden
                BeginContext(3967, 32, true);
                WriteLiteral("                            <td>");
                EndContext();
                BeginContext(3999, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0b1768482fd14e08978070398a839bf7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4066, 66, true);
                WriteLiteral("<b style=\"color:red;font-size:large;\">FAIRBORN FLICKERS</b></td>\r\n");
                EndContext();
#line 81 "C:\Users\ShivaThogiti\Documents\DPLT10\DPLT10\DPLT10\Pages\Schedule.cshtml"
                        }
                        else if (@Schedule.Team2 == "DAYTON DEMONS")
                        {

#line default
#line hidden
                BeginContext(4256, 32, true);
                WriteLiteral("                            <td>");
                EndContext();
                BeginContext(4288, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "56c7fa57d1ec4c82bdea963f8975bd48", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4353, 65, true);
                WriteLiteral("<b style=\"color:yellow;font-size:large;\">DAYTON DEMONS</b></td>\r\n");
                EndContext();
#line 85 "C:\Users\ShivaThogiti\Documents\DPLT10\DPLT10\DPLT10\Pages\Schedule.cshtml"
                        }
                        else if (@Schedule.Team2 == "BEAVERCREEK RAPTORS")
                        {

#line default
#line hidden
                BeginContext(4548, 32, true);
                WriteLiteral("                            <td>");
                EndContext();
                BeginContext(4580, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "41da92fbc4ce419ca97f154dbb2c6efa", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4646, 70, true);
                WriteLiteral("<b style=\"color:brown;font-size:large;\">BEAVERCREEK RAPTORS</b></td>\r\n");
                EndContext();
#line 89 "C:\Users\ShivaThogiti\Documents\DPLT10\DPLT10\DPLT10\Pages\Schedule.cshtml"
                        }
                        else if (@Schedule.Team2 == "CINCY TOPAZC")
                        {

#line default
#line hidden
                BeginContext(4839, 32, true);
                WriteLiteral("                            <td>");
                EndContext();
                BeginContext(4871, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9702fa01421146c2b67fb25995da8988", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4936, 64, true);
                WriteLiteral("<b style=\"color:orange;font-size:large;\">CINCY TOPAZC</b></td>\r\n");
                EndContext();
#line 93 "C:\Users\ShivaThogiti\Documents\DPLT10\DPLT10\DPLT10\Pages\Schedule.cshtml"
                        }

#line default
#line hidden
                BeginContext(5027, 74, true);
                WriteLiteral("                        <td><br /><br /></td>\r\n                    </tr>\r\n");
                EndContext();
#line 96 "C:\Users\ShivaThogiti\Documents\DPLT10\DPLT10\DPLT10\Pages\Schedule.cshtml"
                    }

#line default
#line hidden
                BeginContext(5124, 58, true);
                WriteLiteral("                \r\n            </tbody>\r\n        </table>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5189, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DPLT10.Pages.ScheduleModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DPLT10.Pages.ScheduleModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DPLT10.Pages.ScheduleModel>)PageContext?.ViewData;
        public DPLT10.Pages.ScheduleModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
