# Portofolio - C# Labyrinth-Game, One Day-Task
![image](https://github.com/fujiwat/Portofolio---C-Labyrinth-Game---One-Day-Task/assets/16160120/1fc2479f-2c61-4efd-aa7e-691eea542704)

## Task
There is a Labyrinth's coordinates:
{X=50,Y=50 },
{X=50, Y=500},
{X=500, Y=500},
{X=500, Y=50 },
{X=100, Y=50},
{X=100, Y=450},
{X=450, Y=450},
{X=450, Y=100},
{X=150, Y=100},
{X=150, Y=400},
{X=400, Y=400},
{X=400, Y=150},
{X=200, Y=150},
{X=200, Y=350},
{X=350, Y=350}

Place the smile on the labyrinth's entrance. There is an hour in the middle of the labyrinth that starts
after the first key is pressed.
The essence of the game is the quickest way to reach the middle of the labyrinth. The clock stops
when the smile passes through the dashed line.
If a smiling tooth touches the sideline, write that game is over. In this case, you can restart the game.
When the clock stops, an input box will appear in which you can enter your name. The name and
time results are stored in a TXT file.


## Workmanship
　　It is enough for one day task.  I could complete it with no bugs.  Half day is hard to fix the bug.
  Fixed bug is recognizing to touch the line.  Finally, it is written as following code:
```
             for (int i=0; i< labyPoint.Length-1; i++)
            {
                int x0 = Math.Min(labyPoint[i].X, labyPoint[i + 1].X);
                int x1 = Math.Max(labyPoint[i].X, labyPoint[i + 1].X);
                int y0 = Math.Min(labyPoint[i].Y, labyPoint[i + 1].Y);
                int y1 = Math.Max(labyPoint[i].Y, labyPoint[i + 1].Y);
                if ( ((x0 == x1) && (PicSmile.Left < x0) && (x1 < PicSmile.Right  && y0 < PicSmile.Top  && PicSmile.Bottom < y1)) 
                ||   ((y0 == y1) && (PicSmile.Top  < y0) && (y1 < PicSmile.Bottom && x0 < PicSmile.Left && PicSmile.Right  < x1)) )
                {   // Touched the line
                    gameOver();
                    break;
                }
            }
```
  
