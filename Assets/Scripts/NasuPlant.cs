using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NasuPlant : BasePlant
{
    [SerializeField]
    GameObject normalVegetable;
    [SerializeField]
    GameObject whiteVegetable;

    override protected void CreateVegetable()
    {
        bool isWhiteVegetable = Random.Range(0.0f, 1.0f) > 0.5f;
        GameObject vegetableInstance = null;
        
        if (isWhiteVegetable)
        {
            vegetableInstance = Instantiate(whiteVegetable);
        }
        else
        {
            vegetableInstance = Instantiate(normalVegetable);
        }
        vegetableInstance.transform.SetParent(this.transform);
        vegetableInstance.transform.localPosition = Vector3.zero;
    }
    override protected void HarvestInternal()
    {
        Application.plantNumCounter.AddNasuNum();
    }
}