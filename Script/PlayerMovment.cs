
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovment : MonoBehaviour
{
    public Rigidbody2D MyRigidbody;
    public Text CoinText;
    int numCoin;
    public float Speed;
    public float JumpSpeed;
    void Start()
    {
        MyRigidbody = GetComponent<Rigidbody2D>(); 
    }
    void Update()
    {
        MyRigidbody.velocity = new Vector2(Speed, MyRigidbody.velocity.y);
        if (Input.anyKeyDown)
        {
            MyRigidbody.velocity = new Vector2(MyRigidbody.velocity.x, JumpSpeed);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            UIManager.Instance.GameOver();
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Coin")
        {
            numCoin += 1;
            CoinText.text = numCoin.ToString();
            Destroy(collision.gameObject);
        }
    }

}

