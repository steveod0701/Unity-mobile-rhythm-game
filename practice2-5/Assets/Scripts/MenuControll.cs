using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuControll : MonoBehaviour
{
    private float cameraRotationSpeed = 9f;

    private Transform cameraTransform;
    public Transform LevelMenuTransform;
    public Transform OptionMenuTransform;
    public Transform MainMenuTransform;
    private bool ableToMove;

    public GameObject levelButtonPrefab;
    public GameObject levelButtonContainer;
    
    private void Start()
    {
        cameraTransform = Camera.main.transform;
        ableToMove = true;
        
        PlayerPrefs.SetString("BestTime", "0");

        Sprite[] thumbnails = Resources.LoadAll<Sprite>("Levels");
        Sprite[] achievement = Resources.LoadAll<Sprite>("Achievement");
        foreach (Sprite thumbnail in thumbnails)
        {
            GameObject container = Instantiate(levelButtonPrefab) as GameObject;
            container.GetComponent<Image>().sprite = thumbnail;
            container.transform.SetParent(levelButtonContainer.transform, false);

            string sceneName = thumbnail.name;

            container.GetComponent<Button>().onClick.AddListener(() => LoadLevel(sceneName));
            container.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = "Best Score: "+Singletons.bestScore.ToString();
            if (Singletons.bestScore == 0)
            {
                container.transform.GetChild(1).GetComponent<Image>().sprite = achievement[0];
            }
            else if(Singletons.bestScore >0 && Singletons.bestScore < 15)
            {
                container.transform.GetChild(1).GetComponent<Image>().sprite = achievement[1];
            }
            else if (Singletons.bestScore >14 && Singletons.bestScore < 30)
            {
                container.transform.GetChild(1).GetComponent<Image>().sprite = achievement[2];
            }
            else if (Singletons.bestScore > 29)
            {
                container.transform.GetChild(1).GetComponent<Image>().sprite = achievement[3];
            }
        }    
    }
    
    private void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    
    public void LookAtLevel()
    {
        /*while (cameraTransform.rotation != LevelMenuTransform.transform.rotation)
        {
            cameraTransform.rotation = Quaternion.Slerp(cameraTransform.rotation, LevelMenuTransform.rotation, cameraRotationSpeed * Time.deltaTime);
        }*/
        if (ableToMove)
            StartCoroutine(LookLevel());
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void LookAtMenu()
    {   
        if(ableToMove)
            StartCoroutine(LookMenu());
    }

    public void LookAtOptions()
    {
        if (ableToMove)
            StartCoroutine(LookOptions());
    }

    IEnumerator LookLevel()
    {
        while (cameraTransform.rotation != LevelMenuTransform.rotation)
        {
            yield return new WaitForSeconds(0.001f);
            cameraTransform.rotation = Quaternion.Slerp(cameraTransform.rotation, LevelMenuTransform.rotation, cameraRotationSpeed * Time.deltaTime);
            ableToMove = false;
        }
        
        ableToMove = true;
    }

    IEnumerator LookOptions()
    {
        while(cameraTransform.rotation!= OptionMenuTransform.rotation)
        {
            yield return new WaitForSeconds(0.001f);
            cameraTransform.rotation = Quaternion.Slerp(cameraTransform.rotation, OptionMenuTransform.rotation, cameraRotationSpeed * Time.deltaTime);
            ableToMove = false;
        }
       
        ableToMove = true;
    }

    IEnumerator LookMenu()
    {
        while (cameraTransform.rotation != MainMenuTransform.rotation)
        {
            yield return new WaitForSeconds(0.001f);
            cameraTransform.rotation = Quaternion.Slerp(cameraTransform.rotation, MainMenuTransform.rotation, cameraRotationSpeed * Time.deltaTime);
            ableToMove = false;
        }
        
        ableToMove = true;
    }
}
