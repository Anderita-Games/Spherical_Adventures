#pragma strict
public static var vol : float = .75;
var music : AudioSource;
var mySlider: UnityEngine.UI.Slider;

function Start () {
	mySlider = GameObject.Find("Music Slider").GetComponent(UnityEngine.UI.Slider);
		if(PlayerPrefs.HasKey("vol2")){
  			music.volume = (PlayerPrefs.GetFloat("vol2"));
  			vol = (PlayerPrefs.GetFloat("vol2"));
  			mySlider.value = (PlayerPrefs.GetFloat("vol2"));
  		}else{
   			PlayerPrefs.SetFloat("vol2",vol);
   		}
}

function QuitGame () 
{
	Debug.Log ("Game is exiting...");
	Application.Quit ();
}

function StartGame () 
{
	Application.LoadLevel("level1");
}

function StartT () 
{
	Application.LoadLevel("Tutorial");
}

function SetGameVolume (vol : float) 
{
   		music.volume = vol;
   		PlayerPrefs.SetFloat("vol2",vol);
}