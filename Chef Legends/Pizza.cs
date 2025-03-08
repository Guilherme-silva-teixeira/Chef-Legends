using Raylib_cs;
using chefLegends;
using System.Numerics;

namespace ChefLegends;

class Pizza
{
    private int dough = 0;
    private int pepperoni = 0;
    public int cheese = 0;
    private float margherita = 0.0f;

    Rectangle pizzaRec = new Rectangle(0,200,100,100);

    public Pizza (int dough, int pepperoni, int cheese, float margherita)
    {
        this.dough = dough;
        this.pepperoni = pepperoni;
        this.cheese = cheese;
        this.margherita = margherita;
    }

    public int Dough
    {
        get { return dough;}
        set { dough = value; }
    }

    public int Pepperoni
    {
        get { return pepperoni; }
        set { pepperoni = value; }
    }

    public int Cheese
    {
        get { return cheese; }
        set { cheese = value; }
    }

    public float Margherita
    {
        get { return margherita; }
        set { margherita = value; }
    }

    public void Draw()
    {
        Raylib.BeginDrawing();

        Raylib.DrawRectangleLinesEx(pizzaRec, 1, Color.Yellow);

        Raylib.EndDrawing();
    }

}
