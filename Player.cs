using Godot;

public partial class Player : Node2D
{
    [Export]
    private float speed = 4.0f;
    
    private Vector2 direction = Vector2.Zero;
    private Vector2 currentPosition;
    private Vector2 nextPosition;

    private bool isMoving;
    
    private AnimationPlayer animationPlayer;
    private TileMap tilemap;
    private Timer timer;

    private float percentMoved = 0;

    public override void _Ready()
    {
        animationPlayer = GetNode<AnimationPlayer>("AnimationPlayer");
        animationPlayer.Play("move_down");
        tilemap = GetNode<TileMap>("../TileMap");
        timer = GetNode<Timer>("../Timer");
        timer.Start();
        currentPosition = Position;
    }

    public override void _Process(double delta)
    {
        /*GD.Print("currentPosition                " + currentPosition);
        GD.Print("position                       " + Position);
        GD.Print("nextPosition                   " + nextPosition);
        GD.Print("nextPosition - currentPosition " + (nextPosition - currentPosition));
        GD.Print("currentPosition - nextPosition " + (currentPosition - nextPosition));
        GD.Print("direction                      " + direction);
        GD.Print("isMoving                       " + isMoving);
        GD.Print("percentagePerFrame             " + (float)delta * speed);
        GD.Print("percentage                     " + percentMoved);
        GD.Print("");*/
        
        if (!isMoving)
        {
            HandleInput();    
        }
        else
        {
            HandleMovement(delta);
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
                case (0,1):
                    animationPlayer.Play("idle_down");
                    break;
                case (0,-1):
                    animationPlayer.Play("idle_up"); 
                    break;
                case (-1,0):
                    animationPlayer.Play("idle_left");
                    break;
                case (1,0):
                    animationPlayer.Play("idle_right");
                    break;
            }
        }
    }

    private void selectNextTile(Vector2I direction)
    {
        var nextPosition = tilemap.LocalToMap((Position)) + direction;
        var nextTile = tilemap.GetCellTileData(0, nextPosition);
        if (nextTile.GetCustomData("Walkable").AsBool())
        {
                this.nextPosition = tilemap.MapToLocal(nextPosition);
        }
    }
}