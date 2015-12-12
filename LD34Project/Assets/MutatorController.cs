using UnityEngine;
using System.Collections;

public class MutatorController : MonoBehaviour {

	Vector3 maximumSize;
	Vector3 minimumSize;

	bool growing = true;
	bool shrinking = false;

	void Start () {
		minimumSize = new Vector3 (
			PercentageFor (transform.localScale.x, Random.Range(60, 99)), 
			PercentageFor (transform.localScale.y, Random.Range(60, 99)), 
			PercentageFor (transform.localScale.z, Random.Range(60, 99)));

		maximumSize = new Vector3 (
			PercentageFor (transform.localScale.x, Random.Range(101, 160)), 
			PercentageFor (transform.localScale.y, Random.Range(101, 160)), 
			PercentageFor (transform.localScale.z, Random.Range(101, 160)));
	}

	void Update () {
		print (Vector3.Distance(transform.localScale,maximumSize));
		if (growing == true && shrinking == false) {
			transform.localScale = Vector3.Lerp (transform.localScale, maximumSize, Random.Range(0.05f, 0.2f));
			if (Vector3.Distance(transform.localScale,maximumSize) < .5) {
				growing = !growing;
				shrinking = !shrinking;
			}
		}

		if (growing == false && shrinking == true) {
			transform.localScale = Vector3.Lerp (transform.localScale, minimumSize, Random.Range(0.05f, 0.2f));
			if (Vector3.Distance(transform.localScale,minimumSize) < .5) {
				growing = !growing;
				shrinking = !shrinking;
			}
		}
			
	}	


	float PercentageFor(float value, float percentage){
		float onepercent = value / 100;
		return  onepercent * percentage;
	}
}
