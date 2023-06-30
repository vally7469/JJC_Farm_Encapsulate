using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 植物オブジェクトの基底クラス.
public class BasePlant : MonoBehaviour
{
    public enum E_GROW_PROGRESS
    {
        GROWTH_0,
        GROWTH_1,
        GROWTH_2,
        GROWTH_START = GROWTH_0,
        GROWTH_END = GROWTH_2,
    }

    private E_GROW_PROGRESS growProgress;   // 成長度合い.
    private int growExp;                    // 成長経験値.
    private SpriteRenderer spriteRenderer;  // 画像表示のためのコンポーネント.

    [SerializeField]
    private int GROW_MAX = 100;             // 成長経験値がこの値になったら次の段階になる.

    void Awake()
    {
        growProgress = E_GROW_PROGRESS.GROWTH_START;
        growExp = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 植物が成長するタイミングで呼ばれる.
    public void Grow()
    {
        // 植物が最大成長状態になっていたら、もう成長しない.
        if (growProgress == E_GROW_PROGRESS.GROWTH_END)
        {
            return;
        }
        // 成長経験値を加算する.
        growExp++;
        // 成長経験値が、最大値より高くなっていたら、成長度合いを1つ進める.
        if (growExp >= GROW_MAX)
        {
            GrowNextProgress();
            growExp = 0;
        }
    }

    // 成長度合いを1つ進めるための関数.
    private void GrowNextProgress()
    {
        growProgress = growProgress + 1;

        switch (growProgress)
        {
            case E_GROW_PROGRESS.GROWTH_1:
                spriteRenderer.sprite = Resources.Load<Sprite>("Textures/Plant_1"); //植物の見た目を更新.
                break;
            case E_GROW_PROGRESS.GROWTH_2:
                GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Textures/Plant_2"); //植物の見た目を更新.
                CreateVegetable(); // 野菜を実らせる.
                break;
        }
    }

    // 野菜を生成するための関数.キーワード「virtual」が付いている、仮想関数であり、実際にどんな植物が実るかは、派生クラスで決定する.
    virtual protected void CreateVegetable()
    {

    }
    void OnMouseDown()
    {
        if (growProgress == E_GROW_PROGRESS.GROWTH_2)
        {
            Harvest();
        }
    }

    private void Harvest()
    {
        HarvestInternal();
        Application.plantManager.DestroyPlant(this);
        GameObject.Find("HarvestManager").PlayHarvest();
    }

    virtual protected void HarvestInternal()
    {

    }
}
