#pragma strict
var rotationSpeed = 100;
var moveSpeed = 1f;
var target : Transform;

function Update () {
	//Handle ball rotation
	var rotation : float = Input.GetAxis ("Horizontal") * rotationSpeed;
	rotation *= Time.deltaTime;
	GetComponent.<Rigidbody>().AddRelativeTorque (Vector3.back * rotation);
}