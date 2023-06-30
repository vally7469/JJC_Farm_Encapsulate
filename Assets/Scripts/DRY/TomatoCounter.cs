using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TomatoCounter : MonoBehaviour
{
    Text m_staticText;
    Text m_numText;

    // Start is called before the first frame update
    void Start()
    {
        m_staticText = transform.Find("HLayout/StaticText").GetComponent<Text>();
        m_numText = transform.Find("HLayout/NumText").GetComponent<Text>();

        m_staticText.text = "トマト";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetNum(int newNum)
    {
        m_numText.text = newNum.ToString();
    }
}
