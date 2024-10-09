using CommunityToolkit.Mvvm.Messaging.Messages;

namespace SampleMauiApp.Data;

public class RefreshMessage : ValueChangedMessage<bool>
{
    public RefreshMessage(bool value) : base(value)
    {
    }
}
