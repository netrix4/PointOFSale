using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale.usersControls;
using PointOfSale.models;
using PointOfSale.utils;
using PointOfSale.Bussines;

namespace PointOfSale
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            List<SideMenuItem> menuList = new List<SideMenuItem>()
            {
                new SideMenuItem("Home", Enums.SideMenuType.Home),
                new SideMenuItem("Receipt", Enums.SideMenuType.Receipt),
                new SideMenuItem("Products", Enums.SideMenuType.Products),
                new SideMenuItem("Users", Enums.SideMenuType.Users),
                new SideMenuItem("Reports", Enums.SideMenuType.Reports),
                new SideMenuItem("Settings", Enums.SideMenuType.Settings),
                new SideMenuItem("About", Enums.SideMenuType.About)
            };

            foreach (SideMenuItem item in menuList)
            {
                AddMenuItem(menuList.IndexOf(item), item);
                
            }

            //DataProvider db = new DataProvider();
            //var response = db.GetProductListQuery();
            //db.GetProductListSTP();

        }
        void AddMenuItem(int itemNumber, SideMenuItem itemMenu)
        {
            ucSideMenuItem item = new ucSideMenuItem(itemMenu.Name, itemMenu.MenuType);

            item.panel = pnlMainContent;
            int itemHeight = item.Size.Height;
            pnlSideContainer.Controls.Add(item);
            item.Location = new Point(0, itemHeight*itemNumber);
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
