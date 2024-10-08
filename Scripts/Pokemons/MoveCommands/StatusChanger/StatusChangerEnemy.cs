using Godot;
using static Pokemon;

namespace PokemonMoltoBrutto.Pokemons.MoveCommands;

[GlobalClass]
public partial class StatusChangerEnemy : MoveCommand {
    [Export] private Status status;
}