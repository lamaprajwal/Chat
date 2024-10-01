using FormulaOne.chat.Models;
using System.Collections.Concurrent;

namespace FormulaOne.chat.DataService
{
    public class SharedDb
    {
        private readonly ConcurrentDictionary<string, UserConnection> _connections=new();
        public ConcurrentDictionary<string,UserConnection> connections=> _connections;
    }

}
