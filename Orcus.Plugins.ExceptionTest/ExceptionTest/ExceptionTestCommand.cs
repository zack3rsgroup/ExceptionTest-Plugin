using System;
using System.Collections.Generic;
using System.Text;
using Orcus.Administration.Plugins;
using Orcus.Administration.Plugins.CommandViewPlugin;

public class ExceptionTestCommand : Command
{
    public override void ResponseReceived(byte[] parameter)
    {
    }

    public void ThrowException(int exceptionType, string message)
    {
        List<byte> list = new List<byte>();
        list.AddRange(BitConverter.GetBytes(exceptionType));
        list.AddRange(Encoding.UTF8.GetBytes(message));
        ConnectionInfo.SendCommand((Command)this, list.ToArray(), PackageCompression.Auto);
        LogService.Send("Throw exception");
    }

    protected override uint GetId()
    {
        return 1001u;
    }
}
