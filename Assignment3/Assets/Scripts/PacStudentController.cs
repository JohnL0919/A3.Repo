using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{    
    public float speed = 8.0f;
    public float speedMultiplier = 1.0f;
    public Vector2 initialDirection;
    public LayerMask obstacleLayer;

    public Rigidbody2D rigidBody { get; private set; }
    public Vector2 dir { get; private set; }
    public Vector2 nextPos { get; private set; }
    public Vector3 spawnPos { get; private set; }



    void Awake()
    {
        this.rigidBody = GetComponent<Rigidbody2D>();
        this.spawnPos = this.transform.position;
    }

    void Start()
    {
        Reset();
    }
    
    private void FixedUpdate()
    {
        Vector2 pos = this.rigidBody.position;
        Vector2 translation = this.dir * this.speed * this.speedMultiplier * Time.fixedDeltaTime;
        
        this.rigidBody.MovePosition(pos + translation);
    }

    public void SetDir(Vector2 dir, bool forced = false)
    {
        if (forced || !Occupied(dir))
        {
            this.dir = dir;
            this.nextPos = Vector2.zero;
        }
        else
        {
            this.nextPos = dir;
        }
    }    
    
    private void Update()
    {
        if(this.nextPos != Vector2.zero)
        {
            SetDir(this.nextPos);   
        } 
    }


    public bool Occupied(Vector2 dir)
    {
        RaycastHit2D hit = Physics2D.BoxCast(this.transform.position, Vector2.one * 0.75f, 0.0f, dir, 1.5f, this.obstacleLayer);
        return hit.collider != null;
    }  
    
    public void Reset()
    {
        this.speedMultiplier = 1.0f;
        this.dir = this.initialDirection;
        this.nextPos = Vector2.zero;
        this.transform.position = this.spawnPos;
        this.rigidBody.isKinematic = false;
        this.enabled = true;
    }
}
