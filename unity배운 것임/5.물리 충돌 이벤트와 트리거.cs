using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Special_effects: MonoBehaviour
{
    Rigidbody rigid;
    //1.���� �̺�Ʈ

    //������Ʈ ����!
    //������Ʈ ���� = MeshRenderer�̿�.
    MeshRenderer mesh;//MeshReder ��� ��������
    Material mat;// MeshRender�� �ִ� ��ɵ� �� Material ��� ��������.


    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        mesh = GetComponent<MeshRenderer>();//������Ʈ �ҷ�����    
        //mesh �ȿ� �ִ� material ����� �ҷ��´�.

        //(material�� ������ ������) = (MeshRender ������).material;

        mat = mesh.material;

    }
    private void OnCollisionEnter(Collision collision)//������ �浿�� �Ͼ���� ���Ǵ� �Լ�.(������ �浿�� ������ ������)
    {
        //Collision = �浹 ���� Ŭ���� => �浹�� ���� ������ ������ �ִ�.

        //collision.gameObject.name == "(����ġ�� ��ü�� �̸�)"
        if(collision.gameObject.name == "Sphere (1)")//���� "��"�̶�� �̸��� ���� ��ü�� �浹�� �ϸ�?
        {
            //Color = �⺻ ���� , Color32 = 255 ���� Ŭ����

            //�浹�������� ������ �����Ѵ�.
            mat.color = new Color(0, 0, 0);//(0,0,0) = �� , (1,1,1) = Ⱥ��

        }
    }
    private void OnCollisionStay(Collision collision)//�浹�� ���ӵǰ� ������ ���Ǵ� �Լ�.
    {
        
    }
    private void OnCollisionExit(Collision collision)//����w�� �浹�� �������� ���Ǵ� �Լ�.
    {
        mat.color = new Color(1, 1, 1);

    }



    //2.Ʈ����

    private void OnTriggerStay(Collider other)//Ʈ���ſ� ��� �ִ� ���߿� ���Ǵ� �Լ�.
    {


        //+ collision �� �ƴ� Collider�� ���� ����?

        //Ʈ���Ŵ� ���ƴ��� �� ���ƴ����� �˾Ƶ� �Ǳ⶧���� �������� �浹������ ��� �ȴ�.
        if (other.name == "up Cube")//���࿡ "up Cube"��� ��ü�� ������ ���?
        {
            rigid.AddForce(Vector3.up, ForceMode.Impulse);//�� ��ü�� ���� ���� ���Ѵ�.
            //!! �����Ű�� ���ؼ��� �̰� �Ӹ� �ƴ϶� ��� ��ü�� Ʈ���Ÿ� ������Ѿ� �����ϴ�.
        }
    }



}
