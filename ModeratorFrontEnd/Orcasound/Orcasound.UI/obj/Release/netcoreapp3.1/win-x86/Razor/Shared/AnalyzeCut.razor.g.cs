#pragma checksum "D:\Code\Orcasound\Orcasound.UI\Shared\AnalyzeCut.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b200134d307d5e4a94e0b816671dc76df517a612"
// <auto-generated/>
#pragma warning disable 1591
namespace Orcasound.UI.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Code\Orcasound\Orcasound.UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Code\Orcasound\Orcasound.UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Code\Orcasound\Orcasound.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Code\Orcasound\Orcasound.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Code\Orcasound\Orcasound.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Code\Orcasound\Orcasound.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Code\Orcasound\Orcasound.UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Code\Orcasound\Orcasound.UI\_Imports.razor"
using Orcasound.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Code\Orcasound\Orcasound.UI\_Imports.razor"
using Orcasound.UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Code\Orcasound\Orcasound.UI\_Imports.razor"
using Orcasound.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Code\Orcasound\Orcasound.UI\_Imports.razor"
using Orcasound.UI.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Code\Orcasound\Orcasound.UI\_Imports.razor"
using Orcasound.ComponentsLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Code\Orcasound\Orcasound.UI\_Imports.razor"
using Orcasound.ComponentsLibrary.Map;

