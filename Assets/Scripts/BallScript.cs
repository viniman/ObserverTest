using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    private Rigidbody rb;
    private Observer[] observers;

    private State state;

    public float force;

    //proprieda de acesso
    public State State
    {
    //    get() {return state;};

    }

	void Start () {
        rb = GetComponent<Rigidbody>();
        observers = new Observer[10];
        observers[0] = new Achievements();
        for(int i = 1; i < 10; ++i)
        {
            observers[i] = null;
        }

        state = State.standing;
	}
	
	void Update () {
        float dh = Input.GetAxis("Horizontal");
        float dv = -Input.GetAxis("Vertical");

        rb.AddForce(new Vector3(dv, 0, dh) * force);

        if (Input.GetKeyDown(KeyCode.Space))
            rb.AddForce(new Vector3(0, 10, 0) * 10);

        float distance = Vector3.Distance(transform.position, new Vector3(0, 2.9f, 7.6f));

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
    }
}
