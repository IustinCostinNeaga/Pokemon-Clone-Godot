using Godot;

namespace PokemonMoltoBrutto.Pokemons.MoveCommands;

[GlobalClass]
public partial class Healer : MoveCommand
{
    [Export] private int healAmount;
}