using UnityEngine;

public class Gear
{
    public string name_;
    public float durability_;
    public enum Material
    {
        none,
        leather,
        steel,
        silver,
        gold,
        last
    };
    public int material_;
    public void CheckDurability()
    {
        if(durability_ > 0)
        {
            durability_--;
        }
    }

}