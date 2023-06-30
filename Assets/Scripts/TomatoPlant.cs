using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 植物としてのトマトオブジェクトの派生クラス.
public class TomatoPlant : BasePlant
{
    [SerializeField]
    GameObject vegetable;
    [SerializeField]
    int maxVegetableNum;

    int currentVegetableNum;

    override protected void CreateVegetable()
    {
        currentVegetableNum = Random.Range(1, maxVegetableNum + 1);

        for (int i = 0; i < currentVegetableNum; i++)
        {
            GameObject vegetableInstance = Instantiate(vegetable);
            vegetableInstance.transform.SetParent(this.transform);
            vegetableInstance.transform.localPosition = new Vector3(-0.3f + Random.Range(0.0f, 0.6f), -0.3f + Random.Range(0.0f, 0.6f), 0.0f);
        }

    }

    override protected void HarvestInternal()
    {
        for (int i = 0; i < currentVegetableNum; i++)
        {
            Application.plantNumCounter.AddTomatoNum();
        }
    }
}
