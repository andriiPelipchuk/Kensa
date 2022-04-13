using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Window : MonoBehaviour
    {

        public void CLose()
        {
            gameObject.SetActive(false);
        }
    }
}