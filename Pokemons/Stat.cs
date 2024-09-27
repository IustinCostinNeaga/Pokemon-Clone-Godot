using System;
using Godot;

[GlobalClass]
public partial class Stat : Resource
{
    [Export] private string stat;
    [Export] private int baseAmount;
    private int actual;
    private int statBoost;
}