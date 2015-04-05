using System.Windows.Forms.Design;
using KabMan.Controls;
using System.ComponentModel;

namespace KabMan.Designer
{
    public class ManagerFormDesigner : ScrollableControlDesigner
    {

        public override void Initialize(IComponent component)
        {
            base.Initialize(component);
            C_ControlManagerForm cmp = (C_ControlManagerForm)component;

            EnableDesignMode(cmp.LayoutPanel, cmp.LayoutPanel.Name);
            EnableDragDrop(true);
        }

    }
}
