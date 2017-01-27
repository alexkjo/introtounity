using UnityEngine;
using System.Collections;

public class rotation : MonoBehaviour {
    public float speed = 1.5f;

	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
	}
}
