using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUi : MonoBehaviour
{
    [SerializeField] private GameObject selectionMaker;
    public GameObject SelectionMaker
    {
        get { return selectionMaker; }
    }

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
}
