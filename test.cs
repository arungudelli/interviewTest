namespace CirclesAndSquares
{
    /// <summary>
    /// Program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main entry point.
        /// </summary>
        /// <remarks>DO NOT change this method.</remarks>
        private static void Main()
        {
            new Manager().Run();

            /*
            the expected console output is
           
            Circle: 1 2 3
            Circle: 2 15 1
            Square: 3 7 15
            Square: 3 10 23
            Square: 7 0 2
           
             */
        }
    }

    /// <summary>
    /// Circle and Square manager.
    /// </summary>
    public class Manager
    {
        /// <summary>
        /// Runs the program.
        /// </summary>
        public void Run()
        {
            /*
            using OOPs concepts, change the code on this method and the Circle and Square classes
            to use only one collection and one foreach loop.
            the program output must not be changed
            */

            // TODO: change this section to ONLY use ONE collection
            var circles = new List<Circle>();
            circles.Add(new Circle { X = 1, Y = 2, Radius = 3 });
            circles.Add(new Circle { X = 2, Y = 15, Radius = 1 });

            var squares = new List<Square>();
            squares.Add(new Square { X = 3, Y = 7, Length = 15 });
            squares.Add(new Square { X = 3, Y = 10, Length = 23 });
            squares.Add(new Square { X = 7, Y = 0, Length = 2 });

            // TODO: change this section to ONLY use ONE foreach
            foreach (var c in circles)
                ConsoleWriteLine(c.Draw());

            foreach (var s in squares)
                ConsoleWriteLine(s.Draw());
        }

        /// <summary>
        /// <see cref="Console"/> write line wrapper.
        /// </summary>
        /// <param name="s"></param>
        /// <remarks>DO NOT change this method.</remarks>
        public virtual void ConsoleWriteLine(string s) => Console.WriteLine(s);
    }



    /// <summary>
    /// Represents a circle.
    /// </summary>
    public class Circle 
    {
        // TODO: change this class using OOPs concepts

        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }

        public string Draw() => $"Circle: {X} {Y} {Radius}";
    }

    /// <summary>
    /// Represents a square.
    /// </summary>
    public class Square 
    {
        // TODO: change this class using OOPs concepts
        public int X { get; set; }
        public int Y { get; set; }
        public int Length { get; set; }

        public string Draw() => $"Square: {X} {Y} {Length}";
    }
}
