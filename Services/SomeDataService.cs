using System;
using System.Threading.Tasks;

namespace dbtest
{
    public class SomeDataService : ISomeDataService
    {
        private readonly MailDBServicesContext _dbContext;

        public SomeDataService(MailDBServicesContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public void AddMailCounts()
        {
            _dbContext.DbSetMailCountSentErrorMails
                .Add(new MailCountSentErrorMails { CountSentMails = 55 });
            _dbContext.SaveChanges();
        }
    }
}