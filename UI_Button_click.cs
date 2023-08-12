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
    public void Button_UI_cpnMenu_click()
    {
        toPage("UI_cpnMenu");
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
    public void Button_board_func_click()
    {
        toPage("UI_board_func");
    }
    public void Button_board_locate_click()
    {
        toPage("UI_board_locate");
    }
    public void Button_board_compare_click()
    {
        toPage("UI_board_compare");
    }
    public void Button_cpu_func_click()
    {
        toPage("UI_cpu_func");
    }
    public void Button_cpu_locate_click()
    {
        toPage("UI_cpu_locate");
    }
    public void Button_cpu_compare_click()
    {
        toPage("UI_cpu_compare");
    }
    public void Button_ram_func_click()
    {
        toPage("UI_ram_func");
    }
    public void Button_ram_locate_click()
    {
        toPage("UI_ram_locate");
    }
    public void Button_ram_compare_click()
    {
        toPage("UI_ram_compare");
    }
    public void Button_gpu_func_click()
    {
        toPage("UI_gpu_func");
    }
    public void Button_gpu_locate_click()
    {
        toPage("UI_gpu_locate");
    }
    public void Button_gpu_compare_click()
    {
        toPage("UI_gpu_compare");
    }
    public void Button_m2_func_click()
    {
        toPage("UI_m2_func");
    }
    public void Button_m2_locate_click()
    {
        toPage("UI_m2_locate");
    }
    public void Button_m2_compare_click()
    {
        toPage("UI_m2_compare");
    }
    public void Button_power_func_click()
    {
        toPage("UI_power_func");
    }
    public void Button_power_locate_click()
    {
        toPage("UI_power_locate");
    }
    public void Button_power_compare_click()
    {
        toPage("UI_power_compare");
    }
}
