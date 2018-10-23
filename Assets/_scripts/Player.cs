using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float movementSpeed;
    public float movementSpeedMulti = 1;
    float movementSpeedDelta;
    public float attackSpeed = 3f;
    public float speedOfAttack = 3f;


    public float candyCount;
    public Animator animPlayer;

    public Rigidbody rigid;

    public bool takesDamage;
    public bool Attacking;

    public GameObject player;
    public GameObject candyBag;


    void Start()
    {
        candyCount = 0;
		rigid = GetComponent<Rigidbody>();
        movementSpeedDelta = movementSpeed;
        animPlayer.SetFloat("Speed", 0);
        takesDamage = false;
        candyBag.transform.localScale = new Vector3(1, 1, 1);
    }

    void Update()
    {
        PlayerController();

        if (candyCount >= 5)
        {
            candyBag.transform.localScale = new Vector3(2, 2, 2);
            movementSpeed = 7;
        }
        else
        {
            candyBag.transform.localScale = new Vector3(1,1,1);
            movementSpeed = 10;
        }

        Plane playerPlane = new Plane(Vector3.up, transform.position);
        //Ray ray = UnityEngine.Camera.main.ScreenPointToRay(Input.mousePosition);
        float hitDist = 0.0f;

        if (attackSpeed == speedOfAttack)
        {
            //canAttack = true;
        }

        if (Input.GetMouseButtonDown(0))
        {
            
        }
        if(Attacking == true)
        {
            //canAttack = false;
            attackSpeed -= Time.deltaTime;
            if (attackSpeed <= 0)
            {
                animPlayer.SetBool("Attacking", false);
                attackSpeed = 0;              
                Attacking = false;
                                         
            }
        }
        if (Attacking == false)
        {
            Attacking = false;
            animPlayer.SetBool("Attacking", false);
            attackSpeed += Time.deltaTime;
            if (attackSpeed > speedOfAttack)
                attackSpeed = speedOfAttack;
            //if (attackSpeed == speedOfAttack)
                //canAttack = true;
        }
		//if (canMove == true)
        
    }

    void PlayerController()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement.normalized), 0.15f);
        }
        
        transform.Translate(movement * (movementSpeed * movementSpeedMulti) * Time.deltaTime, Space.World);
        
    }
    void IsAttackedHeavy() {
        animPlayer.SetBool("isAttackedHeavy", true);

        float iFrames = .5f;

        while (iFrames > 0)
        {
            iFrames -= Time.deltaTime;
        }      
        if(iFrames < 0)
        {
            animPlayer.SetBool("isAttackedHeavy", false);
        }
    }
    

    void OnCollisionEnter(Collision col)
    {
        
        if (col.gameObject.tag == "lightAttack")
        {

        }
        if (col.gameObject.tag == "mediumAttack")
        {

        }
        if(col.gameObject.tag == "candy")
        {
            candyCount++;
        }
        if (col.gameObject.tag == "bag")
        {
            takesDamage = true;
        }
        
    }
}
