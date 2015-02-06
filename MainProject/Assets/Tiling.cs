using UnityEngine;
using System.Collections;

[RequireComponent (typeof(SpriteRenderer))]
[RequireComponent (typeof(Rigidbody2D))]
public class Tiling : MonoBehaviour {
	
	public int offsetY = 2;			// the offset so that we don't get any weird errors
	public bool hasATopBuddy = false;
	public float speed = 0;
	
	private float spriteHeight = 0f;
	private Camera cam;
	private Transform myTransform;
	
	void Awake () {
		cam = Camera.main;
		myTransform = transform;
	}
	
	// Use this for initialization
	void Start () {
		SpriteRenderer sRenderer = GetComponent<SpriteRenderer>();
		spriteHeight = sRenderer.sprite.bounds.size.y;
	}
	
	// Update is called once per frame
	void Update () {
		// does it still need buddies? If not do nothing
		if (hasATopBuddy == false) {
			// calculate the cameras extend (half the width) of what the camera can see in world coordinates
			float camVerticalExtend = cam.orthographicSize * Screen.height / Screen.width;
			
			// calculate the x position where the camera can see the edge of the sprite (element)
			float edgeVisiblePositionTop = (myTransform.position.x + spriteHeight / 2) - camVerticalExtend;
			
			// checking if we can see the edge of the element and then calling MakeNewBuddy if we can
			if (cam.transform.position.y >= edgeVisiblePositionTop - offsetY && hasATopBuddy == false) {
				MakeNewBuddy ();
				hasATopBuddy = true;
			}
		}
	}
	
	// a function that creates a buddy on the side required
	void MakeNewBuddy () {
		// calculating the new position for our new buddy
		Vector3 newPosition = new Vector3 (myTransform.position.x , myTransform.position.y + spriteHeight, myTransform.position.z);
		// instantating our new body and storing him in a variable
		Transform newBuddy = Instantiate (myTransform, newPosition, myTransform.rotation) as Transform;
		newBuddy.rigidbody2D.AddForce (Vector2.up*-speed);

		newBuddy.parent = myTransform.parent;
		newBuddy.GetComponent<Tiling>().hasATopBuddy = true;
	}
}
