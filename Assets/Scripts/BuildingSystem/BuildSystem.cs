using System;
using UnityEngine;

public class BuildSystem : MonoBehaviour
{
    // 건물 설치
    public GameObject PlaceBuilding(GameObject prefabToPlace, IGridProvider grid, Vector2Int index, Vector3 pos, Quaternion rotation)
    {
        // 1. 오브젝트 생성
        GameObject newObj = Instantiate(prefabToPlace, pos, rotation);

        // 2. 자체 설치 로직 실행
        IBuildable buildable = newObj.GetComponent<IBuildable>();
        buildable.ConstructedGrid = grid;
        buildable.ConstructedIndex = index;

        return newObj;
    }

    // 건물 파괴
    public void DestroyBuilding(GameObject buildingObj)
    {   
        // 2. 오브젝트 파괴
        Destroy(buildingObj);
    }

}
