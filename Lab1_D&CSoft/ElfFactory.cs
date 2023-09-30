namespace Lab1DCSoft;

internal class ElfFactory : HeroFactory
{
    public override Movement CreateMovement()
    {
        return new Fly();
    }
    public override Weapon CreateWeapon()
    {
        return new Arbalet();
    }
}
