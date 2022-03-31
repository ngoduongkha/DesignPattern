using System;

namespace Prototype {
    public class TimeUtils {
        private static readonly DateTime Jan1st1970 = new DateTime
        (1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static long CurrentTimeMillis() {
            return (long)(DateTime.UtcNow - Jan1st1970).TotalMilliseconds;
        }
    }

    internal class Program {
        static void Main(string[] args) {
            long startTime = TimeUtils.CurrentTimeMillis();
            Board chessBoard = new Board();
            long endTime = TimeUtils.CurrentTimeMillis();
            Console.WriteLine("Time taken to create a board: " + (endTime - startTime) + " millis");

            startTime = TimeUtils.CurrentTimeMillis();
            BoardCloneable boardClonable = new BoardCloneable();
            endTime = TimeUtils.CurrentTimeMillis();
            Console.WriteLine("Time taken to create a board: " + (endTime - startTime) + " millis");

            startTime = TimeUtils.CurrentTimeMillis();
            BoardCloneable checkersBoard = (BoardCloneable)boardClonable.Clone();
            endTime = TimeUtils.CurrentTimeMillis();
            Console.WriteLine("Time taken to clone a board: " + (endTime - startTime) + " millis");
        }
    }
}
