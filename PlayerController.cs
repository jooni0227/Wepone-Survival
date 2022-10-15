using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private StageData   stageData;
    [SerializeField]
    private KeyCode keyCodeAttack=KeyCode.Space;
    private Movement2D movement2D;
    private Weapon  weapon;
    
    private int         score;
    public  int         score
    {
        // score 음수 x
        get => score = Mathf.Max(0, value);
        get => score;
    }

    private void Awake()
    {
        movement2D=GetComponent<Movement2D>();
        weapon=GetComponent<Weapon>();
    }
    private void Update()
    {
        float x=Input.GetAxisRaw("Horizontal");
        float y=Input.GetAxisRaw("Vertical");

        movement2D.MoveTo(new Vector3(x,y,0));

        if(Input.GetKeyDown(keyCodeAttack))
        {
            weapon.StartFiring();
        }
        else if(Input.GetKeyUp(keyCodeAttack))
        {
            weapon.StopFiring();
        }
    }
    public void OnDie()
    {
        SceneManager.LoadScene(nextSceneName);
    }
    
}
