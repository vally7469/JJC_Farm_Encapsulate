using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornPlant : BasePlant
{
    [SerializeField]
    GameObject vegetable;

    override protected void CreateVegetable()
    {
        GameObject vegetableInstance = Instantiate(vegetable);
        vegetableInstance.transform.SetParent(this.transform);
        vegetableInstance.transform.localPosition = Vector3.zero;
    }

    override protected void HarvestInternal()
    {
        Application.plantNumCounter.AddCornNum();
    }
}