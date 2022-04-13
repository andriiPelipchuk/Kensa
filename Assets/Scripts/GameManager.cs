using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] GameObject _window1;
        [SerializeField] GameObject _window2;
        [SerializeField] GameObject _window11;
        [SerializeField] GameObject _window21;
        [SerializeField] GameObject _autoWindow;


        private void Start()
        {
            StartCoroutine(OpenAutoWindow());
        }

        private void Update()
        {
            
        }
        public void OpenWindowOne()
        {
            _window1.SetActive(true);
        }
        public void OpenWindowTwo()
        {
            _window2.SetActive(true);
        }
        public void OpenWindowEleven()
        {
            _window11.SetActive(true);
        }
        public void OpenWindowTwentyOne()
        {
            _window21.SetActive(true);
        }

        IEnumerator OpenAutoWindow()
        {
            yield return new WaitForSeconds(Random.Range(10, 20));
            _autoWindow.SetActive(true);
        }
    }
}