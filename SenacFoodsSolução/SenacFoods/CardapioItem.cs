

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SenacFoods;

public class CardapioItem
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public decimal Preco { get; set; }
    public bool PossuiPreparo { get; set; }
}
