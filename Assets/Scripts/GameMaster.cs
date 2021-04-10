using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{

	public bool[] inventorySlots;
	public GameObject[] slotsObj;
    public GameObject canvasObj;
    public GameObject[] flows;
    public Text objetivoText;
    public int current_quest=1;
    public string[] objetivos;
    public menuInGameScript menu;
    private static GameMaster instance;
    void Start(){
        PlayerPrefs.SetInt("Current Quest", current_quest);
    }
    void Awake()
        { 
            if(instance == null)
            {
                instance = this;
                DontDestroyOnLoad(instance);
            }else
            {
                Destroy(gameObject);

            }

        }
    // called first
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
        // called second
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
            /*Inventory/Menu canvas*/

             if(scene.name=="Menu" || scene.name=="Intro")
                canvasObj.SetActive(false);
            else{
                canvasObj.SetActive(true);
                menu.closeMenuInventory();
                /*Quests and objectives*/
                NovoObjetivo(current_quest-1);

                /*Dialog flows*/
                string n_scene=scene.name.Substring(0, 2);
                switch(n_scene){

                    case "00": //Praça
                        flows[0].SetActive(true); //Monologo inicial
                    break;

                    case "10": //Sala de aula
                        flows[1].SetActive(true); //Chegou na sala de aula
                        if(current_quest==1)
                            CumpriuQuest(); //Passou da QUEST 1
                    break;
                    
                    case "11": //Biblioteca
                        if(current_quest==2)
                            flows[2].SetActive(true); //Flow 1 do freddy

                        else if(current_quest==4){ // QUEST DE DEVOLVER A CARTEIRINHA DO FREDDY

                            if(inventorySlots[0]){ //Caso esteja com a carteirinha
                                flows[7].SetActive(true); //Flow de devolução
                                CumpriuQuest();
                                CumpriuQuest(); //Inicia quest dos itens do elixir
                            }
                            else{ //Caso a carteirinha do Freddy tenha sido confiscada
                                flows[6].SetActive(true);
                                CumpriuQuest(); //Inicia quest do teorema da gaveta
                            }
                        }
                        else if(current_quest==5){
                             if(inventorySlots[0])
                                flows[7].SetActive(true); //Flow de devolução
                                CumpriuQuest();
                        }
                    break;               

                    case "01": //Redondo
                        if(current_quest==3 || current_quest==4)
                            flows[4].SetActive(true); //Flow do veterano
                    break;

                    case "02": //Guarita
                        if(current_quest==3 || current_quest==4)
                            flows[5].SetActive(true); //Flow do guardinha
                    break;


                }
                
            }
    }
    public void NovoObjetivo(int n){
        objetivoText.text=objetivos[n];
    }

    public void NovaQuest(int n){
        current_quest=n;
        NovoObjetivo(current_quest-1);
        PlayerPrefs.SetInt("Current Quest", current_quest);
    }

    public void CumpriuQuest(){
        current_quest++;
        NovoObjetivo(current_quest-1);
        PlayerPrefs.SetInt("Current Quest", current_quest);

    }
    public int GetCurrentQuest(){
        return current_quest;
    }
    
    public void CollectItem(int item_id){
    	if(item_id<inventorySlots.Length && item_id>=0){
    		inventorySlots[item_id]=true;
    		slotsObj[item_id].SetActive(true);
    	}
    }

    public void RemoveItem(int item_id){
    	if(item_id<inventorySlots.Length && item_id>=0){
    		inventorySlots[item_id]=false;
    		slotsObj[item_id].SetActive(false);
    	}
    }

}
