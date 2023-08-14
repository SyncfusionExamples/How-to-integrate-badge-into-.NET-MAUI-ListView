using System.Collections.ObjectModel;

namespace BadgeView;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

}
public class Model
{
    public string Category { get; set; }
    public int Count { get; set; }
    public Color Color { get; set; }
}
public class ViewModel
{
    public ObservableCollection<ModelList> Items { get; set; }

    public ViewModel()
    {
        var modellList1 = new ModelList()
            {
                new Model(){Category = "Primary", Count = 27, Color = Color.FromArgb("#e3165b")},
                new Model(){Category = "Social", Count = 12, Color = Color.FromArgb("#3f51b5")},
                new Model(){Category = "Promotions", Count = 7, Color = Color.FromArgb("#4d841d")},
                new Model(){Category = "Updates", Count = 1, Color = Color.FromArgb("#2088da")},
            };
        modellList1.Heading = "Inbox";

        var modellList2 = new ModelList()
            {
                new Model(){Category = "Starred", Count = 0, Color = Colors.Brown},
                new Model(){Category = "Important", Count = 12, Color = Colors.Brown},
                new Model(){Category = "Sent", Count = 0, Color = Color.FromArgb("#e3165b")},
                new Model(){Category = "Drafts", Count = 0, Color = Color.FromArgb("#e3165b")},
            };
        modellList2.Heading = "All Labels";

        Items = new ObservableCollection<ModelList>()
            {
                modellList1,
                modellList2
            };
    }
}

public class ModelList : ObservableCollection<Model>
{
    public ObservableCollection<Model> Models => this;
    public string Heading { get; set; }
}
