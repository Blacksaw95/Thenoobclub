using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {

    public int Maxhealth;
    public int CurrentHealth;

    // Use this for initialization
    void Start()
    {
        CurrentHealth = Maxhealth;


    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentHealth <= 0)
        {
            gameObject.SetActive(false);

        }


    }

    public void HurtEnemy(int damageToGive)
    {
        CurrentHealth -= damageToGive;
    }

    public void SetMaxHealth()
    {
        CurrentHealth = Maxhealth;
    }

}