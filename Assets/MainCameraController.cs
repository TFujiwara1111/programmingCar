using UnityEngine;
using System.Collections;

public class MainCameraController : MonoBehaviour
{
    //車のオブジェクト
    private GameObject car;
    //車とカメラの距離
    private float difference;



    // Use this for initialization
    void Start()
    {
        //車のオブジェクトを取得
        this.car = GameObject.Find("Car");
    }

    // Update is called once per frame
    void Update()
    {
        //車の位置に合わせてカメラの位置を移動  2.0fは車からみたカメラの高さ
        this.transform.position = this.car.transform.position - car.transform.forward * 2.0f + new Vector3(0.0f, 2.0f, 0.0f);

        this.transform.rotation = this.car.transform.rotation;
    }
}
