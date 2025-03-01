using DG.Tweening;
using System;
using System.Collections;

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ManagerUI : MonoBehaviour
{

    public static ManagerUI Instance;
    public GameObject BGChangeScene;
    public GameObject HomeBTN;

    private void Start()
    {
        Instance = this;
        HomeBTN.SetActive(false);
        DontDestroyOnLoad(Instance);
    }

    



    private IEnumerator ChangeSceneCountine(EnumNameScene name, float timeDelay)
    {
        yield return new WaitForSeconds(timeDelay);
        BGChangeScene.SetActive(true);
        BGChangeScene.GetComponent<RawImage>().DOFade(1, 0.5f);
        yield return new WaitForSeconds(0.6f);
        SceneManager.LoadScene(name.ToString());
        BGChangeScene.GetComponent<RawImage>().DOFade(0, 0.5f);
        yield return new WaitForSeconds(0.8f);
        BGChangeScene.SetActive(false);
    }


    public void ChangeScene(EnumNameScene name, float timeDelay)
    {
        
        StartCoroutine(ChangeSceneCountine(name, timeDelay));
        if (name != EnumNameScene.DieScene && name != EnumNameScene.MainScene)
        {
            HomeBTN.SetActive(true);
        }
        else
        {
            HomeBTN.SetActive(false);
        }
    }

    public void LoadScenePlay()
    {
        int getScene = PlayerPrefs.GetInt("Level", 1);
        EnumNameScene scene = (EnumNameScene)(100+getScene);
       
        ChangeScene(scene, 0);
    }

    public void LoadNextScene()
    {
        
        int getScene = PlayerPrefs.GetInt("Level", 1) + 1;
        if(getScene > 4) { ResetLevel(); ChangeScene(EnumNameScene.MainScene, 0); return; }
        EnumNameScene scene = (EnumNameScene)(100 + getScene);
        PlayerPrefs.SetInt("Level", getScene);
        ChangeScene(scene, 0);
    }

    [ContextMenu("Reset")]
    public void ResetLevel()
    {
        PlayerPrefs.SetInt("Level", 1);
        PlayerPrefs.SetInt("IQ", 0);
    }
}