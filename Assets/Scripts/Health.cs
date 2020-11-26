using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Health : MonoBehaviour
{
    public int maxHealth =100;
    public int objectHealth = 100;
    Gamemanage _gamehelper;
    public int Gold;
    private void Start()
    {
        _gamehelper = GameObject.FindObjectOfType<Gamemanage>();
    }
    public void GetHit(int damage)
    {
        int objectHealthdamage = objectHealth - damage;
        if (objectHealth <= 0)
        {
            _gamehelper.takeGold(Gold);
            Destroy(gameObject);
            GetComponent<Animator>().SetTrigger("TakeGold");
            //_gamehelper.SpawnEnemy();
        }
        objectHealth = objectHealthdamage;
        Debug.Log("Health" + objectHealth);
    }
}
