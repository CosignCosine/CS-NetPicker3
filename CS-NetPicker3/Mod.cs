using ICities;

namespace CS_NetPicker3
{
    public class NetPicker : IUserMod
    {
        public string Name => "Prefab Picker";
        public string Description => "Eyedrop any object from the map.";

        public void OnSettingsUI(UIHelperBase helper)
        {
            UIHelperBase keybindingsGroup = helper.AddGroup("Keybindings");
            keybindingsGroup.AddCheckbox("Ctrl", false, (check) =>
            {

            });

            keybindingsGroup.AddCheckbox("Alt", false, (check) =>
            {

            });

            keybindingsGroup.AddCheckbox("Shift", false, (check) =>
            {

            });
        }
    }
}
