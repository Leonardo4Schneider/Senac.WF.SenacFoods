
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SenacFoods;

public class PedidoCozinha
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public int ComandaId { get; set; }

    public int SituaçãoId { get; set; }



}
