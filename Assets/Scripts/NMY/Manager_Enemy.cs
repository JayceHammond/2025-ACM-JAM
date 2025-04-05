using UnityEngine;

public class Manager_Enemy : MonoBehaviour{
    private Inovker_Manager _InvokeManager;

    public PlayerPrefs player;

    private void Start(){
        _InvokeManager = new Inovker_Manager(this);
    }

    
}
