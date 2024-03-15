namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            Animal animalDog = new Dog();
            Animal animalParrot = new Parrot();

            Console.WriteLine(animalDog.Speak());
            animalDog.Move();
            animalDog.Sit();
            if (animalDog is ISwimmer swimmer) 
            {
                swimmer.Swim(); 
            }
            if (animalDog is IRun run)
            {
                run.Run();
            }

            Console.WriteLine(animalParrot.Speak()); 
            animalParrot.Move();
            animalParrot.Sit();
            if (animalParrot is IFlyer flyer) 
            {
                flyer.Fly(); 
            }
        }
    }
}
