#pragma strict
var paused : boolean = false;
public var Tpaused : GameObject;
public var speedr = 5f;
public var speedl = -5f;
private var isFalling = false;
public var TeleportEffect : Transform;
public var TeleportEffect2 : Transform;
var target : Transform;
var jumpHeight = 8;
var Jump:AudioClip;

function QuitGame () 
{
	Debug.Log ("Game is exiting...");
	Application.Quit ();
}

function Start () {
	Tpaused.SetActive (false);
}

function leftarrow ()
{
	GetComponent.<Rigidbody>().velocity.x = speedl;
	Debug.Log ("Going left...");
}

function rightarrow()
{
	GetComponent.<Rigidbody>().velocity.x = speedr;
	Debug.Log ("Going right...");
}

function uparrow()
{
	if (isFalling == false){
		GetComponent.<Rigidbody>().velocity.y = jumpHeight;
		GetComponent.<AudioSource>().PlayOneShot(Jump);
		isFalling = true;
		Debug.Log ("Jumping...");
	}
	
	else if (isFalling == false){
		GetComponent.<Rigidbody>().velocity.y = jumpHeight;
		GetComponent.<AudioSource>().PlayOneShot(Jump);
		isFalling = true;
	}
}

function OnCollisionStay (){
	isFalling = false;
}

function teleport()
{
	if (GameMaster.teleports <= 0)
		{
			Debug.Log("No more Teleports Left!");
		}
	else 
		{
			GameMaster.teleports -= 1;
			gameObject.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
			var effect = Instantiate(TeleportEffect, transform.position, transform.rotation);
			transform.Rotate(Vector3.right * Time.deltaTime);
			Destroy(effect.gameObject, 1.1);
		}
}

function pause()
{
	 if (paused == false)
        {
        	Debug.Log ("Pausing...");
                paused = true;
                Time.timeScale = 0;
                Tpaused.SetActive (true);
        }
     else if (paused == true)
        {
        		Debug.Log ("Pausing...");
                paused = false;
                Time.timeScale = 1;
                Tpaused.SetActive (false);
        }
}

function MainMenu()
{
	Application.LoadLevel("MainMenu");
	paused = false;
	Time.timeScale = 1;
}

function Playgame()
{
if(PlayerPrefs.HasKey("savedLevel")){
   // there is a saved level, load that one
   Application.LoadLevel(PlayerPrefs.GetString("savedLevel"));
}else{
   // no saved level, load the first one
   Application.LoadLevel("Level1");
 }
}

function LevelS()
{
	Application.LoadLevel("LevelSelect");
}
function LevelS2()
{
	Application.LoadLevel("LevelSelect2");
}
function Store()
{
	Application.LoadLevel("Store");
}
function Tutorial()
{
	Application.LoadLevel("Tutorial");
}
function Level1()
{
	Application.LoadLevel("Level1");
}
function Level2()
{
	Application.LoadLevel("Level2");
}
function Level3()
{
	Application.LoadLevel("Level3");
}
function Level4()
{
	Application.LoadLevel("Level4");
}
function Level5()
{
	Application.LoadLevel("Level5");
}
function Level6()
{
	Application.LoadLevel("Level6");
}
function Level7()
{
	Application.LoadLevel("Level7");
}
function Level8()
{
	Application.LoadLevel("Level8");
}
function Level9()
{
	Application.LoadLevel("Level9");
}
function Level10()
{
	Application.LoadLevel("Level10");
}
function Level11()
{
	Application.LoadLevel("Level11");
}
function Level12()
{
	Application.LoadLevel("Level12");
}

