using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Button_click : MonoBehaviour
{
    public void toPage(string pageName)
    {
        MainControl._ins.switchUIPages(pageName);
    }
    public void Button1_click()
    {
        toPage("UI_Q1");
    }
    public void Button_intro_sys_click()
    {
        toPage("UI_Intro_sys");
    }
    public void Button_member_click()
    {
        toPage("UI_member");
    }
    public void Button_sysfunc_click()
    {
        toPage("UI_sysfunc");
    }
    public void Button2_click()
    {
        toPage("UI_Q2");
    }
    public void Button3_click()
    {
        toPage("UI_Q3");
    }
    public void Button3_1_click()
    {
        toPage("UI_Q3_1");
    }
    public void Button4_click()
    {
        int rand = Random.Range(1, 4);
        toPage("UI_Q4_" + rand.ToString());
    }
    public void Button4_1_1click()
    {
        toPage("UI_Q4_1_1");
    }
    public void Button4_1_2click()
    {
        toPage("UI_Q4_1_2");
    }
    public void Button4_1_3click()
    {
        toPage("UI_Q4_1_3");
    }
    public void Button4_2_1click()
    {
        toPage("UI_Q4_2_1");
    }
    public void Button4_2_2click()
    {
        toPage("UI_Q4_2_2");
    }
    public void Button4_2_3click()
    {
        toPage("UI_Q4_2_3");
    }
    public void Button4_3_1click()
    {
        toPage("UI_Q4_2_1");
    }
    public void Button4_3_2click()
    {
        toPage("UI_Q4_2_2");
    }
    public void Button4_3_3click()
    {
        toPage("UI_Q4_2_3");
    }
    public void Button_return_click()
    {
        toPage("UI_MainMenu");
    }

    public void Button_case_func_click()
    {
        toPage("UI_case_func");
    }
    public void Button_case_locate_click()
    {
        toPage("UI_case_locate");
    }
    public void Button_case_compare_click()
    {
        toPage("UI_case_compare");
    }
}
