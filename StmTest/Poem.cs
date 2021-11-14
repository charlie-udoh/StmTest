namespace StmTest
{
    public class Poem
    {
        public Poem(string name, string sound)
        {
            this.AnimalName = name;
            this.AnimalSound = sound;
        }

        public string AnimalName { get; set; }
        public string AnimalSound { get; set; }

        public string Sing()
        {
            return $"Old MacDonald had a farm, E I E I O. \n" +
                $"And on his farm he had a {AnimalName}, E I E I O.\n" +
                $"With a {AnimalSound} {AnimalSound} here and a {AnimalSound} {AnimalSound} there,\n" +
                $"Here a {AnimalSound}, there a {AnimalSound}, ev'rywhere a {AnimalSound} {AnimalSound}.\n" +
                $"Old MacDonald had a farm, E I E I O. \n";
        }
    }
}
