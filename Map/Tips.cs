using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using HtmlAgilityPack;
using System.ComponentModel;

namespace Map
{
    class Tips
    {
        public Tips()
        {
            LoadProperty();
        }
        private void LoadProperty()
        {
            HtmlWeb hw = new HtmlWeb();
            var htmlDoc = hw.Load("http://10.49.150.159/plans/view/000000190/");
            var nameNodes = htmlDoc.DocumentNode.SelectNodes("//div[@class='catalog-detail-item-layer']/table/tr/td/h2");
            var nameofroom=htmlDoc.DocumentNode.SelectNodes("//div[@class='desc switch-object-company']/table/tr/td/h2");
            ObservableCollection<string> tr = new ObservableCollection<string>();
            ObservableCollection<TipOne> tipss = new ObservableCollection<TipOne>();
            ObservableCollection<string> cr = new ObservableCollection<string>();
            foreach (var N in nameNodes)
            {
                tr.Add(N.InnerText.Remove(0, 10));
            }
            foreach (var T in nameofroom)
            {
                cr.Add(T.InnerText);
            }
            for (int i = 0; i < tr.Count; i++)
            {
                tipss.Add(new TipOne(tr[i].Remove(0,30), cr[i])); 
            }
        }

    }
}
