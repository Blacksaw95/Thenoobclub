using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour {

    public int damageToGive;
    public GameObject damageNumber;
    private PlayerStats thePS;
    private int currentDamage;

    // Use this for initialization
    void Start()
    {
        thePS = FindObjectOfType<PlayerStats>();


    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.name == "Player")
        {

            currentDamage = damageToGive - thePS.currentDefense;
            if(currentDamage < 0)
            {
                currentDamage = 1;
            }


            other.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(currentDamage);

            var clone = (GameObject)Instantiate(damageNumber, other.transform.position, Quaternion.Euler(Vector3.zero));
            clone.GetComponent<FloatingNumbers>().damageNumber = currentDamage;
            clone.transform.position = new Vector2(transform.position.x, transform.position.y);

        }
    }

}
