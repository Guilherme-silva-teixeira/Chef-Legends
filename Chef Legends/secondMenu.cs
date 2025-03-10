using Raylib_cs;
using System.Numerics;
using ChefLegends;

namespace ChefLegends;

class secondMenu()
{
    public Rectangle pizzaRec = new Rectangle(30, 130, 250, 300);
    public Rectangle burgerRec = new Rectangle(280+30,130,250,300);

    Rectangle leftButton = new Rectangle(0, 210, 33, 100);
    Color buttonColor = new Color(0, 0, 0, 77);
    Rectangle rightButton = new Rectangle(Raylib.GetScreenWidth() - 33, 210, 33, 100);

    Color burgerColor = new Color(210, 170, 55, 255);

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
}
