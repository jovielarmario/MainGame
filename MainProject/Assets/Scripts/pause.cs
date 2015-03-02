using UnityEngine;
using System.Collections;

public class pause : MonoBehaviour {
	public float p = 1,duration;
	private bool toStart = false;
	private Color col;


	void Start () {

	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) { Application.Quit(); }
#if UNITY_EDITOR
		if (Input.GetMouseButtonDown(0))
		{
			Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector2 touchPos = new Vector2(wp.x, wp.y);
			if(toStart == false){
				if (collider2D == Physics2D.OverlapPoint(touchPos))
				{
					if(p == 1){
						p = Time.timeScale = 0;
					}else
						p = Time.timeScale = 1;
				}
			}
		}



#endif

		if (Input.touchCount > 0)
		{
			Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
			Vector2 touchPos = new Vector2(wp.x, wp.y);
			if(toStart == false){
				if (collider2D == Physics2D.OverlapPoint(touchPos))
				{
					if(p == 1){
						p = Time.timeScale = 0;
					}else
						p = Time.timeScale = 1;
				}
			}
		}
	}

}
