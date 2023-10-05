using UnityEngine;

public class Zeus : God
{
    public Zeus()
    {
        name_ = "Zeus";
        attack_ = 25.0f;
        defense_ = 15.0f;
        health_ = 200.0f;
        mana_ = 50.0f;
        max_mana_ = 50.0f;
        power_ = new Lightning();
    }
}