using Godot;
using Godot.Collections;

[GlobalClass]
public partial class Pokemon : Resource {
    [Export] public string name;
    [Export] public Texture2D sprite;
    [Export] public Texture2D backSprite;
    [Export] public int hp;
    [Export] private Stat atk;
    [Export] private Stat def;
    [Export] private Stat spd;
    [Export] private Status status = Status.None;
    [Export] private Array<Move> moves;

    public enum Status {
        None,
        Burned,
        Frozen,
        Paralyzed,
        Poisoned,
        BadlyPoisoned,
    }
}