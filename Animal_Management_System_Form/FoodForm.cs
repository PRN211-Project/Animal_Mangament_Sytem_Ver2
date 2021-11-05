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
    public partial class FoodForm : UserControl
    {
        private IFoodRepository foodRepository;
        //Singleton
        private static FoodForm _instance;
        
        public static FoodForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FoodForm();
                }

                return _instance;
            }
        }

        private FoodForm()
        {
            InitializeComponent();
            foodRepository = new ImplFoodRepository();
        }
    }
}
