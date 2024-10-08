using Godot;
using System;

public partial class GodotEventHandler : Node2D
{
	[Signal] public delegate void ShowWorldMapEventHandler();
	[Signal] public delegate void ShowBattleScreenEventHandler();

	
	private WorldMap worldMap;
	private BattleScreen battleScreen;
	
	public override void _Ready()
	{
		worldMap = ResourceLoader.Load<PackedScene>("res://Scenes/OverWorld.tscn").Instantiate<WorldMap>();
		worldMap.Connect(Node.SignalName.Ready, new Callable(this, nameof(OnWorldReady)));
		battleScreen = ResourceLoader.Load<PackedScene>("res://Scenes/BattleScreen.tscn").Instantiate<BattleScreen>();
		// battleScreen.Connect(Node.SignalName.Ready, new Callable(this, nameof(OnBattleReady)));
		CallDeferred(Node.MethodName.AddSibling, worldMap);
		CallDeferred(Node.MethodName.AddSibling, battleScreen);
		battleScreen.Hide();
	}

	public void OnWorldReady()
	{
		GetTree().Root.GetNode<Node2D>("Mondo/PlayableCharacter")
			.Connect(Player.SignalName.ChangeToBattleScene, new Callable(this, nameof(ChangeSceneToBattleOne)));
	}

	public void OnBattleReady()
	{
		GetTree().Root.GetNode<Button>("BattleScreen/Button")
			.Connect(BaseButton.SignalName.Pressed, new Callable(this, nameof(ChangeSceneToWorldOne)));
	}


	public void ChangeSceneToBattleOne(Pokemon pokemon)
	{
		battleScreen.instantiate(pokemon);
		EmitSignal(SignalName.ShowBattleScreen);
	}

	public void ChangeSceneToWorldOne()
	{
		EmitSignal(SignalName.ShowWorldMap);
	}
}
