using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Count3seconds : MonoBehaviour
{
    public static Count3seconds Instance;
    [SerializeField] private TextMeshProUGUI m_TextMeshPro;
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
    public IEnumerator Count(GameObject gameObject,GameObject setTrue)
    {
        m_TextMeshPro.SetText("3");
        yield return new WaitForSeconds(1);
        m_TextMeshPro.SetText("2");
        yield return new WaitForSeconds(1);
        m_TextMeshPro.SetText("1");
        yield return new WaitForSeconds(1);
        m_TextMeshPro.SetText("Start");
        yield return new WaitForSeconds(1);
        m_TextMeshPro.SetText("");
        setTrue.SetActive(true);
        gameObject.SetActive(false);
        
    }
}
