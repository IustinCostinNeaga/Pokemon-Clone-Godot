using Godot;

namespace PokemonMoltoBrutto.Pokemons.MoveCommands;

[GlobalClass]
public partial class DefenceBooster : MoveCommand
{
    [Export] private int boostAmount;
}