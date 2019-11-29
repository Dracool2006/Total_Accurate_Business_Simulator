using UnityEngine;
using System.Collections;

public class CharacterControllerScript : MonoBehaviour
{
	[SerializeField]
	private float maxSpeed = 10f; 

	private void Start()
	{
		
	}

	private void Update()
	{
		float move = Input.GetAxis("Horizontal");

		//в компоненте анимаций изменяем значение параметра Speed на значение оси Х.
		//приэтом нам нужен модуль значения
		anim.SetFloat("Speed", Mathf.Abs(move));

		//обращаемся к компоненту персонажа RigidBody2D. задаем ему скорость по оси Х, 
		//равную значению оси Х умноженное на значение макс. скорости
		rigidbody2D.velocity = new Vector2(move * maxSpeed, rigidbody2D.velocity.y);

		//если нажали клавишу для перемещения вправо, а персонаж направлен влево
		if(move > 0 && !isFacingRight)
			//отражаем персонажа вправо
			Flip();
		//обратная ситуация. отражаем персонажа влево
		else if (move < 0 && isFacingRight)
			Flip();
	}

	/// <summary>
	/// Метод для смены направления движения персонажа и его зеркального отражения
	/// </summary>
	private void Flip()
	{
		//меняем направление движения персонажа
		isFacingRight = !isFacingRight;
		//получаем размеры персонажа
		Vector3 theScale = transform.localScale;
		//зеркально отражаем персонажа по оси Х
		theScale.x *= -1;
		//задаем новый размер персонажа, равный старому, но зеркально отраженный
		transform.localScale = theScale;
	}
}