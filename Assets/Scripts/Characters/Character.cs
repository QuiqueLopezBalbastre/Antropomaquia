using UnityEngine;

public enum AttackType
{
    smash,
    cutting,
    piercing
};
public class Character
{

    public string name_;
    public float attack_;
    public float defense_;
    public float health_;
    public int attack_type_;
    // public int initiative_;
    // public int reaction_;
    // Estructura que almacena el tipo de daño que hace un personaje
    public struct AttackInfo
    {
        public float attack_;
        public int attack_type_;
        public Weapon weapon_;
    };
    public virtual AttackInfo Attack(Weapon weapon_)
    {
        AttackInfo temp;
        temp.attack_ = attack_ + weapon_.attack_;
        temp.attack_type_ = attack_type_;
        temp.weapon_ = weapon_;
        return temp;
    }
    public virtual void TakeDamage(AttackInfo info, Armor armor_)
    {
        float attack_multiplier = 0.0f;
        // Comprobación de tipo de daño
        switch(armor_.material_)
        {
            case none:
                switch(info.attack_type_)
                {
                    case smash:
                        attack_multiplier = 2.0f;
                        break;
                    case cutting:
                        attack_multiplier = 2.0f;
                        break;
                    case piercing:
                        attack_multiplier = 2.0f;
                        break;
                }
                break;
            case leather:
                switch(info.attack_type_)
                {
                    case smash:
                        attack_multiplier = 0.85f;
                        break;
                    case cutting:
                        attack_multiplier = 1.25f;
                        break;
                    case piercing:
                        attack_multiplier = 1.25f;
                        break;
                }
                break;
            case steel:
                switch(info.attack_type_)
                {
                    case smash:
                        attack_multiplier = 1.25f;
                        break;
                    case cutting:
                        attack_multiplier = 0.85f;
                        break;
                    case piercing:
                        attack_multiplier = 0.5f;
                        break;
                }
                break;
            case silver:
                switch(info.attack_type_)
                {
                    case smash:
                        attack_multiplier = 1.5f;
                        break;
                    case cutting:
                        attack_multiplier = 0.85f;
                        break;
                    case piercing:
                        attack_multiplier = 0.75f;
                        break;
                }
                break;            
            case gold:
                switch(info.attack_type_)
                {
                    case smash:
                        attack_multiplier = 1.0f;
                        break;
                    case cutting:
                        attack_multiplier = 0.85f;
                        break;
                    case piercing:
                        attack_multiplier = 0.5f;
                        break;
                }
                break;
        }
        // Resta los HitPoints calculados
        health_ -= info.attack_ * attack_multiplier - defense_;
    }
}
