using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
      Transform myTran;
    // Start is called before the first frame update
    void Start()
    {
        myTran = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = new Vector3(10, 0, 0);
         myTran.position += dir * Time.deltaTime;
    }
}
