namespace gbssg.flenz.m320.wasserfass;

public class Wasserfass
{
    private final int minimalPegel;
    private int maximalPegel;
    private int fuellstand;
    public int getFuellstand()
    {
        return fuellstand;
    }
    private int kapazitaet;
    public int getKapazitaet()
    {
        return kapazitaet;
    }
    public Wasserfass(int minimalPegel, int maximalPegel, int kapazitaet)
    {
        this.minimalPegel = minimalPegel;
        this.maximalPegel = maximalPegel;
        this.kapazitaet = kapazitaet;
        fuellstand = 0;
    }

    public void befuellen(int menge)
    {
        fuellstand += menge;
    }
    public void entnehmen(int menge)
    {
        fuellstand -= menge;
    }

    public void entleeren()
    {
        fuellstand = 0;
    }
}