using Godot;
using static Pokemon;

namespace PokemonMoltoBrutto.Pokemons.MoveCommands;

[GlobalClass]
public partial class StatusChanger : MoveCommand {
    [Export] private Status status;
}