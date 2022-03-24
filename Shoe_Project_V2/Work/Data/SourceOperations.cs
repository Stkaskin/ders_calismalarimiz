using Shoe_Project_V2.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoe_Project_V2.Work.Data
{
  public  class SourceOperations
    {
        Anaform form = (Anaform)Application.OpenForms[nameof(Anaform)];
        public DataGridView dataSource() 
        {
            //form.ayakkabiSource=
            return new DataGridView();
        }
    }
}
