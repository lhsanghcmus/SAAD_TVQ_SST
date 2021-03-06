using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BUS;
using DTO;
namespace GUI
{
    /// <summary>
    /// Interaction logic for DashboardWindow.xaml
    /// </summary>
    public partial class DashboardWindow : Window
    {
        public DashboardWindow()
        {
            InitializeComponent();
            Global.Books = SachBUS.loadAll();
            Global.Categories = TheLoaiBUS.loadAllAndConvertToFillCombobox();
            Global.BookCategories = TheLoaiBUS.loadAll();
            Global.Customers = KhachHangBUS.loadAll();
            KiemTraQuyDinh kt = QuyDinhBUS.loadKiemTraQuyDinh();
            Global.ControlRules = kt;


            var rules = QuyDinhBUS.loadQuyDinh();

            Global.quyDinh = rules;
            Global.BookBoughtBills = new List<ChiTietHoaDonBanSachDTO>();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            GridPrincipal.IsEnabled = false;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
            GridPrincipal.IsEnabled = true;
        }

        private void MoveWindow(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void btn_CloseWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_MinimizeWindow(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            MoveCursorMenu(index);
            switch (index)
            {
                case 0:
                    GridPrincipal.Content = new HomePage();
                    break;
                case 1:
                    GridPrincipal.Content = new SellPage();
                    break;
                case 2:
                    GridPrincipal.Content = new ManageBillPage();
                    break;
                case 3:
                    GridPrincipal.Content = new ManageCustomerPage();
                    break;
                case 4:
                    GridPrincipal.Content = new ReportPage();
                    break;
                case 5:
                    GridPrincipal.Content = new ManageBookPage();
                    break;
                case 6:
                    GridPrincipal.Content = new ManageSalePage();
                    break;
                case 7:
                    GridPrincipal.Content = new ManageRulePage();
                    break;
                case 8:
                    GridPrincipal.Content = new AboutPage();
                    break;
                default:
                    break;
            }
        }

        private void MoveCursorMenu(int index)
        {
            GridCursor.Margin = new Thickness(0, (157+(50 * index)), 0, 0);
            switch (index)
            {
                case 0:
                    ListViewMenu__tab1_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#000"));
                    ListViewMenu__tab1_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#000"));
                    ListViewMenu__tab2_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab2_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab3_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab3_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab4_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab4_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab5_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab5_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab6_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab6_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab7_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab7_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab8_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab8_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab9_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab9_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    break;
                case 1:
                    ListViewMenu__tab1_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab1_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab2_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#000"));
                    ListViewMenu__tab2_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#000"));
                    ListViewMenu__tab3_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab3_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab4_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab4_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab5_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab5_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab6_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab6_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab7_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab7_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab8_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab8_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab9_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab9_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    break;
                case 2:
                    ListViewMenu__tab1_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab1_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab2_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab2_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab3_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#000"));
                    ListViewMenu__tab3_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#000"));
                    ListViewMenu__tab4_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab4_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab5_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab5_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab6_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab6_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab7_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab7_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab8_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab8_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab9_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab9_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    break;
                case 3:
                    ListViewMenu__tab1_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab1_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab2_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab2_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab3_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab3_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab4_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#000"));
                    ListViewMenu__tab4_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#000"));
                    ListViewMenu__tab5_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab5_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab6_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab6_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab7_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab7_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab8_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab8_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab9_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab9_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    break;
                case 4:
                    ListViewMenu__tab1_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab1_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab2_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab2_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab3_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab3_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab4_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab4_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab5_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#000"));
                    ListViewMenu__tab5_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#000"));
                    ListViewMenu__tab6_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab6_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab7_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab7_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab8_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab8_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab9_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab9_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    break;
                case 5:
                    ListViewMenu__tab1_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab1_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab2_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab2_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab3_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab3_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab4_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab4_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab5_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab5_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab6_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#000"));
                    ListViewMenu__tab6_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#000"));
                    ListViewMenu__tab7_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab7_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab8_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab8_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab9_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab9_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    break;
                case 6:
                    ListViewMenu__tab1_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab1_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab2_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab2_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab3_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab3_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab4_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab4_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab5_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab5_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab6_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab6_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab7_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#000"));
                    ListViewMenu__tab7_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#000"));
                    ListViewMenu__tab8_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab8_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab9_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab9_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    break;
                case 7:
                    ListViewMenu__tab1_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab1_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab2_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab2_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab3_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab3_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab4_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab4_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab5_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab5_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab6_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab6_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab7_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab7_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab8_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#000"));
                    ListViewMenu__tab8_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#000"));
                    ListViewMenu__tab9_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab9_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    break;
                case 8:
                    ListViewMenu__tab1_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab1_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab2_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab2_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab3_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab3_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab4_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab4_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab5_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab5_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab6_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab6_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab7_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab7_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab8_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab8_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b6b8ba"));
                    ListViewMenu__tab9_icon.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#000"));
                    ListViewMenu__tab9_content.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#000"));
                    break;
                default:
                    break;
            }
        }
    }
}
