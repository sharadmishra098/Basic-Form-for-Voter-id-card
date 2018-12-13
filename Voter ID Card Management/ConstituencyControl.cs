using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voter_ID_Card_Management
{
    public partial class ConstituencyControl : UserControl
    {
        private static ConstituencyControl _instance;

        public static ConstituencyControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ConstituencyControl();
                }
                return _instance;
            }
        }
        public ConstituencyControl()
        {
            InitializeComponent();
        }
    }
}
