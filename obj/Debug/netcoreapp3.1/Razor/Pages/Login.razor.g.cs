#pragma checksum "C:\Users\ivan_\OneDrive\Documents\GitHub\DinoManager_Blazor\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "185c3194da7105d0e192e664090041bf72905d17"
// <auto-generated/>
#pragma warning disable 1591
namespace DinoManager_Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ivan_\OneDrive\Documents\GitHub\DinoManager_Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ivan_\OneDrive\Documents\GitHub\DinoManager_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ivan_\OneDrive\Documents\GitHub\DinoManager_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ivan_\OneDrive\Documents\GitHub\DinoManager_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ivan_\OneDrive\Documents\GitHub\DinoManager_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ivan_\OneDrive\Documents\GitHub\DinoManager_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ivan_\OneDrive\Documents\GitHub\DinoManager_Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ivan_\OneDrive\Documents\GitHub\DinoManager_Blazor\_Imports.razor"
using DinoManager_Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ivan_\OneDrive\Documents\GitHub\DinoManager_Blazor\_Imports.razor"
using DinoManager_Blazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddAttribute(2, "style", "margin-top: 2em;");
            __builder.AddMarkupContent(3, "\r\n\r\n    ");
            __builder.OpenElement(4, "main");
            __builder.AddAttribute(5, "role", "main");
            __builder.AddAttribute(6, "class", "pb-1");
            __builder.AddMarkupContent(7, "\r\n\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.AddMarkupContent(11, @"<div class=""col-md-5"">
                <section>
                    <div>
                        <img src=""/images/Pet1_DinoManager_noborder.png"" width=""390"" height=""400"">
                    </div>
                </section>
            </div>
            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-md-6 col-md-offset-2");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "section");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "form");
            __builder.AddAttribute(18, "id", "account");
            __builder.AddAttribute(19, "method", "post");
            __builder.AddAttribute(20, "novalidate", "novalidate");
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.AddMarkupContent(22, "<h4>Usa tu cuenta de DinoManager para iniciar sesión.</h4>\r\n                        <hr>\r\n                        ");
            __builder.AddMarkupContent(23, @"<div class=""text-danger validation-summary-valid"" data-valmsg-summary=""true"">
                            <ul>
                                <li style=""display:none""></li>
                            </ul>
                        </div>
                        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "form-group");
            __builder.AddMarkupContent(26, "\r\n                            ");
            __builder.AddMarkupContent(27, "<label for=\"Input_Email\">Email</label> \r\n                            ");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "class", "form-control");
            __builder.AddAttribute(30, "type", "email");
            __builder.AddAttribute(31, "data-val", "true");
            __builder.AddAttribute(32, "data-val-email", "The Email field is not a valid e-mail address.");
            __builder.AddAttribute(33, "data-val-required", "The Email field is required.");
            __builder.AddAttribute(34, "id", "Input_Email");
            __builder.AddAttribute(35, "name", "Input.Email");
            __builder.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\ivan_\OneDrive\Documents\GitHub\DinoManager_Blazor\Pages\Login.razor"
                                          Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Email = __value, Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                            <span class=\"text-danger field-validation-valid\" data-valmsg-for=\"Input.Email\" data-valmsg-replace=\"true\"></span>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "form-group");
            __builder.AddMarkupContent(42, "\r\n                            ");
            __builder.AddMarkupContent(43, "<label for=\"Input_Password\">Contraseña</label> \r\n                            ");
            __builder.OpenElement(44, "input");
            __builder.AddAttribute(45, "class", "form-control");
            __builder.AddAttribute(46, "type", "password");
            __builder.AddAttribute(47, "data-val", "true");
            __builder.AddAttribute(48, "data-val-required", "The Password field is required.");
            __builder.AddAttribute(49, "id", "Input_Password");
            __builder.AddAttribute(50, "name", "Input.Password");
            __builder.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\ivan_\OneDrive\Documents\GitHub\DinoManager_Blazor\Pages\Login.razor"
                                          Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Password = __value, Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                            <span class=\"text-danger field-validation-valid\" data-valmsg-for=\"Input.Password\" data-valmsg-replace=\"true\"></span>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                        ");
            __builder.AddMarkupContent(55, @"<div class=""form-group"">
                            <div class=""checkbox"">
                                <label for=""Input_RememberMe"">
                                    <input type=""checkbox"" data-val=""true"" data-val-required=""The Remember me? field is required."" id=""Input_RememberMe"" name=""Input.RememberMe"" value=""true"">
                                    Recordar cuenta.
                                </label>
                            </div>
                        </div>
                        ");
            __builder.AddMarkupContent(56, "<div class=\"form-group\">\r\n                            <button id=\"login-submit\" type=\"submit\" class=\"btn btn-primary\">Log in</button>\r\n                        </div>\r\n                        ");
            __builder.AddMarkupContent(57, @"<div class=""form-group"">
                            <p>
                                <a id=""forgot-password"" href=""/Identity/Account/ForgotPassword"">¿Has olvidado tu contraseña?</a>
                            </p>
                            <p>
                                <a href=""/Identity/Account/Register?returnUrl=%2F"">Registrarte como nuevo usuario.</a>
                            </p>
                        </div>
                        <input name=""__RequestVerificationToken"" type=""hidden"" value=""CfDJ8GlRPxZMhKZEi0Tq4s2m4ubmIWo4Cs5XKEOCTdmm7oW1FQpMse9fJ2Dn3hIC3JHqwApeVpPpXYRmw5SR7qs35Jg7Zbs86TWZKcXIlIdt73bXMJaYYiZNDLpTurYFbywxvN0QoHeDO19pS1dxizcSMtE""><input name=""Input.RememberMe"" type=""hidden"" value=""false"">
                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
