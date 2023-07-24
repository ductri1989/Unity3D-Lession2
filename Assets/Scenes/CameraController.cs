using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour{
    public float movementSpeed;
    public float turningSpeed;
    [SerializeField] Transform[] listModel;
    [SerializeField] Button[] buttons;
    public int currentModelId;
    private void Awake()
    {
        for (int i = 0; i < buttons.Length; i++){
            int id = i;
            buttons[id].onClick.AddListener(() => {
                setToOtherView(id);
            });
        }
    }

    void Update(){
        //float horizontal = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
        //transform.Rotate(0, horizontal, 0);

        //float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        //transform.Translate(0, 0, vertical);



        if (Input.GetKeyDown(KeyCode.Space)){
            Debug.Log($"currentModelId : {currentModelId}");
            listModel[currentModelId].GetComponent<Rigidbody>().AddForce(Vector3.up*100);
        }




        if (Input.GetMouseButtonDown(0))
            listModel[currentModelId].GetComponent<Animator>().Play("Attack");



        float horizontal = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;

        listModel[currentModelId].transform.Rotate(0, horizontal, 0);
        listModel[currentModelId].transform.Translate(0, 0, vertical);



        Transform currentModel = listModel[currentModelId];
        this.transform.position = new Vector3(currentModel.position.x, currentModel.position.y + 2, currentModel.position.z - 6);
    }

    public void setToOtherView(int index) {
        currentModelId = index;
    }
}
