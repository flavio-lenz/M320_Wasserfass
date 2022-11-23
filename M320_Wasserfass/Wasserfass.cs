using System.ComponentModel;

namespace gbssg.flenz.m320.wasserfass;

public class Wasserfass
{
    private int minimalPegel;
    private int maximalPegel;
    public int fuellstand;
    public int kapazitaet;

    public Wasserfass(int minimalPegel, int maximalPegel, int kapazitaet)
    {
        this.minimalPegel = minimalPegel;
        this.maximalPegel = maximalPegel;
        this.kapazitaet = kapazitaet;
        this.fuellstand = 0;
    }

    public int getFuellstand()
    {
        return fuellstand;
    }
    public int getKapazitaet()
    {
        return kapazitaet;
    }

    public void befuellen(int menge)
    {
        fuellstand = fuellstand + menge;
    }
    public void entnehmen(int menge)
    {
        fuellstand = fuellstand - menge;
    }
    public void entleeren()
    {
        fuellstand = minimalPegel;
    }
}