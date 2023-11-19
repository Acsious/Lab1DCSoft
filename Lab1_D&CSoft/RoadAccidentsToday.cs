using Lab1DCSoft;

namespace Lab1_D_CSoft;

internal class RoadAccidentsToday
{
    public EuroProtocol smallCrash;
    public SeriousAccident largeCrash;
    public RoadAccidentsToday()
    {
        smallCrash = new EuroProtocol();
        largeCrash = new SeriousAccident();
    }
}
