﻿#pragma checksum "..\..\..\Controls\RichTextEditor.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4C5678E9C65892AC8700087A767CD14A"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interactivity;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using TestExerciser.Diary.Behaviors;
using TestExerciser.Diary.Logic.Models;
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace TestExerciser.Diary.Controls {
    
    
    /// <summary>
    /// RichTextEditor
    /// </summary>
    public partial class RichTextEditor : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Controls\RichTextEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TestExerciser.Diary.Controls.RichTextEditor userControl;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Controls\RichTextEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ToolBar toolbar;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Controls\RichTextEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxFontFamily;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Controls\RichTextEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxFontSize;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Controls\RichTextEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton tbBold;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Controls\RichTextEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton tbItalic;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Controls\RichTextEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton tbUnderline;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Controls\RichTextEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton tbAlignLeft;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Controls\RichTextEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton tbAlignCenter;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Controls\RichTextEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton tbAlignRight;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Controls\RichTextEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton tbIncreaseIndent;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Controls\RichTextEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton tbDecreaseIndent;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Controls\RichTextEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton tbBulletList;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Controls\RichTextEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton tbNumericList;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\Controls\RichTextEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton tbHyperlink;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\Controls\RichTextEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton tbUndo;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\Controls\RichTextEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton tbRedo;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\Controls\RichTextEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.RichTextBox rtbContent;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TestExerciser.Diary;component/controls/richtexteditor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\RichTextEditor.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.userControl = ((TestExerciser.Diary.Controls.RichTextEditor)(target));
            return;
            case 2:
            this.toolbar = ((System.Windows.Controls.ToolBar)(target));
            
            #line 19 "..\..\..\Controls\RichTextEditor.xaml"
            this.toolbar.IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.rtbContent_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cbxFontFamily = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.cbxFontSize = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.tbBold = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 6:
            this.tbItalic = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 7:
            this.tbUnderline = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 8:
            this.tbAlignLeft = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 52 "..\..\..\Controls\RichTextEditor.xaml"
            this.tbAlignLeft.Checked += new System.Windows.RoutedEventHandler(this.tbAlignLeft_Checked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.tbAlignCenter = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 54 "..\..\..\Controls\RichTextEditor.xaml"
            this.tbAlignCenter.Checked += new System.Windows.RoutedEventHandler(this.tbAlignCenter_Checked);
            
            #line default
            #line hidden
            return;
            case 10:
            this.tbAlignRight = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 56 "..\..\..\Controls\RichTextEditor.xaml"
            this.tbAlignRight.Checked += new System.Windows.RoutedEventHandler(this.tbAlignRight_Checked);
            
            #line default
            #line hidden
            return;
            case 11:
            this.tbIncreaseIndent = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 12:
            this.tbDecreaseIndent = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 13:
            this.tbBulletList = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 14:
            this.tbNumericList = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 15:
            this.tbHyperlink = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 86 "..\..\..\Controls\RichTextEditor.xaml"
            this.tbHyperlink.Click += new System.Windows.RoutedEventHandler(this.tbHyperlink_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.tbUndo = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 17:
            this.tbRedo = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 18:
            this.rtbContent = ((Xceed.Wpf.Toolkit.RichTextBox)(target));
            
            #line 107 "..\..\..\Controls\RichTextEditor.xaml"
            this.rtbContent.KeyDown += new System.Windows.Input.KeyEventHandler(this.rtbContent_KeyDown);
            
            #line default
            #line hidden
            
            #line 107 "..\..\..\Controls\RichTextEditor.xaml"
            this.rtbContent.SelectionChanged += new System.Windows.RoutedEventHandler(this.rtbContent_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

