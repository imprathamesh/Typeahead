using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace TypeaheadComponent;

public static class Interop
{
    internal static ValueTask<object> Focus(IJSRuntime jsRuntime, ElementReference element)
    {
        return jsRuntime.InvokeAsync<object>("Typeahead.setFocus", element);
    }

    internal static ValueTask<object> AddKeyDownEventListener(IJSRuntime jsRuntime, ElementReference element)
    {
        return jsRuntime.InvokeAsync<object>("Typeahead.addKeyDownEventListener", element);
    }

    internal static ValueTask<object> OnOutsideClick(this IJSRuntime jsRuntime, ElementReference element, object caller, string methodName, bool clearOnFire = false)
    {
        return jsRuntime.InvokeAsync<object>("Typeahead.onOutsideClick", element, DotNetObjectReference.Create(caller), methodName, clearOnFire);
    }
}
