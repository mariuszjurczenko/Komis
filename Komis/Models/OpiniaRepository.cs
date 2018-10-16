namespace Komis.Models
{
    public class OpiniaRepository : IOpiniaRepository
    {
        private readonly AppDbContext _appDbContext;

        public OpiniaRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void DodajOpinie(Opinia opinia)
        {
            _appDbContext.Opinie.Add(opinia);
            _appDbContext.SaveChanges();
        }
    }
}
