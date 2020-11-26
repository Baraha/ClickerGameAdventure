using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamemanage : MonoBehaviour
{
    public Transform startposition;
    public int PlayerGold;
    public Text playerGoldUI;
    public GameObject GoldPrefab;
    public GameObject[] MonsterPrefab;
    int PlayerGoldn;
    private void Start()
    {
        playerGoldUI.text = PlayerGold.ToString();
        SpawnEnemy();
    }
    public void takeGold(int gold)
    {
        PlayerGoldn += gold;
        playerGoldUI.text = PlayerGoldn.ToString();
        GameObject newobjGold = Instantiate(GoldPrefab) as GameObject;
        Destroy(newobjGold, 3);
        SpawnEnemy();
    }
    public void SpawnEnemy()
    {
        int index = 0;
        GameObject newmonstrsp = Instantiate(MonsterPrefab[index]) as GameObject;
        newmonstrsp.transform.position = startposition.position;

    }
        
}
