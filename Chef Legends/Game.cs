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
        Pizza pizza = new Pizza(0,0,0,0.0f);
        int starts = 0;

        if ((init.StartCollision == false || init.optionCollsion == false) || starts < 1)
        {
            init.Draw();
        }

        while (!Raylib.WindowShouldClose())
        {
            init.Update();
            if (init.StartCollision == true)
            {
                starts += 1;
                init.Delete();
                pizza.Draw();
            }

        }

        Raylib.CloseWindow();
    }
}
