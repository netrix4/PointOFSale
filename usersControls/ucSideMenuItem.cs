using System;
using System.Windows.Forms;
using PointOfSale.Bussines;
using PointOfSale.utils;

namespace PointOfSale.usersControls
{
    public partial class ucSideMenuItem : UserControl
    {
        public string title { get; set; }
        public Panel panel { get; set; }
        public Enums.SideMenuType menuType { get; set; }

        public ucSideMenuItem()
        {
            InitializeComponent();
        }

        public ucSideMenuItem(string content, Enums.SideMenuType menuType) : this()
        {
            title = content;
            this.menuType = menuType;
            lblTitle.Text = content;
            var titleIcon = Properties.Resources.home_icon;

            switch (menuType)
            {
                case Enums.SideMenuType.Home:
                default:
                    titleIcon = Properties.Resources.home_icon;
                    break;

                case Enums.SideMenuType.Receipt:
                    titleIcon = Properties.Resources.receipts_icon;
                    break;

                case Enums.SideMenuType.Products:
                    titleIcon = Properties.Resources.prodcuts_icon;
                    break;

                case Enums.SideMenuType.Users:
                    titleIcon = Properties.Resources.users_icon;
                    break;

                case Enums.SideMenuType.Reports:
                    titleIcon = Properties.Resources.reports_icon;
                    break;

                case Enums.SideMenuType.Settings:
                    titleIcon = Properties.Resources.settings_icon;
                    break;

                case Enums.SideMenuType.About:
                    titleIcon = Properties.Resources.about_icon;
                    break;
            }

            imgIconItem.Image = titleIcon;
        }

        private void imgIconItem_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            Control content = new Control();

            // The following variables contains the code to be injected
            // on all of the screens (using dependency injection pattern).

            IProductService productService = new ProductService();
            ITransactionService transactionService = new TransactionService();

            switch (menuType)
            {
                case Enums.SideMenuType.Home:
                default:
                    content = new ucHomeScreen(productService, transactionService);
                    break;

                case Enums.SideMenuType.Receipt:
                    content = new ucReceiptScreen(transactionService);
                    break;

                 case Enums.SideMenuType.Products:
                    content = new ucProductsScreen(productService);
                    break;

                case Enums.SideMenuType.Users:
                    content = new ucUsersScreen();
                    break;

                case Enums.SideMenuType.Reports:
                    content = new ucReportsScreen();
                    break;

                case Enums.SideMenuType.Settings:
                    content = new ucSettingsScreen();
                    break;

                case Enums.SideMenuType.About:
                    content = new ucAboutScreen();
                    break;
            }

            content.Size = panel.Size;
            panel.Controls.Add(content);
        }
    }
}
