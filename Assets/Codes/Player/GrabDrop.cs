using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabDrop : MonoBehaviour
{
    public Transform grabPoint;
    private GameObject itemGrabed;

    public Vector3 Direction { get; set; }
    public LayerMask Grablers;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (itemGrabed)
            {
                itemGrabed.transform.position = transform.position + Direction;
                itemGrabed.transform.parent = null;
                if (itemGrabed.GetComponent<Rigidbody2D>())
                    itemGrabed.GetComponent<Rigidbody2D>().simulated = true;
                itemGrabed = null;
            }
            else
            {
                Collider2D pickedUp = Physics2D.OverlapCircle(transform.position + Direction, .4f, Grablers);

                if (pickedUp)
                {
                    itemGrabed = pickedUp.gameObject;
                    itemGrabed.transform.localPosition = grabPoint.position;
                    itemGrabed.transform.parent = transform;
                    if (itemGrabed.GetComponent<Rigidbody2D>())
                        itemGrabed.GetComponent<Rigidbody2D>().simulated = false;
                }
            }
        }
    }
}