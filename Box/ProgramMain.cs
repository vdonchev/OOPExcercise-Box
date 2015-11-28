namespace Box
{
    using System;
    using Models;

    public static class ProgramMain
    {
        public static void Main()
        {
            var box = new Box();

            var moliv = new Pencil("red");
            var himikal = new Pen("blue");
            var nojica = new Scissors("Plastic"); // Приема като аргумент само Plastic / Iron

            Console.WriteLine(nojica.Cut());

            box.AddItems(moliv, himikal, nojica);

            foreach (var item in box.Items)
            {
                Console.WriteLine(item);
            }

            himikal.ChangeState();

            Console.WriteLine(himikal);
        }
    }
}
