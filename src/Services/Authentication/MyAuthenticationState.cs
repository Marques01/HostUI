using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Services.Authentication
{
    public class MyAuthenticationState : AuthenticationStateProvider
    {
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var user = new ClaimsIdentity();

            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(user)));
        }
    }
}
