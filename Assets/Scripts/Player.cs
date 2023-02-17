using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;

    public Rigidbody2D rig2D;
    
    float moveX;
    float moveY;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");
        Move();
    }

    void Move()
    {
        /*Movimenta o personagem através da fisica do unity, utilizando nosso vetor de movimento
    multiplicado por [Delta Time] para que a velocidade seja constante e independente
    do frame rate do jogo e também multiplicando por [Move Speed] para que possamos escolher
    a velocidade do personagem.
    */

        rig2D.MovePosition(transform.position + new Vector3(moveX, moveY, 0) * Time.deltaTime * moveSpeed);
    }
}
