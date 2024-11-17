using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

//Cambiar el nombre del "namespace", por el nombre del proyecto
namespace Proyecto_Final_Equipo_1 
{
    class ListViewItemComparer : IComparer
    {
        private int col;
        private SortOrder order;

        public ListViewItemComparer()
        {
            col = 0;
            order = SortOrder.Ascending;
        }
        public ListViewItemComparer(int column, SortOrder order)
        {
            col = column;
            this.order = order;
        }
		
        public int Compare(object x, object y)
        {
            int result;

            ListViewItem itemA = x as ListViewItem;
            ListViewItem itemB = y as ListViewItem;
            if (itemA == null && itemB == null)
                result = 0; 
            else if (itemA == null)
                result = -1;
            else if (itemB == null)
                result = 1;

            if (itemA == itemB)
                result = 0;

            // Comparacion de fechas
            DateTime x1, y1;            
            if (!DateTime.TryParse(itemA.SubItems[col].Text, out x1))
                x1 = DateTime.MinValue;
            if (!DateTime.TryParse(itemB.SubItems[col].Text, out y1))
                y1 = DateTime.MinValue;
            result = DateTime.Compare(x1, y1);

            if (x1 != DateTime.MinValue && y1 != DateTime.MinValue)
                goto done;

            //Comparación Numérica
            decimal x2, y2;
            if (!Decimal.TryParse(itemA.SubItems[col].Text, out x2))
                x2 = Decimal.MinValue;
            if (!Decimal.TryParse(itemB.SubItems[col].Text, out y2))
                y2 = Decimal.MinValue;
            result = Decimal.Compare(x2, y2);

            if (x2 != Decimal.MinValue && y2 != Decimal.MinValue)
                goto done;

            //Comparación alfabetica
            result = String.Compare(itemA.SubItems[col].Text, itemB.SubItems[col].Text);



        done:            
            if (order == SortOrder.Descending)                
                result *= -1;
            return result;


        }
    }
}
