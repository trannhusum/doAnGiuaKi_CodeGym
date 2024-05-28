using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OneTwoThreeManagement : MonoBehaviour
{
    public static OneTwoThreeManagement Instance;
    [SerializeField] private Player player;
    [SerializeField] private NPC npc;
    private SpriteManagement spriteManagement;
    private bool canRun=true;
    [SerializeField] private GameObject gamePlay;
    [SerializeField] private GameObject c_Popup;
    public bool Canrun
    {
        set {canRun=value;}
    }
    private void Awake()
    {
        spriteManagement = GameObject.Find("SpriteManagement").GetComponent<SpriteManagement>();
    }
    private void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        
    }
    private void OnEnable()
    {
        StartCoroutine(DoSomethingSeconds(npc.Time));
    }
    // Update is called once per frame
    void Update()
    {
        if (player.Hp <= 0 || NPC.Instance.HP <= 0)
        {
            StartCoroutine(EndGame());
        }
    }
    public void checkState(int randomNumber)
    {
        switch (randomNumber)
        {
            case 1:
                if (player.statee == Player.State.Bao)
                {
                    spriteManagement.WhoWin(4, 0, 1, 1);
                    player.TakeDamage(npc.Damage);
                }
                    
                else if (player.statee == Player.State.Bua)
                {
                    spriteManagement.WhoWin(1, 4, 1, 1);
                    npc.TakeDamage(player.Damage);
                }
                else if (player.statee == Player.State.Keo)
                {
                    spriteManagement.WhoWin(0, 0, 1, 1);
                    player.TakeDamage(npc.Damage/2);
                    npc.TakeDamage(player.Damage/2);
                }
                break;
            case 2:
                if (player.statee == Player.State.Keo)
                {
                    spriteManagement.WhoWin(4, 1, 1, 1);
                    player.TakeDamage(npc.Damage);
                }
                    
                else if (player.statee == Player.State.Bao)
                {
                    spriteManagement.WhoWin(2, 4, 1, 1);
                    npc.TakeDamage(player.Damage);
                }
                else if (player.statee == Player.State.Bua)
                {
                    spriteManagement.WhoWin(1, 1, 1, 1);
                    player.TakeDamage(npc.Damage / 2);
                    npc.TakeDamage(player.Damage / 2);
                }
                break;
            case 3:
                if (player.statee == Player.State.Bua)
                {
                    spriteManagement.WhoWin(4, 2, 1, 1);
                    player.TakeDamage(npc.Damage);
                }
                    
                else if (player.statee == Player.State.Keo)
                {
                    spriteManagement.WhoWin(0, 4, 1, 1);
                    npc.TakeDamage(player.Damage);
                }
                else if (player.statee == Player.State.Bao)
                {
                    spriteManagement.WhoWin(2, 2, 1, 1);
                    player.TakeDamage(npc.Damage / 2);
                    npc.TakeDamage(player.Damage / 2);
                }
                break;
        }
    }
    IEnumerator DoSomethingSeconds(float waitTime)
    {
        canRun = true;
        while (canRun)
        {
            int randomNumber = Random.Range(1, 4);
            spriteManagement.addSprite(randomNumber);
            yield return new WaitForSeconds(waitTime);
            checkState(randomNumber);
            yield return new WaitForSeconds(1);
        }
    }
    IEnumerator EndGame()
    {
        yield return new WaitForSeconds(3);
        gamePlay.SetActive(false);
        c_Popup.SetActive(true);
    }
}
