using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

namespace ProfessionalThief
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private Player player;
        [SerializeField] private GameObject HUD;
        [SerializeField] private GameObject gadgetHUD;
        [SerializeField] private GameObject actionLog;
        [SerializeField] private GameObject interactionUI;
        [SerializeField] private TextMeshProUGUI gadgetIcon;
        [SerializeField] private TextMeshProUGUI actionLogText;
        [SerializeField] private TextMeshProUGUI totalTakeText;
        [SerializeField] private TextMeshProUGUI interactionText;

        private void Start(){
            RegisterForEvents();
            HUD.SetActive(true);
            ToggleInteractionUI(false);
        }

        private void RegisterForEvents(){
            player.GetComponent<Inventory>().onValuableAdded += OnValuableAdded;
            Inventory.onGadgetAdded += OnGadgetAdded;
            EventManager.Instance.onTotalTakeUpdated += OnTotalTakeUpdated;
        }

        private void OnGadgetAdded(Gadget gadget){
            actionLogText.text = "Collected " + gadget.name;
        }

        private void OnValuableAdded(Valuable valuable, int quantity){
            actionLogText.text = "Collected " + quantity + " $" +valuable.value + " " + valuable.name;
        }

        private void OnTotalTakeUpdated(int amountInDollar){
            totalTakeText.text = "$ " + amountInDollar;
        }

        public void ToggleInteractionUI(bool status){
            interactionUI.SetActive(status);
        }
    }
}
