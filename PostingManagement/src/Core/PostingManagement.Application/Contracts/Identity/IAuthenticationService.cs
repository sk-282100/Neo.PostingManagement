using PostingManagement.Application.Models.Authentication;
using System.Threading.Tasks;

namespace PostingManagement.Application.Contracts.Identity
{
    public interface IAuthenticationService
    {
        Task<AuthenticationResponse> AuthenticateAsync(AuthenticationRequest request);
        Task<RegistrationResponse> RegisterAsync(RegistrationRequest request);
        Task<RefreshTokenResponse> RefreshTokenAsync(RefreshTokenRequest request);
        Task<RevokeTokenResponse> RevokeToken(RevokeTokenRequest request);
    }
}
