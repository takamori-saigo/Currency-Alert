using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public class CurrencyAlertContext: DbContext
{
    public DbSet<Currency> Currencies { get; set; }

    public CurrencyAlertContext(DbContextOptions<CurrencyAlertContext> options): 
        base(options){}
}