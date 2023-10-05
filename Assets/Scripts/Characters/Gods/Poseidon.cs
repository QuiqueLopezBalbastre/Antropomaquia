using UnityEngine;

public class Poseidon : God
{
    public Poseidon()
    {
        name_ = "Poseidon";
        attack_ = 25.0f;
        defense_ = 10.0f;
        health_ = 300.0f;
        mana_ = 40.0f;
        max_mana_ = 40.0f;
        power_ = new Tsunami();
    }
}