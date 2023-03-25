using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public enum UnitState
{
    Idle,
    Walk,
    Sow,
    Water,
    Plow,
    Harvest
}
public class Staff : MonoBehaviour
{
    private int _id;
    public int ID { get { return _id;} set { _id = value; } }

    private int charSkinId;
    public int CharSkinId { get { return charSkinId;} set { charSkinId = value; } }
    public GameObject[] charSkin;

    public string staffName;
    public int dailyWage;

    //Animation
    [SerializeField] private UnitState state;
    
    //Nav Agent
    [SerializeField] private NavMeshAgent navAgent;
    public NavMeshAgent NavAgent { get { return navAgent; } }

    private void Awake()
    {
        navAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        CheckStop();
    }
    public UnitState State
    {
        get { return state; }
        set { state = value; }
    }

    public void InitCharID(int id)
    {
        _id = id;
        charSkinId = Random.Range(0, charSkin.Length - 1);
        staffName = "XXXX";
        dailyWage = Random.Range(80, 125);
    }

    public void ChangeCharSkin()
    {
        for (int i = 0; i < charSkin.Length; i++)
        {
            if (i == charSkinId)
            {
                charSkin[i].SetActive(true);
            }
            else
            {
                charSkin[i].SetActive(false);
            }
        }
    }

    public void CheckStop()
    {
        float dist = Vector3.Distance(transform.position, navAgent.destination);

        if (dist <= 3f)
        {
            state = UnitState.Idle;
            navAgent.isStopped = true;
        }
    }

    public void SetToWalk(Vector3 dest)
    {
        state = UnitState.Walk;

        navAgent.SetDestination(dest);
        navAgent.isStopped = false;
    }
}
