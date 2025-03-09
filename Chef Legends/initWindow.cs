using Raylib_cs;
using System.Numerics;

namespace chefLegends;

class initWindow
{
    public bool startCollision = false;
    public bool optionCollsion = false;

    static float animationTime = 0;
    static float animationDuration = 0.3f;

    static Rectangle startGame = new Rectangle(240, 180, 300, 50);
    static Rectangle options = new Rectangle(240, 250, 300, 50);

    public static bool leftClickRect(Rectangle rect)
    {
        Vector2 mousePos = Raylib.GetMousePosition();
        return Raylib.IsMouseButtonPressed(MouseButton.Left) &&
            Raylib.CheckCollisionPointRec(mousePos, rect);
    }

    public void Update()
    {
        float deltaTime = Raylib.GetFrameTime();

        if (animationTime <= 0)
        {
            if(leftClickRect(startGame))
            {
                startCollision = true;
                startGame.Y += 7;
                animationTime = animationDuration;
            }
            else if(leftClickRect(options))
            {
                optionCollsion = true;
                options.Y += 7;
                animationTime = animationDuration;
            }
        }

        if(animationTime>0)
        {
            animationTime -= deltaTime;
            if (animationTime <= 0)
            {
                startGame.Y = 180;
                options.Y = 250;
            }
        }
    }

    public void Draw()
    {

        Raylib.DrawRectangleLinesEx(startGame, 3, Color.Black);

        Raylib.DrawRectangleLinesEx(options, 3, Color.Black);

    }

    public bool StartCollision
    {
        get { return startCollision; }
        set { startCollision = value; }
    }

    public bool OptionCollision
    {
        get { return optionCollsion; }
        set { optionCollsion = value; }
    }

    public void Delete()
    {
        startGame = new Rectangle(0, 0, 0, 0);
        options = new Rectangle(0, 0, 0, 0);
    }
}
