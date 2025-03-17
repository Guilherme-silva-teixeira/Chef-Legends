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
        Pizza pizza = new Pizza(0, 0, 0, 0.0f);
        Burger burger = new Burger(0, 0, 0, 0, 0, 0, 0, 0);
        bool isStarted = init.startCollision;
        secondMenu menu = new secondMenu();

        Random rdn = new Random();
        float menuXPosition = Raylib.GetScreenWidth() - 39;
        Rectangle chef = new Rectangle(0, Raylib.GetScreenHeight() - 23, 23, 23);

        burger.TopBun = 0;
        burger.Chicken = 0;
        burger.Cheese = 0;
        burger.Egg = 0;
        burger.Beef = 0;
        burger.Lettuce = 0;
        burger.Tomato = 0;
        burger.BottomBun = 0;

        Rectangle burgerTopBunRec = new Rectangle(rdn.Next(Raylib.GetScreenWidth() - 23), 0, 27, 27);
        Rectangle burgerLettuceRec = new Rectangle(rdn.Next(Raylib.GetScreenWidth() - 23), 0, 27, 27);
        Rectangle burgerCheeseRec = new Rectangle(rdn.Next(Raylib.GetScreenWidth() - 23), 0, 27, 27);
        Rectangle burgerBeefRec = new Rectangle(rdn.Next(Raylib.GetScreenWidth() - 23), 0, 27, 27);
        Rectangle burgerEggRec = new Rectangle(rdn.Next(Raylib.GetScreenWidth() - 23), 0, 27, 27);
        Rectangle burgerBottomBunRec = new Rectangle(rdn.Next(Raylib.GetScreenWidth() - 23), 0, 27, 27);
        Rectangle burgerTomatoRec = new Rectangle(rdn.Next(Raylib.GetScreenWidth() - 23), 0, 27, 27);
        Rectangle burgerChickenRec = new Rectangle(rdn.Next(Raylib.GetScreenWidth() - 23), 0, 27, 27);

        Rectangle burgerTopBunSlot = new Rectangle(menuXPosition, 490, 37, 37);
        Rectangle burgerLettuceSlot = new Rectangle(menuXPosition, burgerTopBunSlot.Y - 39, 37, 37);
        Rectangle burgerCheeseSlot = new Rectangle(menuXPosition, burgerLettuceSlot.Y - 39, 37, 37);
        Rectangle burgerBeefSlot = new Rectangle(menuXPosition, burgerCheeseSlot.Y - 39, 37, 37);
        Rectangle burgerEggSlot = new Rectangle(menuXPosition, burgerBeefSlot.Y - 39, 37, 37);
        Rectangle burgerBottomBunSlot = new Rectangle(menuXPosition, burgerEggSlot.Y - 39, 37, 37);
        Rectangle burgerTomatoSlot = new Rectangle(menuXPosition, burgerBottomBunSlot.Y - 39, 37, 37);
        Rectangle burgerChickenSlot = new Rectangle(menuXPosition, burgerTomatoSlot.Y - 39, 37, 37);

        pizza.Dough = 0;
        pizza.Cheese = 0;
        pizza.Margherita = 0;
        pizza.Pepperoni = 0;

        Rectangle pizzaCheeseSlot = new Rectangle(menuXPosition,490,37,37);
        Rectangle pizzaDoughSlot = new Rectangle(menuXPosition, pizzaCheeseSlot.Y - 39, 37, 37);
        Rectangle pizzaMargueritaSlot = new Rectangle(menuXPosition, pizzaDoughSlot.Y - 39, 37, 37);
        Rectangle pizzaPepperoniSlot = new Rectangle(menuXPosition, pizzaMargueritaSlot.Y - 39, 37, 37);

        Rectangle pizzaCheeseRec = new Rectangle(rdn.Next(Raylib.GetScreenWidth()-23), 0, 27, 27);
        Rectangle pizzaDoughRec = new Rectangle(rdn.Next(Raylib.GetScreenWidth()-23), 0, 27, 27);
        Rectangle pizzaMargueritaRec = new Rectangle(rdn.Next(Raylib.GetScreenWidth()-23), 0, 27, 27);
        Rectangle pizzaPepperoniRec = new Rectangle(rdn.Next(Raylib.GetScreenWidth()-23), 0, 27, 27);

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

                Raylib.DrawRectangleLinesEx(pizzaCheeseSlot, 1, Color.Yellow);
                Raylib.DrawRectangleLinesEx(pizzaDoughSlot, 1, Color.Beige);
                Raylib.DrawRectangleLinesEx(pizzaMargueritaSlot, 1, Color.Red);
                Raylib.DrawRectangleLinesEx(pizzaPepperoniSlot, 1, Color.Brown);

                pizzaDoughRec.Y += 1;
                pizzaCheeseRec.Y += 1;
                pizzaMargueritaRec.Y += 1;
                pizzaPepperoniRec.Y += 1;

                if (pizzaDoughRec.Y > Raylib.GetScreenHeight())
                {
                    pizzaDoughRec.Y = 0;
                    pizzaCheeseRec.X = rdn.Next(Raylib.GetScreenWidth());
                } else if (pizzaCheeseRec.Y > Raylib.GetScreenHeight())
                {
                    pizzaCheeseRec.Y = 0;
                    pizzaDoughRec.X = rdn.Next(Raylib.GetScreenWidth());
                } else if (pizzaMargueritaRec.Y > Raylib.GetScreenHeight())
                {
                    pizzaMargueritaRec.Y = 0;
                    pizzaMargueritaRec.X = rdn.Next(Raylib.GetScreenWidth());
                } else if (pizzaPepperoniRec.Y > Raylib.GetScreenHeight())
                {
                    pizzaPepperoniRec.Y = 0;
                    pizzaPepperoniRec.X = rdn.Next(Raylib.GetScreenWidth());
                }

                if (Raylib.CheckCollisionRecs(chef, pizzaDoughRec))
                {
                    pizza.Dough += 1;
                    pizzaDoughRec.X = rdn.Next(Raylib.GetScreenWidth());
                    pizzaDoughRec.Y = 0;
                }
                else if (Raylib.CheckCollisionRecs(chef, pizzaCheeseRec))
                {
                    pizza.Cheese += 1;
                    pizzaCheeseRec.X = rdn.Next(Raylib.GetScreenWidth());
                    pizzaCheeseRec.Y = 0;
                }
                else if (Raylib.CheckCollisionRecs(chef, pizzaMargueritaRec))
                {
                    pizzaMargueritaRec.Y = 0;
                    pizzaMargueritaRec.X = rdn.Next(Raylib.GetScreenWidth());
                    pizza.Margherita += 1;
                }
                else if (Raylib.CheckCollisionRecs(chef, pizzaPepperoniRec))
                {
                    pizzaPepperoniRec.Y = 0;
                    pizzaPepperoniRec.X = rdn.Next(Raylib.GetScreenWidth());
                    pizza.Pepperoni += 1;
                }

                Raylib.DrawText("" + pizza.Cheese, 0, 0, 23, Color.Black);
                Raylib.DrawText("" + pizza.Dough, 0, 30, 23, Color.Black);
                Raylib.DrawText("" + pizza.Margherita, 0, 60, 23, Color.Black);
                Raylib.DrawText("" + pizza.Pepperoni, 0, 90, 23, Color.Black);
            }

            Raylib.EndDrawing();
        }
        Raylib.CloseWindow();
    }
} 
