using Raylib_cs;
using System.Numerics;
using System.Reflection.Metadata;
Raylib.InitWindow(800, 600,"hastalavistababy");
Raylib.SetTargetFPS(60);
Texture2D Batman = Raylib.LoadTexture("BATMAN2.png");
Texture2D Batmanattack = Raylib.LoadTexture("BATMAN ATTACK.png");
Batman.width = 200;
Batman.height = 200;
Batmanattack.width = 200;
Batmanattack.height = 200;

int x = 400;
int y = 300;
while (!Raylib.WindowShouldClose())
{

 if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
 {
 x -= 10;
 }

if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
 {
 x += 10;
 }

 
if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
 {
 y -= 10;
 }


if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
 {
 y += 10;
 }

if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE))
 {

 
 }


Raylib.BeginDrawing();

Raylib.ClearBackground(Color.WHITE);
Raylib.DrawTexture(Batman,x ,y,Color.WHITE);
Raylib.DrawTexture(Batmanattack,x ,y ,Color.WHITE);
Raylib.EndDrawing();
}
