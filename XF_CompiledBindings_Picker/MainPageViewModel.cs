using System;
using System.Collections.ObjectModel;

namespace XF_CompiledBindings_Picker
{
    public class MainPageViewModel
    {
        public ObservableCollection<PickerOption> Options { get; private set; }

        public MainPageViewModel()
        {
            Options = new ObservableCollection<PickerOption>()
            {
                new PickerOption(1, "First"),
                new PickerOption(2, "Second"),
            };
        }
    }

    public class PickerOption
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public PickerOption(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
