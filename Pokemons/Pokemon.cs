using Godot;
using Godot.Collections;

[GlobalClass]
public partial class Pokemon : Resource
{
	[Export] private string name;
	[Export] private int hp;
	[Export] private Stat atk;
	[Export(PropertyHint.ResourceType, "Stat")] private Stat def;
	[Export] private Status status = Status.None;
	[Export] private Array<Move> moves;

	public enum Status
	{
		None,
		Burned,
		Freezed,
		Paralyzed,
		Poisoned,
		BadlyPoisoned,
	}
}

