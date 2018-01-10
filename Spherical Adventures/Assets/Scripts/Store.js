#pragma strict
//ALL THE FREAKING BALLS
public var ball : GameObject;
var ball2 : GameObject;
var ball3 : GameObject;
var ball4 : GameObject;
var ball5 : GameObject;
var ball6 : GameObject;
var ball7 : GameObject;
var ball8 : GameObject;
var ball9 : GameObject;
var ball10 : GameObject;
var ball11 : GameObject;
var ball12 : GameObject;
var ball13 : GameObject;
var ball14 : GameObject;
var ball15 : GameObject;
var ball16 : GameObject;
var ball17 : GameObject;
var ball18 : GameObject;
var ball19 : GameObject;
var ball20 : GameObject;
//Teleport locations
var target : GameObject;
var target2 : GameObject;
static var BallN : int = 0;
var switch2: int;

function start() {
	BallN = PlayerPrefs.GetInt("Ball");
}
function update() {
	PlayerPrefs.SetInt("Ball", BallN);
}

function right() {
	if(switch2 == 1){
		BallN += 1;
		switch2 = 0;
	}
	if(PlayerPrefs.GetInt("Ball") <= 1) {
		ball.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	if(BallN == 0) {
		BallN = 1;
		ball.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball2.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 1) {
		BallN = 2;
		ball2.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball3.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 2) {
		BallN = 3;
		ball3.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball4.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 3) {
		BallN = 4;
		ball4.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball5.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 4) {
		BallN = 5;
		ball5.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball6.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 5) {
		BallN = 6;
		ball6.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball7.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 6) {
		BallN = 7;
		ball7.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball8.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 7) {
		BallN = 8;
		ball8.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball9.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 8) {
		BallN = 9;
		ball9.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball10.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 9) {
		BallN = 10;
		ball10.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball11.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 10) {
		BallN = 11;
		ball11.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball12.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 11) {
		BallN = 12;
		ball12.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball13.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 12) {
		BallN = 13;
		ball13.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball14.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 13) {
		BallN = 14;
		ball14.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball15.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 14) {
		BallN = 15;
		ball15.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball16.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 15) {
		BallN = 16;
		ball16.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball17.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 16) {
		BallN = 17;
		ball17.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball18.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 17) {
		BallN = 18;
		ball18.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball19.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 18) {
		BallN = 19;
		ball19.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball20.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 19) {
		BallN = 0;
		ball20.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
}


	function left() {
	if(switch2 == 0){
		switch2 = 1;
		if(BallN == 0){
			BallN = 19;
		}
		else{
			BallN -= 1;
		}
	}
	if(PlayerPrefs.GetInt("Ball") <= 1) {
		ball.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	if(BallN == 19) {
		BallN = 18;
		ball.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball20.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 18) {
		BallN = 17;
		ball20.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball19.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 17) {
		BallN = 16;
		ball19.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball18.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 16) {
		BallN = 15;
		ball18.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball17.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 15) {
		BallN = 14;
		ball17.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball16.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 14) {
		BallN = 13;
		ball16.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball15.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 13) {
		BallN = 12;
		ball15.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball14.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 12) {
		BallN = 11;
		ball14.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball13.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 11) {
		BallN = 10;
		ball13.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball12.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 10) {
		BallN = 9;
		ball12.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball11.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 9) {
		BallN = 8;
		ball11.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball10.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 8) {
		BallN = 7;
		ball10.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball9.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 7) {
		BallN = 6;
		ball9.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball8.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 6) {
		BallN = 5;
		ball8.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball7.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 5) {
		BallN = 4;
		ball7.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball6.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 4) {
		BallN = 3;
		ball6.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball5.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 3) {
		BallN = 2;
		ball5.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball4.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 2) {
		BallN = 1;
		ball4.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball3.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 1) {
		BallN = 0;
		ball3.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball2.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
	else if(BallN == 0) {
		BallN = 19;
		ball2.transform.position = Vector3(target2.transform.position.x, target.transform.position.y, target.transform.rotation.x);
		ball.transform.position = Vector3(target.transform.position.x, target.transform.position.y, target.transform.rotation.x);
	}
}