using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour{
    public float movementSpeed;
    public float turningSpeed;
    public GameObject myPlayer;

    void Update(){
        if (Input.GetMouseButtonDown(0)){
            myPlayer.GetComponent<Animator>().Play("Attack");
        }
        if (Input.GetKeyDown(KeyCode.Space))
            myPlayer.GetComponent<Rigidbody>().AddForce(Vector3.up * 300);


        //float horizontal = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
        //transform.Rotate(0, horizontal, 0);

        //float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        //transform.Translate(0, 0, vertical);



        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Debug.Log($"currentModelId : {currentModelId}");
        //    listModel[currentModelId].GetComponent<Rigidbody>().AddForce(Vector3.up * 100);
        //}

        //if (Input.GetMouseButtonDown(0))
        //    listModel[currentModelId].GetComponent<Animator>().Play("Attack");

        float horizontal = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;

        myPlayer.transform.Rotate(0, horizontal, 0);
        myPlayer.transform.Translate(0, 0, vertical);

        //Transform currentModel = listModel[currentModelId];
        //this.transform.position = new Vector3(currentModel.position.x, currentModel.position.y + 2, currentModel.position.z - 6);

    }
}
