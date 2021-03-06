﻿using UnityEngine;
using System.Collections;

public class GM : MonoBehaviour {

	//this function holds the speed of the switching lanes of the rabbit and the turtle
	//this also holds the score and high score of the game
	public static float speedT = 55f;
	public static float speedR = 55f;
	public GUISkin theSkin;
	public static int score = 0;
	public static int high = 0;
	// Use this for initialization
	void Awake () {
		float xFactor = Screen.width / 600f;
		float yFactor = Screen.height  / 1024f;

		Camera.main.rect=new Rect(0,0,1,xFactor/yFactor); 
	}
	void Start () {
		speedR = speedT = 55f;
		score = 0;
		high = PlayerPrefs.GetInt ("High Score");
	}
	
	// Update is called once per frame
	public static void AddScore (string obj) {
		if (obj == "food")
			score += 1;
	}
	public static void highScore (){
		if(high < score){
			high = score;
			PlayerPrefs.SetInt("High Score",high);
		}
	}

	public static void ResetSpeed(){
		speedR = 55f;
		speedT = 55f;
	}

	public static void AddSpeed (string tag) {
		if(tag == "turtle"){
			speedT += 3f;
		}else{
			speedR += 3f;
		}
	}

	void OnGUI () {
		GUI.skin = theSkin;
		Color old = GUI.color;
		GUI.color = old;
		GUI.skin.label.fontSize = 62;
		GUI.Label (new Rect(Screen.width/2-50,Camera.main.orthographicSize*Screen.height/Screen.width,100,100), "" + score);
		GUI.skin.label.fontSize = 40;
		GUI.color = old;
		GUI.Label (new Rect(Screen.width/2-50,(Camera.main.orthographicSize*Screen.height/Screen.width)+50f,100,100), "" + high);
		GUI.skin.label.fontSize = 62;

	}

	public static void loadPage (){
		play.endTurn ();
		Time.timeScale = 0;
		Application.LoadLevel(0);
	}
	
}