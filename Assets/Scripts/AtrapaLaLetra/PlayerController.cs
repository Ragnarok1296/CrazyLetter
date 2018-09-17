using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour {

    public enum FACE_DIRECTION
    {
        LEFT = 1,
        RIGHT = -1
    };

    public FACE_DIRECTION direction = FACE_DIRECTION.RIGHT;

    public static PlayerController player = null;
    public bool canMove = true;

    public float maxSpeed = 40.0f;

    private string horizontalAxis = "Horizontal";

    private Rigidbody2D theRigibody = null;
    private Transform theTransform = null;
    public BoxCollider2D feetCollider = null;
    public LayerMask groundLayer;

    Animator animacion;


    void Awake()
    {
        animacion = GetComponent<Animator>();
        theRigibody = GetComponent<Rigidbody2D>();
        theTransform = GetComponent<Transform>();
        player = this;    
    }
    // Use this for initialization
    void Start () {
		
	}

    private void ChangeDirection()
    {
        direction = (FACE_DIRECTION)((int)direction * -1.0f);
        Vector3 localScale = theTransform.localScale;
        localScale.x *= -1.0f;
        theTransform.localScale = localScale;

    }

    void FixedUpdate()
    {
        float horizontal = CrossPlatformInputManager.GetAxis(horizontalAxis);
        //float horizontal = Input.GetAxis(horizontalAxis);
        
        animacion.SetFloat("speed", Mathf.Abs(horizontal));

        theRigibody.AddForce(Vector2.right * horizontal * maxSpeed);

        if ((horizontal < 0 && direction != FACE_DIRECTION.LEFT) || (horizontal > 0 && direction != FACE_DIRECTION.RIGHT))
            ChangeDirection();

        

        theRigibody.velocity = new Vector2(
            Mathf.Clamp(theRigibody.velocity.x, -maxSpeed, maxSpeed), 
            Mathf.Clamp(theRigibody.velocity.y, -Mathf.Infinity, 100)
            );
        

    }



    // Update is called once per frame
    void Update () {
		
	}
}
