using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantManager : MonoBehaviour
{
    List<BasePlant> plantList;
    [SerializeField]
    private int startPlantNum = 10;

    float growTimer = 0.0f;
    [SerializeField]
    float growLimit = 0.2f;

    enum E_VEGETABLE_ID
    {
        TOMATO,
        NASU,
        CORN,
    }

    private void Awake()
    {
        plantList = new List<BasePlant>();

        for (int i = 0; i < startPlantNum; i++)
        {
            int vegetableId = Random.Range(0,2+1);
            GameObject prefab = null;
            switch ((E_VEGETABLE_ID)vegetableId)
            {
                case E_VEGETABLE_ID.TOMATO:
                    prefab = Resources.Load<GameObject>("Prefabs/TomatoPlant");
                    break;
                case E_VEGETABLE_ID.NASU:
                    prefab = Resources.Load<GameObject>("Prefabs/NasuPlant");
                    break;
                case E_VEGETABLE_ID.CORN:
                    prefab = Resources.Load<GameObject>("Prefabs/CornPlant");
                    break;
            }
            GameObject instance = Instantiate(prefab);
            instance.transform.position = new Vector3(-5.0f + 10.0f * Random.Range(0.0f, 1.0f), -3.0f + 6.0f * Random.Range(0.0f, 1.0f), 0.0f);
            plantList.Add(instance.GetComponent<BasePlant>());
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        growTimer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        growTimer += Time.deltaTime;
        if (growTimer > growLimit)
        {
            growTimer = 0.0f;
            for (int i = 0; i < plantList.Count; i++)
            {
                plantList[i].Grow();
            }
        }
    }

    public void DestroyPlant(BasePlant plant)
    {
        plantList.Remove(plant);
        Destroy(plant.gameObject);
    }
}
