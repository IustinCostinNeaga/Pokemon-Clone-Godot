using Godot;

namespace PokemonMoltoBrutto.Pokemons.MoveCommands;

[GlobalClass]
public partial class AttackBoosterEnemy : MoveCommand {
    [Export] private int boostAmount;
}