using System.Security.Claims;
using System.Text.Json;
using BlazorApp6.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;


namespace Microsoft.AspNetCore.Routing;

internal static class IdentityComponentsEndpointRouteBuilderExtensions {
    // These endpoints are required by the Identity Razor components defined in the /Components/Account/Pages directory of this project.
    public static IEndpointConventionBuilder MapAdditionalIdentityEndpoints(this IEndpointRouteBuilder endpoints) {
        ArgumentNullException.ThrowIfNull(endpoints);

        var accountGroup = endpoints.MapGroup("/Account");
        
        accountGroup.MapPost("/Logout", async (
            ClaimsPrincipal user,
            SignInManager<ApplicationUser> signInManager,
            [FromForm] string returnUrl) => {
            await signInManager.SignOutAsync();
            return TypedResults.LocalRedirect($"~/");
        });

        accountGroup.MapPost("/uploadImage", async (
            ClaimsPrincipal user,
            SignInManager<ApplicationUser> signInManager,
            [FromForm] string imgCropped) => {
            var base64 = imgCropped.Split(',');
            byte[] bytes = Convert.FromBase64String(base64[1]);
            string filePath = Path.Combine(WebApplication.CreateBuilder().Environment.WebRootPath, "upload", "Cropped.png");
            using (FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate)) {
                stream.Write(bytes, 0, bytes.Length);
                stream.Flush();
            }

            return TypedResults.LocalRedirect("~/");
        }).DisableAntiforgery();
        
        return accountGroup;
    }
}