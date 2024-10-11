using Godot;
using System;

public partial class MoveButton : TextureButton {
    private Move move = new Move();
    private Label name;

    public override void _Ready() {
        name = GetNode<Label>("Name");
        name.Text = move.name;
    }

    private void OnClick() {
        GD.Print("Move used");
    }
}
