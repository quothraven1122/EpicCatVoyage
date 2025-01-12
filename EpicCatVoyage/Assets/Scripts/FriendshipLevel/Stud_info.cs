using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Stud_info : MonoBehaviour
{
    public List<NPCdata> npcData;

    public GameObject studInfoScreen;
    public Text studInfoLike;
    public Text studInfoTalk;
    public string[] talks;
    public Animator screenAnim;

    // Start is called before the first frame update
    void Start()
    {
        screenAnim = studInfoScreen.GetComponent<Animator>();
        npcData = StoreInfo.getFriendshipList();
        studInfoLike.text = "ȣ���� : " + npcData[0].friendship_level.ToString();

        int index = (npcData[0].friendship_level - 1) / 25;
        studInfoTalk.text = talks[index];
    }

    public void clickStud()
    {
        screenAnim.SetTrigger("upStudent");
    }

    public void clickBtn()
    {
        screenAnim.SetTrigger("downStudent");
    }
}
