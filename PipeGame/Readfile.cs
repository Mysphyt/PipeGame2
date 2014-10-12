using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PipeGame
{
    class Readfile
    {

        string[] lines;
        int gameR, gameC;
        int[] start = new int[2];
        int[] finish = new int[2];
        int[] size = new int[2];
        int rows, columns;
        public int[] ReadSize()
        {
            lines = System.IO.File.ReadAllLines(@"Content\LevelSize.txt");
            size[0] = int.Parse(lines[0]);
            size[1] = int.Parse(lines[1]);
            rows = size[0];
            columns = size[1];
            return size;
        }
        public int[] FindStart()
        {
            lines = System.IO.File.ReadAllLines(@"Content\LevelStart.txt");
            start[0] = int.Parse(lines[0]);
            start[1] = int.Parse(lines[1]);
            return start;
        }
        public int[] FindFinish()
        {
            lines = System.IO.File.ReadAllLines(@"Content\LevelFinish.txt");
            finish[0] = int.Parse(lines[0]);
            finish[1] = int.Parse(lines[1]);
            return finish;
        }

        public char[,] SetPosArray()
        {
            lines = System.IO.File.ReadAllLines(@"Content\LevelText.txt");
            char[,] level = new char[rows, columns];
            for (gameR = 0; gameR < rows; gameR++)
            {
                for (gameC = 0; gameC < columns; gameC++)
                {
                    level[gameR, gameC] = lines[gameR][gameC];
                }
            }
            return level;
        }
    }
}
