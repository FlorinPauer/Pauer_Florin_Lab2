using Microsoft.EntityFrameworkCore;

public class Pauer_Florin_Lab2Context(DbContextOptions<Pauer_Florin_Lab2Context> options) : DbContext(options)
{
    public DbSet<Pauer_Florin_Lab2.Models.Book> Book { get; set; } = default!;
    public DbSet<Pauer_Florin_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    public DbSet<Pauer_Florin_Lab2.Models.Author> Author { get; set; } = default!;
    public DbSet<Pauer_Florin_Lab2.Models.Category> Category { get; set; } = default!;
}