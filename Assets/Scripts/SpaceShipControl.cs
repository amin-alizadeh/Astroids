using UnityEngine;
using System.Collections;

public class SpaceShipControl : MonoBehaviour {
	public float speed = 4f;
	public float smooth = 5f;
	public Transform leftBoundary;
	public Transform rightBoundary;

	public GameObject rocketPrefab;
	public Transform rocketSpawnPoint1;
	public Transform rocketSpawnPoint2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis("Horizontal");
//		transform.position += h * speed * smooth * Time.deltaTime * Vector3.right;
//		return;
		if(h < 0)
		{
			//left
			ApplyForce (-Vector2.right);
		}
		else if(h > 0)
		{
			//right
			ApplyForce (Vector2.right);
		}

		if(Input.GetKeyDown(KeyCode.Space))
		{
			FireRockets();
		}

	}

	void FireRockets()
	{
		Instantiate (rocketPrefab, rocketSpawnPoint1.position, rocketSpawnPoint1.rotation);
		Instantiate (rocketPrefab, rocketSpawnPoint2.position, rocketSpawnPoint2.rotation);
	}

	void ApplyForce(Vector2 direction)
	{
		if (transform.position.x < rightBoundary.position.x && transform.position.x > leftBoundary.position.x)
		{
			rigidbody2D.AddForce (direction * speed);
		}
		else
		{
			rigidbody2D.velocity = -direction;
			rigidbody2D.AddForce (-2 * direction * speed);
		}
	}

	void OnCollision2D (Collision2D other)
	{

	}
}
