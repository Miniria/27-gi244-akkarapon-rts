using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainUi : MonoBehaviour
{




    [SerializeField] private TextMeshPro unitCountText;
    [SerializeField] private TextMeshPro foodText;
    [SerializeField] private TextMeshPro woodText;
    [SerializeField] private TextMeshPro goldText;
    [SerializeField] private TextMeshPro stoneText;
    
    public static MainUi instance;

    private void Awake()
    {
        instance = this; 
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void UpdateAllResource(Faction faction)
    {
        unitCountText.text = faction.AliveUnits.Count.ToString();
        foodText.text = faction.Food.ToString();
        woodText.text = faction.Wood.ToString();
        goldText.text = faction.Gold.ToString();
        stoneText.text = faction.Stone.ToString();
    }
}
