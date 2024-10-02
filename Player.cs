using System;
using System.Threading;
using Godot;
using Timer = Godot.Timer;

public partial class Player : Node2D
{
    [Export] private float speed = 4.0f;

    private Vector2 direction = Vector2.Zero;
    private Vector2 currentPosition;
    private Vector2 nextPosition;

    private bool isMoving;
    private bool movementIsEnabled = true;

    private AnimationPlayer animationPlayer;
    private TileMapLayer tilemap;
    private Timer timer;
    private Node thisNode;

    private float percentMoved = 0;

    [Export] private Pokemon yourPokemon;

    public override void _Ready()
    {
        animationPlayer = GetNode<AnimationPlayer>("PgAnimations");
        animationPlayer.Play("move_down");
        tilemap = GetNode<TileMapLayer>("../WorldMap");
        timer = GetNode<Timer>("PgAnimationTimer");
        timer.Start();
        currentPosition = Position;
        thisNode = this;
    }

    public override void _Process(double delta)
    {
        if (movementIsEnabled)
        {
            if (!isMoving)
            {
                HandleInput();
            }
            else
            {
                HandleMovement(delta);
            }
        }
    }

    public void HandleMovement(double delta)
    {
        percentMoved += (float)delta * speed;
        if (percentMoved >= 1)
        {
            Position = nextPosition;
            currentPosition = Position;
            isMoving = false;
            percentMoved = 0;
            direction = Vector2.Zero;
        }
        else
        {
            Position = currentPosition + (nextPosition - currentPosition) * percentMoved;
        }
    }

    private void HandleInput()
    {
        if (Input.IsActionPressed("up"))
        {
            direction = Vector2.Up;
            animationPlayer.Play("move_up");
            selectNextTile(Vector2I.Up);
        }
        else if (Input.IsActionPressed("down"))
        {
            direction = Vector2.Down;
            animationPlayer.Play("move_down");
            selectNextTile(Vector2I.Down);
        }
        else if (Input.IsActionPressed("left"))
        {
            direction = Vector2.Left;
            animationPlayer.Play("move_left");
            selectNextTile(Vector2I.Left);
        }
        else if (Input.IsActionPressed("right"))
        {
            direction = Vector2.Right;
            animationPlayer.Play("move_right");
            selectNextTile(Vector2I.Right);
        }

        if (direction != Vector2.Zero)
        {
            currentPosition = Position;
            isMoving = true;
        }
        else
        {
            switch (direction)
            {
                case (0, 1):
                    animationPlayer.Play("idle_down");
                    break;
                case (0, -1):
                    animationPlayer.Play("idle_up");
                    break;
                case (-1, 0):
                    animationPlayer.Play("idle_left");
                    break;
                case (1, 0):
                    animationPlayer.Play("idle_right");
                    break;
            }
        }
    }

    private void selectNextTile(Vector2I direction)
    {
        var nextPosition = tilemap.LocalToMap((Position)) + direction;
        var nextTile = tilemap.GetCellTileData(nextPosition);
        if (nextTile.GetCustomData("Walkable").AsBool())
        {
            this.nextPosition = tilemap.MapToLocal(nextPosition);
        }

        if (nextTile.GetCustomData("PokemonCanSpawn").AsBool())
        {
            var number = new Random().Next(0, 15);
            if (number < 15 && !GetTree().Root.HasNode("BattleScreen"))
            {
                PackedScene scene = ResourceLoader.Load<PackedScene>("res://BattleScreen.tscn");
                BattleScreen battleScreen = (BattleScreen)scene.Instantiate();
                GetTree().Root.AddChild(battleScreen);
                while (!battleScreen.IsNodeReady()) {}
                battleScreen.instantiate(yourPokemon);
                GetTree().Root.GetNode<Node2D>("Mondo").Hide();
                movementIsEnabled = false;
                GetTree().Root.PrintTreePretty();
            }
        }
    }
}