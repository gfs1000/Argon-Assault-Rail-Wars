using UnityEngine;
using TMPro;



    public class ScoreBoardEntryUI : MonoBehaviour
    {
        [SerializeField] public TextMeshProUGUI entryNameText = null;
        [SerializeField] public TextMeshProUGUI entryScoreText = null;

        public void Initialise(ScoreBoardEntryData scoreBoardEntryData)
        {
            entryNameText.text = scoreBoardEntryData.entryName;
            entryScoreText.text = scoreBoardEntryData.entryScore.ToString();
        }
    }

   


