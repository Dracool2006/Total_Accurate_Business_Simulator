using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour {

    [SerializeField]
    //НЕ работает этот параметр почему-то!
    //private float linesSpeed = 0.001f;
    private float dirX;
    private bool can_go = false;
    // Use this for initialization
    void Start()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(ExampleCoroutine());
    }
    void Update()
    {


        if (can_go == true)
            transform.Translate( -0.1f, 0, 0);
        {
            if (transform.position.x < -3.029f)
            {
                Debug.Log("Линия уничтожена корректно");
                
                Destroy(gameObject);
                //не получается заставить линии появляться сразу после своего уничтожения
                //Instantiate(gameObject, transform.position);
            }
        }

    }
  
        

IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        if (this.tag == "Red Stage")
        {
            Debug.Log("Я Красный Stage");
            can_go = true;
        }
        if (this.tag == "Green Stage")
        {
            Debug.Log("Я Зеленый Stage");
            yield return new WaitForSeconds(1);
            can_go = true;
        }
        if (this.tag == "Blue Stage")
        {
            Debug.Log("Я Синий Stage"); 
            yield return new WaitForSeconds(2);
            can_go = true;
        }
        if (this.tag == "White Stage")
        {
            Debug.Log("Я Белый Stage");
            yield return new WaitForSeconds(4);
            can_go = true;
        }


        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    // Update is called once per frame



        
           // public Rigidbody rb;
           //dirX = Input.GetAxis("Horizontal");
           //dirY = Input.GetAxis("Vertical");

           //rb.velocity = new Vector2 (dirX * speed, 0);
}
