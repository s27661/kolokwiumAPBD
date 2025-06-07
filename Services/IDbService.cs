using Kolokwium.DTOs;

namespace Kolokwium.Services;

public interface IDbService
{
    public Task<ICollection<ClinetGetDto>> GetAllClinetsAsync();
}