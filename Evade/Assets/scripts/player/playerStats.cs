using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "playerStats")]
public class playerStats : ScriptableObject {

    //variables concerning properties of the player character
    public float moveSpeed;
    public float size;
    public float livePoints;
    public float liveRegeneration;
    public float luck;



    //variables concerning attacks of the player
    public float atkDamage;
    public float atkSize;
    public float atkRate;           //how often the player attacks
    public float atkSpeed;          //how fast attacks move
    public float atkDuration;



    //variables concerning the current expedition
    public int score;
    public int kills;
    public float time;


    private void Start() {
        score = 0;
        kills = 0;
        time = 0;
    }

    private void FixedUpsate(){

        time += Time.fixedDeltaTime;


    }

}
