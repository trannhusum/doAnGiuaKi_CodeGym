using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    
    [SerializeField] private List<Sprite> animationPlayer;
    [SerializeField] private float hp;
    [SerializeField] private float dame;
    [SerializeField] private Slider slider;
    [SerializeField] private Slider countdown;
    [SerializeField] private float keyPressCooldown; // Thời gian chờ giữa các lần bấm phím
    private float lastKeyPressTime = 0f; // Thời gian của lần bấm phím cuối cùng
    private SpriteRenderer spriteRenderer;
    private State state;
    private float fullHP;
    public float KeyPressCooldown
    {
        set { keyPressCooldown = value; }
    }


    public State statee => state;
    public float Damage
    {
        get { return dame; }
        set { dame = value; }
    }
    public float Hp
    {
        get { return hp; }
        set { hp = value; }
    }

    public List<Sprite> AnimationPlayer=>animationPlayer;

    private void Awake()
    {
        
    }
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        fullHP = hp;
        state = State.Keo;
        countdown.maxValue = keyPressCooldown;
    }
    void Update()
    {
        if (Time.time - lastKeyPressTime >= keyPressCooldown&&hp>0)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                lastKeyPressTime = Time.time;
                state = State.Keo;
                SpriteManagement.Instance.changeAttackSprite(0);
                countdown.value = 0;
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                lastKeyPressTime = Time.time;
                state = State.Bua;
                SpriteManagement.Instance.changeAttackSprite(1);
                countdown.value = 0;
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                lastKeyPressTime = Time.time;
                state = State.Bao;
                SpriteManagement.Instance.changeAttackSprite(2);
                countdown.value = 0;
            }
            
        }
        countdown.value += Time.deltaTime;
        slider.value = hp/ fullHP;
        
    }
    public enum State
    {
        Keo, Bua, Bao
    }
    
    public void TakeDamage(float damageOther)
    {
        hp -= damageOther;
        if (hp <= 0)
        {
            BarTime.Instance.CanRun = OneTwoThreeManagement.Instance.Canrun=false;
        }
            
    }
    public IEnumerator ChangeandresetAnimation(int index,float second)
    {
        spriteRenderer.sprite = animationPlayer[index];
        yield return new WaitForSeconds(second);
        if (hp<=0)
        {
            spriteRenderer.sprite = animationPlayer[5];
        }
        else if (hp > 0 && NPC.Instance.HP <= 0)
            spriteRenderer.sprite = animationPlayer[6];
        else
            spriteRenderer.sprite = animationPlayer[3];
    }
        

}
