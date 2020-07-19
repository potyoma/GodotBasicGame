using Godot;
using System;

public class Sprite : Godot.Sprite
{
    public float speed = 5;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {

    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        Godot.Sprite child = this.GetNode<Godot.Sprite>("Sprite2");
        Move(child);
    }

    public void Move(Godot.Sprite someChild)
    {
        if (Input.IsKeyPressed((int)KeyList.W))
        {
            this.Position += new Vector2(0, -speed);
            someChild.GlobalPosition = new Vector2(0,0);
        }
        if (Input.IsKeyPressed((int)KeyList.S))
        {
            this.Position += new Vector2(0, speed);
        }
        if (Input.IsKeyPressed((int)KeyList.A))
        {
            this.Position += new Vector2(-speed, 0);
        }
        if (Input.IsKeyPressed((int)KeyList.D))
        {
            this.Position += new Vector2(speed, 0);
        }
    }
}
