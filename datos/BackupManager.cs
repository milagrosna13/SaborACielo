using System;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace SaborAcielo.datos
{
    internal class BackupManager
    {
        private string connectionString; // Tu cadena de conexión a la base de datos

        public BackupManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void PerformBackup(string backupFilePath)
        {
            ServerConnection serverConnection = new ServerConnection(connectionString);
            Server sqlServer = new Server(serverConnection);

            Backup backup = new Backup();
            backup.Action = BackupActionType.Database;
            backup.Database = sqlServer.Databases["SaborAcielo"].Name; // Reemplaza con el nombre de tu base de datos
            backup.Devices.AddDevice(backupFilePath, DeviceType.File);

            backup.SqlBackup(sqlServer);
        }
    }
}
