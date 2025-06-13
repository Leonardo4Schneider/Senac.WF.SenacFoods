

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SenacFoods;

public class Comanda
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int NumeroMesa { get; set; }
    public string NomeCliente { get; set; }
    public int SituacaoComanda { get; set; }
}
