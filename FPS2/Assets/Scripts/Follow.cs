using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

    public Transform Player;
    static Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(Player.position, this.transform.position) < 10) {
            Vector3 direction = Player.position - this.transform.position;
            direction.y = 0;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);

            anim.SetBool("isIdle", false);

            if(direction.magnitude > 5) {
                anim.SetBool("isShooting", true);
                anim.SetBool("isIdle", false);

            }
            else {
                //anim.SetBool("isIdle", true);
                anim.SetBool("isShooting", true);
                
            }
        } 
		
	}
}  
