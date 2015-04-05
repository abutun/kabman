using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KabMan.Import;
using userSettings = KabMan.Properties.Settings;
using KabMan.Extensions;
using KabMan.Windows;

namespace KabMan.Forms
{
    public partial class ExcelImportForm
    {
        private void CollectServers(out Dictionary<string, List<ServerListItem>> argListSet, string argColumnKey)
        {
            argListSet = new Dictionary<string, List<ServerListItem>>();

            string columnName;
            ServerCollector collector;

            columnName = userSettings.Default.ImportServerPageColumns.ToDictionary()[argColumnKey];
            collector = new ServerCollector("Server", columnName);
            collector.CollectItems(ref serverDataSet);

            argListSet.Add("Server", collector.Items);
        }

        private void ProcessServers()
        {
            Dictionary<string, List<ServerListItem>> listSet;

            var key = "Server";

            CollectServers(out listSet, "Name");

            var seqServer = listSet["Server"];

            RefreshAssistant.AddVisualizerDataTable(key + "-All", seqServer.ToList());

            var groupedByName = from grp in seqServer
                                group grp by new
                                {
                                    grp.Name
                                } into g
                                select new
                                {
                                    ServerName = g.Key.Name,
                                    PortCount = g.Count()
                                };

            var grouped = from grp in seqServer
                          group grp by new
                          {
                              grp.Name,
                              grp.OperatingSystem,
                              grp.BlechName
                          } into g
                          join ports in groupedByName on g.Key.Name equals ports.ServerName
                          select new ServerGroupedListItem
                          {
                              Name = g.Key.Name,
                              BlechName = g.Key.BlechName,
                              OperatingSystem = g.Key.OperatingSystem,
                              PortCount = ports.PortCount
                          };

            RefreshAssistant.AddVisualizerDataTable(key + "-Grouped", grouped.ToList());

            listServerAll = seqServer.ToList();
            listServerGrouped = grouped.ToList();

        }
    }
}