#line default
#line hidden
#nullable disable
    public partial class AnalyzeCut : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "D:\Code\Orcasound\Orcasound.UI\Shared\AnalyzeCut.razor"
 if (DisplayModal)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "\t<div class=\"modal-backdrop show\"></div>\r\n");
            __builder.AddMarkupContent(1, "\t");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "modal fade show");
            __builder.AddAttribute(4, "id", "exampleModal");
            __builder.AddAttribute(5, "tabindex", "-1");
            __builder.AddAttribute(6, "role", "dialog");
            __builder.AddAttribute(7, "aria-labelledby", "exampleModalLabel");
            __builder.AddAttribute(8, "aria-hidden", "true");
            __builder.AddAttribute(9, "style", "display: block;");
            __builder.AddMarkupContent(10, "\r\n\t\t");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "modal-dialog");
            __builder.AddAttribute(13, "role", "document");
            __builder.AddAttribute(14, "style", "margin:0;");
            __builder.AddMarkupContent(15, "\r\n\t\t\t\r\n\t\t\t");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "modal-content");
            __builder.AddAttribute(18, "style", "width:1200px;min-width:1200px; top:40px; left:calc(50vw - 600px);");
            __builder.AddMarkupContent(19, "\r\n\t\t\t\t");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(20);
            __builder.AddAttribute(21, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "D:\Code\Orcasound\Orcasound.UI\Shared\AnalyzeCut.razor"
                                 Candidate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "D:\Code\Orcasound\Orcasound.UI\Shared\AnalyzeCut.razor"
                                                           OnConfirm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(24, "\r\n\t\t\t\t\t");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "modal-header");
                __builder2.AddMarkupContent(27, "\r\n\t\t\t\t\t\t");
                __builder2.AddMarkupContent(28, "<h5 class=\"modal-title\">\r\n\t\t\t\t\t\t\tAnalyze Candidate\r\n\t\t\t\t\t\t</h5>\r\n\t\t\t\t\t\t");
                __builder2.OpenElement(29, "button");
                __builder2.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "D:\Code\Orcasound\Orcasound.UI\Shared\AnalyzeCut.razor"
                                          OnCancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "type", "button");
                __builder2.AddAttribute(32, "class", "close");
                __builder2.AddMarkupContent(33, "\r\n\t\t\t\t\t\t\t");
                __builder2.AddMarkupContent(34, "<span aria-hidden=\"true\">&times;</span>\r\n\t\t\t\t\t\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n\t\t\t\t\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n\t\t\t\t\t");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "modal-body");
                __builder2.AddMarkupContent(39, "\r\n\t\t\t\t\t\t<img src=\"images/analyze.png\">\r\n\t\t\t\t\t\t");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group");
                __builder2.AddMarkupContent(42, "\r\n\t\t\t\t\t\t\t");
                __builder2.AddMarkupContent(43, "<label>ID:</label>\r\n\t\t\t\t\t\t\t");
                __builder2.OpenElement(44, "p");
                __builder2.AddAttribute(45, "class", "form-control");
                __builder2.AddContent(46, 
#nullable restore
#line 24 "D:\Code\Orcasound\Orcasound.UI\Shared\AnalyzeCut.razor"
                                                     Candidate.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n\t\t\t\t\t\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n\t\t\t\t\t\t");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "form-group");
                __builder2.AddMarkupContent(51, "\r\n\t\t\t\t\t\t\t");
                __builder2.AddMarkupContent(52, "<label>Timestamp:</label>\r\n\t\t\t\t\t\t\t");
                __builder2.OpenElement(53, "p");
                __builder2.AddAttribute(54, "class", "form-control");
                __builder2.AddContent(55, 
#nullable restore
#line 28 "D:\Code\Orcasound\Orcasound.UI\Shared\AnalyzeCut.razor"
                                                     Candidate.Timestamp

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n\t\t\t\t\t\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n\t\t\t\t\t\t");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "form-group");
                __builder2.AddMarkupContent(60, "\r\n\t\t\t\t\t\t\t");
                __builder2.AddMarkupContent(61, "<label>Node:</label>\r\n\t\t\t\t\t\t\t");
                __builder2.OpenElement(62, "p");
                __builder2.AddAttribute(63, "class", "form-control");
                __builder2.AddContent(64, 
#nullable restore
#line 32 "D:\Code\Orcasound\Orcasound.UI\Shared\AnalyzeCut.razor"
                                                     Candidate.Node

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n\t\t\t\t\t\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n\t\t\t\t\t\t");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "form-group");
                __builder2.AddMarkupContent(69, "\r\n\t\t\t\t\t\t\t");
                __builder2.AddMarkupContent(70, "<label>Tags:</label>\r\n\t\t\t\t\t\t\t");
                __builder2.OpenElement(71, "p");
                __builder2.AddAttribute(72, "class", "form-control");
                __builder2.AddContent(73, 
#nullable restore
#line 36 "D:\Code\Orcasound\Orcasound.UI\Shared\AnalyzeCut.razor"
                                                     Candidate.TagString

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n\t\t\t\t\t\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n\t\t\t\t\t\t");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "form-group");
                __builder2.AddMarkupContent(78, "\r\n\t\t\t\t\t\t\t");
                __builder2.AddMarkupContent(79, "<label>Approval Comments:</label>\r\n\t\t\t\t\t\t\t");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(80);
                __builder2.AddAttribute(81, "class", "form-control");
                __builder2.AddAttribute(82, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "D:\Code\Orcasound\Orcasound.UI\Shared\AnalyzeCut.razor"
                                                                              Candidate.ApprovalComments

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(83, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Candidate.ApprovalComments = __value, Candidate.ApprovalComments))));
                __builder2.AddAttribute(84, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Candidate.ApprovalComments));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(85, "\r\n\t\t\t\t\t\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n\r\n\t\t\t\t\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n\t\t\t\t\t");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "modal-footer");
                __builder2.AddMarkupContent(90, "\r\n\t\t\t\t\t\t");
                __builder2.OpenElement(91, "button");
                __builder2.AddAttribute(92, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "D:\Code\Orcasound\Orcasound.UI\Shared\AnalyzeCut.razor"
                                          OnCancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(93, "type", "button");
                __builder2.AddAttribute(94, "class", "btn btn-secondary");
                __builder2.AddContent(95, "Cancel");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n\t\t\t\t\t\t");
                __builder2.OpenElement(97, "button");
                __builder2.AddAttribute(98, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "D:\Code\Orcasound\Orcasound.UI\Shared\AnalyzeCut.razor"
                                          OnConfirm

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(99, "type", "button");
                __builder2.AddAttribute(100, "class", "btn btn-primary");
                __builder2.AddContent(101, "Ok");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n\t\t\t\t\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n\t\t\t\t");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(104, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n");
#nullable restore
#line 52 "D:\Code\Orcasound\Orcasound.UI\Shared\AnalyzeCut.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "D:\Code\Orcasound\Orcasound.UI\Shared\AnalyzeCut.razor"
       
	[Parameter] public bool DisplayModal { get; set; }
	[Parameter] public Candidate Candidate { get; set; }
	[Parameter] public EventCallback OnConfirm { get; set; }
	[Parameter] public EventCallback OnCancel { get; set; }
	public void Show() => DisplayModal = true;
	public void Hide() => DisplayModal = false;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
