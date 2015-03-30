using UnityEngine;
using System.Collections;

public class collectiblemanager : MonoBehaviour
{

    private int nrOfTotalCollectables;
    private int nrOfCollectedItems;


    void Start()
    {
        GameObject[] collectables = GameObject.FindGameObjectsWithTag("collectable");
        nrOfTotalCollectables = collectables.Length;
        nrOfCollectedItems = 0;
    }
    public void AddCollectable()
    {
        nrOfCollectedItems++;
        
    Debug.Log("u have" + nrOfCollectedItems + "items");
    }
    void update()
    {
        if (nrOfCollectedItems == 1)
        {
            Application.Quit();
        }
    }
}
