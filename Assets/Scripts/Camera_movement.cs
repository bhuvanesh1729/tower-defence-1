using UnityEngine;

public class Camera_movement : MonoBehaviour {


	public float scrollSpeed = 5f;
	public float minY = 10f;
	public float maxY = 80f;

	// Update is called once per frame
	void Update () {




		float scroll = Input.GetAxis("Mouse ScrollWheel");

		Vector3 pos = transform.position;

		pos.y -= scroll * 1000 * scrollSpeed * Time.deltaTime;
		pos.y = Mathf.Clamp(pos.y, minY, maxY);

		transform.position = pos;

	}
}
