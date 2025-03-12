using Raylib_cs;
using System.Numerics;
using ChefLegends;

namespace ChefLegends;

class secondMenu()
{
    public static Rectangle pizzaRec = new Rectangle(30, 130, 250, 300);
    public static Rectangle burgerRec = new Rectangle(280+30,130,250,300);

    public static Rectangle pizzaContinue = new Rectangle(56, 390, 200, 30);
    public static Rectangle burgerContinue = new Rectangle(336, 390, 200, 30);

    static Rectangle leftButton = new Rectangle(0, 210, 33, 100);
    Color buttonColor = new Color(0, 0, 0, 77);
    static Rectangle rightButton = new Rectangle(Raylib.GetScreenWidth() - 33, 210, 33, 100);

    Color burgerColor = new Color(210, 170, 55, 255);

    public bool isPizzaChecked = false;

    public void Delete()
    {
        pizzaRec = new Rectangle(0,0,0,0);
        burgerRec = new Rectangle(0, 0, 0, 0);
        pizzaContinue = new Rectangle(0, 0, 0, 0);
        burgerContinue = new Rectangle(0, 0, 0, 0);
        leftButton = new Rectangle(0, 0, 0, 0);
        rightButton = new Rectangle(0, 0, 0, 0);
    }

    public void Update()
    {
        if(leftMouseClickCheck(pizzaContinue))
        {
            isPizzaChecked = true;
        }
    }

    public bool leftMouseClickCheck(Rectangle rect)
    {
        Vector2 mousepos = Raylib.GetMousePosition();
        return Raylib.IsMouseButtonPressed(MouseButton.Left) &&
            Raylib.CheckCollisionPointRec(mousepos, rect);
    }

    public void drawButtons()
    {
        Raylib.DrawRectangleRec(leftButton, buttonColor);
        Raylib.DrawRectangleRec(rightButton, buttonColor);
    }

    public void drawPizza()
    {
        Raylib.DrawRectangleLinesEx(pizzaRec, 3, Color.Yellow);
    }

    public void deletePizza()
    {
        pizzaRec = new Rectangle(0, 0, 0, 0);
    }

    public void drawBurger()
    {
        Raylib.DrawRectangleLinesEx(burgerRec, 3, burgerColor);
    }

    public void drawPizzaContinue()
    {
        Raylib.DrawRectangleLinesEx(pizzaContinue,3,Color.Black);
    }

    public void drawBurgerContinue()
    {
        Raylib.DrawRectangleLinesEx(burgerContinue, 3, Color.Black);
    }
}
