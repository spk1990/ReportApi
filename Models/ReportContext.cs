using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace ReportApi.Models
{
    public class ReportContext : DbContext
    {
        public ReportContext(DbContextOptions<ReportContext> options)
            : base(options)
        {
        }

        public DbSet<Report> report { get; set; } = null!;
    }
}