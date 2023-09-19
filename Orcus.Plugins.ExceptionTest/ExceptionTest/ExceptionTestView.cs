using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

public class ExceptionTestView : UserControl, IComponentConnector
{
    private bool _contentLoaded;

    public ExceptionTestView()
    {
        InitializeComponent();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent()
    {
        if (!_contentLoaded)
        {
            _contentLoaded = true;
            Uri resourceLocator = new Uri("/ExceptionTest;component/exceptiontestview.xaml", UriKind.Relative);
            Application.LoadComponent(this, resourceLocator);
        }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    void IComponentConnector.Connect(int connectionId, object target)
    {
        _contentLoaded = true;
    }
}
