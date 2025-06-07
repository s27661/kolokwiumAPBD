using Kolokwium.DTOs;

namespace Kolokwium.Services;

public interface IDbService
{
    public Task<ICollection<ClinetGetDto>> GetAllClinetsAsync();
    public Task<PaymentCreateDto> CreatePaymentAsync(PaymentCreateDto payment);
}