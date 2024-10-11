using Godot;
using Godot.Collections;

[GlobalClass]
public partial class Move : Resource {
    [Export] public string name;
    [Export] private string description;
    [Export] private Priority priority;
    [Export] private Array<MoveCommand> moves;

    public Move() {
        this.name = "MissingMove";
        this.description = "";
        this.priority = Priority.Normal;
        this.moves = new Array<MoveCommand>();
    }
    
    internal enum Priority {
        Absolute,
        Faster,
        Normal,
        Slower
    }
}