using Godot;
using System;

public partial class BattleScreen : Control {
    private Pokemon yourPokemon;
    private Pokemon enemyPokemon;

    private TextureRect yourPokemonSprite;
    private TextureRect enemyPokemonSprite;

    private Label yourPokemonName;
    private Label yourPokemonHp;
    private Label enemyPokemonName;
    private Label enemyPokemonHp;
    private Camera2D camera;

    public void instantiate(Pokemon pokemon) {
        yourPokemon = pokemon;
        int number = new Random().Next(3);
        switch (number) {
            case 0:
                enemyPokemon = ResourceLoader.Load<Pokemon>("res://Scripts/Pokemons/PocketMonsters/charmander.tres");
                break;
            case 1:
                enemyPokemon = ResourceLoader.Load<Pokemon>("res://Scripts/Pokemons/PocketMonsters/bulbasaur.tres");
                break;
            case 2:
                enemyPokemon = ResourceLoader.Load<Pokemon>("res://Scripts/Pokemons/PocketMonsters/squirtle.tres");
                break;
        }

        yourPokemonSprite.Texture = yourPokemon.backSprite;
        enemyPokemonSprite.Texture = enemyPokemon.sprite;

        yourPokemonName.Text = yourPokemon.name;
        yourPokemonHp.Text = "HP: " + yourPokemon.hp;
        enemyPokemonName.Text = enemyPokemon.name;
        enemyPokemonHp.Text = "HP: " + enemyPokemon.hp;

        camera.MakeCurrent();
    }

    public override void _Ready() {
        var eventHandler = GetTree().Root.GetNode<GodotEventHandler>("StartingScene");
        eventHandler.Connect(GodotEventHandler.SignalName.ShowBattleScreen, new Callable(this, nameof(UnHideBattle)));
        eventHandler.Connect(GodotEventHandler.SignalName.ShowWorldMap, new Callable(this, nameof(HideBattle)));

        yourPokemonSprite = GetNode<TextureRect>("YourPokemonSide/Sprites/PokemonSprite");
        enemyPokemonSprite = GetNode<TextureRect>("EnemyPokemonSide/Sprites/PokemonSprite");

        yourPokemonName = GetNode<Label>("YourPokemonSide/PokemonStats/Texts/Name");
        yourPokemonHp = GetNode<Label>("YourPokemonSide/PokemonStats/Texts/HP");
        enemyPokemonName = GetNode<Label>("EnemyPokemonSide/PokemonStats/Texts/Name");
        enemyPokemonHp = GetNode<Label>("EnemyPokemonSide/PokemonStats/Texts/HP");

        camera = GetNode<Camera2D>("Camera");
    }

    public void ChangeToMoves() {
        
    }

    public void ChangeToFight() {
        
    }

    public void HideBattle() {
        Hide();
    }

    public void UnHideBattle() {
        Show();
    }
}