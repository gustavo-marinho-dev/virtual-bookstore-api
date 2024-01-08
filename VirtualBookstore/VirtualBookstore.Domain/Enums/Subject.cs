using System;
using System.ComponentModel;

namespace VirtualBookstore.Domain.Enums
{
    public enum Subject
    {
        [Description("Artes")]
        Arts,
        [Description("Biografias")]
        Biographies,
        [Description("Negócios")]
        Business,
        [Description("Infantil")]
        Children,
        [Description("Tecnologia")]
        Technology,
        [Description("Culinária")]
        Cooking,
        [Description("Saúde")]
        Health,
        [Description("História")]
        History,
        [Description("Casa")]
        Home,
        [Description("Humor")]
        Humor,
        [Description("Literatura")]
        Literature,
        [Description("Mistério")]
        Mystery,
        [Description("Paternidade")]
        Parenting,
        [Description("Política")]
        Politics,
        [Description("Religião")]
        Religion,
        [Description("Romance")]
        Romance,
        [Description("Autoajuda")]
        SelfHelp,
        [Description("Ciência e Natureza")]
        ScienceAndNature,
        [Description("Ficção Científica")]
        ScienceFiction,
        [Description("Esportes")]
        Sports,
        [Description("Juventude")]
        Youth,
        [Description("Viagens")]
        Travel,
        [Description("Fantasia")]
        Fantasy
    }
}
  