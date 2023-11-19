namespace Lab1DCSoft;

internal class EuroProtocol : AccidentProtocol
{
    public override Participant CreateInjury() => new NonInjury();

    public override Vehicle CreateDamage() => new LightlyMarked();

}
 