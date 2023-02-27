using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using API_Kassim_Co.Data;
using System;
using System.Linq;
namespace API_BDTN.Models;
public static class SeedData // Ajout d’une nouvelle classe SeedData dans Models pour créer la base et ajouter un film si besoin
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new API_Kassim_CoContext(
        serviceProvider.GetRequiredService<
        DbContextOptions<API_Kassim_CoContext>>()))
        {
            context.Database.EnsureCreated();
            // S’il y a déjà des films dans la base
            if (context.Continent.Any())
            {
                return; // On ne fait rien
            }
            // Sinon on en ajoute un
            context.Continent.AddRange(
            new API_Kassim_Co.Models.Continent
            {
                Nom = "France"
            }
            );
            context.SaveChanges();
        }
    }
}