#pragma checksum "D:\Code\Orcasound\Orcasound.UI\Shared\AnalyzeCut.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b200134d307d5e4a94e0b816671dc76df517a612"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
