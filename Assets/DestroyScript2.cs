using UnityEngine;
using System.Collections;

public class DestroyScript2 : MonoBehaviour
{
    //Unityちゃんのオブジェクト
    private GameObject unitychan;

    ///UnityChanのZ座標とアイテムのZ座標の位置の差
    private float objdifference;

    //アイテム破棄する距離＊＊＊＊
    private float destroyDist = 5;


    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Unityちゃんのオブジェクトを取得＊＊＊
        this.unitychan = GameObject.Find("unitychan");

        //Unityちゃんとアイテムの位置（z座標）の差を求める＊＊＊
        this.objdifference = unitychan.transform.position.z - this.transform.position.z;

        //画面外に出たアイテムを破棄＊＊＊
        if (this.objdifference > destroyDist)
        {
            Destroy(this.gameObject);
        }
    }
}