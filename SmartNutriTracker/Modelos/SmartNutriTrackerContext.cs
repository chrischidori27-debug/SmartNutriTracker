using Microsoft.EntityFrameworkCore;

namespace SmartNutriTracker.Modelos;

public partial class SmartNutriTrackerContext : DbContext
{
    public SmartNutriTrackerContext(DbContextOptions<SmartNutriTrackerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Alimento> Alimentos { get; set; }
    public virtual DbSet<LogsAuditorium> LogsAuditoria { get; set; }
    public virtual DbSet<MenuAlimento> MenuAlimentos { get; set; }
    public virtual DbSet<MenusDiario> MenusDiarios { get; set; }
    public virtual DbSet<Role> Roles { get; set; }
    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Nombres de tablas explícitos (por si el naming convention no alcanza)
        modelBuilder.Entity<Role>().ToTable("roles");
        modelBuilder.Entity<Usuario>().ToTable("usuarios");
        modelBuilder.Entity<Alimento>().ToTable("alimentos");
        modelBuilder.Entity<MenusDiario>().ToTable("menus_diarios");
        modelBuilder.Entity<MenuAlimento>().ToTable("menu_alimentos");
        modelBuilder.Entity<LogsAuditorium>().ToTable("logs_auditoria");

        modelBuilder.Entity<Alimento>(entity =>
        {
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaRegistro).HasDefaultValueSql("now()");
            entity.Property(e => e.Fibra).HasDefaultValue(0m);
        });

        modelBuilder.Entity<LogsAuditorium>(entity =>
        {
            entity.Property(e => e.Fecha).HasDefaultValueSql("now()");

            entity.HasOne(d => d.Usuario)
                  .WithMany(p => p.LogsAuditoria)
                  .HasForeignKey(d => d.UsuarioId)
                  .OnDelete(DeleteBehavior.SetNull)
                  .HasConstraintName("fk_logs_usuarios");
        });

        modelBuilder.Entity<MenuAlimento>(entity =>
        {
            entity.HasOne(d => d.Alimento)
                  .WithMany(p => p.MenuAlimentos)
                  .HasForeignKey(d => d.AlimentoId)
                  .OnDelete(DeleteBehavior.Restrict)
                  .HasConstraintName("fk_menualim_alimento");

            entity.HasOne(d => d.Menu)
                  .WithMany(p => p.MenuAlimentos)
                  .HasForeignKey(d => d.MenuId)
                  .OnDelete(DeleteBehavior.Cascade)
                  .HasConstraintName("fk_menualim_menu");
        });

        modelBuilder.Entity<MenusDiario>(entity =>
        {
            entity.Property(e => e.FechaRegistro).HasDefaultValueSql("now()");

            entity.HasOne(d => d.Usuario)
                  .WithMany(p => p.MenusDiarios)
                  .HasForeignKey(d => d.UsuarioId)
                  .OnDelete(DeleteBehavior.Restrict)
                  .HasConstraintName("fk_menus_usuarios");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaRegistro).HasDefaultValueSql("now()");

            entity.HasOne(d => d.Rol)
                  .WithMany(p => p.Usuarios)
                  .HasForeignKey(d => d.RolId)
                  .OnDelete(DeleteBehavior.Restrict)
                  .HasConstraintName("fk_usuarios_roles");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}