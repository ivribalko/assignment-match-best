using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    Public class Board
    {
    enum JewelKind
    {
           Empty,
           Red,
           Orange,
           Yellow
           Green,
           Blue,
           Indigo,
           Violet
    };

    enum MoveDirection
    {
           Up,
           Down,
           Left,
           Right
    };

    struct Move
    {
    int x;
    int y;
    MoveDirection direction;
    };

           int GetWidth();
           int GetHeight();

           JewelKind GetJewel(int x, int y);
           void SetJewel(int x, int y, JewelKind kind);

    //Implement this function
    Public Move CalculateBestMoveForBoard();
    };
}