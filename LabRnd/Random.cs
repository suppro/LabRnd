using System;
using System.Linq;
using System.Windows.Forms;

namespace LabRnd
{
    abstract class Random : Form
    {
        History history = new History();
        Label resultRnd;
        int valMin;
        int valMax;
        string resource;

        public void countClient(Label resultRnd, TextBox valMin, TextBox valMax, ComboBox cbResource)
        {
            this.resultRnd = resultRnd;
            this.valMax = Convert.ToInt32(valMax.Text.Trim());
            this.valMin = Convert.ToInt32(valMin.Text.Trim());
            resource = cbResource.Text;
            getRndValue(cbResource, resultRnd, this.valMin, this.valMax);
            MessageBox.Show("Результат определен");
            addHistory();
            MessageBox.Show("Результаты добавлены");
        }

        public abstract void getRndValue(ComboBox cbResource, Label resultRnd, int valMin, int valMax);

        private void addHistory()
        {
            history.range_min = valMin;
            history.range_max = valMax;
            history.result = Convert.ToInt32(resultRnd.Text);

            using (RNDDBEntities db = new RNDDBEntities())
            {
                History model = (from u in db.History
                                orderby u.number_rnd descending
                                select u).FirstOrDefault();
                if (model != null)
                    history.number_rnd = model.number_rnd + 1;
                else
                    history.number_rnd = 1;
            }

            using (RNDDBEntities db = new RNDDBEntities())
            {
                Resource model = (from u in db.Resource
                                  where u.name == resource
                                  select u).FirstOrDefault();
                history.url_id = model.id;

            }


            using (RNDDBEntities db = new RNDDBEntities())
            {
                db.History.Add(history);
                db.SaveChanges();
            }
        }





    }
}
