using Raylib_cs;
using ChefLegends;
using System.Numerics;

namespace ChefLegends;

class Burger
{
    private int topBun;
    private int lettuce;
    private int tomato;
    private float cheese;
    private float beef;
    private int egg;
    private float chicken;
    private int bottomBun;

    public Burger(int topBun, int lettuce, int tomato, int cheese, int beef, int egg, int chicken, int bottomBun)
    {
        this.topBun = topBun;
        this.lettuce = lettuce;
        this.tomato = tomato;
        this.cheese = cheese;
        this.beef = beef;
        this.egg = egg;
        this.chicken = chicken;
        this.bottomBun = bottomBun;
    }

    public int TopBun
    {
        get { return topBun; }
        set { topBun = value; }
    }

    public int Lettuce
    {
        get { return lettuce; }
        set { lettuce = value; }
    }

    public int Tomato
    {
        get { return tomato; }
        set { tomato = value; }
    }

    public float Cheese
    {
        get { return cheese; }
        set { cheese = value; }
    }

    public float Beef
    {
        get { return beef; }
        set { beef = value; }
    }

    public int Egg
    {
        get { return egg; }
        set { egg = value; }
    }

    public float Chicken
    {
        get { return chicken; }
        set { chicken = value; }
    }

    public int BottomBun
    {
        get { return bottomBun; }
        set { bottomBun = value; }
    }
}
