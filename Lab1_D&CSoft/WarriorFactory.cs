namespace Lab1DCSoft;

internal class WarriorFactory : HeroFactory
{
    public override Movement CreateMovement()
    {
        return new Run();
    }

    public override Weapon CreateWeapon()
    {
        return new Sword();
    }

}
