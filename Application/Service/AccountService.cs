using Application.DTO.Request.Identity;
using Application.DTO.Response;
using Application.DTO.Response.Identity;
using Application.Interface.Identity;

namespace Application.Service
{
    public class AccountService(IAccount account) : IAccountService
    {
        public async Task<ServiceResponse> CreateUserAsync(CreateUserRequestDTO model) => await account.CreateUserAsync(model);

        public async Task<IEnumerable<GetUserWithClaimResponseDTO>> GetUserWithClaimsAsync() => await account.GetUserWithClaimsAsync();

        public async Task<ServiceResponse> LoginAsync(LoginUserRequestDTO model) => await account.LoginAsync(model);

        public async Task SetupAsync() => await account.SetupAsync();

        public async Task<ServiceResponse> UpdteUserAsync(ChangeUserClaimRequestDTO model) => await account.UpdteUserAsync(model);
    }
}