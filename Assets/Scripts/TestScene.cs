using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScene : MonoBehaviour
{
    public Staff staff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ButtonIdle()
    {
        staff.State = UnitState.Idle;
    }
    
    public void ButtonWalk()
    {
        staff.State = UnitState.Walk;
    }

    public void ButtonHarvest()
    {
        staff.State = UnitState.Harvest;
    }

    public void ButtonSow()
    {
        staff.State = UnitState.Sow;
    }
    
    public void ButtonPlow()
    {
        staff.State = UnitState.Plow;
    }
    public void ButtonWater()
    {
        staff.State = UnitState.Water;
    }
}
