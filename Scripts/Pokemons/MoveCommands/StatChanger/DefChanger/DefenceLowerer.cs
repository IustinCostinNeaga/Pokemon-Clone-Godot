using Godot;

namespace PokemonMoltoBrutto.Pokemons.MoveCommands;

[GlobalClass]
public partial class DefenceLowerer : MoveCommand {
    [Export] private int lowerAmount;
}