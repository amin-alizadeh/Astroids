using UnityEngine;
using System.Collections;

public class RocketBehavior : MonoBehaviour {

	public float speed = 5f;
	public AudioClip explosionSFX;

	private Animator anim;

	void Start()
	{
		anim = GetComponent<Animator>();
	}

	void Update()
	{
		rigidbody2D.velocity = speed * Vector2.up;
	}

	void OnCollisionEnter2D(Collision2D theCollision)
	{
		if(theCollision.gameObject.tag == "Asteroid")
		{
			anim.SetTrigger("Explode");
//			Destroy (gameObject);
			Destroy (theCollision.gameObject);
			AudioSource.PlayClipAtPoint(explosionSFX, transform.position);
		}
	}
}
