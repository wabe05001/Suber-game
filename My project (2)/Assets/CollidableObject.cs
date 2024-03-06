using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidableObject : MonoBehaviour
{
    
    private Collider2D z_Collider;
    [SerializeField]
    private ContactFilter2D z_Filter;
    private List<Collider2D> z_CollidableObjects = new List<Collider2D>(1);

    private void Start()
    {
        z_Collider = GetComponent<Collider2D>();
    }

    private void Update()
    {
        z_Collider.OverlapCollider(z_Filter, z_CollidableObjects);
        foreach(var o in z_CollidableObjects)
        {
            Debug.Log("Collided with " + o.name);
        }
        
    }




}
