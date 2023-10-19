using Raylib_cs;
using System.Numerics;
using System.Reflection.Metadata;
Raylib.InitWindow(800, 600,"hastalavistababy");
Raylib.SetTargetFPS(60);
Texture2D Batman = Raylib.LoadTexture("BATMAN2.png");
Batman.width = 200;
Batman.height = 200;
int x = 400;
int y = 300;
while (!Raylib.WindowShouldClose())
{

// if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
// {

// }



 
Raylib.BeginDrawing();

Raylib.ClearBackground(Color.WHITE);
Raylib.DrawTexture(Batman,x ,y,Color.WHITE);

Raylib.EndDrawing();
}
