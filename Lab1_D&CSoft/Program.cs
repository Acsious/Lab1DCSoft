using Lab1DCSoft;

Crew crew = new Crew();
crew.Elf.CreateWeapon().Hit();
crew.Warrior.CreateWeapon().Hit();
crew.Elf.CreateMovement().Move();
crew.Warrior.CreateMovement().Move();

//namespace Lab1DCSoft
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Crew crew = new Crew();
//            crew.Elf.CreateWeapon().Hit();
//            crew.Warrior.CreateWeapon().Hit();
//            crew.Elf.CreateMovement().Move();
//            crew.Warrior.CreateMovement().Move();
//        }
//    }
//}