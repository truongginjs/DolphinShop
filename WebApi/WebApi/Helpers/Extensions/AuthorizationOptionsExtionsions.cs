using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using WebApi.Helpers.Constants;

namespace WebApi.Helpers.Extensions
{
    public static class AuthorizationOptionsExtionsions
    {
        public static void SettingPolicies(this AuthorizationOptions options)
        {
            options.AddPolicy(Constant.PolicyTypes.Admin, policy =>
            {
                policy.RequireAuthenticatedUser();
                policy.RequireClaim(ClaimTypes.Role, Constant.RoleTypes.Admin);
            });

            options.AddPolicy(Constant.PolicyTypes.User, policy =>
            {
                policy.RequireAuthenticatedUser();
                policy.RequireClaim(ClaimTypes.Role, Constant.RoleTypes.User);
            });

            options.AddPolicy(Constant.PolicyTypes.Viewer, policy =>
            {
                policy.RequireAuthenticatedUser();
                policy.RequireClaim(ClaimTypes.Role, Constant.RoleTypes.Viewer);
            });
        }
    }
}
