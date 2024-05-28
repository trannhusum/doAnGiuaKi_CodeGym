using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SelectCharacterPVP : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_TextMeshProPlayer1, m_TextMeshProPlayer2;
    [SerializeField] private List<Sprite> machoManSprites;
    [SerializeField] private List<Sprite> kimYunaSprites;
    [SerializeField] private List<Sprite> a12Sprites;
    [SerializeField] private List<Sprite> kwesiSprites;
    [SerializeField] private List<Sprite> roiSprites;
    [SerializeField] private List<Sprite> xManSprites;
    [SerializeField] private List<Sprite> devilManSprites;
    [SerializeField] private List<Sprite> amySprites;
    [SerializeField] private Player2 player1;
    [SerializeField] private Player2 player2;
    [SerializeField] private GameObject gamePlayPVP;
    private SpriteRenderer spritePlayer1, spritePlayer2;
    private bool checkPlayer1 = false, checkPlayer2 = false;
    private void Start()
    {
        spritePlayer1 = player1.GetComponent<SpriteRenderer>();
        spritePlayer2 = player2.GetComponent<SpriteRenderer>();
    }
    public void Fight()
    {

        if (checkPlayer1 && checkPlayer2)
        {
            StartCoroutine(Count3seconds.Instance.Count(gameObject, gamePlayPVP));
            checkPlayer1 = false;
            checkPlayer2 = false;
        }
    }
    public void SelectKimYunaPlayer1()
    {
        checkPlayer1 = true;
        m_TextMeshProPlayer1.SetText("Kim Yuna");
        for (int i = 0; i < 7; i++)
        {
            player1.AnimationPlayer[i] = kimYunaSprites[i];
        }
        player1.Hp = 10f;
        player1.Damage = 1.3f;
        player1.KeyPressCooldown = 0.8f;
        spritePlayer1.sprite = kimYunaSprites[3];
    }
    public void SelectMachoManPlayer1()
    {
        checkPlayer1 = true;
        m_TextMeshProPlayer1.SetText("Macho Man");
        for (int i = 0; i < 7; i++)
        {
            player1.AnimationPlayer[i] = machoManSprites[i];
        }
        player1.Hp = 14f;
        player1.Damage = 1.1f;
        player1.KeyPressCooldown = 1f;
        spritePlayer1.sprite = machoManSprites[3];
    }
    public void SelectA12Player1()
    {
        checkPlayer1 = true;
        m_TextMeshProPlayer1.SetText("A12");
        for (int i = 0; i < 7; i++)
        {
            player1.AnimationPlayer[i] = a12Sprites[i];
        }
        player1.Hp = 8f;
        player1.Damage = 1.8f;
        player1.KeyPressCooldown = 0.5f;
        spritePlayer1.sprite = a12Sprites[3];
    }
    public void SelectKwesiPlayer1()
    {
        checkPlayer1 = true;
        m_TextMeshProPlayer1.SetText("Kwesi");
        for (int i = 0; i < 7; i++)
        {
            player1.AnimationPlayer[i] = kwesiSprites[i];
        }
        player1.Hp = 17f;
        player1.Damage = 1f;
        player1.KeyPressCooldown = 1.3f;
        spritePlayer1.sprite = kwesiSprites[3];
    }
    public void SelectRoiPlayer1()
    {
        checkPlayer1 = true;
        m_TextMeshProPlayer1.SetText("Roi");
        for (int i = 0; i < 7; i++)
        {
            player1.AnimationPlayer[i] = roiSprites[i];
        }
        player1.Hp = 9f;
        player1.Damage = 1.7f;
        player1.KeyPressCooldown = 0.7f;
        spritePlayer1.sprite = roiSprites[3];
    }
    public void SelectXManPlayer1()
    {
        checkPlayer1 = true;
        m_TextMeshProPlayer1.SetText("X-Man");
        for (int i = 0; i < 7; i++)
        {
            player1.AnimationPlayer[i] = xManSprites[i];
        }
        player1.Hp = 10f;
        player1.Damage = 1.6f;
        player1.KeyPressCooldown = 0.75f;
        spritePlayer1.sprite = xManSprites[3];
    }
    public void SelectDevilManPlayer1()
    {
        checkPlayer1 = true;
        m_TextMeshProPlayer1.SetText("Devil Man");
        for (int i = 0; i < 7; i++)
        {
            player1.AnimationPlayer[i] = devilManSprites[i];
        }
        player1.Hp = 6f;
        player1.Damage = 2.3f;
        player1.KeyPressCooldown = 0.3f;
        spritePlayer1.sprite = devilManSprites[3];
    }
    public void SelectAmyPlayer1()
    {
        checkPlayer1 = true;
        m_TextMeshProPlayer1.SetText("Amy");
        for (int i = 0; i < 7; i++)
        {
            player1.AnimationPlayer[i] = amySprites[i];
        }
        player1.Hp = 25f;
        player1.Damage = 1f;
        player1.KeyPressCooldown = 2f;
        spritePlayer1.sprite = amySprites[3];
    }
    public void SelectKimYunaPlayer2()
    {
        checkPlayer2 = true;
        m_TextMeshProPlayer2.SetText("Kim Yuna");
        for (int i = 0; i < 7; i++)
        {
            player2.AnimationPlayer[i] = kimYunaSprites[i];
        }
        player2.Hp = 10f;
        player2.Damage = 1.3f;
        player2.KeyPressCooldown = 0.8f;
        spritePlayer2.sprite = kimYunaSprites[3];
    }
    public void SelectMachoManPlayer2()
    {
        checkPlayer2 = true;
        m_TextMeshProPlayer2.SetText("Macho Man");
        for (int i = 0; i < 7; i++)
        {
            player2.AnimationPlayer[i] = machoManSprites[i];
        }
        player2.Hp = 14f;
        player2.Damage = 1.1f;
        player2.KeyPressCooldown = 1f;
        spritePlayer2.sprite = machoManSprites[3];
    }
    public void SelectA12Player2()
    {
        checkPlayer2 = true;
        m_TextMeshProPlayer2.SetText("A12");
        for (int i = 0; i < 7; i++)
        {
            player2.AnimationPlayer[i] = a12Sprites[i];
        }
        player2.Hp = 8f;
        player2.Damage = 1.8f;
        player2.KeyPressCooldown = 0.5f;
        spritePlayer2.sprite = a12Sprites[3];
    }
    public void SelectKwesiPlayer2()
    {
        checkPlayer2 = true;
        m_TextMeshProPlayer2.SetText("Kwesi");
        for (int i = 0; i < 7; i++)
        {
            player1.AnimationPlayer[i] = kwesiSprites[i];
        }
        player2.Hp = 17f;
        player2.Damage = 1f;
        player2.KeyPressCooldown = 1.3f;
        spritePlayer2.sprite = kwesiSprites[3];
    }
    public void SelectRoiPlayer2()
    {
        checkPlayer2 = true;
        m_TextMeshProPlayer1.SetText("Roi");
        for (int i = 0; i < 7; i++)
        {
            player2.AnimationPlayer[i] = roiSprites[i];
        }
        player2.Hp = 9f;
        player2.Damage = 1.7f;
        player2.KeyPressCooldown = 0.7f;
        spritePlayer2.sprite = roiSprites[3];
    }
    public void SelectXManPlayer2()
    {
        checkPlayer2 = true;
        m_TextMeshProPlayer2.SetText("X-Man");
        for (int i = 0; i < 7; i++)
        {
            player2.AnimationPlayer[i] = xManSprites[i];
        }
        player2.Hp = 10f;
        player2.Damage = 1.6f;
        player2.KeyPressCooldown = 0.75f;
        spritePlayer2.sprite = xManSprites[3];
    }
    public void SelectDevilManPlayer2()
    {
        checkPlayer2 = true;
        m_TextMeshProPlayer2.SetText("Devil Man");
        for (int i = 0; i < 7; i++)
        {
            player2.AnimationPlayer[i] = devilManSprites[i];
        }
        player2.Hp = 6f;
        player2.Damage = 2.3f;
        player2.KeyPressCooldown = 0.3f;
        spritePlayer2.sprite = devilManSprites[3];
    }
    public void SelectAmyPlayer2()
    {
        checkPlayer2 = true;
        m_TextMeshProPlayer2.SetText("Amy");
        for (int i = 0; i < 7; i++)
        {
            player2.AnimationPlayer[i] = amySprites[i];
        }
        player2.Hp = 25f;
        player2.Damage = 1f;
        player2.KeyPressCooldown = 2f;
        spritePlayer2.sprite = amySprites[3];
    }
}
