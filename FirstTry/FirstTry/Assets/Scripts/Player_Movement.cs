using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Movement : MonoBehaviour {

	public float speed = 15f;
	private Rigidbody2D RB2D;
	public float Xmin, Xmax, Ymin, Ymax;
	public int JumpPower = 3000;
	public bool player_can_move = true;
	public GameObject player;



	// Use this for initialization
	void Start () {
		RB2D = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (player_can_move == true) {
			float Xcoordinate = Input.GetAxis ("Horizontal");
			RB2D.MovePosition (RB2D.position + Vector2.right * Xcoordinate * speed * Time.deltaTime);

			if (Input.GetKeyDown (KeyCode.Space)) {
				RB2D.AddForce (Vector2.up * JumpPower);
			}
		}

	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "YOU LOOSE") {
			Debug.Log ("Игрок тронул взрыв");
			SceneManager.LoadScene (0);
		}
		if (other.tag == "YOU WIN") {
			Debug.Log ("Игрок тронул дверь");
			player_can_move = false;

			//Тут должна проиграться анимация смерти

			SceneManager.LoadScene (0);
			//player.GetComponent<Animation> ().Play ("123");
			//SceneManager.LoadScene (0);
			//RB2D.GetComponent<Animation> ().Play ("Character_animation");
		}
		//if (other.tag == "Finish") {
			//SceneManager.LoadScene (0);
		//	player_can_move = false;
			//RB2D.GetComponent<Animation>().Play (Name)
		//}
	}

//	void Boarders()
//	{
//		Camera gameCamera = Camera.main;
//		Xmin = gameCamera.ViewportToWorldPoint (new Vector2 (0, 0)).x;
//		Xmax = gameCamera.ViewportToWorldPoint (new Vector2 (1, 0)).x;
//		Ymin = gameCamera.ViewportToWorldPoint (new Vector2 (0, 0)).y;
//		Ymax = gameCamera.ViewportToWorldPoint (new Vector2 (0, 1)).y;
	//
//	}
}
