// Ashley Maynez
// 09/22/2019
// CS 3410

using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb2d;
    public Text countText;
    private int count;
    public Text winText;
    public float totalTime = 60.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        count = 0;
        winText.text = "";
        countText.text = totalTime.ToString();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.velocity = movement * speed;
        
    }

    void Update()
    {
        totalTime -= Time.deltaTime;
        countText.text = totalTime.ToString();
        if (totalTime < 0)
        {
            winText.text = "GAMEOVER";
        }
 
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            if (count >= 6)
            {
                winText.text = "You win!";
            }
        }
    } 
}
