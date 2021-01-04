using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBM_EF
{
    static class Program
    {
        public static HospitalEntities db = new HospitalEntities(); //Partial singleton pattern
        public static DebugPanel debugPanel;
        public static AdminPanel adminPanel;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            debugPanel = new DebugPanel();
            adminPanel = new AdminPanel();
            Application.Run(debugPanel);
        }
        public static void detachAll()
        {
            var test = db.ChangeTracker.Entries();/*
            var changedEntriesCopy = test
        .Where(e => e.State == EntityState.Added ||
                    e.State == EntityState.Modified ||
                    e.State == EntityState.Deleted)
        .ToList();
            */
            foreach (var entry in test)
                entry.State = EntityState.Detached;

            db.SaveChanges();
        }
    }
}
