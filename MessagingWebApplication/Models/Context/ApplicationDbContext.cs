﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessagingWebApplication.Models;
using Core.MessageSender.Contracts.Models;
using Microsoft.EntityFrameworkCore;

namespace MessagingWebApplication
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Message> Messages { get; set; }
        public DbSet<Core.MessageSender.Contracts.Models.EmailMessage> EmailMessages { get; set; }
        public DbSet<ToDoItems> ToDoItems { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
      
        {
        }

     
    }
}
