using Raylib_cs;
using System.Numerics;

namespace ChefLegends;

class testes
{
    /*public static void Main(string[] args)
    {
        Raylib.InitWindow(800, 480, "Teste");

        Rectangle botao = new Rectangle(300, 200, 200, 100);
        
        float tempoAnimacao = 0;
        float duracaoAnimacao = 0.3f; // Tempo em segundos

        while (!Raylib.WindowShouldClose())
        {
            float deltaTime = Raylib.GetFrameTime(); // Obtém o tempo do frame atual

            // Verifica se o botão foi clicado e inicia o temporizador
            if (Raylib.IsMouseButtonPressed(MouseButton.Left) &&
                Raylib.CheckCollisionPointRec(Raylib.GetMousePosition(), botao))
            {
                tempoAnimacao = duracaoAnimacao; // Ativa o efeito do clique
            }

            // Atualiza o tempo da animação
            if (tempoAnimacao > 0)
            {
                tempoAnimacao -= deltaTime; // Reduz o tempo da animação
            }

            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.Black);

            // Se o tempo da animação estiver ativo, mostrar outra cor
            if (tempoAnimacao > 0)
            {
                Raylib.DrawRectangleRec(botao, Color.Green);
            }
            else
            {
                Raylib.DrawRectangleRec(botao, Color.Blue);
            }

            Raylib.EndDrawing();
        }
        Raylib.CloseWindow();
    }*/
}
