using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantNumCounter : MonoBehaviour
{
    TomatoCounter m_tomatoCounter;
    NasuCounter m_nasuCounter;
    CornCounter m_cornCounter;

    int tomatoNum;
    int nasuNum;
    int cornNum;

    // Start is called before the first frame update
    void Start()
    {
        m_tomatoCounter = GameObject.Find("TomatoCounter").GetComponent<TomatoCounter>();
        m_nasuCounter = GameObject.Find("NasuCounter").GetComponent<NasuCounter>();
        m_cornCounter = GameObject.Find("CornCounter").GetComponent<CornCounter>();

        tomatoNum = 0;
        nasuNum = 0;
        cornNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddTomatoNum()
    {
        tomatoNum++;
        m_tomatoCounter.SetNum(tomatoNum);
    }

    public void AddNasuNum()
    {
        nasuNum++;
        m_nasuCounter.SetNum(nasuNum);
    }

    public void AddCornNum()
    {
        cornNum++;
        m_cornCounter.SetNum(cornNum);
    }
}
