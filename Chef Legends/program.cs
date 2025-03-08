using Raylib_cs;
using System.Numerics;

namespace chefLegends;

class Program
{

    public static void Main()
    {
        Raylib.InitWindow(800, 480, "Game");
        Raylib.SetTargetFPS(60);

        bool startCollision = false;
        bool optionCollision = false;

        Rectangle pizzaRect = new Rectangle();
        Rectangle burguerRect = new Rectangle();
        Rectangle friesRect = new Rectangle();
        Rectangle pastaRect = new Rectangle();

        int money = 100;
        int coins = 50;
        float exp = 0;
        int level = 0;

        while (!Raylib.WindowShouldClose())
        {
            init();

            if(startCollision)
            {
            }

            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);
            Raylib.EndDrawing();
        }

        bool leftClickRect(Rectangle rect)
        {
            Vector2 mousepos = Raylib.GetMousePosition();
            return Raylib.IsMouseButtonPressed(MouseButton.Left) &&
                Raylib.CheckCollisionPointRec(mousepos, rect);
        }

        void init()
        {
            float deltaTime = Raylib.GetFrameTime();

            float animationTime = 0;
            float animationDuration = 0.3f;

            Rectangle startGame = new Rectangle(240, 180, 300, 50);
            Rectangle options = new Rectangle(240, 240, 300, 50);
            
            Vector2 mousePos = Raylib.GetMousePosition();

            if(animationTime>0)
            {
                if (leftClickRect(startGame))
                {
                    startCollision = true;
                    startGame.Y = (startGame.Y + 7);
                    animationTime = animationDuration;
                }
                else if (leftClickRect(options))
                {
                    optionCollision = true;
                    options.Y = (options.Y + 7);
                }
            }

            if (animationTime > 0)
            {
                animationTime -= deltaTime;
            }


                Raylib.DrawRectangleLinesEx(startGame, 3, Color.Black);
            Raylib.DrawRectangleLinesEx(options, 3, Color.Black);

        }

        Raylib.CloseWindow();
    }
}
