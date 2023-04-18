using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Coffee_management_store.DB;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Coffee_management_store.BL
{
    class BLInventory
    {
        Database db = null;
        public BLInventory()
        {
            db = new Database();
        }
        public DataSet GetInventory()
        {
            return db.ExecuteQueryDataSet("select * from Inventory", CommandType.Text);
        }

        public bool DeleteInventory(string inventoryId, out string errorMessage)
        {
            return this.db.DeleteInventory(inventoryId, out errorMessage);
        }
        public bool UpdateInventory(string inventoryId, int newAmount, int newBuyingPrice, out string errorMessage)
        {
            return this.db.UpdateInventory(inventoryId,  newAmount,  newBuyingPrice, out  errorMessage);
        }
        

    }
}
