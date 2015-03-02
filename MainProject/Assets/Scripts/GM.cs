using UnityEngine;
using System.Collections;

public class GM : MonoBehaviour {

	public GUISkin theSkin;
	public float pos,pos2;
	public static int score = 0;
	public static int high = 0;
	// Use this for initialization
	void Awake () {
		float xFactor = Screen.width / 600f;
		float yFactor = Screen.height  / 1024f;

		Camera.main.rect=new Rect(0,0,1,xFactor/yFactor); 
	}
	void Start () {
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
	void OnGUI () {
		GUI.skin = theSkin;
		Color old = GUI.color;
		GUI.color = new Color (0, 0, 0, 1);
		GUI.skin.label.fontSize = 62;
		GUI.Label (new Rect(Screen.width/2-50,pos,100,100), "" + score);
		GUI.skin.label.fontSize = 40;
		GUI.color = old;
		GUI.Label (new Rect(Screen.width/2-50,pos2,100,100), "" + high);
		GUI.skin.label.fontSize = 62;

	}

	public static void loadPage (){
		Application.LoadLevel (0);
	}
	
}