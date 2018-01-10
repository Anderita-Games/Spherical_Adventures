#pragma strict

var lvl = "MainMenu";
function OnTriggerEnter (info : Collider)
{
	if (info.name == "Ball")
	{
		Application.LoadLevel(lvl);
	}
}