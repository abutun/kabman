using System;
using KabMan.Import;
using System.Windows.Forms;
using System.Drawing;

namespace KabMan.Test
{
    public partial class SwitchImportTest : DevExpress.XtraEditors.XtraForm
    {
        public SwitchImportTest()
        {
            InitializeComponent();
        }

        private void ImportTest_Load(object sender, EventArgs e)
        {

        }

        public void RefreshTestForm(SwitchImportComponent argComponent)
        {
            ClearControlValues();

            switchName.Text = argComponent.Switch.Name;
            switchModel.Text = argComponent.Switch.Model;
            switchPortCount.Text = argComponent.Switch.PortCount.ToString();

            lcSymbol.Text = argComponent.LcUrmCable.Symbol;
            lcNumber.Text = argComponent.LcUrmCable.Number;

            blechSymbol.Text = argComponent.Blech.Symbol;
            blechRoom.Text = argComponent.Blech.Room;
            blechSan.Text = argComponent.Blech.San;
            blechClass1.Text = argComponent.Blech.Class1;
            blechNumber.Text = argComponent.Blech.Number;
            blechClass2.Text = argComponent.Blech.Class2;

            trunkSymbol.Text = argComponent.TrunkCable.Symbol;
            trunkNumber.Text = argComponent.TrunkCable.Number;
            trunkClass.Text = argComponent.TrunkCable.Class;

            vtSymbol.Text = argComponent.VtPort.Symbol;
            vtRoom.Text = argComponent.VtPort.Room;
            vtSan.Text = argComponent.VtPort.San;
            vtClass1.Text = argComponent.VtPort.Class1;
            vtNumber.Text = argComponent.VtPort.Number;
            vtClass2.Text = argComponent.VtPort.Class2;

            urmSymbol.Text = argComponent.UrmUrmCable.Symbol;
            urmNumber.Text = argComponent.UrmUrmCable.Number;

        }

        private void ClearControlValues()
        {
            switchName.Text =
            switchModel.Text =
            switchPortCount.Text =

            lcSymbol.Text =
            lcNumber.Text =

            blechSymbol.Text =
            blechRoom.Text =
            blechSan.Text =
            blechClass1.Text =
            blechNumber.Text =
            blechClass2.Text =

            trunkSymbol.Text =
            trunkNumber.Text =
            trunkClass.Text =

            vtSymbol.Text =
            vtRoom.Text =
            vtSan.Text =
            vtClass1.Text =
            vtNumber.Text =
            vtClass2.Text =

            urmSymbol.Text =
            urmNumber.Text = string.Empty;


        }
    }
}