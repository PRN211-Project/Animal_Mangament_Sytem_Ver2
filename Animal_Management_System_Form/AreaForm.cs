using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Animal_Management_System.Repository;
using Animal_Management_System.Repository.Implementation;

namespace Animal_Management_System_Form
{
    public partial class AreaForm : UserControl
    {
        private IAreaRepository areaRepository;

        //Singleton
        private static AreaForm _instance;

        public static AreaForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AreaForm();
                }

                return _instance;
            }
        }

        private AreaForm()
        {
            InitializeComponent();
            areaRepository = new ImplAreaRepository();
        }
    }
}
