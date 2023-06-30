using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Application : MonoBehaviour
{
    private void Awake()
    {
        S = this;
    }

    // ---------------- Static Section ---------------- //

    static private Application _S;
    static private Application S
    {
        get
        {
            if (_S == null)
            {
                return null;
            }
            return _S;
        }
        set
        {
            if (_S != null)
            {
                Debug.LogError("_Sは既に設定されています.");
            }
            _S = value;
        }
    }

    private PlantNumCounter _plantNumCounter;
    static public PlantNumCounter plantNumCounter
    {
        get
        {
            if (S != null)
            {
                if (S._plantNumCounter == null)
                {
                    S._plantNumCounter = GameObject.Find("PlantNumCounter").GetComponent<PlantNumCounter>();
                }
                return S._plantNumCounter;
            }
            return null;
        }
    }

    private PlantManager _plantManager;
    static public PlantManager plantManager
    {
        get
        {
            if (S != null)
            {
                if (S._plantManager == null)
                {
                    S._plantManager = GameObject.Find("PlantManager").GetComponent<PlantManager>();
                }
                return S._plantManager;
            }
            return null;
        }
    }
}
