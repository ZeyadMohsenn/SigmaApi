using SigmaApi.BL.DTOS.Candidate;
using SigmaApi.BL.ServiceResponse;

namespace SigmaApi.BL
{
    public interface ICandidateService
    {
        Task<ServiceResponse<bool>> AddOrUpdateApplication(AddCandidateDto application);
    }
}
