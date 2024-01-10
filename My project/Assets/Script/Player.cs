using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    //Touch input veriable
    private int leftFingerId, rightFingerId;
    private float halfScreenWidth;

    //Hammer posintion
    Vector3 PlayerPostion;

    // Start is called before the first frame update
    void Start()
    {
        //   finger is being tracked or not
        leftFingerId = -1;
        rightFingerId = -1;
        // calculate half width 
        halfScreenWidth = Screen.width / 2;

        PlayerPostion = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        
        keyboardInput();  
        GetTouchInput();
        // GameOver and Hammer Destroy  
        if (transform.position.x < -12)
        {
            Destroy(gameObject);
            print("Game Over");
            Time.timeScale = 0;
        }

    }

    
    void keyboardInput()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayerPostion = new Vector3(-8.27f, 3.4f, transform.position.z);
            transform.position = PlayerPostion;
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            PlayerPostion = new Vector3(-8.27f, -4, transform.position.z);
            transform.position = PlayerPostion;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, 0, -67);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
    void GetTouchInput()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch touch = Input.GetTouch(i);
            // Check each touch's phase
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (touch.position.x < halfScreenWidth && leftFingerId == -1)
                    {                       
                        //Tracking left finger
                        leftFingerId = touch.fingerId;
                        PlayerPostion = new Vector3(-8.27f, 3.4f, transform.position.z);
                        transform.position = PlayerPostion;
                        print("Left finger");

                    }
                    else if (touch.position.x > halfScreenWidth && rightFingerId == -1)
                    {
                        //Tracking Right finger
                        rightFingerId = touch.fingerId;
                        transform.rotation = Quaternion.Euler(0, 0, -67);
                        print("Right finger");
                    }
                    break;

                case TouchPhase.Ended:
                case TouchPhase.Canceled:
                    if (touch.fingerId == leftFingerId)
                    {
                        // Stop tracking the left finger
                        leftFingerId = -1;
                        PlayerPostion = new Vector3(-8.27f, -4, transform.position.z);
                        transform.position = PlayerPostion;
                        Debug.Log("Stopped tracking left finger");
                    }
                    else if (touch.fingerId == rightFingerId)
                    {
                        // Stop tracking the right finger
                        rightFingerId = -1;
                        transform.rotation = Quaternion.Euler(0, 0, 0);
                        Debug.Log("Stopped tracking right finger");
                    }

                    break;
            }
        }
    }
}
