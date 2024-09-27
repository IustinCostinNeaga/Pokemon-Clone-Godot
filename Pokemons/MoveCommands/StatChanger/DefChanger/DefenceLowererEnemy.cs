using Godot;

namespace PokemonMoltoBrutto.Pokemons.MoveCommands;

[GlobalClass]
public partial class DefenceLowererEnemy : MoveCommand
{
    [Export] private int lowerAmount;
}