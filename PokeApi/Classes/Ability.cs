using System.Text.Json.Serialization;

namespace PokeApi.Classes;

public class Ability
{
    [JsonPropertyName("ability")]
    public AbilityInfo Info { get; set; }
    public bool IsHidden { get; set; }
    public int Slot { get; set; }
}
