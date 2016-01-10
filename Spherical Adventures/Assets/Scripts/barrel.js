#pragma strict
var target2 : GameObject;
public var TeleportEffect3 : Transform;
public var TeleportEffect4 : Transform;
var maxFallDistance2 = -1;

function Update () 
{
	if (transform.position.y <= maxFallDistance2)
	{
			gameObject.transform.position = Vector3(target2.transform.position.x, target2.transform.position.y, target2.transform.rotation.x);
			TeleportEffect4 = Instantiate(TeleportEffect3, transform.position, transform.rotation);
			transform.Rotate(Vector3.right * Time.deltaTime);
			Destroy(TeleportEffect4.gameObject, 1.1);
	}
}
