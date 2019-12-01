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


        if (transform.name == "YOU WIN")
        {
           if (transform.position.x > -3.30f)
           { transform.Translate(-0.1f, 0, 0); }
        }

        else
        {
            transform.Translate(-0.1f, 0, 0);
            if (transform.position.x < -40f)
            {
                Debug.Log("Линия уничтожена корректно");

                Destroy(gameObject);
            }
        }

    }

}
