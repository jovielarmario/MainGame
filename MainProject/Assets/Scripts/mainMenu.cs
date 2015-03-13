using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class mainMenu : MonoBehaviour {

	//this holds the whole play button and the menu to select
	public static bool start = true;
	public GameObject nam;
	public GameObject medal;
	
	void Start () {
		Time.timeScale = 0;
		StartCoroutine ("fade");
	}

	void Update () {
		if(!start){
			StartCoroutine("fade");
			start = true;
		}
		if(start){
			StartCoroutine("fade2");
			start = false;
		}
	}

	IEnumerator fade (){
		for(float i=0f; i<0.8f;i+=0.1f){
			renderer.material.color = new Color(1f,1f,1f,i);
			nam.renderer.material.color = new Color(1f,1f,1f,i);
			medal.renderer.material.color = new Color(1f,1f,1f,i);
			yield return new WaitForSeconds(0.09f);
		}
	}

	IEnumerator fade2 (){
		for(float i=0.8f; i>=0f;i-=0.1f){
			renderer.material.color = new Color(1f,1f,1f,i);
			nam.renderer.material.color = new Color(1f,1f,1f,i);
			medal.renderer.material.color = new Color(1f,1f,1f,i);
			yield return new WaitForSeconds(0.09f);
		}
		renderer.enabled = false;
		nam.renderer.enabled = false;
		medal.renderer.enabled = false;
	}
}
