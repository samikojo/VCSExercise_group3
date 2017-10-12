using UnityEngine;

namespace TAMK.VCSExample
{
	public class Mover : MonoBehaviour
	{

		// Movement speed
		[SerializeField]
		private float speed;

		void Update()
		{
			if (Input.GetKey (KeyCode.W)) {
				transform.Translate (Vector3.forward * Time.deltaTime * speed);
			} else if (Input.GetKey(KeyCode.S)) {
				transform.Translate (Vector3.back * Time.deltaTime * speed);
			}

			if (Input.GetKey (KeyCode.A)) {
				transform.Translate (Vector3.left * Time.deltaTime * speed);
			} else if (Input.GetKey(KeyCode.D)) {
				transform.Translate (Vector3.right * Time.deltaTime * speed);
			}


		}
	}
}
