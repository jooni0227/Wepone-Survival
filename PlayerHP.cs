using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHp : MonoBehaviour
{
    [SeriallizeField]
    private float   maxHP=10;
    private float   currentHP;
    private SpriteRenderer  spriteRenderer;

    private void Awake()
    {
        currentHP=maxHP;
        spriteRenderer=GetComponent<spriteRenderer>();
    }

    public void TakeDamage(float damage)
    {
        currentHP-=damage;

        StopCoroutine("HitColorAnimation");
        StartCoroutine("HitColorAnimation");

        if(currentHP<=0)
        {
            Debug.Log("Player HP : 0..Die");
        }
    }
    private IEnumerator HitColorAnimation()
    {
        spriteRenderer.color=Color.red;
        yield return new WaitForSeconds(0.1f);
        spriteRenderer.color=Color.white;
    }
}