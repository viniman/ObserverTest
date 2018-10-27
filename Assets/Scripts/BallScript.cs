using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    private Rigidbody rb;
    private Observer[] observers;
    private Vector3 posInicial;

    public BallState ballState;

    public float force;

    //proprieda de acesso
  /*  public BallState BallState
    {
    //    get() {return ballState;};

    }
*/
	void Start () {
        rb = GetComponent<Rigidbody>();
	    posInicial = transform.position;
        observers = new Observer[10];
        observers[0] = new Achievements();
        for(int i = 1; i < 10; ++i)
        {
            observers[i] = null;
        }

        ballState = BallState.standingBall;
	}
	
	void Update () {
        float dh = Input.GetAxis("Horizontal");
        float dv = -Input.GetAxis("Vertical");

        rb.AddForce(new Vector3(dv, 0, dh) * force);

        if (Input.GetKeyDown(KeyCode.Space))
            rb.AddForce(new Vector3(0, 10, 0) * 10);

        float distance = Vector3.Distance(transform.position, posInicial);

        handleInput();

        
        if (distance > 20)
        {
            Destroy(gameObject);
            notify();
        }
    }

    void notify()
    {
        for(int i = 0; i < 10; ++i)
        {
            if(observers[i] != null)
                observers[i].onNotify();
        }
    }

    void handleInput()
    {
        // a ideia é passar a tecla que foi pressionada para ele, sem passar qual é ela.
        KeyCode key;
        if (Input.GetKey(KeyCode.LeftArrow))
            key = KeyCode.LeftArrow;
        else
            key = KeyCode.Space;

        ballState.hendleInput(this, key);
    }
    
}
