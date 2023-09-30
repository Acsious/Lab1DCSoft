namespace Lab1DCSoft;

internal class Crew
{
    public ElfFactory Elf;
    public WarriorFactory Warrior;
    public Crew()
    {
        Elf = new ElfFactory();
        Warrior = new WarriorFactory();
    }
}
