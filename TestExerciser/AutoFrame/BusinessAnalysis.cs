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
        //桌面
        AutomationElement RootElement = AutomationElement.RootElement;
        //产品打开后工程管理窗口
        AutomationElement windowProject;
        //产品
        AutomationElement dataGridProject;


        /// <summary>
        /// 定位窗口
        /// </summary>
        /// <param name="name"></param>
        /// <param name="localizedControlType"></param>
        /// <param name="className"></param>
        void findWinodw(string name,string localizedControlType,string className)
        {
            //先识别桌面             
            //找到分析工具打开的窗口
            windowProject = RootElement.FindFirst(TreeScope.Children,
            new AndCondition(
            new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Window),
            new PropertyCondition(AutomationElement.NameProperty, name),
            new PropertyCondition(AutomationElement.LocalizedControlTypeProperty,localizedControlType),
            new PropertyCondition(AutomationElement.ClassNameProperty, className)            
            ));
            //找到项目名称显示列表中对应项
        }

        void findDataGridProjectList(string name, string localizedControlType, string className)
        {
            findWinodw(Config.NAME_PROJECT_LIST, Config.LOCALIZEDCONTROLTYPE_PROJECT_LIST, Config.CLASSNAME_PROJECT_LIST);
            //找到项目名称显示列表
            dataGridProject = windowProject.FindFirst(TreeScope.Children,
            new AndCondition(
            new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Window),
            new PropertyCondition(AutomationElement.NameProperty, name),
            new PropertyCondition(AutomationElement.LocalizedControlTypeProperty, localizedControlType),
            new PropertyCondition(AutomationElement.ClassNameProperty, className)
            ));
        }

        void findDataGridProjectSpecific()
        {
            
        }
    }
}
