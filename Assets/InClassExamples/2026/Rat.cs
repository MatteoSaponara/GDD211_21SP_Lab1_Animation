using UnityEngine;

RequireComponent
public class Rat : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprRend;
    
    private Animator ani;
    private bool shouldFlipX;

    private void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0) // Right
        {
            transform.position += new Vector3(1, 0, 0) * Time.deltaTime;
            ani.Play("RatWalkingRight");

            if (sprRend.flipX)
                sprRend.flipX = false;

            shouldFlipX = false;
        }
        else if (Input.GetAxisRaw("Horizontal") < 0) // Left
        {
            transform.position += new Vector3(-1, 0, 0) * Time.deltaTime;
            ani.Play("RatWalkingLeft");

            if (sprRend.flipX == false)
                sprRend.flipX = true;
            shouldFlipX = true;
        }
        else // nothing
        {
            ani.Play("CatIdle");
            sprRend.flipX = shouldFlipX;
        }
    }

}
