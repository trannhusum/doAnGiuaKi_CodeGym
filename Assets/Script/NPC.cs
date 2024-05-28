using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    private Player player;
    public static NPC Instance;
    [SerializeField] private float hp;
    [SerializeField] private float dame;
    [SerializeField] private float time;
    [SerializeField] private Slider slider;
    [SerializeField] private List<Sprite> animationNPC;
    private SpriteRenderer spriteRenderer;
    private float fullHP;
    
    public float Time=>time;
    public float Damage
    {
        get { return dame; }
        set { dame = value; }
    }
    public float HP
    {
        get { return hp; }
        set { hp = value; }
    }
    public List<Sprite> AnimationNPC => animationNPC;
    void Start()
    {
        player=GameObject.Find("Player").GetComponent<Player>();
        fullHP = hp;
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = hp / fullHP;
    }
    public void TakeDamage(float damageOther)
    {
        hp -= damageOther;
        if (hp <= 0)
        {
            BarTime.Instance.CanRun = OneTwoThreeManagement.Instance.Canrun = false;
        }
    }
    public IEnumerator ChangeandresetAnimation(int index, float second)
    {
        spriteRenderer.sprite = animationNPC[index];
        yield return new WaitForSeconds(second);
        if (hp <= 0)
        {
            spriteRenderer.sprite = animationNPC[5];
        }
        else if (hp >0 && player.Hp<=0)
            spriteRenderer.sprite = animationNPC[6];
        else
            spriteRenderer.sprite = animationNPC[3];
    }
}
