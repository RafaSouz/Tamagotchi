﻿namespace PokeApi.Classes;

public class Pokemon
{
    public string Name { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public List<Ability> Abilities { get; set; }

    public override string ToString()
    {
        var abilidades = Abilities != null ? string.Join("\n", 
            Abilities.Select(a => a.Info.Name)) : string.Empty;

        return "Nome Pokemon: " + Name + '\n' +
               "Altura: " + Height + "\n" +
               "Peso: " + Weight + "\n" +
               "Habilidades: " + "\n" + (abilidades).ToUpper();
               
    }
}
