using Godot;
using System;
using System.Collections.Generic;

public partial class Pokemon : Node
{
	[Export] private String name;
	[Export] private int hp;
	[Export] private Stat atk;
	[Export] private Stat def;git@github.com:IustinCostinNeaga/Pokemon-Clone-Godot.git
	[Export] private Status status = Status.None;
	[Export] private List<Move> moves;
	
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

public abstract partial class Stat : Node
{
	[Export] private String stat;
	[Export] private int baseAmount;
	[Export] private int actual;
	[Export] private int statBoost;
}

public partial class Move : Node
{
	[Export] private String name;
	[Export] private String description;
	[Export] private List<Command> commands;
}



internal interface Command
{
}
