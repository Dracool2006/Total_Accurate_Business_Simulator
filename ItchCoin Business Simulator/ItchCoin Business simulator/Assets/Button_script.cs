using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_script : MonoBehaviour {

    [SerializeField]
    private Sprite Button_Active;
    private Sprite Button_Passive;
    private Sprite Button_Triggered;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (ScoreTextScript.coinAmount >= 100)
        {
            this.GetComponent<SpriteRenderer>().sprite = Button_Active;
        }
	}
}
