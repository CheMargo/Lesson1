Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("X");

int xa = 50; 
int ya = 1;
int xb = 1; 
int yb = 30;
int xc = 100; 
int yc = 30;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("X");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("X");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("X");

int x = xa, y = xb;
int count = 0;

while (count < 5000)
{
    int cur = new Random().Next(0,3);
    if (cur == 0)
    {
        x=(x+xa)/2;
        y=(y+ya)/2;
    }
    
    if (cur == 1)
    {
        x=(x+xb)/2;
        y=(y+yb)/2;
    }
    
    if (cur == 2)
    {
        x=(x+xc)/2;
        y=(y+yc)/2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("X");
    count++;
}
    
