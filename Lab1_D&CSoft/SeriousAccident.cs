namespace Lab1DCSoft;

internal class SeriousAccident : AccidentProtocol
{
    public override Participant CreateInjury() => new SevereInjury();

    public override Vehicle CreateDamage() => new Total();
}
