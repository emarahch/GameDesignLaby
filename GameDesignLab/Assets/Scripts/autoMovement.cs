using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class autoMovement : MonoBehaviour
{


  	[SerializeField] bool goingLeft= false;
    [SerializeField] bool isFacingRight = true;
    public int nextSceneLevel;
    public int speed=1;

    float scale = 0.20f;
    int points=9;

   public int currentLevel;
    // Start is called before the first frame update

    private void Awake() {
        nextSceneLevel= SceneManager.GetActiveScene().buildIndex + 1;
    }


    void Start()
    {
      // audioPlayer = GetComponent<AudioSource>();
      currentLevel=SceneManager.GetActiveScene().buildIndex;
    }




    // Update is called once per frame
    void Update()
    {
          inflatey();

    }


    void Flip()
  {
    transform.Rotate(0, 180, 0);
    isFacingRight = !isFacingRight;
  }


    void moveLeft()
    {
      transform.Translate(Vector2.left * Time.deltaTime);
      if (currentLevel==5){
      fleeingAlgo();
    }
    }

    void moveRight()
    {
      transform.Translate(Vector2.right * Time.deltaTime);
      if (currentLevel==5){
      fleeingAlgo();
    }

    }


    void FixedUpdate()
   {
    // rigid.velocity = new Vector2(movement * speed, rigid.velocity.y);
    if (goingLeft)
      // Flip();
      moveLeft();

    if(!goingLeft)
     // Flip();
     moveRight();




   }




//Balloon Inflation throughout the game
 void inflatey()
    {
if (currentLevel==4){
        scale += 0.05f * Time.deltaTime;
        transform.localScale = new Vector2(scale, scale);
}

if (currentLevel==5){
        scale += 0.09f * Time.deltaTime;
        transform.localScale = new Vector2(scale, scale);
        // fleeingAlgo();
}

if (currentLevel==6){
        scale += 0.15f * Time.deltaTime;
        transform.localScale = new Vector2(scale, scale);
}

       if (scale >= 1f){
        Destroy(gameObject);
        SceneManager.LoadScene(currentLevel);
      }

    }




    void OnCollisionEnter2D (Collision2D collider)
  {
    if (collider.gameObject.tag == "boundaryL")
      goingLeft=false;

    if (collider.gameObject.tag == "boundaryR")
      goingLeft=true;




  }


   public void OnTriggerEnter2D (Collider2D collider)
    {
  if (collider.gameObject.tag == "knife"){
      if(scale>=0.80f){
        points=1;
        FindObjectOfType<scoreKeeper>().AddPoints(points); // Find the Score script and tell it to increase the score
        Destroy(gameObject);


      }
       if(scale<0.80f){
        points=5;
        FindObjectOfType<scoreKeeper>().AddPoints(points); // Find the Score script and tell it to increase the score
        Destroy(gameObject);


      }

      SceneManager.LoadScene(nextSceneLevel);
      }


  }


public void fleeingAlgo(){
  //from unity
//  move sprite towards the target location
// transform.position = Vector2.MoveTowards(transform.position, target, step);
//https://blog.csdn.net/weixin_44728750/article/details/126913862


var player = GameObject.Find("basic1");
transform.position = transform.position = Vector2.MoveTowards(transform.position, -player.transform.position, speed * Time.deltaTime);

  // Vector3 dir = (transform.position - player.transform.position).normalized;
  // transform.Translate(dir * Time.deltaTime);

}

}
