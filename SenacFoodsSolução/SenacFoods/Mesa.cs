
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SenacFoods;

public class Mesa
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int NumeroMesa { get; set; }
    // 0-Disponível 1-ocupada 2-Reservada
    public int SituacaoMesa { get; set; }


}
