/* https://leetcode.com/problems/walls-and-gates/
 * 
 * Runtime: 284 ms, faster than 87.80% of C# online submissions for Walls and Gates.
 * Memory Usage: 34.9 MB, less than 100.00% of C# online submissions for Walls and Gates.
 * 
 * use BFS to find path and calculate distance
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace algorithm_csharp
{
    public class WallsGates
    {
        const int empty = Int32.MaxValue - 1;
        const int gate = 0;
        const int wall = -1;
        public void WallsAndGates(int[][] rooms)
        {
            if (rooms == null || rooms.Length == 0 || rooms[0].Length == 0) return;

            for (int i = 0; i < rooms.Length; i++)
            {
                for (int j = 0; j < rooms[i].Length; j++)
                {
                    if (rooms[i][j] == gate)
                    {
                        fillDistance(rooms, i, j);
                    }
                }
            }
        }

        private void fillDistance(int[][] rooms, int x, int y)
        {
            Queue<Position> _queue = new Queue<Position>();
            _queue.Enqueue(new Position(x, y));
            int _distance = 1;
            while (_queue.Any())
            {
                int _curLevelLength = _queue.Count();
                for (int i = 0; i < _curLevelLength; i++) 
                {
                    Position _curPosition = _queue.Dequeue();
                    // processing four directions
                    if ( _curPosition.Down  < rooms.Length
                        && rooms[_curPosition.Down][_curPosition.Y] > _distance)
                    {
                        rooms[_curPosition.Down][_curPosition.Y] = _distance;
                        _queue.Enqueue(new Position(_curPosition.Down, _curPosition.Y));
                    }
                    if ( _curPosition.Right < rooms[0].Length
                        && rooms[_curPosition.X][_curPosition.Right] > _distance)
                    {
                        rooms[_curPosition.X][_curPosition.Right] = _distance;
                        _queue.Enqueue(new Position(_curPosition.X, _curPosition.Right));
                    }
                    if ( 0 <= _curPosition.Left
                        && rooms[_curPosition.X][_curPosition.Left] > _distance)
                    {
                        rooms[_curPosition.X][_curPosition.Left] = _distance;
                        _queue.Enqueue(new Position(_curPosition.X, _curPosition.Left));
                    }
                    if ( 0 <= _curPosition.Up
                        && rooms[_curPosition.Up][_curPosition.Y] > _distance)
                    {
                        rooms[_curPosition.Up][_curPosition.Y] = _distance;
                        _queue.Enqueue(new Position(_curPosition.Up, _curPosition.Y));
                    }
                }
                _distance++;
            }
        }

        public class Position
        {
            public int X { get; set; }
            public int Y { get; set; }

            public int Right
            {
                get { return Y + 1; }
            }
            public int Left
            {
                get { return Y - 1; }
            }
            public int Up
            {
                get { return X - 1; }
            }
            public int Down
            {
                get { return X + 1; }
            }
            public Position(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
        }
    }
}
