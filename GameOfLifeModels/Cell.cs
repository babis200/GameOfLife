using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLifeModels
{
    public class Cell
    {
        public bool IsAlive;
        public readonly List<Cell> neighbors = new List<Cell>();

        public bool IsAliveNext;

        public void DetermineNextLiveState()
        {
            // Live cells with fewer than two live neighbors die
            // Live cells with more than three live neighbors die
            // Dead cells with three live neighbors comes alive

            int liveNeighbors = neighbors.Where(x => x.IsAlive).Count();

            if (IsAlive)
                IsAliveNext = liveNeighbors == 2 || liveNeighbors == 3;
            else
                IsAliveNext = liveNeighbors == 3;
        }
        public void Advance()
        {
            IsAlive = IsAliveNext;
        }


    }
}
