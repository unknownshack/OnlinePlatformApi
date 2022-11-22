using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatformAPI;
using OnlineLearningPlatformAPI.Class;

namespace OnlineLearningPlatformAPI.Data
{
    public class OnlineLearningPlatformAPIContext : DbContext
    {
        public OnlineLearningPlatformAPIContext (DbContextOptions<OnlineLearningPlatformAPIContext> options)
            : base(options)
        {
        }

        public DbSet<OnlineLearningPlatformAPI.User> User { get; set; }

        public DbSet<OnlineLearningPlatformAPI.Class.Course> Course { get; set; }

        public DbSet<OnlineLearningPlatformAPI.Class.Lesson> Lesson { get; set; }

        public DbSet<OnlineLearningPlatformAPI.Class.Activity> Activity { get; set; }

        public DbSet<OnlineLearningPlatformAPI.Class.Payment> Payment { get; set; }

        public DbSet<OnlineLearningPlatformAPI.Class.Notes> Notes { get; set; }

        public DbSet<OnlineLearningPlatformAPI.Class.Progress> Progress { get; set; }
    }
}
