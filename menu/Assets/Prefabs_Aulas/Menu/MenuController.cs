using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject menuInicial, menuOptions, rawImage;
    public AudioSource selectSound;
    public string newGameScene;
    private Animator animatorRawImage;

    // Start is called before the first frame update
    void Start()
    {
        rawImage.SetActive(false);
        menuOptions.SetActive(false);
        animatorRawImage = rawImage.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!videoPlayer.isPlaying && Input.anyKeyDown)
        {
            selectSound.Play();
            videoPlayer.Play();
            animatorRawImage.SetTrigger("FadeIn");
            rawImage.SetActive(true);
            menuInicial.SetActive(true);
        }
    }

    public void Options()
    {
        menuInicial.SetActive(false);
        menuOptions.SetActive(true);
    }

    public void Salvar()
    {
        SaveConfigs();
        ReturnMenuInicial();
    }

    public void ReturnMenuInicial()
    {
        menuInicial.SetActive(true);
        menuOptions.SetActive(false);
    }

    public void NewGame()
    {
        SceneManager.LoadScene(newGameScene);
    }

    private void SaveConfigs()
    {

    }
}
