using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Notes_Practice.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Note> Notes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TaggedNote> TaggedNotes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TaggedNote>()
                .HasKey(tn => new { tn.TagId, tn.NoteId });

            //Seed Tables
            modelBuilder.Entity<Tag>().HasData(new Tag { Id = 1, TagName = "Personal"});
            modelBuilder.Entity<Tag>().HasData(new Tag { Id = 2, TagName = "Work" });
            modelBuilder.Entity<Tag>().HasData(new Tag { Id = 3, TagName = "Vacation" });

            modelBuilder.Entity<Note>().HasData(
                new Note { 
                    Id = 1,
                    Title = "Stuff To do", 
                    Content = "Work Stuff a lot todo's", 
                    
                });

            modelBuilder.Entity<Note>().HasData(
                new Note
                {
                    Id = 2,
                    Title = "Vacation in Bahamas",
                    Content = "Chill Mode is On.",
                    
                });

            modelBuilder.Entity<TaggedNote>().HasData(new TaggedNote {NoteId = 1, TagId = 2});
            modelBuilder.Entity<TaggedNote>().HasData(new TaggedNote { NoteId = 2, TagId = 1 });
            modelBuilder.Entity<TaggedNote>().HasData(new TaggedNote { NoteId = 2, TagId = 3 });
        }
    }
}
