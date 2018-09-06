using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocity : MonoBehaviour {

	public Vector3 vectorVelocidadBarco;
	public Vector3 vectorVelocidadCorriente;
	public Vector3 vectorVelocidadNeta;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		vectorVelocidadNeta = vectorVelocidadCorriente + vectorVelocidadBarco;

		Debug.DrawLine(Vector3.zero, vectorVelocidadCorriente, Color.yellow);
		Debug.DrawLine(Vector3.zero, vectorVelocidadBarco, Color.green);
		Debug.DrawLine(Vector3.zero, vectorVelocidadNeta, Color.blue);

		Vector3 vectorVelocidadNetaInCentimetre = vectorVelocidadNeta / 100;

		transform.position += vectorVelocidadNetaInCentimetre * Time.deltaTime;
	}
}
