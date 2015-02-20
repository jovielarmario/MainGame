using UnityEngine;
using System.Collections;

public class respawn : MonoBehaviour {

	private Vector3 newPosition;
	public float delayMin=0, delayMax=0;
	private float delay =0, random = 0;
	private Transform newObject;
	private Transform myTransform;

	void Start () {
		newPosition = transform.position;
		myTransform = transform;
	}
	void Update () {
		random = Random.Range (0, 2);
		if(random < 0){
			newPosition = newPosition;
		}else
		{
			newPosition = new Vector3(newPosition.x - 1.4f, newPosition.y, newPosition.z);
		}
		delay = Random.Range (delayMin,delayMax);//.5 and 1
	}

	public IEnumerator makeObjects () {
		//for position
		random = Random.Range (0, 2);
		yield return new WaitForSeconds (delay);
		newObject = Instantiate (myTransform, newPosition, myTransform.rotation) as Transform;
		newObject.parent = myTransform.parent;
	}
	
	void destroyObjects () {
		
	}
}
