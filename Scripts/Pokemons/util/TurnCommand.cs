using static Pokemon;


public class TurnCommand { }


public class Damage : TurnCommand
{
    private int damage;
    private Pokemon target;
    private Pokemon attacker;
}

public class Heal : TurnCommand
{
    private int healAmount;
    private Pokemon pokemon;
}

public class StatChange : TurnCommand
{
    private int boostStages;
    private string Stat;
    private Pokemon pokemon;
}

public class StatusChange : TurnCommand
{
    private Status status;
    private Pokemon pokemon;
}
