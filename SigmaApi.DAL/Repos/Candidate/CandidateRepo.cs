using SigmaApi.DAL.Data.Context;

namespace SigmaApi.DAL
{
    public class CandidateRepo : ICandidateRepo
    {
        private readonly SigmaContext _context;

        public CandidateRepo(SigmaContext context)
        {
            _context = context;
        }
        public void AddApplication(Candidate candidate)
        {
            _context.Set<Candidate>().Add(candidate);
        }

        public Candidate FindByEmail(string email)
        {
            return _context.Set<Candidate>().Find(email);
        }


        public void UpdateApplication(Candidate candidate)
        {
            _context.Set<Candidate>().Update(candidate);
        }
    }
}
