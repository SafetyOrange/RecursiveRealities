using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Handle : MonoBehaviour {
	
	List<string> dap;


	// Use this for initialization
	void Start () {

		dap= new List<string>();

		dap.Add("Hot");
		dap.Add("Sweaty");
		dap.Add("Greasy");
		dap.Add("Loud");
		dap.Add("Fucking");
		dap.Add("Shitty");
		dap.Add("Warzone");
		dap.Add("Word Bullets");
		dap.Add("Money");
		dap.Add("Cramped");
		dap.Add("Screaming");
		dap.Add("Drunk");
		dap.Add("Kyle");
		dap.Add("People");
		dap.Add("FUCKING");
		dap.Add("Yuppie");
		dap.Add("Vomit");
		dap.Add("Socialite");
		dap.Add("Rude");
		dap.Add("Forgettable");
		dap.Add("Yelling");
		dap.Add("Loser");
		dap.Add("Cringe");
		dap.Add("Fake Smiles");
		dap.Add("Silence");
		dap.Add("Busy");
		dap.Add("Can't.");
		dap.Add("Nah.");
		dap.Add("Fuck Nah.");
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.anyKeyDown){
			audio.Play();
			Destroy(GameObject.Find("T1"));
			Destroy(GameObject.Find("T2"));
			for(int i = 0; i < 200; i++){
				GameObject F = (GameObject)Instantiate(Resources.Load("Word"));
				F.GetComponent<TextMesh>().text=dap[Random.Range(0, dap.Count)];
			}
		}

		if(audio.time>=13.25f && !GameObject.Find("Main Camera").audio.isPlaying){
			GameObject.Find("Main Camera").audio.Play();
			GameObject.Find("New Text").GetComponent<MeshRenderer>().enabled = true;
	}
}
}
