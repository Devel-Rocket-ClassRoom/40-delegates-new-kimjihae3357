using System;

// 1
Action driver = GoForward;
driver += GoLeft;
driver += GoRight;
driver():

static void GoForward() => Console.WriteLine("직진");
static void GoLeft() => Console.WriteLine("좌회전");
static void GoRight() => Console.WriteLine("우회전");

// 2

Action driver = GoForward;
driver += GoLeft;

driver += delegate ()
{
    Console.WriteLine("우회전");
};

driver();

static void GoForward() => Console.WriteLine("직진");
static void GoLeft() => Console.WriteLine("좌회전");