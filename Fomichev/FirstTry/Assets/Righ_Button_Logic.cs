using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Righ_Button_Logic : MonoBehaviour {

	AudioSource audio_object;
	GameObject referenceObject;
	Player_Movement referenceScript ;

	void OnMouseDown () {


		Debug.Log ("Игрок нажал на кнопку!!!");


		//Проигрываем звук
		audio_object = GetComponent<AudioSource>();
		audio_object.Play ();
		Debug.Log ("Звук ускорения проигран");

		//Меняем скорость главного героя
		referenceObject = GameObject.FindWithTag("Player");
		referenceScript = referenceObject.GetComponent<Player_Movement> ();
		referenceScript.speed = 10000f;

		Debug.Log ("Кнопка вправо нашла объект игрока на карте");

	}

	public class ScriptTwo : MonoBehaviour {


		void Start () {
			

		}

		void Update () {
	}

	}
}
