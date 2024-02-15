using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InfoManager : MonoBehaviour
{
    [SerializeField] private Image unitPic, hpIcon, rsrcIcon, moveIcon, atkIcon, amrIcon, vslRngIcon, wpRngIcon;
    [SerializeField] private TextMeshProUGUI nameTxt, hpTxt, rsrcTxt, moveTxt, atkTxt, amrTxt, vslRngTxt, wpRngTxt;
    
    
    public static InfoManager instance;
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
}
