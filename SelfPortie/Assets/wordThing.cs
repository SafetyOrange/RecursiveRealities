using UnityEngine;
using System.Collections;

public class wordThing : MonoBehaviour {

	string type;
	public GameObject main;
	bool init =false;
	float speed;

	// Use this for initialization
	void Start () {
		main = GameObject.Find("Main Camera");
		transform.position=main.transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {

		if(!init){
			speed=Random.Range(.35f,.6f);

			float screenX = Random.Range(-80,80)+main.camera.pixelWidth/2;
			float screenY = Random.Range(-80,80)+main.camera.pixelHeight/2;
			float ScreenZ = Random.Range(-80,80)+main.camera.farClipPlane/4;
			Vector3 point = main.camera.ScreenToWorldPoint(new Vector3(screenX, screenY, ScreenZ));
			transform.position=point;
			init=true;
		}

		if(init){
			transform.position+= new Vector3(0,0,-speed);
			transform.rotation = Quaternion.LookRotation(main.transform.position) * Quaternion.Euler(0, 180, 0);
		}
	
	}
}
