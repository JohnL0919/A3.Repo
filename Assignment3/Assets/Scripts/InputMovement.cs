using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMovement : MonoBehaviour
{
    public PacStudentController pacStudentController { get; private set; }

    void Start()
    {
        
    }

    void Awake()
    {
        this.pacStudentController = GetComponent<PacStudentController>();
    }

    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            this.pacStudentController.SetDirection(Vector2.up);
        }
        else if (Input.GetKeyDown("a"))
        {
            this.pacStudentController.SetDirection(Vector2.left);
        }
        else if (Input.GetKeyDown("d"))
        {
            this.pacStudentController.SetDirection(Vector2.right);
        }
        else if (Input.GetKeyDown("s"))
        {
            this.pacStudentController.SetDirection(Vector2.down);
        }


        float rotateAng = Mathf.Atan2(this.pacStudentController.direction.y, this.pacStudentController.direction.x);
        this.transform.rotation = Quaternion.AngleAxis(rotateAng * Mathf.Rad2Deg, Vector3.forward);
    }
}
