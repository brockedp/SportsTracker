#pragma checksum "C:\Users\denob\Documents\Hockey\NatureBoysStats\NatureBoysStats\Views\Golf\DisplayAllRounds.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c6e4129a92aac238be7ebcf509dbc3d5b1e1ecc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Golf_DisplayAllRounds), @"mvc.1.0.view", @"/Views/Golf/DisplayAllRounds.cshtml")]
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
#line 1 "C:\Users\denob\Documents\Hockey\NatureBoysStats\NatureBoysStats\Views\_ViewImports.cshtml"
using NatureBoysStats;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\denob\Documents\Hockey\NatureBoysStats\NatureBoysStats\Views\_ViewImports.cshtml"
using NatureBoysStats.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c6e4129a92aac238be7ebcf509dbc3d5b1e1ecc", @"/Views/Golf/DisplayAllRounds.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2444a269e700521ef8b8321ad3f45f44e849d024", @"/Views/_ViewImports.cshtml")]
    public class Views_Golf_DisplayAllRounds : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NatureBoysStats.Models.GolfScoreCard>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\denob\Documents\Hockey\NatureBoysStats\NatureBoysStats\Views\Golf\DisplayAllRounds.cshtml"
  
    ViewData["Title"] = "AllRounds";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <style>
        .putting-green {
            /*            background-color: green;*/
            background: repeating-linear-gradient( 0deg, lightgreen 0px, lawngreen 0px, green 40px, darkgreen 2px );
            border-radius: 90%;
            position: fixed;
            padding: 50px 50px 60px 60px;
            margin: 0;
            top: 0;
            left: 0;
            width: 100%;
            height: 100%;
            z-index: -1;
            box-shadow: 10px 20px 20px 0px darkgreen;
        }
        #cup {
            background-color: black;
            position: fixed;
            border-radius: 30%;
            height: 20px;
            width: 20px;
            left: 70%;
            top: 65%;
        }
        #golf-ball {
            background-color:white;
            position:fixed;
            border-radius:50%;
            height:10px;
            width:10px;
            top: 300px;
            left:50px;
            animation-name:rolling;
          ");
            WriteLiteral("  animation-duration:5s;\r\n            animation-iteration-count:infinite;\r\n            \r\n        }\r\n        ");
            WriteLiteral(@"@keyframes rolling{
            75% {
                left: 80%;
                top: 65%;
                animation-timing-function: ease-out;
            }
            100%{
                left:70%;
                top:65%;
               animation-timing-function:ease-out;
            }
        }
    </style>

    <div class=""putting-green"" >
        <div id=""cup""></div>
        <div id=""golf-ball""></div>
    </div>
    <div>
        <table class=""table-bordered"" style=""background-color:cornflowerblue"">
            <tr style=""color:black"">
                <th style=""width:200px"">Course Name</th>
                <th style=""width:100px"">Player</th>
                <th style=""width:100px"">Hole 1</th>
                <th style=""width:100px"">Hole 2</th>
                <th style=""width:100px"">Hole 3</th>
                <th style=""width:100px"">Hole 4</th>
                <th style=""width:100px"">Hole 5</th>
                <th style=""width:100px"">Hole 6</th>
                <th styl");
            WriteLiteral(@"e=""width:100px"">Hole 7</th>
                <th style=""width:100px"">Hole 8</th>
                <th style=""width:100px"">Hole 9</th>
                <th style=""width:100px"">Hole 10</th>
                <th style=""width:100px"">Hole 11</th>
                <th style=""width:100px"">Hole 12</th>
                <th style=""width:100px"">Hole 13</th>
                <th style=""width:100px"">Hole 14</th>
                <th style=""width:100px"">Hole 15</th>
                <th style=""width:100px"">Hole 16</th>
                <th style=""width:100px"">Hole 17</th>
                <th style=""width:100px"">Hole 18</th>
                <th style=""width:100px"">Round Score</th>
                <th style=""width:100px"">Date</th>
            </tr>
");
#nullable restore
#line 87 "C:\Users\denob\Documents\Hockey\NatureBoysStats\NatureBoysStats\Views\Golf\DisplayAllRounds.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr style=\"color:aliceblue\">\r\n                    <td>");
#nullable restore
#line 90 "C:\Users\denob\Documents\Hockey\NatureBoysStats\NatureBoysStats\Views\Golf\DisplayAllRounds.cshtml"
                   Write(item.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 91 "C:\Users\denob\Documents\Hockey\NatureBoysStats\NatureBoysStats\Views\Golf\DisplayAllRounds.cshtml"
                   Write(item.PlayerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 92 "C:\Users\denob\Documents\Hockey\NatureBoysStats\NatureBoysStats\Views\Golf\DisplayAllRounds.cshtml"
                   Write(item.Hole1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 93 "C:\Users\denob\Documents\Hockey\NatureBoysStats\NatureBoysStats\Views\Golf\DisplayAllRounds.cshtml"
                   Write(item.Hole2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 94 "C:\Users\denob\Documents\Hockey\NatureBoysStats\NatureBoysStats\Views\Golf\DisplayAllRounds.cshtml"
                   Write(item.Hole3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 95 "C:\Users\denob\Documents\Hockey\NatureBoysStats\NatureBoysStats\Views\Golf\DisplayAllRounds.cshtml"
                   Write(item.Hole4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 96 "C:\Users\denob\Documents\Hockey\NatureBoysStats\NatureBoysStats\Views\Golf\DisplayAllRounds.cshtml"
                   Write(item.Hole5);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 97 "C:\Users\denob\Documents\Hockey\NatureBoysStats\NatureBoysStats\Views\Golf\DisplayAllRounds.cshtml"
                   Write(item.Hole6);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 98 "C:\Users\denob\Documents\Hockey\NatureBoysStats\NatureBoysStats\Views\Golf\DisplayAllRounds.cshtml"
                   Write(item.Hole7);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 99 "C:\Users\denob\Documents\Hockey\NatureBoysStats\NatureBoysStats\Views\Golf\DisplayAllRounds.cshtml"
                   Write(item.Hole8);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 100 "C:\Users\denob\Documents\Hockey\NatureBoysStats\NatureBoysStats\Views\Golf\DisplayAllRounds.cshtml"
                   Write(item.Hole9);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 101 "C:\Users\denob\Documents\Hockey\NatureBoysStats\NatureBoysStats\Views\Golf\DisplayAllRounds.cshtml"
                   Write(item.Hole10);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 102 "C:\Users\denob\Documents\Hockey\NatureBoysStats\NatureBoysStats\Views\Golf\DisplayAllRounds.cshtml"
                   Write(item.Hole11);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 103 "C:\Users\denob\Documents\Hockey\NatureBoysStats\NatureBoysStats\Views\Golf\DisplayAllRounds.cshtml"
                   Write(item.Hole12);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 104 "C:\Users\denob\Documents\Hockey\NatureBoysStats\NatureBoysStats\Views\Golf\DisplayAllRounds.cshtml"
                   Write(item.Hole13);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 105 "C:\Users\denob\Documents\Hockey\NatureBoysStats\NatureBoysStats\Views\Golf\DisplayAllRounds.cshtml"
                   Write(item.Hole14);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 106 "C:\Users\denob\Documents\Hockey\NatureBoysStats\NatureBoysStats\Views\Golf\DisplayAllRounds.cshtml"
                   Write(item.Hole15);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 107 "C:\Users\denob\Documents\Hockey\NatureBoysStats\NatureBoysStats\Views\Golf\DisplayAllRounds.cshtml"
                   Write(item.Hole16);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 108 "C:\Users\denob\Documents\Hockey\NatureBoysStats\NatureBoysStats\Views\Golf\DisplayAllRounds.cshtml"
                   Write(item.Hole17);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 109 "C:\Users\denob\Documents\Hockey\NatureBoysStats\NatureBoysStats\Views\Golf\DisplayAllRounds.cshtml"
                   Write(item.Hole18);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 110 "C:\Users\denob\Documents\Hockey\NatureBoysStats\NatureBoysStats\Views\Golf\DisplayAllRounds.cshtml"
                   Write(item.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 111 "C:\Users\denob\Documents\Hockey\NatureBoysStats\NatureBoysStats\Views\Golf\DisplayAllRounds.cshtml"
                   Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 113 "C:\Users\denob\Documents\Hockey\NatureBoysStats\NatureBoysStats\Views\Golf\DisplayAllRounds.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n");
            WriteLiteral("        \r\n        ");
#nullable restore
#line 117 "C:\Users\denob\Documents\Hockey\NatureBoysStats\NatureBoysStats\Views\Golf\DisplayAllRounds.cshtml"
   Write(Html.ActionLink("Log New Score", "Index", "Golf"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        \r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NatureBoysStats.Models.GolfScoreCard>> Html { get; private set; }
    }
}
#pragma warning restore 1591
