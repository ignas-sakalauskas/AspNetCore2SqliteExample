using Microsoft.EntityFrameworkCore;

namespace dbtest
{
    public class MailDBServicesContext : DbContext
    {
        public MailDBServicesContext(DbContextOptions<MailDBServicesContext> options)
            : base(options)
        {

        }

        public DbSet<MailCountSentErrorMails> DbSetMailCountSentErrorMails { get; set; }
    }
}