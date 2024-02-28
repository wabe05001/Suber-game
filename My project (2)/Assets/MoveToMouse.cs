using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveToMouse : MonoBehaviour
{   
    public static List<MoveToMouse> moveableObjects = new List<MoveToMouse>();
    public float speed = 5f;
    private Vector3 target;
    private bool selected;


    void Start(){
        moveableObjects.Add(this);
        target = transform.position;

    }

    void Update(){
        if(Input.GetMouseButtonDown(1))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
        }

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
       
       


        //transform.up - direction;
    }
    

    private void OnMouseDown() {
        selected = true;
        gameObject.GetComponent<SpriteRenderer>().color = Color.green;

        foreach(MoveToMouse obj in moveableObjects)
        {
            if(obj != this)
            {
                obj.selected = false;
                obj.gameObject.GetComponent<SpriteRenderer>().color = Color.white;

            }
        }
        

    }

    
}