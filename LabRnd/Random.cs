using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabRnd
{
    abstract class Random : Form
    {
        History history = new History();
        Resource resource = new Resource();
        Label resultRnd;
        int valMin;
        int valMax;

        public void countClient(Label resultRnd, TextBox valMin, TextBox valMax, ComboBox cbResource)
        {
            this.resultRnd = resultRnd;
            this.valMax = Convert.ToInt32(valMax.Text.Trim());
            this.valMin = Convert.ToInt32(valMin.Text.Trim());
            getRndValue(cbResource, resultRnd);
            //addHistory();
            //addClient();
        }

        public abstract void getRndValue(ComboBox cbResource, Label resultRnd);

        //private void addHistory()
        //{
        //    history.date = Convert.ToDateTime(date);
        //    history.range_min = valMin;
        //    history.range_max = valMax;
        //    history.result;
        //    history.number_rnd;
        //    history.url_id;

        //    using (RNDDBEntities db = new RNDDBEntities())
        //    {
        //        db.History.Add(history);
        //        db.SaveChanges();
        //    }
        //}

        


        
    }
}
