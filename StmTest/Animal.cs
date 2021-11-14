namespace StmTest
{
    public abstract class Animal
    {
        public virtual string Sing()
        {
            return $"Unable to sing poem without an actual animal";
        }
    }

    public class Cow : Animal
    {
        public override string Sing()
        {
            return $"Old MacDonald had a farm, E I E I O. \n" +
                $"And on his farm he had a Cow, E I E I O.\n" +
                $"With a moo moo here and a moo moo there,\n" +
                $"Here a moo, there a moo, ev'rywhere a moo moo.\n" +
                $"Old MacDonald had a farm, E I E I O.";
        }
    }

    public class Cat : Animal
    {
        public override string Sing()
        {
            return $"Old MacDonald had a farm, E I E I O. \n" +
                $"And on his farm he had a Cat, E I E I O.\n" +
                $"With a meow meow here and a meow meow there,\n" +
                $"Here a meow, there a meow, ev'rywhere a meow meow.\n" +
                $"Old MacDonald had a farm, E I E I O.";
        }
    }

    public class Dog : Animal
    {
        public override string Sing()
        {
            return $"Old MacDonald had a farm, E I E I O. \n" +
                $"And on his farm he had a Dog, E I E I O.\n" +
                $"With a bark bark here and a bark bark there,\n" +
                $"Here a bark, there a bark, ev'rywhere a bark bark.\n" +
                $"Old MacDonald had a farm, E I E I O.";
        }
    }
    public class Duck : Animal
    {
        public override string Sing()
        {
            return $"Old MacDonald had a farm, E I E I O. \n" +
                $"And on his farm he had a Duck, E I E I O.\n" +
                $"With a quack quack here and a quack quack there,\n" +
                $"Here a quack, there a quack, ev'rywhere a quack quack.\n" +
                $"Old MacDonald had a farm, E I E I O.";
        }
    }

    public class Cock : Animal
    {
        public override string Sing()
        {
            return $"Old MacDonald had a farm, E I E I O. \n" +
                $"And on his farm he had a Cock, E I E I O.\n" +
                $"With a crow crow here and a crow crow there,\n" +
                $"Here a crow, there a crow, ev'rywhere a crow crow.\n" +
                $"Old MacDonald had a farm, E I E I O.";
        }
    }
}
