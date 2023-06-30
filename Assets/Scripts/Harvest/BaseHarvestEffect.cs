using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHarvestEffect
{
    private float kuwabara_timer;
    private bool kuwabara_isPlaying;
    private GameObject kuwabara_effectPrefab;
    private GameObject kuwabara_effectInstance;
    virtual public void Initialize()
    {
        kuwabara_timer = 0.0f;
        kuwabara_isPlaying = false;
        kuwabara_effectPrefab = Resources.Load<GameObject>("Prefabs/HarvestEffect/kuwabara/kuwaEffect");
        kuwabara_effectInstance = null;
    }

    // Update is called once per frame
    virtual public void Update()
    {
        if (kuwabara_isPlaying)
        {
            kuwabara_timer -= Time.deltaTime;
            if (kuwabara_timer < 0.0f) {
                GameObject.Destroy(kuwabara_effectInstance);
                kuwabara_isPlaying = false;
                kuwabara_effectInstance = null;
            }
        }
    }

    virtual public void PlayHarvest()
    {
        if (kuwabara_effectInstance == null)
        {
            kuwabara_effectInstance = GameObject.Instantiate(kuwabara_effectPrefab);
            kuwabara_timer = 2.0f;
            kuwabara_isPlaying = true;
        }
    }
}
