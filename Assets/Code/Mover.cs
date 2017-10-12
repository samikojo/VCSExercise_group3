using UnityEngine;

namespace TAMK.VCSExample
{
	public class Mover : MonoBehaviour
	{
       [SerializeField]
       float rotationSpeed = 90f;


		void Update()
		{
            Rotate();
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
