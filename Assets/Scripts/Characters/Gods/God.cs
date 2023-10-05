using UnityEngine;
[System.Serializable]
public class God : Character
{
    protected float mana_;
    public float max_mana_;
    protected Power power_;
    public Weapon weapon_;
    // public void Attack(Hero target)
    // {
    //     int special_attack_probability_ = Random.Range(0, 5);
    //     if (special_attack_probability_ == 0 && mana_ > power_.mana_use_)
    //     {
    //         Debug.Log(name_ + " used " + power_.name_ + "!\nIt caused " + power_.attack_ + " damage points to " + target.name_);
    //     }
    //     else
    //     {
    //         Debug.Log("Damage done: " + (attack_ - target.defense_));
    //         if (attack_ - target.defense_ > 0)
    //         {
    //             target.health_ -= attack_ - target.defense_;
    //         }
    //     }
    // }
    public void ManaRecovery()
    {
        if(mana_ + 10.0f < max_mana_)
        mana_ += 10.0f;
    }
}