using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CenterUI : MonoBehaviour
{
    public bool hey;
    [SerializeField] Canvas canv;
    [SerializeField] GameObject text;
    [SerializeField] GameObject[] centers;
    [SerializeField] Transform diceCenter;

    private void OnValidate() {
            // Process();
            // var parent = gameObject.transform.positionv
            // canv.transform.position = gameObject.transform.position*1.001f;
            // canv.transform.LookAt(Vector3.zero);
    }

    private void Process()
    {
        foreach(GameObject center in centers)
        {
            // foreach(Transform trans in center.transform)
            // {
            //     DestroyImmediate(trans.gameObject);
            // }

            var newCanvas = Instantiate(text);
            newCanvas.transform.position = center.transform.position*1.001f;
            newCanvas.transform.eulerAngles = Vector3.zero - transform.position;

            newCanvas.transform.LookAt(Vector3.zero);
        }
    }
}
