using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarvestManager : MonoBehaviour
{
    public int harbestId;

    List<BaseHarvestEffect> effectList;



    // Start is called before the first frame update
    void Start()
    {
        effectList = new List<BaseHarvestEffect>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayHarvest()
    {

    }
}
