using CCS.WorkplaceManagementSystem.View;

namespace CCS.WorkplaceManagementSystem.Utilities
{
    public class UIService : IUIService
    {
        public void Initialize()
        {
            UIServiceLinker.Register("OpenDialog", OpenDialog);
        }
        public void OpenDialog(object vm)
        {
            var win = new MachineDetailsWindow();
            win.Content = vm;
            win.Show();
        }
    }
}
