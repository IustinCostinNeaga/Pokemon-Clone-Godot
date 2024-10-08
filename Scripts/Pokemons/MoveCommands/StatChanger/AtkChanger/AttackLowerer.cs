using Godot;

namespace PokemonMoltoBrutto.Pokemons.MoveCommands;

[GlobalClass]
public partial class AttackLowerer : MoveCommand {
    [Export] private int lowerAmount;
}