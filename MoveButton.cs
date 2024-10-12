using Godot;
using System;

public partial class MoveButton : TextureButton {
    private Move move = new Move();
    private Label nameLabel;

    public override void _Ready() {
        nameLabel = GetNode<Label>("Name");
        nameLabel.Text = move.name;
    }

    public void Initialize(Move move) {
        this.move = move;
        nameLabel.Text = move.name;
    }

    private void OnClick() {
        GD.Print("Move " + move.name + " used: " + move);
    }
}
