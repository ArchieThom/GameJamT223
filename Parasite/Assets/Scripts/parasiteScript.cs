using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parasiteScript : MonoBehaviour
{
    public GameObject radius;
    public GameObject scope;
    Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            radius.GetComponent<SpriteRenderer>().color = new Color32(117, 255, 64, 13);
            scope.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);

            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = scope.transform.position.z;

            //Credit: https://forum.unity.com/threads/making-the-player-face-the-direction-of-the-cursor.937859/
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

            direction = mousePosition - scope.transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            scope.transform.rotation = Quaternion.Euler(0, 0, angle);
        }
        else if (Input.GetKeyUp("space"))
        {
            radius.GetComponent<SpriteRenderer>().color = new Color32(0, 0, 0, 0);
            scope.GetComponent<SpriteRenderer>().color = new Color32(0, 0, 0, 0);
            RaycastHit other;
            Debug.DrawRay(transform.position, direction);
            Debug.Log(direction);
            if (Physics.Raycast(transform.position, direction, out other))
            {
                Debug.Log("Ray hit");
                transform.position = other.transform.position;
            }
        }

    }
}
