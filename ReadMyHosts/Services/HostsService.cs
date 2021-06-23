using ReadMyHosts.Core;
using ReadMyHosts.Core.Handlers;
using ReadMyHosts.Core.Models;
using System.Collections.Generic;

namespace ReadMyHosts.Services
{
    public class HostsService
    {
        #region Public Methods

        public IEnumerable<Host> GetData()
        {
            var handler = new HostsHandler();
            handler.ReadFile(Info.RootPath);
            return handler.HostList;
        }

        #endregion Public Methods
    }
}