using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unity1 : MonoBehaviour
{

   /*
    int resurt(int money)
    {
        int count = 0;
        while (money >= 100)
        {
            money -= 100;
            count++;
        }
        return count;
    
    }
   */

    void Start()
    {


        //����
        /*
        int a = 3;
        Debug.Log("���� a�� ���� ?  : " + a);
        */

        /*
        * Debug.Log(); ���� ��� �����ϰ�
        * ������ ���� ���������� string�� ������ �� ������ 
        * ���� ���� ���ÿ� ����ҷ��� +�� �̿��� �ٿ��� �Ѵ�.
        */
        //�迭
        /*
        string[] arr = { "���� ����" , "���� ����" , "���� �⸰" };
        int[] Level = new int[3];
        Level[0] = 1;
        Level[1] = 15;
        Level[2] = 28;
        string[] str = new string[3];
        str[0] = "�츮 ��";
        str[1] = "����";
        str[2] = "���б�";

        Debug.Log(arr[0]);
        Debug.Log(Level[1]);
        Debug.Log("���� �ִ� ��Ҵ�?");
        Debug.Log(str[0]);
        */

        //����Ʈ ����

        /*
        List<string> language = new List<string>();
        language.Add("c���");
        language.Add("c#");
        language.Add("unity");

        Debug.Log("���� ���� �Ҵ� ����? ");
        Debug.Log(language[0]);
        Debug.Log(language[1]);
        Debug.Log(language[2]);
        */
        /*
        * �迭�� �����ҷ��� 
        * 1.(int,string,char...)[] (�迭�� �̸�) = {�迭�� �ȿ� ����� ������ �̸�}
        * �Ǵ� 
        * 2.(int,string,char...)[] (�迭�� �̸�) = new (int,string,char...ó���� ������ �Ͱ� �����ϰ�)
        * (�迭�� �̸�)[] = (�迭�� ����� ������ �̸�)
        * �� �������� �迭�� �����Ҽ��� �ִ�!
        * 
        * int arr[3] ={};(X)(c���), int[] arr = {};(O) 
         * 
         * ����Ʈ�� 2���� ��������� List<(�ڷ���)>�� �־�� �ϰ�
         * �߰��ҷ���
         * (�迭�� �̸�).Add(�迭�ȿ� ����� ������ �̸�) �� ���� ��������
         * �ؾߵȴ�!
         */
        //������

        /*
        int playerLevel = 85;
        bool check = playerLevel >= 100;
        Debug.Log(check);
        string playLevel = check ? "���� ����" : "���� ����";
        Debug.Log("����� ������ " + playLevel + "�Դϴ�!");
        */

        /*
         * ���� ��� �Ͱ� ������ �߰��� �˾ƾ� �Ұ��� bool �����ڷ� 
         * false �� ture �� �ΰ����� ������ ������ �������� �Ǻ�����
        */


        //�ݺ��� foreach

        /*
        string[] todayclass = new string[3];
        todayclass[0] = "���縯 ���";
        todayclass[1] = "������ ���";
        todayclass[2] = "�̻����";
        foreach (string crass in todayclass)
        {
            Debug.Log("�����ϰ�  ȭ���Ͽ� �ִ� ������ ?" +crass);

        }
        
        int money = 500;
        Debug.Log("100��¥�� "+resurt(money)+"���� �Ž��� �־����ϴ�");
        */

        //Ŭ����

        playerstats player = new playerstats();
        player.playerLevel = 0;




    }

}
