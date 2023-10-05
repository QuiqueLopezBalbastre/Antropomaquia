using UnityEngine;
public class Heracles : Hero
{
    public Heracles()
    {
        name_ = "Heracles";
        attack_ = 15.0f;
        defense_ = 10.0f;
        health_ = 140.0f;
        weapon_ = new Club();
    }
}