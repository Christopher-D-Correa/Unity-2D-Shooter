using UnityEngine;
using System.Collections;
public class PlayerInput : MonoBehaviour
{
    [SerializeField] private Player player;
    public static Camera mainCamera;
    public bool isSpinning = false;
    public Vector2 direction;
    public Vector3 mousePosition;
    public Vector3 lookDirection;
    //Create starting point for position of mouse on the screen in pixels
    //Pixels go from bottom left to top right 
    public IEnumerator Deathblossom()
    {
        float timer = Time.time + 2f;
        while (isSpinning == true)
        {
            Vector3 rot = transform.localEulerAngles;
            rot.z += 1.5f;
            transform.localEulerAngles = rot;

            if (gameObject.tag == "Enemy")
            {
                Destroy(gameObject); 
            }

            if (Time.time > timer)
            {
                isSpinning = false;
            }
            yield return new WaitForEndOfFrame();


        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isSpinning)
        {

            direction.x = Input.GetAxis("Horizontal");
            direction.y = Input.GetAxis("Vertical");
            player.Move(direction);


            mousePosition = Input.mousePosition;
            //This gives us the position of the mouse on the screen in pixels
            //Pixels go from bottom left to top right
            mousePosition.z = 10;
            Vector3 destination = Camera.main.ScreenToWorldPoint(mousePosition);
            lookDirection = destination - transform.position;
            player.Look(lookDirection);
            //shortcut to access main camera in game
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isSpinning = true;
                StartCoroutine(Deathblossom());
                  

        
            }


            if (Input.GetMouseButtonDown(0))
            {
                player.Attack();
                //start shooting 
            }

            if (Input.GetMouseButtonUp(0))
            {
                //stop shooting 
            }

            /*if (Input.GetMouseButtonDown(1))
             {
                 player.ShootlightOrb();
             }
            */
         }

            


            //Above commands enable us to move the player up/down/left/right



        }   

   

    private void FixedUpdate()
    {

    }
}
