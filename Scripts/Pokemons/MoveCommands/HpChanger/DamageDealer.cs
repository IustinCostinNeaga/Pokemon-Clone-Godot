using Godot;

namespace PokemonMoltoBrutto.Pokemons.MoveCommands;

[GlobalClass]
public partial class DamageDealer : MoveCommand {
    [Export] private int damage;
}