using Godot;
using System;
using System.Collections.Generic;
using Godot.Collections;

[GlobalClass]
public partial class Pokemon : Resource
{
	[Export] private string name {get; set;}
	[Export] private int hp {get; set;}
	[Export] private Stat atk {get; set;}
	[Export(PropertyHint.ResourceType, "Stat")] private Stat def {get; set;}
	[Export] private Status status = Status.None;
	[Export] private Array<Move> moves {get; set;}

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

