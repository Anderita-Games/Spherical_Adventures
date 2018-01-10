#pragma strict

static var currentScore : int = 10;
static var specialScore : int = 0;
static var teleports : int = 5;
static var zero : int = 0; 
static var TextWidth : int = Screen.width/4;
public static var savedLevel : String;
var sizeX : float = 200;
var sizeY : float = 100;
var lvl = "MainMenu";
var w = Screen.width/2;
function Start () {
	currentScore = 10;
	specialScore = 0;
	teleports = 5;
	Debug.Log (Application.loadedLevelName);
}

function Update () 
{
	if (currentScore <= 0)
		{
			if(Time.timeSinceLevelLoad <= PlayerPrefs.GetInt("Best" + Application.loadedLevelName)){
				PlayerPrefs.SetInt("Best" + Application.loadedLevelName, Time.timeSinceLevelLoad);
				Application.LoadLevel(lvl);
				//saving playerPrefs
				PlayerPrefs.SetString("savedLevel",lvl);
			}
			else if(zero <= PlayerPrefs.GetInt("Best" + Application.loadedLevelName)){
				PlayerPrefs.SetInt("Best" + Application.loadedLevelName, Time.timeSinceLevelLoad);
				Application.LoadLevel(lvl);
				//saving playerPrefs
				PlayerPrefs.SetString("savedLevel",lvl);
			}
			else{
				Application.LoadLevel(lvl);
				//saving playerPrefs
				PlayerPrefs.SetString("savedLevel",lvl);
			}
		}
}
  
	

function OnGUI () {
	GUI.skin.box.fontSize = Screen.width/80;
	 //Boxes
	GUI.Box (new Rect (Screen.width-(Screen.width*.12), 0, Screen.width/8, Screen.height/16), "Coins Left: " + currentScore);
	GUI.Box (new Rect (0, 0, Screen.width/8, Screen.height/16), "Special Coins: " + specialScore + "/3");
	GUI.Box (new Rect ((Screen.width/8) + 10, 0, Screen.width/8, Screen.height/16), "Teleports Left: " +  teleports);
	GUI.Box (new Rect ((Screen.width/8) + 20 + (Screen.width/8), 0, Screen.width/6, Screen.height/16), "Current Time: " + Time.timeSinceLevelLoad);
	if(zero >= PlayerPrefs.GetInt("Best" + Application.loadedLevelName)){
		GUI.Box (new Rect ((Screen.width/8) + (Screen.width/8) + (Screen.width/6) + 30, 0, Screen.width/6, Screen.height/16), "No best time!!!");
	}
	else if(zero <= PlayerPrefs.GetInt("Best" + Application.loadedLevelName)){
		GUI.Box (new Rect ((Screen.width/8) + (Screen.width/8) + (Screen.width/6) + 30, 0, Screen.width/6, Screen.height/16), "Best Time: " + PlayerPrefs.GetInt("Best" + Application.loadedLevelName) + " seconds");
	}
}