using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    public GameObject point1; // 手に近いほうの座標を記録
    public GameObject point2; // 手から遠いほうの座標を記録
    public GameObject fakeRay; // サポートのための議事Rayを追加

    void Start()
    {
        // Left Controllerを探す
        GameObject parent = GameObject.Find("Left Controller");

        // prefab を子オブジェクトとしてインスタンス化する
        GameObject childPoint1 = Instantiate(point1, transform);
        GameObject childPoint2 = Instantiate(point2, transform);
        GameObject childFakeRay = Instantiate(fakeRay, transform);

        // childObject の位置、回転、スケールを設定する
        // point1は5cm先
        childPoint1.transform.localPosition = new Vector3(0, 0, 0.05f);
        // point2は10m先
        childPoint2.transform.localPosition = new Vector3(0, 0, 10f);
        // fakeRayは5m先で中間に
        childFakeRay.transform.localPosition = new Vector3(0, 0, 5f);
        //childObject.transform.localRotation = Quaternion.identity;


        Transform point1Transform = parent.transform.Find("point1(Clone)");
        Vector3 position1 = point1Transform.position;

        Debug.Log("ワールド座標でのx = " + position1.x);
        //Debug.Log("ワールド座標でのy = " + position1.y);
        Debug.Log("ワールド座標でのz = " + position1.z);

        Transform point2Transform = parent.transform.Find("point2(Clone)");
        Vector3 position2 = point2Transform.position;

        Debug.Log("ワールド座標でのx = " + position2.x);
        //Debug.Log("ワールド座標でのy = " + position1.y);
        Debug.Log("ワールド座標でのz = " + position2.z);
    }
}