using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMarkeMovement : MonoBehaviour
{


    ////[SerializeField]
    ////private int rows = 5;
    ////private int cols = 10;
    ////private float tileSize = 1;

    ////private void Start()
    ////{
    ////    GenerateGrid();   
    ////}

    ////private void GenerateGrid()
    ////{
    ////    GameObject referenceTile = (GameObject)Instantiate(Resources.Load("GrassTile"));
    ////    for (int row = 0; row < rows; row++)
    ////    {
    ////        for (int col = 0; col < cols; col++)
    ////        {
    ////            GameObject tile = (GameObject)Instantiate(referenceTile, transform);

    ////            float posX = col * tileSize;
    ////            float posY = row * -tileSize;

    ////            tile.transform.position = new Vector2(posX, posY);


    ////        }
    ////    }
    ////    Destroy(referenceTile);
    ////}
    float dirX, dirY;
    //Rigidbody2D rb;
    [SerializeField]
    private float moveSpeed = 5f;


    [SerializeField]
    private Sprite red;
    [SerializeField]
    private Sprite green;
    [SerializeField]
    private Sprite black;
    [SerializeField]
    private Sprite white;

    //Для движения мышкой объявление переменных
    private Vector3 mousePosition;
    private Rigidbody2D rb;
    private Vector2 direction;
    [SerializeField]
    private float moveSpeedX = 50f;
    [SerializeField]
    private float moveSpeedY = 50f;





    void Start()
    {
        //       StartCoroutine(CoUpdate());
        rb = GetComponent<Rigidbody2D>();
        
        //GetComponent(SpriteRenderer).sprite = newSprite;
        //}

        //   // Update is called once per frame
        //   IEnumerator CoUpdate()
    }
    //       if (Input.GetKey(KeyCode.UpArrow))
    //       {
    //           move(Vector3.forward * Time.deltaTime);
    //       }
    //       else if (Input.GetKey(KeyCode.DownArrow))
    //       {
    //           move(Vector3.back * Time.deltaTime);
    //       }
    //   }

    //   void move(Vector3 direction)
    //  {
    //       transform.Translate(direction * moveSpeed, Space.Self);
    //   }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //пока не получается заставить определять что тык произошёл именно по итч.коину
            //RaycastHit hit;
            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //if (Physics.Raycast(ray, out hit))
            //{
             //   if (hit.transform.name == "PlayerMarker")
             //   {
             //       Debug.Log("Hit point: " + hit.point);
                    ScoreTextScript.coinAmount += 10;

              //  }
            //}
        }



        if (Input.GetMouseButton(0))
        {

            


            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            direction = (mousePosition - transform.position).normalized;

            if (mousePosition.y > rb.position.y)
            {
                rb.velocity = new Vector2( 0 , direction.y * moveSpeedY);
            }
            if (mousePosition.y < rb.position.y)
            {
                rb.velocity = new Vector2(0, direction.y * moveSpeedY/10);
            }
        }
        else {
            rb.velocity = Vector2.zero;
        }
        //Логика движения клавишами на клавиатуре
        //dirX = Input.GetAxis("Horizontal");
        //dirY = Input.GetAxis("Vertical");
        //rb.velocity = new Vector2(dirX * moveSpeed, dirY * moveSpeed);
        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\


    }

    //**********Логика изменения цвета коина, когда начинается новый этап*******//
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Red Stage")
        {
            Debug.Log("Red Stage Started!");
            this.GetComponent<SpriteRenderer>().sprite = red;
            moveSpeed = 1f;
        }
        else
            if (other.tag == "Green Stage")
        {
            Debug.Log("Green Stage Started!");
            this.GetComponent<SpriteRenderer>().sprite = green;
            moveSpeed = 7f;
        }
        //Пока что пропадает текстура, почему-то
        else
            if (other.tag == "Blue Stage")
        {
            Debug.Log("Blue Stage Started!");
            this.GetComponent<SpriteRenderer>().sprite = black;
            moveSpeed = 9f;
        }
        else
            if (other.tag == "White Stage")
        {
            Debug.Log("White Stage Started!");
            TotalScore.TotalCoinAmount += ScoreTextScript.coinAmount;
            ScoreTextScript.coinAmount = 0 ;
            this.GetComponent<SpriteRenderer>().sprite = white;
            moveSpeed = 5f;
        }
        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    





    }
    void OnTriggerStay2D(Collider2D other) {
        if (other.tag == "StopZone")
        {
            Debug.Log("Я В КРАСНОЙ ЗОНЕ!!!");
            ScoreTextScript.coinAmount -= 5;
        }
    }
}
