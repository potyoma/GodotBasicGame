using Godot;
using System;
using static System.Math;

public class SpriteChildRotation : Sprite
{
    bool isPlaying = true;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {

    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        // Rotate();
    }

    public void Rotate()
    {
        do
        {
            this.Position += new Vector2(10, 10);
        }
        while (isPlaying);
    }
}
