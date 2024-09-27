using Godot;
using static Pokemon;

[GlobalClass]
public partial class MoveCommand: Resource
{
    [Export] private string move;
};

[GlobalClass]
public partial class DamageDealer : MoveCommand
{
    [Export] private int damage;
}

[GlobalClass]
public partial class Healer : MoveCommand
{
    [Export] private int healAmount;
}

[GlobalClass]
public partial class AttackBooster : MoveCommand
{
    [Export] private int boostStages;
}

[GlobalClass]
public partial class DefenceBooster : MoveCommand
{
    [Export] private int boostStages;
}

[GlobalClass]
public partial class AttackBoosterEnemy : MoveCommand
{
    [Export] private int boostStages;
}

[GlobalClass]
public partial class DefenceBoosterEnemy : MoveCommand
{
    [Export] private int boostStages;
}

[GlobalClass]
public partial class AttackLowerer : MoveCommand
{
    [Export] private int lowerAmount;
}

[GlobalClass]
public partial class DefenceLowerer : MoveCommand
{
    [Export] private int lowerAmount;
}

[GlobalClass]
public partial class AttackLowererEnemy : MoveCommand
{
    [Export] private int lowerAmount;
}

[GlobalClass]
public partial class DefenceLowererEnemy : MoveCommand
{
    [Export] private int lowerAmount;
}

[GlobalClass]
public partial class StatusChanger : MoveCommand
{
    [Export] private Status status;
}

[GlobalClass]
public partial class StatusChangerEnemy : MoveCommand
{
    [Export] private Status status;
}