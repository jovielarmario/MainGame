using UnityEngine;
using System.Collections;

[RequireComponent (typeof(SpriteRenderer))]
[RequireComponent (typeof(Rigidbody2D))]
public class Tiling : MonoBehaviour {

	//this holds the function for infinite looking track and bushes

	public int offsetY = 2;
	public bool reverseScale = false;

	private float spriteHeight = 0f, old, speed;
	private Camera cam;
	private Transform myTransform;
	private bool hasATopBuddy = false;
	private bool hasABottomBuddy = false;
	public int delayTime = 0;
	private float camVerticalExtend;
	
	void Awake () {
		cam = Camera.main;
		camVerticalExtend = cam.orthographicSize * Screen.height / Screen.width;
		myTransform = transform;
	}
	
	// Use this for initialization
	void Start () {
		SpriteRenderer sRenderer = GetComponent<SpriteRenderer>();
		spriteHeight = sRenderer.sprite.bounds.size.y;
	}
	
	// Update is called once per frame
	void Update () {
		// calculate the cameras extend (half the width) of what the camera can see in world coordinates
		
		// calculate the x position where the camera can see the edge of the sprite (element)
		float edgeVisiblePositionTop = (myTransform.position.y + spriteHeight / 2) - camVerticalExtend;

		if (cam.transform.position.y >= edgeVisiblePositionTop - offsetY) {
			// checking if we can see the edge of the element and then calling MakeNewBuddy if we can
			if(hasATopBuddy == false){
				MakeNewBuddy ();
				hasATopBuddy = true;
				hasABottomBuddy = true;
			}
		}

		if(spriteHeight + offsetY <= -1*(myTransform.position.y)  && hasABottomBuddy == true){
			Destroy(myTransform.gameObject);
		}

	}
	
	// a function that creates a buddy on the side required
	void MakeNewBuddy () {

		// calculating the new position for our new buddy
		Vector3 newPosition = new Vector3 (myTransform.position.x , myTransform.position.y + spriteHeight, myTransform.position.z);
		// instantating our new body and storing him in a variable
		Transform newBuddy = Instantiate (myTransform, newPosition, myTransform.rotation) as Transform;
		if (reverseScale == true) {
			newBuddy.localScale = new Vector3 (newBuddy.localScale.x, newBuddy.localScale.y*-1, newBuddy.localScale.z);
		}

		newBuddy.parent = myTransform.parent;
		newBuddy.GetComponent<Tiling> ().hasATopBuddy = false;
		newBuddy.GetComponent<Tiling> ().hasABottomBuddy = false;

	}

}
