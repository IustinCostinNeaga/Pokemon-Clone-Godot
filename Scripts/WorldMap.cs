using Godot;
using System;
using System.Security.Principal;

public partial class WorldMap : Node2D {
    public override void _Ready() {
        var eventHandler = GetTree().Root.GetNode<GodotEventHandler>("StartingScene");
        eventHandler.Connect(GodotEventHandler.SignalName.ShowBattleScreen, new Callable(this, nameof(HideMap)));
        eventHandler.Connect(GodotEventHandler.SignalName.ShowWorldMap, new Callable(this, nameof(UnHideMap)));
    }

    private void HideMap() {
        Hide();
    }

    private void UnHideMap() {
        Show();
    }
}