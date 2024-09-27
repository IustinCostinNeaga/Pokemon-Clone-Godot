using Godot;

namespace PokemonMoltoBrutto.Pokemons.MoveCommands;

[GlobalClass]
public partial class AttackBooster : MoveCommand
{
    [Export] private int boostAmount;
}