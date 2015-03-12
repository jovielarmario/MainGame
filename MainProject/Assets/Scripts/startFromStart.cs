using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class startFromStart : MonoBehaviour {

	public LayerMask touchInputMask;
	private List<GameObject> touchList = new List<GameObject>();
	private GameObject[] touchesOld;
	
	// Update is called once per frame
	void Update () {
#if UNITY_EDITOR
		if(Input.GetMouseButtonDown(0)){
			touchesOld = new GameObject[touchList.Count];
			touchList.CopyTo(touchesOld);
			touchList.Clear();

			Ray ray = camera.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
				
			if(Physics.Raycast(ray,out hit,touchInputMask)){
			 	touchList.Add(gameObject);
				if(Input.GetMouseButtonDown(0)){
					GM.loadPage();
					Application.Quit();
				}
			}

		}
#endif
		if(Input.touchCount > 0){
			touchesOld = new GameObject[touchList.Count];
			touchList.CopyTo(touchesOld);
			touchList.Clear();

			foreach (Touch touch in Input.touches) {
				Ray ray = camera.ScreenPointToRay(touch.position);
				RaycastHit hit;

				if(Physics.Raycast(ray,out hit,touchInputMask)){
					touchList.Add(gameObject);
					if(touch.phase == TouchPhase.Began){
						Application.LoadLevel(0);
					}
				}
			}
		}
	}
}
