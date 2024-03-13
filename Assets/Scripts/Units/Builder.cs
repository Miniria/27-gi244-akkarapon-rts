using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Builder : MonoBehaviour
{
    [SerializeField] private bool toBuild = false; //this builder has duty to build things
    [SerializeField] private bool showGhost = false; //ghost building is showing

    [SerializeField] private GameObject[] buildingList; // Buildings that this unit can build
    public GameObject[] BuildingList { get { return buildingList; } }
    [SerializeField] private GameObject[] ghostBuildingList; // Transparent buildings according to building list

    [SerializeField] private GameObject newBuilding; // Current building to build
    public GameObject NewBuilding { get { return newBuilding; } set { newBuilding = value; } }

    [SerializeField] private GameObject ghostBuilding; // Tranparent building to check site to build
    public GameObject GhostBuilding { get { return ghostBuilding; } set { ghostBuilding = value; } }

    [SerializeField] private GameObject inProgressBuilding; // The building a unit is currently building
    
    public GameObject InProgressBuilding { get { return inProgressBuilding; } set { inProgressBuilding = value; } }

    private Unit unit;
    
    
    // Start is called before the first frame update
    void Start()
    {
        unit = GetComponent<Unit>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ToCreateNewBuilding(int i) //Start call from ActionManager UI Btns
    {
        if (buildingList[i] == null)
            return;

        Building b = buildingList[i].GetComponent<Building>();

        if (!unit.Faction.CheckBuildingCost(b)) //don't have enough resource to build
            return;
        else
        {
            //Create ghost building at the mouse position
            ghostBuilding = Instantiate(ghostBuildingList[i],
                Input.mousePosition,
                Quaternion.identity, unit.Faction.GhostBuildingParent);

            toBuild = true;
            newBuilding = buildingList[i]; //Set prefab into new building
            showGhost = true;
        }
    }
    
    private void GhostBuildingFollowsMouse()
    {
        if (showGhost)
        {
            Ray ray = CameraController.instance.Cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 1000, LayerMask.GetMask("Ground")))
            {
                if (ghostBuilding != null)
                {
                    ghostBuilding.transform.position = new Vector3(hit.point.x, 0, hit.point.z);
                }
            }
        }
    }
    
    private void CancelToBuild()
    {
        toBuild = false;
        showGhost = false;

        newBuilding = null;
        Destroy(ghostBuilding);
        ghostBuilding = null;
        //Debug.Log("Cancel Building");
    }
    
    public void BuilderStartFixBuilding(GameObject target)
    {
        inProgressBuilding = target;        
        unit.SetState(UnitState.MoveToBuild);
    }
    
    private void StartConstruction(GameObject buildingObj)
    {
        BuilderStartFixBuilding(buildingObj);
    }
    
    
}
