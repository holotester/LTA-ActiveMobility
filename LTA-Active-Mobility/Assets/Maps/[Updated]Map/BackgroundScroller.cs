using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public new BoxCollider2D collider;
    public Rigidbody2D rb;
    private float height;
    private readonly float scrollSpeed = -0.1f;

    //private int mapNumber;

    // Start is called before the first frame update
    void Start()
    {
        //start = true;

        collider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        
        height = collider.size.y;
        collider.enabled = false;

        rb.velocity = new Vector2(0, scrollSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        /*while (start == true)
        {
            mapNumber = Random.Range(0, 5);
            switch (mapNumber)
            {
                case 4:
                    TrafficLightJunction();
                    break;
                case 3:
                    TrafficLight();
                    break;
                case 2:
                    ZebraCross();
                    break;
                case 1:
                    Bridge();
                    break;
                default:
                    Normalroad();
                    break;
            }
        }*/

        if (transform.position.y < -height)
        {
            Vector2 resetPosition = new Vector2(0, height * 2f);
            transform.position = (Vector2)transform.position + resetPosition;
        }
    }

    /*void Normalroad()
    {
        if
    }*/

}