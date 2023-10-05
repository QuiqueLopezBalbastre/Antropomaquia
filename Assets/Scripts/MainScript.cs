using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    // Start is called before the first frame update
    public List<God> godlist_;
    public List<Hero> herolist_;

    God InitGods()
    {
        int rand = Random.Range(0, 3);
        // Debug.Log("Rand: " + rand);
        God god_ = null;
        switch (rand)
        {
            case 0:
                god_ = new Zeus();
                break;
            case 1:
                god_ = new Artemisa();
                break;
            case 2:
                god_ = new Poseidon();
                break;
        }
        return god_;
    }
    Hero InitHeroes()
    {
        int rand = Random.Range(0, 3);
        // Debug.Log("Rand: " + rand);
        Hero hero_ = null;
        switch (rand)
        {
            case 0:
                hero_ = new Heracles();
                break;
            case 1:
                hero_ = new Aquiles();
                break;
            case 2:
                hero_ = new Ayax();
                break;
        }
        return hero_;
    }
    void Start()
    {
        godlist_ = new List<God>();
        herolist_ = new List<Hero>();
        int max_quantity_units = 6;
        int rand_ = Random.Range(1, max_quantity_units);
        for (int i = 0; i < rand_; i++)
            godlist_.Add(InitGods());
        for (int i = 0; i < rand_; i++)
            herolist_.Add(InitHeroes());

        // Debug.Log("godlist lenght: " + godlist_.Count);
    }

    // Update is called once per frame
    void Update()
    {
        if (herolist_.Count == 0 && godlist_.Count == 0)
        {
            Debug.Log("DRAW!!!!");
        }
        else if (herolist_.Count == 0)
        {
            Debug.Log("GODS WIN!!!!");
        }
        else if (godlist_.Count == 0)
        {
            Debug.Log("HEROES WIN!!!!");
        }
        else
        {
            //Heroes attack turn
            for (int i = 0; i < herolist_.Count; i++)
            {
                int rand_ = Random.Range(0, godlist_.Count);
                Debug.Log(herolist_[i].name_ + " Attacking " + godlist_[rand_].name_);
                // herolist_[i].Attack(godlist_[rand_]);
                if (godlist_[rand_].health_ <= 0)
                {
                    godlist_.RemoveAt(rand_);
                }
            }
            // Debug.Break();
            // Gods attack turn
            for (int i = 0; i < godlist_.Count; i++)
            {
                int rand_ = Random.Range(0, herolist_.Count);
                Debug.Log(godlist_[i].name_ + " Attacking " + herolist_[rand_].name_);
                // godlist_[i].Attack(herolist_[rand_]);
                godlist_[i].ManaRecovery();
                if (herolist_[rand_].health_ <= 0)
                {
                    herolist_.RemoveAt(rand_);
                }
            }
            Debug.Break();
        }

        // for (int i = 0; i < godlist_.Count; i++)
        // {

        // }
    }
}
