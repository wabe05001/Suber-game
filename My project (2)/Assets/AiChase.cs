using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiChase : MonoBehaviour
{

    public GameObject player;
    public float speed;
    private float distance;

    //public int health = 100;

  //  public void TakeDamage(int damage)
    //{
       // health -= damage;
       // if(health <= 0)
       // {
       //     Die();
      //  }
  //  }

   // void Die ()
   // {
        
   //     Destroy(gameObject);
  //  }
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;

        var v = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);

        transform.position = new Vector3(v.x,v.y,transform.position.z);

        
    }

    
        
    
}
