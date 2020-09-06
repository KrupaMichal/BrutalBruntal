using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DvereOt : MonoBehaviour
{

        public GameObject dvere;

        void OnTriggerEnter(Collider other) {
            dvere.GetComponent<Animator>().Play("DvereOby");
        }
}
