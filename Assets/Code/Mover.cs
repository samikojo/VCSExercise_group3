using UnityEngine;

namespace TAMK.VCSExample
{
	public class Mover : MonoBehaviour
	{
		float yVelocity;
		bool grounded;


		// Movement speed
		[SerializeField]
		private float speed;
        [SerializeField]
        float rotationSpeed = 90f;


        void Update()
        {
            if (transform.position.y == 0.5)
            {
                grounded = true;
                yVelocity = 0;
            }
            else
            {
                grounded = false;
            }

            if (!grounded)
            {
                yVelocity -= 0.1f;
            }

            if (transform.position.y < 0.5f)
            {
                transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z);
                Debug.Log("AAA");
                yVelocity = 0;
            }

            if (Input.GetButtonDown("Jump") && grounded)
            {
                Debug.Log("Jump got, yVelocity is " + yVelocity);
                yVelocity = 1;
            }

            if (yVelocity < -1)
            {
                yVelocity = -1;
            }

			Rotate();

            transform.Translate(new Vector3(0, yVelocity, 0));
		
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
        
        void Rotate()
        {
            if(Input.GetButton("Rotation"))
            {
                float rotation = Input.GetAxis("Rotation") * rotationSpeed;
                transform.RotateAround(transform.position, transform.up, Time.deltaTime * rotation);
            }
            
        }
        
	}
}
