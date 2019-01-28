using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    Text heathText;
    Player player;
    int healthNum;
    // Start is called before the first frame update
    void Start()
    {
        heathText = GetComponent<Text>();
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        heathText.text = player.GetHealth().ToString();
    }

}
