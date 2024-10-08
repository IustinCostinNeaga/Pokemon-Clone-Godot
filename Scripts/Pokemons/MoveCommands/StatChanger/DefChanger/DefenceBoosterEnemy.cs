using Godot;

namespace PokemonMoltoBrutto.Pokemons.MoveCommands;

[GlobalClass]
public partial class DefenceBoosterEnemy : MoveCommand {
    [Export] private int boostAmount;
}