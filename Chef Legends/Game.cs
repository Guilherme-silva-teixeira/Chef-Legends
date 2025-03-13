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
        bool isStarted = init.startCollision;
        secondMenu menu = new secondMenu();

        pizza.Dough = 0;
        pizza.Cheese = 0;
        pizza.Margherita = 0;
        pizza.Pepperoni = 0;

        Rectangle pizzaCheeseRec = new Rectangle(0, 0, 23, 23);
        Rectangle pizzaDoughRec = new Rectangle(0, 0, 23, 23);
        Rectangle pizzaMargueritaRec = new Rectangle(0, 0, 23, 23);
        Rectangle pizzaPepperoniRec = new Rectangle(0, 0, 23, 23);

        Rectangle chef = new Rectangle(0, Raylib.GetScreenHeight()-23, 23, 23);

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);

            if (!init.startCollision)
            {
                init.Update();
                init.Draw();
            }else
            {
                init.Delete();
                menu.drawButtons();
                menu.drawPizza();
                menu.drawBurger();
                menu.drawPizzaContinue();
                menu.drawBurgerContinue();
                menu.Update();
            }

            //game logic
            if (menu.isPizzaChecked)
            {
                menu.Delete();

                Raylib.DrawRectangleRec(chef, Color.Black);
                if (Raylib.IsKeyDown(KeyboardKey.A))
                {
                    if(chef.X <= 0)
                    {
                        chef.X = 0;
                    }else
                    {
                        chef.X -= 10;
                    }
                }else if(Raylib.IsKeyDown(KeyboardKey.D))
                {
                    if(chef.X >= 778)
                    {
                        chef.X = 778;
                    }else
                    {
                        chef.X += 10;
                    }
                }


            }


            Raylib.EndDrawing();
        }
        Raylib.CloseWindow();
    }
}
