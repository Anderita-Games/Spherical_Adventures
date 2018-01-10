#pragma strict
var target : GameObject;
public var TeleportEffect : Transform;
public var TeleportEffect2 : Transform;
var maxFallDistance = -175;
var lvl1 = "Level1";


function Update () 
{
	if (Input.GetKeyDown (KeyCode.R)){
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
	if (transform.position.y <= maxFallDistance)
	{
		if (GameMaster.teleports <= 0)
		{
			Application.LoadLevel(lvl1);
		}
		else 
		{
			GameMaster.teleports -= 1;
			gameObject.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
			var effect2 = Instantiate(TeleportEffect, transform.position, transform.rotation);
			transform.Rotate(Vector3.right * Time.deltaTime);
			Destroy(effect2.gameObject, 1.1);
		}
	}
}
function OnCollisionEnter(col : Collision) {
     if (col.collider.name == "Barrel" ) {
         	GameMaster.teleports -= 1;
			gameObject.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
			var effect3 = Instantiate(TeleportEffect, transform.position, transform.rotation);
			transform.Rotate(Vector3.right * Time.deltaTime);
			Destroy(effect3.gameObject, 1.1);
     }
 }