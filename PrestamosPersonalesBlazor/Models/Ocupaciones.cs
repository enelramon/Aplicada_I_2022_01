using System.ComponentModel.DataAnnotations;

public class Ocupaciones
{
    [Key]
    public int OcupacionId { get; set; }

    [Required]
    public String? Descripcion { get; set; }

    [Range(1, 1_000_000)]
    public double Salario { get; set; }
}