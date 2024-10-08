using Godot;
using Godot.Collections;

[GlobalClass]
public partial class Move : Resource {
    [Export] private string name;
    [Export] private string description;
    [Export] private Priority priority;
    [Export] private Array<MoveCommand> moves;

    internal enum Priority {
        Absolute,
        Faster,
        Normal,
        Slower
    }
}