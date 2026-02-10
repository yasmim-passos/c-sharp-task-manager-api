using Microsoft.EntityFrameworkCore;

namespace TaskManager.Data;

/// <summary>
/// Contexto do banco de dados
/// Demonstra: Entity Framework, DbContext
/// </summary>
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Models.Task> Tasks { get; set; }
    public DbSet<Models.User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configuração da entidade Task
        modelBuilder.Entity<Models.Task>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Title).IsRequired().HasMaxLength(200);
            entity.Property(e => e.Description).HasMaxLength(1000);
            
            // Relacionamento com User
            entity.HasOne(e => e.AssignedUser)
                  .WithMany(u => u.Tasks)
                  .HasForeignKey(e => e.AssignedUserId)
                  .OnDelete(DeleteBehavior.SetNull);
        });

        // Configuração da entidade User
        modelBuilder.Entity<Models.User>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
            entity.Property(e => e.Email).IsRequired().HasMaxLength(200);
            entity.Property(e => e.Role).HasMaxLength(50);
        });

        // Dados de exemplo (Seed)
        SeedData(modelBuilder);
    }

    private void SeedData(ModelBuilder modelBuilder)
    {
        // Usuários exemplo
        modelBuilder.Entity<Models.User>().HasData(
            new { Id = 1, Name = "João Silva", Email = "joao@claps.com", Role = "Developer", CreatedAt = DateTime.Now },
            new { Id = 2, Name = "Maria Santos", Email = "maria@claps.com", Role = "Designer", CreatedAt = DateTime.Now }
        );

        // Tarefas exemplo
        modelBuilder.Entity<Models.Task>().HasData(
            new
            {
                Id = 1,
                Title = "Implementar API de Usuários",
                Description = "Criar endpoints REST para gerenciar usuários",
                Status = Models.TaskStatus.InProgress,
                Priority = Models.TaskPriority.High,
                CreatedAt = DateTime.Now,
                DueDate = DateTime.Now.AddDays(7),
                AssignedUserId = 1
            },
            new
            {
                Id = 2,
                Title = "Criar design do dashboard",
                Description = "Prototipar interface do painel administrativo",
                Status = Models.TaskStatus.Pending,
                Priority = Models.TaskPriority.Medium,
                CreatedAt = DateTime.Now,
                DueDate = DateTime.Now.AddDays(5),
                AssignedUserId = 2
            }
        );
    }
}
