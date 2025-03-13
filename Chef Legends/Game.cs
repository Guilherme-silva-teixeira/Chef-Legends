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

        
        Random rdn = new Random();
        
        pizza.Dough = 0;
        pizza.Cheese = 0;
        pizza.Margherita = 0;
        pizza.Pepperoni = 0;

        Rectangle pizzaCheeseRec = new Rectangle(rdn.Next(Raylib.GetScreenWidth()-23), 0, 23, 23);
        Rectangle pizzaDoughRec = new Rectangle(rdn.Next(Raylib.GetScreenWidth()-23), 0, 23, 23);
        Rectangle pizzaMargueritaRec = new Rectangle(rdn.Next(Raylib.GetScreenWidth()-23), 0, 23, 23);
        Rectangle pizzaPepperoniRec = new Rectangle(rdn.Next(Raylib.GetScreenWidth()-23), 0, 23, 23);

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

                //floating itens
                Raylib.DrawRectangleRec(pizzaDoughRec, Color.Beige);
                Raylib.DrawRectangleRec(pizzaPepperoniRec, Color.Brown);
                Raylib.DrawRectangleRec(pizzaCheeseRec, Color.Yellow);
                Raylib.DrawRectangleRec(pizzaMargueritaRec, Color.Red);

                pizzaDoughRec.Y += 1;
                pizzaCheeseRec.Y += 1;
                pizzaMargueritaRec.Y += 1;
                pizzaPepperoniRec.Y += 1;

                if(Raylib.CheckCollisionRecs(chef,pizzaDoughRec))
                {
                    pizza.Dough += 1;
                }else if(Raylib.CheckCollisionRecs(chef,pizzaCheeseRec))
                {
                    pizza.Cheese += 1;
                }else if(Raylib.CheckCollisionRecs(chef,pizzaMargueritaRec))
                {
                    pizza.Margherita += 1;
                }else if(Raylib.CheckCollisionRecs(chef,pizzaPepperoniRec))
                {
                    pizza.Pepperoni += 1;
                }

            }

            Raylib.EndDrawing();
        }
        Raylib.CloseWindow();
    }
}
