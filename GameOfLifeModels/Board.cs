using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLifeModels
{
    public class Board
    {
        public readonly Cell[,] Cells;
        public readonly int CellSize;

        public int Columns { get { return Cells.GetLength(0); } }
        public int Rows { get { return Cells.GetLength(1); } }
        public int Height { get { return Rows * CellSize; } }
        public int Width { get { return Columns * CellSize; } }

        public Board(int width, int height, int cellSize, double liveDensity = .1)
        {
            CellSize = cellSize;

            Cells = new Cell[width / cellSize, height / cellSize];
            for (int x = 0; x < Columns; x++)
                for (int y = 0; y < Rows; y++)
                    Cells[x, y] = new Cell();

            ConnectNeighbors();
            Randomize(liveDensity);
        }


        readonly Random rand = new Random();

        public void Randomize(double liveDensity)
        {
            foreach (var cell in Cells)
                cell.IsAlive = rand.NextDouble() < liveDensity;
        }

        public void Advance()
        {
            foreach (var cell in Cells)
                cell.DetermineNextLiveState();
            foreach (var cell in Cells)
                cell.Advance();
        }

        private void ConnectNeighbors()
        {
            for (int x = 0; x < Columns; x++)
            {
                for (int y = 0; y < Rows; y++)
                {
                    // determine X of left and right cells
                    int xL = (x > 0) ? x - 1 : Columns - 1;
                    int xR = (x < Columns - 1) ? x + 1 : 0;

                    // determine Y of top and bottom cells
                    int yT = (y > 0) ? y - 1 : Rows - 1;
                    int yB = (y < Rows - 1) ? y + 1 : 0;

                    // add the 8 neighbors surrounding this cell
                    Cells[x, y].neighbors.Add(Cells[xL, yT]);       //Top-Left Cell
                    Cells[x, y].neighbors.Add(Cells[x, yT]);        //Top Cell
                    Cells[x, y].neighbors.Add(Cells[xR, yT]);       //Top-Right Cell
                    Cells[x, y].neighbors.Add(Cells[xL, y]);        //Left Cell
                    Cells[x, y].neighbors.Add(Cells[xR, y]);        //Right Cell
                    Cells[x, y].neighbors.Add(Cells[xL, yB]);       //Bottom-Left Cell
                    Cells[x, y].neighbors.Add(Cells[x, yB]);        //Bottom Cell
                    Cells[x, y].neighbors.Add(Cells[xR, yB]);       //Bottom-Right Cell
                }
            }
        }
    }
}
