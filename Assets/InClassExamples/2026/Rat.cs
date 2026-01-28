using UnityEngine;

RequireComponent
public class Rat : MonoBehaviour
{
    [SerializeField] private Animator ani;

    private void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0) // Right
        {
            transform.position += new Vector3(1, 0, 0) * Time.deltaTime;
            ani.Play("RatWalkingRight");
        }
        else if (Input.GetAxisRaw("Horizontal") < 0) // Left
        {
            transform.position += new Vector3(-1, 0, 0) * Time.deltaTime;
            ani.Play("RatWalkingLeft");
        }
        else // nothing
        {

        }
    }

}
