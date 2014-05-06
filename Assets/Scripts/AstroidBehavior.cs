using UnityEngine;
using System.Collections;

public class AstroidBehavior : MonoBehaviour {

	public float speed = 2;

	void Start()
	{
		speed = Random.Range (0.8f, 2.5f);
	}
	// Update is called once per frame
	void Update () {
		rigidbody2D.velocity = -1 * speed * Vector2.up;
	}
}
