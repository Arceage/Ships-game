using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Task_02112021
    {
        const int mapsize = 10;
        public static bool[,] shipCreator()
        {
            Random RandShip = new Random();
            int[,] map = new int[mapsize, mapsize];

            for (int i = 4; i > 0; i--)
            {
                for (int k = 0; k < 6-i; k++)
                {
                    bool free = true;
                    bool direction = RandShip.Next(1,3) == 1;
                    int y = RandShip.Next(mapsize);
                    int x = RandShip.Next(mapsize);
                
                    if (direction)
                    {
                        if (y + i > mapsize)
                        {
                            y -= i;
                        }
                    }
                    else if (x + i > mapsize)
                    {
                        x -= i;
                    }

                    if (direction)
                    {
                        for (int m = y; m < y + i; m++)
                        {
                            if (map[m, x] != 0)
                            {
                                free = false;
                                break;
                            }
                        }
                    }
                    else
                    {

                        for (int n = x; n < x + i; n++)
                        {
                            if (map[y, n] != 0)
                            {
                                free = false;
                                break;
                            }
                        }
                    }

                    if (!free)
                    {
                        k--;
                        
                        continue;
                    }

                    if (direction)
                    {
                        for (int m = Math.Max(0, x - 1); m < Math.Min(mapsize, x + 2); m++)
                        {
                            for (int n = Math.Max(0, y - 1); n < Math.Min(mapsize, y + i + 1); n++)
                            {
                                map[n, m] = 7;
                            }
                        }
                    }
                    else
                    {
                        for (int m = Math.Max(0, y - 1); m < Math.Min(mapsize, y + 2); m++)
                        {
                            for (int n = Math.Max(0, x - 1); n < Math.Min(mapsize, x + i + 1); n++)
                            {
                                map[m, n] = 7;
                            }
                        }
                    }

                    for (int j = 0; j < i; j++)
                    {
                        map[y, x] = k;
                        if (direction)
                        {
                            y++;
                        }
                        else
                        {
                            x++;
                        }
                    }
                }                                  
            }

            bool[,] Boolmap = new bool[mapsize, mapsize];
            for (int f = 0; f < mapsize; f++)
            {
                for (int j = 0; j < mapsize; j++)
                {
                    Boolmap[f, j] = map[f, j] == 0 || map[f, j] == 7 ? false : true;
                }
            }


            return Boolmap;

        }

        
    }
}
