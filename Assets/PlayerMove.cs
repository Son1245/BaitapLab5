using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(new Vector2(h, v) * speed * Time.deltaTime);
    }

    // VA CHẠM VẬT LÝ
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Va chạm với: " + collision.gameObject.name);
    }

    // TRIGGER
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Đi vào Trigger: " + other.gameObject.name);
    }
}
