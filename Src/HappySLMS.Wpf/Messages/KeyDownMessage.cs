using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HappySLMS.Wpf.Messages
{
    public class KeyDownMessage : ValueChangedMessage<KeyEventArgs>
    {
        public KeyDownMessage(KeyEventArgs value) : base(value)
        {
        }
    }
}
