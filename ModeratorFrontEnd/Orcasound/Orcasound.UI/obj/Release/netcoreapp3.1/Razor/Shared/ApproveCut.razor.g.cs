#pragma checksum "D:\Code\Orcasound\Orcasound.UI\Shared\ApproveCut.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5668e864381f79392f4f0a5a2503e2b69579754"
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
    public partial class ApproveCut : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "D:\Code\Orcasound\Orcasound.UI\Shared\ApproveCut.razor"
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
            __builder.AddMarkupContent(14, "\r\n\t\t\t");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "modal-content");
            __builder.AddMarkupContent(17, "\r\n\t\t\t\t");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(18);
            __builder.AddAttribute(19, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "D:\Code\Orcasound\Orcasound.UI\Shared\ApproveCut.razor"
                                 Candidate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "D:\Code\Orcasound\Orcasound.UI\Shared\ApproveCut.razor"
                                                           OnConfirm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(22, "\r\n\t\t\t\t\t");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "modal-header");
                __builder2.AddMarkupContent(25, "\r\n\t\t\t\t\t\t");
                __builder2.AddMarkupContent(26, "<h5 class=\"modal-title\">\r\n\t\t\t\t\t\t\tApprove Candidate\r\n\t\t\t\t\t\t</h5>\r\n\t\t\t\t\t\t");
                __builder2.OpenElement(27, "button");
                __builder2.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\Code\Orcasound\Orcasound.UI\Shared\ApproveCut.razor"
                                          OnCancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "type", "button");
                __builder2.AddAttribute(30, "class", "close");
                __builder2.AddMarkupContent(31, "\r\n\t\t\t\t\t\t\t");
                __builder2.AddMarkupContent(32, "<span aria-hidden=\"true\">&times;</span>\r\n\t\t\t\t\t\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n\t\t\t\t\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n\t\t\t\t\t");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "modal-body");
                __builder2.AddMarkupContent(37, "\r\n\t\t\t\t\t\t");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-group");
                __builder2.AddMarkupContent(40, "\r\n\t\t\t\t\t\t\t");
                __builder2.AddMarkupContent(41, "<label>ID:</label>\r\n\t\t\t\t\t\t\t");
                __builder2.OpenElement(42, "p");
                __builder2.AddAttribute(43, "class", "form-control");
                __builder2.AddContent(44, 
#nullable restore
#line 22 "D:\Code\Orcasound\Orcasound.UI\Shared\ApproveCut.razor"
                                                     Candidate.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n\t\t\t\t\t\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n\t\t\t\t\t\t");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "form-group");
                __builder2.AddMarkupContent(49, "\r\n\t\t\t\t\t\t\t");
                __builder2.AddMarkupContent(50, "<label>Timestamp:</label>\r\n\t\t\t\t\t\t\t");
                __builder2.OpenElement(51, "p");
                __builder2.AddAttribute(52, "class", "form-control");
                __builder2.AddContent(53, 
#nullable restore
#line 26 "D:\Code\Orcasound\Orcasound.UI\Shared\ApproveCut.razor"
                                                     Candidate.Timestamp

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n\t\t\t\t\t\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n\t\t\t\t\t\t");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group");
                __builder2.AddMarkupContent(58, "\r\n\t\t\t\t\t\t\t");
                __builder2.AddMarkupContent(59, "<label>Node:</label>\r\n\t\t\t\t\t\t\t");
                __builder2.OpenElement(60, "p");
                __builder2.AddAttribute(61, "class", "form-control");
                __builder2.AddContent(62, 
#nullable restore
#line 30 "D:\Code\Orcasound\Orcasound.UI\Shared\ApproveCut.razor"
                                                     Candidate.Node

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n\t\t\t\t\t\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n\t\t\t\t\t\t");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "form-group");
                __builder2.AddMarkupContent(67, "\r\n\t\t\t\t\t\t\t");
                __builder2.AddMarkupContent(68, "<label>Tags:</label>\r\n\t\t\t\t\t\t\t");
                __builder2.OpenElement(69, "p");
                __builder2.AddAttribute(70, "class", "form-control");
                __builder2.AddContent(71, 
#nullable restore
#line 34 "D:\Code\Orcasound\Orcasound.UI\Shared\ApproveCut.razor"
                                                     Candidate.TagString

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n\t\t\t\t\t\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n\t\t\t\t\t\t");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "form-group");
                __builder2.AddMarkupContent(76, "\r\n\t\t\t\t\t\t\t");
                __builder2.AddMarkupContent(77, "<label>Approval Comments:</label>\r\n\t\t\t\t\t\t\t");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(78);
                __builder2.AddAttribute(79, "class", "form-control");
                __builder2.AddAttribute(80, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "D:\Code\Orcasound\Orcasound.UI\Shared\ApproveCut.razor"
                                                                              Candidate.ApprovalComments

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(81, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Candidate.ApprovalComments = __value, Candidate.ApprovalComments))));
                __builder2.AddAttribute(82, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Candidate.ApprovalComments));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(83, "\r\n\t\t\t\t\t\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n\r\n\t\t\t\t\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n\t\t\t\t\t");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "modal-footer");
                __builder2.AddMarkupContent(88, "\r\n\t\t\t\t\t\t");
                __builder2.OpenElement(89, "button");
                __builder2.AddAttribute(90, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "D:\Code\Orcasound\Orcasound.UI\Shared\ApproveCut.razor"
                                          OnCancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(91, "type", "button");
                __builder2.AddAttribute(92, "class", "btn btn-secondary");
                __builder2.AddContent(93, "Cancel");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n\t\t\t\t\t\t");
                __builder2.OpenElement(95, "button");
                __builder2.AddAttribute(96, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "D:\Code\Orcasound\Orcasound.UI\Shared\ApproveCut.razor"
                                          OnConfirm

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(97, "type", "button");
                __builder2.AddAttribute(98, "class", "btn btn-primary");
                __builder2.AddContent(99, "Ok");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n\t\t\t\t\t");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n\t\t\t\t");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(102, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n");
#nullable restore
#line 50 "D:\Code\Orcasound\Orcasound.UI\Shared\ApproveCut.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "D:\Code\Orcasound\Orcasound.UI\Shared\ApproveCut.razor"
       
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
