using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PipeGame
{
    class Readfile
    {

        string[] lines;
        char[,] level = new char[10, 10];
        int gameR, gameC, rows, columns;
        int[] start = new int[2];
        int[] finish = new int[2];
        int[] size = new int[2];
        public int[] ReadSize()
        {
            lines = System.IO.File.ReadAllLines(@"Content\LevelText.txt");
            size[0] = lines[0][0];
            size[1] = lines[0][1];
            rows = size[0];
            columns = size[1];
            return size;
        }
        public int[] FindStart()
        {
            start[0] = lines[1][0];
            start[1] = lines[1][1];
            return start;
        }
        public int[] FindFinish()
        {
            finish[0] = lines[2][0];
            finish[1] = lines[2][1];
            return finish;
        }
        public char[,] SetPosArray()
        {
            for (gameR = 0; gameR < rows; gameR++)
            {
                for (gameC = 0; gameC < columns; gameC++)
                {
                    level[gameR, gameC] = lines[gameR + 3][gameC];
                }
            }

            return level;
        }
    }
}
