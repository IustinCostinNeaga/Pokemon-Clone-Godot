using Godot;
using System;

public partial class ChangeSceneOnClickSript : Node
{
	[Export] private PackedScene scene;
	public void OnClick()
	{
		QueueFree();
	}
}
