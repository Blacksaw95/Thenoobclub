using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {

    public int Maxhealth;
    public int CurrentHealth;

    private PlayerStats thePlayerStats;

    public int expToGive;

    public string enemyQuestName;
    private QuestManager theQM;

    // Use this for initialization
    void Start()
    {
        theQM = FindObjectOfType<QuestManager>();
        CurrentHealth = Maxhealth;

        thePlayerStats = FindObjectOfType<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentHealth <= 0)
        {
            theQM.enemyKilled = enemyQuestName;

            gameObject.SetActive(false);

            thePlayerStats.AddExperiance(expToGive);

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
