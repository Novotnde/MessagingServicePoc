using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MessagingWebApplication.Models.Context
{
    public class SmsMessageDbContext : DbContext
    {
        public SmsMessageDbContext(DbContextOptions options) : base(options)
        {

        }
        DbSet<SmsMessage>SmsMessages { get; set; }
    }
}
