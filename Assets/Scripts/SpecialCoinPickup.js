#pragma strict

var coinEffect : Transform;

function OnTriggerEnter (info : Collider)
{
	if (info.name == "Ball")
	{
		GameMaster.specialScore += 1;
		var effect = Instantiate(coinEffect, transform.position, transform.rotation);
		Destroy(effect.gameObject, 3);
		Destroy(gameObject);
	}
}