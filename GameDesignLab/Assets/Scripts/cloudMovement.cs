using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class cloudMovement : MonoBehaviour
{

      [SerializeField] bool goingLeft= false;
      [SerializeField] bool isFacingRight = true;
      float scale = 0.20f;


  // ???
     public int currentLevel;
      // Start is called before the first frame update
      void Start()
      {
        currentLevel=SceneManager.GetActiveScene().buildIndex;


      }

      // Update is called once per frame
      void Update()
      {

      }


      void Flip()
    {
      transform.Rotate(0, 180, 0);
      isFacingRight = !isFacingRight;
    }


      void moveLeft()
      {
        transform.Translate(Vector2.left * Time.deltaTime);
      }

      void moveRight()
      {
        transform.Translate(Vector2.right * Time.deltaTime);

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





      void OnCollisionEnter2D (Collision2D collision)
    {
      if (collision.gameObject.tag == "boundaryL")
        goingLeft=false;


      if (collision.gameObject.tag == "boundaryR")
        goingLeft=true;



}

private void OnTriggerEnter2D (Collider2D collision){
if (collision.gameObject.tag == "knife"){
scale += 0.1f;
transform.localScale = new Vector2(scale, scale);
// Destroy(GameObject.FindWithTag("knife"));
Destroy(collision.gameObject);
}

}
}
