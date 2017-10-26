using UnityEngine;
using System.Collections;

public class CubeScript : MonoBehaviour {
    public float rotateSpeed;
    public Vector3 spinSpeed;
    Vector3 spinAxis;


	void Start () {

	}
	

    public void SetSize (float size)
    {
          this.transform.localScale = new Vector3(size, size, size);
    }

	// Update is called once per frame
	void Update () {

        this.transform.Rotate(spinSpeed);
        this.transform.RotateAround(Vector3.zero, spinAxis, rotateSpeed);
	}
}
