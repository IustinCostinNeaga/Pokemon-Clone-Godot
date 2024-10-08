using Godot;

namespace PokemonMoltoBrutto.Pokemons.MoveCommands;

[GlobalClass]
public partial class AttackLowererEnemy : MoveCommand {
    [Export] private int lowerAmount;
}