using Microsoft.EntityFrameworkCore;
using BaseLibrary.Entities;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace ServerLibrary.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<UserNote> UserNotes { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure many-to-many relationship
            modelBuilder.Entity<UserNote>()
                .HasKey(un => new { un.UserId, un.NoteId });

            modelBuilder.Entity<UserNote>()
                .HasOne(un => un.User)
                .WithMany(u => u.UserNotes)
                .HasForeignKey(un => un.UserId);

            modelBuilder.Entity<UserNote>()
                .HasOne(un => un.Note)
                .WithMany(n => n.UserNotes)
                .HasForeignKey(un => un.NoteId);
        }
    }
}
