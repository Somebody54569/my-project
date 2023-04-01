using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject staffPrefab;
    public GameObject staffParent;

    public GameObject spawnPos;
    public GameObject rallyPos;

    public static GameManager instance;
    
    //Resource
    public int money;
    public int staff;
    public int wheat;
    public int melon;
    public int corn;
    public int apple;
    public int date;
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        GenerateCandidate();
        money = 25000;
        UI.instance.UpdateHeaderPanel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GenerateCandidate()
    {
        for (int i = 0; i < 20; i++)
        {
            GameObject staffObj = Instantiate(staffPrefab, staffParent.transform);
            Staff s = staffObj.GetComponent<Staff>();
            
            s.InitCharID(i);
            s.ChangeCharSkin();
            
            s.SetToWalk(rallyPos.transform.position);
        }
    }
}
