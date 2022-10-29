using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    public float speed;
    public Vector2 initialDirection;
    public LayerMask wallsLayer;
    

    public new Rigidbody2D rigidBody { get; private set; }
    public Vector2 dir { get; private set; }
    public Vector2 nextPos { get; private set; }
    public Vector3 spawnPos { get; private set; }

    private void Awake()
    {
        this.rigidBody = GetComponent<Rigidbody2D>();
        this.spawnPos = this.transform.position;
    }

    private void Start()
    {
        Reset();
    }
    
    private void FixedUpdate()
    {
        Vector2 pos = this.rigidBody.position;
        Vector2 translation = this.dir * this.speed * Time.fixedDeltaTime;
        this.rigidBody.MovePosition(pos + translation);
    }

    public void SetDir(Vector2 dir, bool forced = false)
    {
        if (forced || !Busy(dir))
        {
            this.dir = dir;
            this.nextPos = Vector2.zero;
        }
    }    

    public bool Busy(Vector2 dir)
    {
        RaycastHit2D Rhit = Physics2D.BoxCast(this.transform.position, Vector2.one * 0.70f, 0.0f, dir, 1.75f, this.wallsLayer);
        return Rhit.collider != null;
    }

    public void Reset()
    {
        this.dir = this.initialDirection;
        this.nextPos = Vector2.zero;
        this.transform.position = this.spawnPos;
        this.rigidBody.isKinematic = false;
        this.enabled = true;
    }
}
