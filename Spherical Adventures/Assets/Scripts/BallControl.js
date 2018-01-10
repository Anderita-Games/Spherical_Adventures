#pragma strict
var jumpHeight = 8;
var Jump:AudioClip;
var target : Transform;
private var isFalling = false;
function Update () 
{
	
	if (Input.GetKeyDown (KeyCode.W) && isFalling == false){
		GetComponent.<Rigidbody>().velocity.y = jumpHeight;
		GetComponent.<AudioSource>().PlayOneShot(Jump);
		isFalling = true;
	}
	
	else if (Input.GetKeyDown (KeyCode.Space) && isFalling == false){
		GetComponent.<Rigidbody>().velocity.y = jumpHeight;
		GetComponent.<AudioSource>().PlayOneShot(Jump);
		isFalling = true;
	}
}

function OnCollisionStay (){
	isFalling = false;
}
