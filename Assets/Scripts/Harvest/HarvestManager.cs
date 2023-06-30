using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarvestManager : MonoBehaviour
{
    public int harbestId;

    List<BaseHarvestEffect> effectList;

    BaseHarvestEffect test;



    // Start is called before the first frame update
    void Start()
    {
        effectList = new List<BaseHarvestEffect>();
        test = new BaseHarvestEffect();
        effectList.Add(test);


        for (int i = 0; i < effectList.Count; i++)
        {
            effectList[i].Initialize();
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < effectList.Count; i++)
        {
            effectList[i].Update();
        }

    }

    public void PlayHarvest()
    {
        effectList[harbestId].PlayHarvest();
    }
}
