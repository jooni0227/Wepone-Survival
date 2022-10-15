using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projecttile : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            collision.GetComponent<Enemy>().OnDie();
            Destroy(gameObject); //이 줄이 없으면 관통되는 발사체로 사용가능
        }
    }
}
