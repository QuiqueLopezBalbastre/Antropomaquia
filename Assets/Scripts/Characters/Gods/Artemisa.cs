using UnityEngine;

public class Artemisa : God
{
    public Artemisa()
    {
        name_ = "Artemisa";
        attack_ = 15.0f;
        defense_ = 10.0f;
        health_ = 180.0f;
        mana_ = 60.0f;
        max_mana_ = 60.0f;
        power_ = new SilverArrow();
    }
}