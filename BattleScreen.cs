using Godot;
using System;

public partial class BattleScreen : Node2D
{
	private Pokemon yourPokemon;
	private Pokemon enemyPokemon;
	
	private Sprite2D yourPokemonSprite;
	private Sprite2D enemyPokemonSprite;
	private Camera2D camera;

	public void instantiate(Pokemon pokemon)
	{
		yourPokemon = pokemon;
		int number = new Random().Next(3);
		switch (number)
		{
			case 1: enemyPokemon = ResourceLoader.Load<Pokemon>("res://Pokemons/PocketMonsters/charmander.tres");break;
			case 2: enemyPokemon = ResourceLoader.Load<Pokemon>("res://Pokemons/PocketMonsters/bulbasaur.tres");break;
			case 3: enemyPokemon = ResourceLoader.Load<Pokemon>("res://Pokemons/PocketMonsters/squirtle.tres");break;
		}
		
		yourPokemonSprite.Texture = yourPokemon.sprite;
		enemyPokemonSprite.Texture = enemyPokemon.sprite;
		camera.MakeCurrent();
	}

	public override void _Ready()
	{
		yourPokemonSprite = GetNode<Sprite2D>("YourPokemon");
		enemyPokemonSprite = GetNode<Sprite2D>("EnemyPokemon");
		camera = GetNode<Camera2D>("Camera");
	}
}
