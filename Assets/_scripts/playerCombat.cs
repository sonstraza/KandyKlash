using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCombat : MonoBehaviour {
    // Related thingamajigs in the prefab. SET THIS OR DIE
    public GameObject weaponHitSphere;

    // Constants
    public float attackCooldownLength = 1;

    // Cooldown we dont use objects here because abstraction is bad m'kay
    private BagCollisionController hitController;
    private float cooldownTimer;
    private bool attacking;

    private Collider weaponHitboxCollider;

	// Use this for initialization
	void Start () {
        attacking = false;
        hitController = weaponHitSphere.GetComponent<BagCollisionController>;
    }
	
	// Update is called once per frame
	void Update () {
        // Check mouse input
        if (Input.GetMouseButton(0))
        {
            // Attack if not already attacking
            if (!attacking)
            {
                attacking = true;
                cooldownTimer = 0;
                hitController.Activate();
            }
        }

        // Update attacking cooldown
        if (attacking)
        {
            cooldownTimer += Time.deltaTime;
            if(cooldownTimer > attackCooldownLength)
            {
                attacking = false;
                cooldownTimer = 0;
                hitController.Deactivate();
            }
        }
	}
}
