using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonScript : MonoBehaviour, IPointerEnterHandler
{
    #region Variables
    [SerializeField] private string text;
    [SerializeField] private Image backgoundImage;
    [SerializeField] private AudioClip audioClip;
    [SerializeField] private AudioClip audioClipEnter;
    private AudioSource audiosource;
    private AudioController audioController;
    #endregion

    #region Defaults
    private void Awake()
    {
        gameObject.GetComponentInChildren<TextMeshProUGUI>().text = text;
        audioController = GameObject.Find("Scene").GetComponent<AudioController>();
    }

    void Start()
    {
        if (audioClip != null)
        {
            gameObject.GetComponent<Button>().onClick.AddListener(() => audioController.Play(audioClip.name));
        }
    }

    void Update()
    {

    }
    #endregion

    #region Functions
    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        audioController.Play(audioClipEnter.name);
    }
    #endregion
}
