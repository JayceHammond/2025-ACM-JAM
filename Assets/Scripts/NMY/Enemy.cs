using UnityEngine;

public class Enemy : MonoBehaviour{

    //**** 0 == Clear **** 1 == Caution **** 2 == Alerted\\
    public int alerted = 0;

    public int Total_Health;
    public int Curr_Health;
    public int Sight_Range;
    public int Damage;
    public int MoveSpeed;

    private Invoker_Enemy _Invoker;
    public Manager_Enemy EM;


    public void Start(){
        EM = FindObjectOfType<Manager_Enemy>();

        _Invoker = new Invoker_Enemy();
    }

}
