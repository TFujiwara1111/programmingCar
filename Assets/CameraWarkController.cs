using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CameraWarkController : MonoBehaviour
{
    public Camera mainCamera;
    public Camera subCamera;
    public Text StartText = null;
    GameObject clickedGameObject;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public IEnumerator method()
    {
        //サブカメラをオンにする　メインをオフ
        mainCamera.enabled = false;
        subCamera.enabled = true;

        //ようこそをゲームシーンに表示する
        StartText.text = "ようこそ○○じまへ";

        //表示させる
        StartText.gameObject.SetActive(true);

        //2秒待つ
        yield return new WaitForSeconds(2);

        //２秒の後は非表示にする
        StartText.gameObject.SetActive(false);

        //選択をゲームシーンに表示する
        StartText.text = "スタート位置を選んでください";

        //表示させる
        StartText.gameObject.SetActive(true);

        //2秒待つ
        yield return new WaitForSeconds(3);

        //２秒の後は非表示にする
        StartText.gameObject.SetActive(false);

        //もしボタンをクリックをされたら
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = subCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();
            if (Physics.Raycast(ray, out hit))
            {
                //本当にキューブタグにたっちされたか判定する
                clickedGameObject = hit.collider.gameObject;
                if (hit.collider.gameObject.tag == "CubeTag")
                {
                    //車に選んだキューブのところに配置する

                }
            }
        }
    }
}