//using ReadMyHosts.Models;
using ReadMyHosts.Core.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ReadMyHosts.ViewModels
{
    public class HostListViewModel : ViewModelBase
    {
        public HostListViewModel(IEnumerable<Host> hosts) {
            Hosts = new ObservableCollection<Host>(hosts);
        }

        public ObservableCollection<Host> Hosts { get; }

        public string Greeting => "Welcome to Avalonia!";
    }
}