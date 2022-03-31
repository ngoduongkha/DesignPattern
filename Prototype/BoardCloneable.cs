using System;

namespace Prototype {
    internal class BoardCloneable : ICloneable {
        public readonly int NO_OF_ROWS = 8;
        public readonly int NO_OF_COLUMNS = 8;

        private readonly Cell[,] board;

        public BoardCloneable() {
            board = new Cell[NO_OF_ROWS, NO_OF_COLUMNS];

            for (int row = NO_OF_ROWS - 1; row >= 0; row--) {
                for (int col = NO_OF_COLUMNS - 1; col >= 0; col--) {
                    if ((row + col) % 2 == 0) {
                        board[row, col] = new Cell("WHITE");
                    }
                    else {
                        board[row, col] = new Cell("BLACK");
                    }
                }
            }
        }

        public void Print() {
            for (int row = 0; row < NO_OF_ROWS; row++) {
                for (int col = 0; col < NO_OF_COLUMNS; col++) {
                    Console.WriteLine(board[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        public object Clone() {
            object obj = null;
            try {
                obj = MemberwiseClone();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            return obj;
        }
    }
}
