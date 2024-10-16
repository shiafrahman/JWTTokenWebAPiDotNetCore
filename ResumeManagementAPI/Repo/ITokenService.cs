using ResumeManagementAPI.Models.DTOs;
using System.Security.Claims;

namespace ResumeManagementAPI.Repo
{
    public interface ITokenService
    {
        TokenResponse GetToken(IEnumerable<Claim> claim);
        string GetRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
