using UnityEngine;
using System.Collections;

public class play : MonoBehaviour {

	//this holds the function for calling the effect of play button on the main menu
	// Update is called once per frame
	void Update () {

		#if UNITY_EDITOR
		if (Input.GetMouseButtonDown(0))
		{
			Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector2 touchPos = new Vector2(wp.x, wp.y);
			if (collider2D == Physics2D.OverlapPoint(touchPos))
			{
				mainMenu.start = false;
				Time.timeScale = 1;
				renderer.enabled = false;
			}
		}
		
		
		
		#endif
		
		if (Input.touchCount > 0)
		{
			Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
			Vector2 touchPos = new Vector2(wp.x, wp.y);
			if (collider2D == Physics2D.OverlapPoint(touchPos))
			{
				mainMenu.start = false;
				Time.timeScale = 1;
				renderer.enabled = false;
			}
		}
	}

	public static void endTurn(){
		mainMenu.start = true;
	}
}
