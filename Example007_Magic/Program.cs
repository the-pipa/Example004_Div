Console.Clear();
Console.SetCursorPosition(10, 4);
Console.WriteLine("+");

int xa = 40, yf = 1,
    db = 1, yb = 30,
    xd = 90, yg = 30;

Console.SetCursorPosition(xa, yf);
Console.WriteLine("+");

Console.SetCursorPosition(db, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xd, yg);
Console.WriteLine("+");

int x = xa, y = yf;

int count = 0;

while(count < 10000)
{
    int what = new Random().Next(0, 3); // [0;3) 0 1 2
    if(what ==0)
    {
    x = (x + xa) / 2;
    y = (y + yf) / 2;
    } 


if (what == 1)
{
    x = (x + db) / 2;
    y = (y + yb) / 2;
}

if (what == 2)
{
    x = (x + xd) / 2;
    y = (y + yg) / 2;
}

Console.SetCursorPosition(x, y );
Console.WriteLine("+");
count++;
}
