using UnityEngine;

public class MovePlayer : MonoBehaviour
{
public float moveSpeed;
public Rigidbody2D rb;
private Vector3 velocity = Vector3.zero;

void FixedUpdate()
{
    float horizontalMovement = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
    float verticalMovement = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

    playerMove(horizontalMovement, verticalMovement);
}

void playerMove(float _horizontalMovement, float _verticalMovement)
{
    Vector3 targetVelocity = new Vector2(_horizontalMovement, _verticalMovement);
    rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, 0.05f);
}

}
