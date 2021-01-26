using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    //Text Stuff: Names and Text and yeah :D
    public Text nameText;
    public GameObject nameBorderText;
    public Text nameText2;
    public GameObject nameBorderText2;
    public Text dialogueText;

    //Visual Stuff: Sprites, Backgrounds, Actual Box for text
    public Animator textBox;
    public Animator agnes;
    public Animator secondSpeaker;
    public Animator bg;
    

    //Queue for names and sentances to know which ones go in order
    private Queue<string> names;
    private Queue<string> sentences;
    private Queue<AudioClip> voices;
    private Queue<Sprite> sprites;

    //Player access for making them stop moving n stuff
    public GameObject Player;
    public GameObject Shooter;
    public GameObject Menu;
    public GameObject Minimap;
    public GameObject Frame;
    public GameObject ConfidenceBG;
    public Image ConfidencePoint;
    public PlayerMovement Moving1;
    public PlayerMovementLevel2 Moving2;
    public ShootandStab Shooting1;
    public ShootandStabLevel2 Shooting2;

    public Image AgnesSprite;
    public Image SecondSprite;

    //checks if ur in a convo
    private bool isActive;
    //checks if the text has ended
    private bool endText;
    private bool bossFight;
    private bool endScene;

    public static DialogueManager Instance;
    void Start()
    {
        bossFight = false;
        endScene = false;

        isActive = false;
        names = new Queue<string>();
        sentences = new Queue<string>();
        voices = new Queue<AudioClip>();
        sprites = new Queue<Sprite>();

    }
    public void StartDialogue(Dialogue dialogue)
    {
        endText = false;
        isActive = true;
        bossFight = dialogue.bossTrigger;
        endScene = dialogue.sceneTransition;
        MusicManager.isDialogue = true;
        Player.GetComponent<CapsuleCollider2D>().isTrigger = true;

        textBox.SetBool("isOpen", true);
        bg.SetBool("isOpen", true);
        if (SceneWatcher.sceneName != null)
        {
            if (SceneWatcher.sceneName.Equals("Level1"))
            {
                Moving1.enabled = false;
                Shooting1.enabled = false;
            }
            else 
            {
                Moving2.enabled = false;
                Shooting2.enabled = false;
            }
        }

        Player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

        ConfidenceBG.SetActive(false);
        ConfidencePoint.enabled = false;
        Menu.SetActive(false);
        Frame.SetActive(false);
        if (Minimap != null)
        {
            Minimap.SetActive(false);
        }

        
        names.Clear();
        foreach (string name in dialogue.names)
        {
            names.Enqueue(name);
        }
        sentences.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        foreach (AudioClip voice in dialogue.voices)
        {
            voices.Enqueue(voice);
        }
        sprites.Clear();
        foreach (Sprite sprite in dialogue.sprites)
        {
            sprites.Enqueue(sprite);
        }
        DisplayNextSentence();
    }



    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        
        Sprite CurrentSprite = sprites.Dequeue();
        string sentence = sentences.Dequeue();
        string name = names.Dequeue();
        if (name.Equals("Agnes"))
        {
            AgnesSprite.sprite = CurrentSprite;
        }
        else
        {
            SecondSprite.sprite = CurrentSprite;
        }
        StopAllCoroutines();
        
        StartCoroutine(TypeSentence(sentence, name));
    }

    IEnumerator TypeSentence(string sentence, string name)
    {
        dialogueText.text = "";
        nameText.text = "";
        nameText2.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            if (name.Equals("Agnes") == true)
            {
                agnes.SetBool("isOpen", true);
                nameText.text = name.ToUpper();
                nameBorderText.SetActive(true);
                nameBorderText2.SetActive(false);
            }
            else
            {
                secondSpeaker.SetBool("isOpen", true);
                nameText2.text = name.ToUpper();
                nameBorderText.SetActive(false);
                nameBorderText2.SetActive(true);
            }


            if (endText == true)
            {
                agnes.SetBool("isOpen", false);
                secondSpeaker.SetBool("isOpen", false);
            }
            
            dialogueText.text += letter;
            yield return null;
        }
    }

    public void EndDialogue()
    {
        endText = true;
        isActive = false;
        MusicManager.isDialogue = false;
        Player.GetComponent<CapsuleCollider2D>().isTrigger = false;
        Player.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);

        agnes.SetBool("isOpen", false);
        secondSpeaker.SetBool("isOpen", false);
        textBox.SetBool("isOpen", false);
        bg.SetBool("isOpen", false);
        if (SceneWatcher.sceneName != null)
        {
            if (SceneWatcher.sceneName.Equals("Level1"))
            {
                Moving1.enabled = true;
                Shooting1.enabled = true;
            }
            else 
            {
                Moving2.enabled = true;
                Shooting2.enabled = true;
            }
        }

        ConfidenceBG.SetActive(true);
        ConfidencePoint.enabled = true;
        Menu.SetActive(true);
        Frame.SetActive(true);
        if (Minimap != null)
        {
            Minimap.SetActive(true);
        }

        if (bossFight == true)
        {
            BossTrigger.BossStart = true;
            MusicManager.isBoss = true;

        }

        if (endScene == true)
        {
            SceneManager.LoadScene("WinScreen");
        }
    }

    private void Update()
    {
        if (isActive == true && Input.GetKeyDown(KeyCode.Return))
        {
            DisplayNextSentence();
        }
        
        if(isActive == true && Input.GetKeyDown(KeyCode.Escape))
        {
            EndDialogue();
        }
    }
}
