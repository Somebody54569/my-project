using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StructureManager : MonoBehaviour
{
    [SerializeField] private bool isConstructing;

    public GameObject curBuildingPrefab;
    public GameObject buildingParent;

    [SerializeField] private Vector3 cursorPos;
    [SerializeField] private GameObject buildingCursor;
    [SerializeField] private GameObject gridPlane;

    // Update is called once per frame
    void Update()
    {
        cursorPos = Selector.instance.GetCurTilePosition();

        if (isConstructing)
        {
            buildingCursor.transform.position = cursorPos;
            gridPlane.SetActive(true);
        }
    }

    public void BeginNewBuildingPlacement(GameObject prefab) //map w button
    {
        isConstructing = true;
        curBuildingPrefab = prefab;
        buildingCursor = Instantiate(curBuildingPrefab, cursorPos, Quaternion.identity);
        buildingCursor.SetActive(true);
    }
}


