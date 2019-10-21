using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float velocidad = 3f;
    public ParticleSystem particulas;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision col) {
        anim.SetBool("jump", false);
        particulas.Play();
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Verical");
        float h = Input.GetAxis("Horizontal");

        if (v != 0)
        {
            transform.Translate(transform.forward * velocidad * v * Time.deltaTime);
            anim.SetFloat("speed", v);
        }

        if (h != 0)
        {
            transform.Translate(transform.right * velocidad * h * Time.deltaTime);
        }

        if (Input.GetAxis("Jump") != 0)
        {
            transform.Translate(transform.up * velocidad * Time.deltaTime);
            anim.SetBool("jump", true);
            particulas.Play();
        }
    }
}
