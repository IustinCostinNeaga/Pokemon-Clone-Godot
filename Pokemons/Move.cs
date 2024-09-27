using Godot;
using Godot.Collections;

[GlobalClass]
public partial class Move : Resource
{
    [Export] private string name;
    [Export] private string description;
    [Export] private Array<MoveCommand> moves;
}