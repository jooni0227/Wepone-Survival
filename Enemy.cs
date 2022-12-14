using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private int damage = 1; //enemy damage
    [SerializeField]
    private int scorePoint = 100; //get score
    private PlayerController playerController;

    private void Awake()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<playerController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerHp>().TakeDamage(damage);
            OnDie();
        }
    }

public void OnDie()
{
    playerController.Score += scorePoint;
    Destroy(GameObject);
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
