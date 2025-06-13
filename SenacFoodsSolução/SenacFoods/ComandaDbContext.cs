

using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SenacFoods;

public class ComandaDBContext:DbContext


{

    // 1 Construtor do banco de dados
    public ComandaDBContext() : base()
    {

    }
    // 2  Configurar conexão
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { // 2.1 String de conexão
        var conexao = "Server=localhost;Database=SenacFoods;User=root;Password=";
        // 2.2 Configurar o provedor de banco de dados
        optionsBuilder.UseMySql(conexao, ServerVersion.AutoDetect(conexao));

        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<CardapioItem> CardapioItems { get; set; }
    public DbSet<Mesa> Mesas { get; set; }
    public DbSet<Comanda> Comandas { get; set; }
    public DbSet<ComandaItem> ComandaItems { get; set; }
    public DbSet<ComandaItem> PedidoCozinhas { get; set; }
    public DbSet<ComandaItem> PedidoCozinhaItems{ get; set; }


}
