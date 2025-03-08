using Raylib_cs;
using chefLegends;

namespace ChefLegends;

class Game
{
    public static void Main()
    {
        initWindow init = new initWindow();
        Raylib.InitWindow(800, 600, "Game");
        Raylib.SetTargetFPS(60);

        while(!Raylib.WindowShouldClose())
        {
            init.Update();
            init.Draw();
        }


        Raylib.CloseWindow();
    }
}
