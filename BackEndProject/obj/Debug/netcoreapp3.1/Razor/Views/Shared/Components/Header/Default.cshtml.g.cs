#pragma checksum "C:\Users\tu201906147\source\repos\BackEndProject\BackEndProject\Views\Shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66dc1be1b913dc12ba3a03c98351eaef17ea9afe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Header_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Header/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66dc1be1b913dc12ba3a03c98351eaef17ea9afe", @"/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0945db5f562c21a23fc7afaba982574c8159aa16", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<header>
    <section id=""nav1"" style=""background-color: #106eea;"">
        <div class=""container"">
            <nav class=""navbar navbar-expand-lg"">
                <a class=""navbar-brand nav1LeftItem"" href=""#"">
                    <i class=""far fa-envelope""></i>
                    contact@example.com
                </a>
                <a class=""navbar-brand nav1LeftItem"" href=""#""> <i class=""fas fa-phone""></i> +1 5589 55488 55</a>
                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNav""
                        aria-controls=""navbarNav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""collapse navbar-collapse nav1RightMargin"" id=""navbarNav"">
                    <ul class=""navbar-nav"">
                        <li class=""nav-item active"">
                            <a class=""nav-link"" href=""#"">
                          ");
            WriteLiteral(@"      <i class=""fab fa-twitter logoNav1""></i> <span class=""sr-only"">(current)</span>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#""><i class=""fab fa-facebook logoNav1""></i></a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#""><i class=""fab fa-instagram logoNav1""></i></a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#""><i class=""fab fa-linkedin logoNav1""></i></a>
                        </li>
                    </ul>
                </div>
            </nav>
        </div>
    </section>

    <section id=""nav2"" class=""w-100"">
        <div class=""container"">
            <nav class=""navbar navbar-expand-lg"">
                <a class=""navbar-brand nav2Left"" href=""#"">BizLand<span>.</span></a>
                ");
            WriteLiteral(@"<button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNavDropdown""
                        aria-controls=""navbarNavDropdown"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon nav2LeftBurger"">Menu</span>
                </button>
                <div class=""collapse navbar-collapse nav2RightMargin"" id=""navbarNavDropdown"">
                    <ul class=""navbar-nav"">
                        <li class=""nav-item active"">
                            <a class=""nav-link"" href=""#Intro"">Home <span class=""sr-only"">(current)</span></a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">About</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#Services"">Services</a>
                        </li>
                        <li class=""nav-item"">
              ");
            WriteLiteral(@"              <a class=""nav-link"" href=""#"">Portfolio</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#team"">Team</a>
                        </li>
                        <li class=""nav-item dropdown"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdownMenuLink"" role=""button""
                               data-toggle=""dropdown"" aria-expanded=""false"">
                                Dropdown link
                            </a>
                            <div class=""dropdown-menu"" aria-labelledby=""navbarDropdownMenuLink"">
                                <a class=""dropdown-item"" href=""#"">Dropdown 1</a>
                                <a class=""dropdown-item"" href=""#"">Deep Drop Down</a>
                                <a class=""dropdown-item"" href=""#"">Dropdown 2</a>
                                <a class=""dropdown-item"" href=""#"">Dropdown 3</a>
                         ");
            WriteLiteral(@"       <a class=""dropdown-item"" href=""#"">Dropdown 4</a>
                            </div>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#contact"">Contact</a>
                        </li>
                    </ul>
                </div>
            </nav>
        </div>
    </section>
</header>");
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