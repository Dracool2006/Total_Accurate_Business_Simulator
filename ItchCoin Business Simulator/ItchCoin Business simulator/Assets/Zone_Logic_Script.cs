using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone_Logic_Script : MonoBehaviour {


    [SerializeField]
    //НЕ работает этот параметр почему-то!
    //private float linesSpeed = 0.001f;
    void Start()
    {
 
    }
    void Update()
    {



            transform.Translate(-0.1f, 0, 0);
            if (transform.position.x < -3.029f)
            {
                Debug.Log("Линия уничтожена корректно");

                Destroy(gameObject);
            }

    }

}
