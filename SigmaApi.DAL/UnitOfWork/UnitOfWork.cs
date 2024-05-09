using SigmaApi.DAL.Data.Context;

namespace SigmaApi.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SigmaContext _context;

        public ICandidateRepo CandidateRepo { get; }

        public UnitOfWork(SigmaContext sigmaContext, ICandidateRepo candidateRepo)
        {
            _context = sigmaContext;
            CandidateRepo = candidateRepo;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
