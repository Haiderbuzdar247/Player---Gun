using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class CharacterSelection : MonoBehaviourParent
{
    public TMP_Text gunlabel;
    public TMP_Text characterlabel;

    public List<GameObject> characters;
    public List<GameObject> guns;
    public int selectgun = 0;
    public int selectcharacter = 0;
    private void Awake()
    {
        foreach (GameObject gun in guns)
        {
            Instantiate(gun, transform.position, Quaternion.identity, transform.parent);
            gun.SetActive(false);
        }
        foreach (GameObject player in characters)
        {
            Instantiate(player, transform.position, Quaternion.identity, transform.parent);
            player.SetActive(false);
        }
    }
    void Start()
    {
        guns[selectgun].SetActive(true);
        characters[selectcharacter].SetActive(true);
    }
    public void nextgun()
    {
        guns[selectgun].SetActive(false);
        selectgun = (selectgun + 1) % guns.Count;
        guns[selectgun].SetActive(true);

    }
    public void previousgun()
    {
        guns[selectgun].SetActive(false);
        selectgun--;
        if (selectgun < 0)
        {
            selectgun += guns.Count;
        }
        guns[selectgun].SetActive(true);
    }
    public void nextCharacter()
    {
        characters[selectcharacter].SetActive(false);
        selectcharacter = (selectcharacter + 1) % characters.Count;
        characters[selectcharacter].SetActive(true);

    }
    public void previousCharacter()
    {
        characters[selectcharacter].SetActive(false);
        selectcharacter--;
        if (selectcharacter < 0)
        {
            selectcharacter += characters.Count;
        }
        characters[selectcharacter].SetActive(true);
    }
    public void startGame()
    {
        PlayerPrefs.SetInt("SelectedCharacter", selectcharacter);
        PlayerPrefs.SetInt("SelectedGun", selectgun);
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
    void Update()
    {
        characterlabel.text = characters[selectcharacter].name;
        gunlabel.text = guns[selectgun].name;
    }
}
