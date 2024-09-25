using static Pokemon;

namespace PokemonMoltoBrutto.Pokemons.util;

public interface MoveType {};

public class DamageDealer : MoveType
{
    private int damage;
}

public class Healer : MoveType
{
    private int healAmount;
}

public class AttackBooster : MoveType
{
    private int boostStages;
}

public class DefenceBooster : MoveType
{
    private int boostStages;
}

public class AttackBoosterEnemy : MoveType
{
    private int boostStages;
}

public class DefenceBoosterEnemy : MoveType
{
    private int boostStages;
}

public class AttackLowerer : MoveType
{
    private int lowerAmount;
}

public class DefenceLowerer : MoveType
{
    private int lowerAmount;
}

public class AttackLowererEnemy : MoveType
{
    private int lowerAmount;
}

public class DefenceLowererEnemy : MoveType
{
    private int lowerAmount;
}

public class StatusChanger : MoveType
{
    private Status status;
}

public class StatusChangerEnemy : MoveType
{
    private Status status;
}