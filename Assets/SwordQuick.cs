using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordQuick : MonoBehaviour
{
    public GameObject swordGuy;
    public GameObject Enemy;
    public GameObject blackScreen;
    private bool hitEnemy = false;
    private Minigame mini;
    private int setTimer;
    private int swingTiming = Random.Range(1,3);


    // Start is called before the first frame update
    void Start()
    {
        mini = GetComponent<Minigame>();
        swordGuy.transform.localPosition = new Vector3(1.0f, 4.0f, 1.0f);
        setTimer = (int)Time.deltaTime + swingTiming;
    }

    // Update is called once per frame
    void Update()
    {
        setTimer = (int)Time.deltaTime + swingTiming;
        if(setTimer >= swingTiming && setTimer <= (swingTiming+1))
        {

            if (Input.GetButtonDown(mini.button))
            {
                Debug.Log("You hit the enemy");
                hitEnemy = true;
                mini.finish = true;

            }
        Debug.Log("Can swing");

        }
        if(mini.timerGet <= 0)
        {
            Reset();
        }

    }
    private void Reset()
    {
        hitEnemy = false;
    }
}
