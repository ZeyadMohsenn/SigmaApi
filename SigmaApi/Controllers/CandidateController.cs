using Microsoft.AspNetCore.Mvc;
using SigmaApi.BL;
using SigmaApi.BL.DTOS.Candidate;

namespace SigmaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private readonly ICandidateService _candidateService;
        public CandidateController(ICandidateService candidateService)
        {
            _candidateService = candidateService;
        }

        [HttpPost]
        public async Task<IActionResult> AddApplication([FromBody] AddCandidateDto application)
        {
            var candidate = await _candidateService.AddOrUpdateApplication(application);
            return Ok(candidate);
        }
    }
}
