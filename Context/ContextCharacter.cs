using MarvelMasterApi.Models;
using System.Data.Entity;

namespace MarvelMasterApi.Context
{
    public class ContextCharacter : DbContext
    {
        public DbSet<Personagem> Personagem { get; set; }
    }
}
