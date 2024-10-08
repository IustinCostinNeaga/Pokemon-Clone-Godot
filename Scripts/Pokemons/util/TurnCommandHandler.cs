using System;
using PokemonMoltoBrutto.Pokemons.MoveCommands;
using PokemonMoltoBrutto.Pokemons.util.TurnCommandHandlers;

namespace PokemonMoltoBrutto.Pokemons.util;

public interface TurnCommandHandler {
    void send(TurnCommand command);
}

public class Turn : TurnCommandHandler {
    public void send(TurnCommand command) {
        switch (command) {
            case Damage damage: {
                new DamageHandler().handle(damage);
                break;
            }
            case Heal heal: {
                new HealHandler().handle(heal);
                break;
            }
            case StatChange statChange: {
                new StatChangeHandler().handle(statChange);
                break;
            }
            case StatusChange statusChange: {
                new StatusChangeHandler().handle(statusChange);
                break;
            }
            default: throw new ArgumentOutOfRangeException(nameof(command));
        }
    }
}