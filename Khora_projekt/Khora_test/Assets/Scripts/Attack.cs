using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Valve.VR;
using System.Threading;
using System.Collections.ObjectModel;

namespace Valve.VR.InteractionSystem
{
    public class Attack : MonoBehaviour
    {
        public Hand hand;
        public AudioClip m05;

        private int score;
        public Text countText;


        void Start()
        {
            GetComponent<AudioSource>().playOnAwake = false;
            GetComponent<AudioSource>().clip = m05;

            score = 0;
            SetCountText();

        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Ring"))
            {
                GetComponent<AudioSource>().Play();
                print("Collide");
                hand.TriggerHapticPulse(0.5f, 25, 15);
                score += 5;
                SetCountText();
            }
        }

        void SetCountText()
        {
            countText.text = "Score:  " + score.ToString();
        }
    }
}

