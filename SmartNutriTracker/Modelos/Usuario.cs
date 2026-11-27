using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SmartNutriTracker.Modelos;

[Index("Correo", Name = "uq_usuarios_correo", IsUnique = true)]
public partial class Usuario
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Nombres { get; set; } = null!;

    [Required]
    [StringLength(50)]
    public string Apellidos { get; set; } = null!;

    [Required]
    [StringLength(150)]
    public string Correo { get; set; } = null!;

    [Required]
    [StringLength(500)]
    public string PasswordHash { get; set; } = null!;

    public int RolId { get; set; }

    public bool Estado { get; set; } = true;

    public DateTime FechaRegistro { get; set; }

    [InverseProperty("Usuario")]
    public virtual ICollection<LogsAuditorium> LogsAuditoria { get; set; } = new List<LogsAuditorium>();

    [InverseProperty("Usuario")]
    public virtual ICollection<MenusDiario> MenusDiarios { get; set; } = new List<MenusDiario>();

    [ForeignKey("RolId")]
    [InverseProperty("Usuarios")]
    public virtual Role Rol { get; set; } = null!;

    // Propiedad de conveniencia (no se mapea a la BD)
    [NotMapped]
    public string NombreCompleto => $"{Nombres} {Apellidos}".Trim();
}