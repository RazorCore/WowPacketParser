using System.Collections.Generic;

namespace WowPacketParser.Store.Objects
{
    public class StartAction
    {
        public ICollection<Action> Actions;
    }

    public class Action
    {
        public uint Button;

        public uint Id;
    }
}
