using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;


namespace AutoFrame
{
    public class BusinessAnalysis
    {
        void findProject(string projectName)
        {
            //先识别桌面 
            AutomationElement RootElement = AutomationElement.RootElement;
            //找到分析工具打开的窗口
            AutomationElement CalcWindows = RootElement.FindFirst(TreeScope.Children,
            new AndCondition(
            new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.DataGrid),
            new PropertyCondition(AutomationElement.NameProperty, ""),
            new PropertyCondition(AutomationElement.LocalizedControlTypeProperty,"数据网格")));

            //找到项目名称显示列表


            //找到项目名称显示列表中对应项
        }  

        
    }
}
