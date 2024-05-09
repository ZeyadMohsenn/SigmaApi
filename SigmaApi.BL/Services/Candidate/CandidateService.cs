using SigmaApi.BL.DTOS.Candidate;
using SigmaApi.BL.ServiceResponse;
using SigmaApi.DAL;

namespace SigmaApi.BL
{
    public class CandidateService : ICandidateService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CandidateService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public async Task<ServiceResponse<bool>> AddOrUpdateApplication(AddCandidateDto application)
        {
            try
            {
                application.FirstName = application.FirstName.Trim();
                application.LastName = application.LastName.Trim();
                application.Email = application.Email.Trim();

                var candidate = _unitOfWork.CandidateRepo.FindByEmail(application.Email);



                if (candidate != null) {
                    candidate.FirstName = application.FirstName;
                    candidate.LastName = application.LastName;
                    candidate.PhoneNumber = application.PhoneNumber;
                    candidate.CallTimeInterval = application.CallTimeInterval;
                    candidate.LinkedInUrl = application.LinkedInUrl;
                    candidate.GitHubUrl = application.GitHubUrl;
                    candidate.FreeTextComment = application.FreeTextComment;


                    _unitOfWork.CandidateRepo.UpdateApplication(candidate);
                    _unitOfWork.SaveChanges();

                    return new ServiceResponse<bool>()
                    {
                        Success = true,
                        Message = "Application Updated Successfully"
                    };
                }

                else
                {
                    Candidate candidateDB = new()
                    {
                        Email = application.Email,
                        FirstName = application.FirstName,
                        LastName = application.LastName,
                        PhoneNumber = application.PhoneNumber,
                        CallTimeInterval = application.CallTimeInterval,
                        LinkedInUrl = application.LinkedInUrl,
                        GitHubUrl = application.GitHubUrl,
                        FreeTextComment = application.FreeTextComment,
                    };
                    _unitOfWork.CandidateRepo.AddApplication(candidateDB);
                    _unitOfWork.SaveChanges();

                    return new ServiceResponse<bool>()
                    {
                        Success = true,
                        Message = "Application Created Successfully"
                    };
                }

            }
            catch (Exception)
            {
                return new ServiceResponse<bool>() { Success = false, Message = "An error occurred while Adding the application" };
            }
        }

    }
}

