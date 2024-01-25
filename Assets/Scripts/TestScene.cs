using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScene : MonoBehaviour
{
    [SerializeField]
    private Unit[] units;
    
    public void SetIdle()
    {
        for (int i = 0; i < units.Length; i++)
        {
            units[i].State = UnitState.Idle;
        }
    }//SetIdle
    public void SetMove()
    {
        for (int i = 0; i < units.Length; i++)
        {
            units[i].State = UnitState.Move;
        }
    }//SetMove
    public void SetAttack()
    {
        for (int i = 0; i < units.Length; i++)
        {
            units[i].State = UnitState.Attack;
        }
    }//SetAttack
    
    // Start is called before the first frame update
    void Start()
    {
        
    }//Start

    // Update is called once per frame
    void Update()
    {
        
    }//Update
}//TestScreen
