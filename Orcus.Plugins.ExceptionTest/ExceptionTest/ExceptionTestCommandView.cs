using ExceptionTest;
using Orcus.Administration.Plugins.CommandViewPlugin;
using Sorzus.Wpf.Toolkit;
using static Sorzus.Wpf.Toolkit.RelayCommand;

public class ExceptionTestCommandView : CommandView
{
    private ExceptionTestCommand _exceptionTestCommand;

    private RelayCommand _throwUpCommand;

    public override string Name
    {
        get;
    } = "Exception Test";


    public override Category Category
    {
        get;
    }

    public int SelectedExceptionIndex
    {
        get;
        set;
    }

    public string Message
    {
        get;
        set;
    }

    public RelayCommand ThrowUpCommand
    {
        get
        {
            //IL_0012: Unknown result type (might be due to invalid IL or missing references)
            //IL_001c: Expected O, but got Unknown
            //IL_0017: Unknown result type (might be due to invalid IL or missing references)
            //IL_001c: Unknown result type (might be due to invalid IL or missing references)
            //IL_001e: Expected O, but got Unknown
            //IL_0023: Expected O, but got Unknown
            RelayCommand obj = _throwUpCommand;
            if (obj == null)
            {
                RelayCommand val = new RelayCommand((ExecuteDelegate)delegate
                {
                    _exceptionTestCommand.ThrowException(SelectedExceptionIndex, Message ?? "");
                });
                RelayCommand val2 = val;
                _throwUpCommand = val;
                obj = val2;
            }
            return obj;
        }
    }

    protected override void InitializeView(IClientController clientController, ICrossViewManager crossViewManager)
    {
        _exceptionTestCommand = clientController.Commander.GetCommand<ExceptionTestCommand>();
    }
}
